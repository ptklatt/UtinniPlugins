using System.Collections.Generic;
using System.IO;
using TJT.UI.SubPanels;
using UtinniCore.ImguiGizmo;
using UtinniCore.Swg.Math;
using UtinniCore.Utinni;
using UtinniCore.Utinni.CuiHud;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Commands;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;

namespace TJT.SWG
{
    public class WorldSnapshotImpl
    {
        private readonly ISnapshotPanel snapshotPanel;
        private readonly IEditorPlugin editorPlugin;
        private readonly HotkeyManager hotkeyManager;

        public bool EnableNodeEditing;

        private WorldSnapshotReaderWriter.Node copiedNode;

        public WorldSnapshotImpl(ISnapshotPanel snapshotPanel, IEditorPlugin editorPlugin, HotkeyManager hotkeyManager)
        {
            this.snapshotPanel = snapshotPanel;
            this.editorPlugin = editorPlugin;
            this.hotkeyManager = hotkeyManager;

            GameCallbacks.AddInstallCallback(OnInstallCallback);
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);
            ObjectCallbacks.AddOnTargetCallback(OnTarget);

            ImGuiCallbacks.AddOnEnabledCallback(OnGizmoEnabled);
            ImGuiCallbacks.AddOnDisabledCallback(OnGizmoDisabled);
            ImGuiCallbacks.AddOnPositionChangedCallback(OnPositionChanged);
            ImGuiCallbacks.AddOnRotationChangedCallback(OnRotationChanged);

            hotkeyManager.Hotkeys.Add("ToggleSnapshotNodeEditingMode", new Hotkey("ToggleSnapshotNodeEditingMode", "Oemtilde", ToggleNodeEditing, true));
            hotkeyManager.Hotkeys.Add("SaveSnapshot", new Hotkey("SaveSnapshot", "Control + S", Save, true));
            hotkeyManager.Hotkeys.Add("CopySnapshotNode", new Hotkey("CopySnapshotNode", "Control + C", CopyNode, true));
            hotkeyManager.Hotkeys.Add("PasteSnapshotNode", new Hotkey("PasteSnapshotNode", "Control + V", PasteNode, true));
            hotkeyManager.Hotkeys.Add("DuplicateSnapshotNode", new Hotkey("DuplicateSnapshotNode", "Control + D", DuplicateNode, true));
            hotkeyManager.Hotkeys.Add("DeleteSnapshotNode", new Hotkey("DeleteSnapshotNode", "Delete", RemoveNode, true));

            hotkeyManager.Hotkeys.Add("SetGizmoTransformOperationMode", new Hotkey("SetGizmoTransformOperationMode", "Control + Q", SetOperationModeToTranslateHotkey, true, false));
            hotkeyManager.Hotkeys.Add("SetGizmoRotationOperationMode", new Hotkey("SetGizmoRotationOperationMode", "Control + E", SetOperationModeToRotationHotkey, true, false));
            hotkeyManager.Hotkeys.Add("ToggleGizmoSnap", new Hotkey("ToggleGizmoSnap", "Control + B", ToggleGizmoSnapHotkey, true, false));
        }

        private void OnInstallCallback()
        {
            var dirInfo = Game.Repository.GetDirectoryInfo("snapshot");

            List<string> snapshots = new List<string>();

            for (int i = 0; i < dirInfo.Size; i++)
            {
                string snapshotFile = Game.Repository.GetFilenameAt(dirInfo.StartIndex + i);

                if (snapshotFile.EndsWith(".ws"))
                {
                    snapshots.Add(Path.GetFileNameWithoutExtension(snapshotFile));
                }
            }

            snapshotPanel.SetCmbSnapshots(snapshots);
        }

        private void OnSetupSceneCallback()
        {
            snapshotPanel.UpdateSceneAvailability(true);
        }

        private void OnCleanupCallback()
        {
            snapshotPanel.UpdateSceneAvailability(false);
        }

