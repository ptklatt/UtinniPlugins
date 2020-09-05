using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Commands;
using UtinniCoreDotNet.PluginFramework;

namespace TJT.SWG
{
    public class WorldSnapshotImpl
    {
        private readonly IEditorPlugin editorPlugin;

        public WorldSnapshotImpl(IEditorPlugin editorPlugin)
        {
            this.editorPlugin = editorPlugin;

            ObjectCallbacks.AddOnTargetCallback(OnTarget);
            ImGuiCallbacks.AddOnPositionChangedCallback(OnPositionChanged);
            ImGuiCallbacks.AddOnRotationChangedCallback(OnRotationChanged);
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

        public void OnTarget()
        {
            var target = Game.PlayerLookAtTargetObject;
            if (target == null)
            {
                UtinniCore.ImguiGizmo.imgui_impl.Disable();
            }
            else
            {
                UtinniCore.ImguiGizmo.imgui_impl.Enable(target);
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
    }
}
