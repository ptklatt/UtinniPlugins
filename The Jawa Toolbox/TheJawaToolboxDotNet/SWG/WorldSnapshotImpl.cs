using System.Collections.Generic;
using System.IO;
using TJT.UI.SubPanels;
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
        private readonly IScenePanel scenePanel;
        private readonly IEditorPlugin editorPlugin;

        public bool EnableNodeEditing;

        private WorldSnapshotReaderWriter.Node copiedNode;

        public WorldSnapshotImpl(IScenePanel scenePanel, IEditorPlugin editorPlugin, HotkeyManager hotkeyManager)
        {
            this.scenePanel = scenePanel;
            this.editorPlugin = editorPlugin;

            GameCallbacks.AddInstallCallback(OnInstallCallback);
            ObjectCallbacks.AddOnTargetCallback(OnTarget);
            ImGuiCallbacks.AddOnPositionChangedCallback(OnPositionChanged);
            ImGuiCallbacks.AddOnRotationChangedCallback(OnRotationChanged);

            hotkeyManager.Hotkeys.Add(new Hotkey("ToggleSnapshotNodeEditingMode", "Oemtilde", ToggleNodeEditing, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("Save Snapshot", "Shift, Control + S", Save, false));

            hotkeyManager.Hotkeys.Add(new Hotkey("Copy Node", "Shift, Control + C", CopyNode, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("Paste Node", "Shift, Control  + V", PasteNode, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("Duplicate Node", "Shift, Control + D", DuplicateNode, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("Delete Node", "Shift, Control + Delete", RemoveNode, false));
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

            scenePanel.SetCmbSnapshots(snapshots);
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
                WorldSnapshotReaderWriter.Get().SaveFile();
            });
        }

        public void AddNode(string objectFilename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshotReaderWriter.Node node = WorldSnapshot.CreateAddNode(objectFilename, Game.Player.ObjectToParent);

                if (node != null)
                {
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(node)));
                }
            });
        }

        public void RemoveNode()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshotReaderWriter.Node node = WorldSnapshotReaderWriter.Get().GetNodeByNetworkId(Game.PlayerLookAtTargetObject.NetworkId);

                if (node != null)
                {
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new RemoveWorldSnapshotNodeCommand(node)));
                    WorldSnapshot.RemoveNode(node);
                }
            });
        }

        public void ToggleNodeEditing()
        {
            bool result = !EnableNodeEditing;
            scenePanel.UpdateSnapshotNodeEditingMode(result);
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
                UtinniCore.ImguiGizmo.imgui_impl.Disable();
            }
            else
            {
                WorldSnapshotReaderWriter.Node node = WorldSnapshotReaderWriter.Get().GetNodeByNetworkId(target.NetworkId);

                if (node == null || !EnableNodeEditing)
                {
                    UtinniCore.ImguiGizmo.imgui_impl.Disable();
                }
                else if (EnableNodeEditing)
                {
                    UtinniCore.ImguiGizmo.imgui_impl.Enable(target);
                }
            }
        }

        public void OnPositionChanged() // ToDo Something is broken where it sometimes has 1-2 too many undo stages
        {
            bool allowMerge = UtinniCore.ImguiGizmo.imgui_impl.HasRecentPositionChange();
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                WorldSnapshotReaderWriter.Node node = WorldSnapshotReaderWriter.Get().GetNodeByNetworkId(obj.NetworkId);

                if (node != null)
                {
                    node.Transform.Position = obj.Transform.Position;
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodePositionChangedCommand(node, allowMerge)));
                }
            });
        }

        public void OnRotationChanged() // ToDo Something is broken where it sometimes has 1-2 too many undo stages
        {
            bool allowMerge = UtinniCore.ImguiGizmo.imgui_impl.HasRecentRotationChange();
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var obj = Game.PlayerLookAtTargetObject;
                WorldSnapshotReaderWriter.Node node = WorldSnapshotReaderWriter.Get().GetNodeByNetworkId(obj.NetworkId);

                if (node != null)
                {
                    node.Transform.CopyRotation(obj.Transform);
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new WorldSnapshotNodeRotationChangedCommand(node, allowMerge)));
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
                    WorldSnapshotReaderWriter.Node node = WorldSnapshotReaderWriter.Get().GetNodeByNetworkId(obj.NetworkId);

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
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(newNode)));
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
                    var newNode = WorldSnapshot.CreateNodeCopy(copiedNode, obj.Transform);

                    if (newNode != null)
                    {
                        editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(newNode)));
                    }
                }
            });
        }
    }
}