        public void Load(string filename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshot.Load(filename);
            });
        }

        public void Unload()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshot.Unload();
            });
        }

        public void Reload()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshot.Reload();
            });
        }

        public void Save()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshotReaderWriter.Get().SaveFile("");
            });
        }

        public void SaveAs(string snapshotName)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshotReaderWriter.Get().SaveFile(snapshotName);
            });
        }

        public void AddNode(string objectFilename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var node = WorldSnapshot.CreateAddNode(objectFilename, Game.Player.ObjectToParent);
                if (node != null)
                {
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(node)));
                }
            });
        }

        public void RemoveNode()
        {
            if (EnableNodeEditing)
            {
                GroundSceneCallbacks.AddUpdateLoopCall(() =>
                {
                    var obj = Game.PlayerLookAtTargetObject;
                    if (obj != null)
                    {
                        var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                        if (node != null)
                        {
                            editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new RemoveWorldSnapshotNodeCommand(node)));
                            WorldSnapshot.RemoveNode(node);
                        }
                    }
                });
            }
        }

        public void ToggleNodeEditing()
        {
            bool result = !EnableNodeEditing;
            snapshotPanel.UpdateNodeEditingMode(result);
            UpdateNodeEditingMode(result);
        }

        public void UpdateNodeEditingMode(bool value)
        {
            EnableNodeEditing = value;
            OnTarget();
        }

        public void OnTarget()
        {
            var target = Game.PlayerLookAtTargetObject;
            if (target == null)
            {
                DisableGizmo();
                snapshotPanel.UpdateSelectedNodeControls(null);
            }
            else
            {
                var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)target.NetworkId);
                if (node != null)
                {
                    if (EnableNodeEditing)
                    {
                        EnableGizmo(target);
                    }
                    else
                    {
                        DisableGizmo();
                    }

                    string cellName = "";
                    if (target.ParentCell != null)
                    {
                        cellName = target.ParentCell.Name;
                    }

                    snapshotPanel.UpdateSelectedNodeControls(node, cellName, target.ClientObject.GameObjectTypeName + " (" + target.ClientObject.GameObjectType + ")");
                }
                else
                {
                    DisableGizmo();
                }
            }
        }

        public void EnableGizmo(UtinniCore.Utinni.Object target)
        {
            GroundSceneCallbacks.AddPreDrawLoopCall(() =>
            {
                imgui_impl.Enable(target);
            });
        }

        public void DisableGizmo()
        {
            GroundSceneCallbacks.AddPreDrawLoopCall(() =>
            {
                imgui_impl.Disable();
            });
        }

        public void OnPositionChanged()
        {
            GroundSceneCallbacks.AddPreDrawLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodePositionChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.Position = obj.Transform.Position;
                        snapshotPanel.UpdateSelectedNodeControlsPosition(node.Transform.Position);
                    }
                }
            });
        }

        public void OnRotationChanged() // ToDo Something is broken where it sometimes has 1-2 too many undo stages
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodeRotationChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.CopyRotation(obj.Transform);
                    }
                }
            });
        }

        public void SetSelectedNodePosition(float x, float y, float z)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {

                        if (node.ParentId != 0)
                        {
                            Vector oldO2w = obj.ObjectToWorld.Position;
                            Vector oldO2p = obj.ObjectToParent.Position;

                            Vector deltaPos = new Vector(oldO2p.X - x, oldO2p.Y - y, oldO2p.Z - z);
                            obj.ObjectToWorld.Position = new Vector(oldO2w + deltaPos);
                            obj.ObjectToParent.SetPosition(x, y, z);
                        }
                        else
                        {
                            obj.Transform.SetPosition(x, y, z);
                        }
                        obj.PositionAndRotationChanged(false, node.Transform.Position);

                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodePositionChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.SetPosition(x, y, z);
                    }
                }
            });
        }

        public void SetRadius(float radius)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        node.Radius = radius;
                        // ToDo add an Undo command for radius?
                    }
                }
            });
        }

        public void CopyNode()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        copiedNode = node;
                    }
                }
            });
        }

        public void PasteNode()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                if (copiedNode != null)
                {
                    var copiedTransform = new Transform(copiedNode.Transform)
                    {
                        Position = cui_hud.GetCursorWorldPosition()
                    };

                    var newNode = WorldSnapshot.CreateNodeCopy(copiedNode, copiedTransform);
                    if (newNode != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(newNode)));
                    }
                }
            });
        }

        public void DuplicateNode()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        var newNode = WorldSnapshot.CreateNodeCopy(node, obj.Transform);
                        if (newNode != null)
                        {
                            editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(newNode)));
                        }
                    }
                }
            });
        }

        public void RotateYaw(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    obj.Transform.Yaw(value);
                    obj.PositionAndRotationChanged(false, obj.Transform.Position);

                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodeRotationChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.CopyRotation(obj.Transform);
                    }
                }
            });
        }

        public void RotatePitch(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    obj.Transform.Pitch(value);
                    obj.PositionAndRotationChanged(false, obj.Transform.Position);

                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodeRotationChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.CopyRotation(obj.Transform);
                    }
                }
            });
        }

        public void RotateRoll(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    obj.Transform.Roll(value);
                    obj.PositionAndRotationChanged(false, obj.Transform.Position);

                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodeRotationChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.CopyRotation(obj.Transform);
                    }
                }
            });
        }

        public void ResetRotation()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                if (obj != null)
                {
                    obj.Transform.SetRotationAxis(0, 0, 0);

                    var node = WorldSnapshotReaderWriter.Get().GetNodeById((int)obj.NetworkId);
                    if (node != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodeRotationChangedCommand(node, node.Transform, obj.Transform)));
                        node.Transform.CopyRotation(obj.Transform);
                    }
                }
            });
        }

        public void SetOperationModeToTranslate()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.SetOperationModeToTranslate();
            });
        }

        public void SetOperationModeToRotation()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.SetOperationModeToRotate();
            });
        }

        public void SetOperationModeToTranslateHotkey()
        {
            SetOperationModeToTranslate();
            snapshotPanel.UpdateGizmoOperationControls(true);
        }

        public void SetOperationModeToRotationHotkey()
        {
            SetOperationModeToRotation();
            snapshotPanel.UpdateGizmoOperationControls(false);
        }

        public void SetGizmoToLocal()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.SetGizmoModeToLocal();
            });
            //snapshotPanel.UpdateGizmoModeControls(true);
        }

        public void SetGizmoToWorld()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.SetGizmoModeToWorld();
            });
            //snapshotPanel.UpdateGizmoModeControls(false);
        }

        public void SetGizmoSnap(bool value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.EnableSnap(value);
            });
        }

        public void ToggleGizmoSnapHotkey()
        {
            bool hasSnapOn = !imgui_impl.IsSnapOn();
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.EnableSnap(hasSnapOn);
            });
            snapshotPanel.UpdateGizmoSnapControl(hasSnapOn);
        }

        public void SetSnapScale(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                imgui_impl.SetSnapSize(value);
            });
        }

        private void OnGizmoEnabled()
        {
            hotkeyManager.Hotkeys["SetGizmoTransformOperationMode"].Enabled = true;
            hotkeyManager.Hotkeys["SetGizmoRotationOperationMode"].Enabled = true;
            hotkeyManager.Hotkeys["ToggleGizmoSnap"].Enabled = true;
        }

        private void OnGizmoDisabled()
        {
            hotkeyManager.Hotkeys["SetGizmoTransformOperationMode"].Enabled = false;
            hotkeyManager.Hotkeys["SetGizmoRotationOperationMode"].Enabled = false;
            hotkeyManager.Hotkeys["ToggleGizmoSnap"].Enabled = false;
        }
    }
}
