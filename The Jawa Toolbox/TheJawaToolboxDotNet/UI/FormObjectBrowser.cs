using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtinniCore.Swg.Math;
using UtinniCore.Utinni;
using UtinniCore.Utinni.CuiHud;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Commands;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI;
using UtinniCoreDotNet.UI.Forms;
using UtinniCoreDotNet.UI.Theme;
using UtinniCoreDotNet.Utility;
using Appearance = UtinniCore.Utinni.Appearance;

namespace TJT.UI
{
    public partial class FormObjectBrowser : UtinniForm, IEditorForm
    {
        private readonly IEditorPlugin editorPlugin;
        private readonly Dictionary<string, List<string>> objectRepo = new Dictionary<string, List<string>>();

        private UtinniCore.Utinni.Object dragDropObject;

        public FormObjectBrowser(IEditorPlugin editorPlugin)
        {
            InitializeComponent();

            this.editorPlugin = editorPlugin;

            tvDirectories.BackColor = Colors.PrimaryHighlight();
            lbFiles.BackColor = Colors.PrimaryHighlight();

            tvDirectories.ForeColor = Colors.Font();
            lbFiles.ForeColor = Colors.Font();

            tvDirectories.BorderStyle = BorderStyle.None;
            lbFiles.BorderStyle = BorderStyle.None;

            Task loadRepo = LoadRepo();

            GameDragDropEventHandlers.OnDragDrop += OnDragDrop;
            GameDragDropEventHandlers.OnDragEnter += OnDragEnter;
            GameDragDropEventHandlers.OnDragOver += OnDragOver;
        }

        private async Task LoadRepo()
        {
            while (!Game.IsRunning)
            {
                await Task.Delay(1);
            }

            var dirInfo = Game.Repository.GetDirectoryInfo("object");

            for (int i = 0; i < dirInfo.Size; i++)
            {
                string fn = Game.Repository.GetFilenameAt(dirInfo.StartIndex + i);

                if (fn.EndsWith(".iff"))
                {
                    int posStart = fn.IndexOf('/');
                    int posEnd = fn.LastIndexOf('/');

                    if (posStart == posEnd)
                    {
                        // Skip root files as they're not proper Object files
                        continue;   
                    }

                    string dir = fn.Substring(posStart + 1, posEnd - posStart);
                    List<string> filenames;
                    if (objectRepo.TryGetValue(dir, out filenames))
                    {
                        filenames.Add(fn);
                    }
                    else
                    {
                        filenames = new List<string> { fn };
                        objectRepo.Add(dir, filenames);
                    }
                }
            }

            TreeNode tmpRootNode = new TreeNode();
            foreach (KeyValuePair<string, List<string>> dir in objectRepo)
            {
                // Split and loop through the directory's subdirectories and created nested nodes
                TreeNode curNode = tmpRootNode;
                string dirPath = dir.Key;
                string[] splitPaths;
                while ((splitPaths = dirPath.Split('/')).Length > 1)
                {
                    if (!curNode.Nodes.ContainsKey(splitPaths[0]))
                    {
                        curNode.Nodes.Add(splitPaths[0], splitPaths[0]);
                    }
                    curNode = curNode.Nodes[curNode.Nodes.IndexOfKey(splitPaths[0])];
                    dirPath = dirPath.Substring(splitPaths[0].Length + 1);
                }
            }

            tvDirectories.SuspendLayout();
            TreeNode[] tmpNodes = new TreeNode[tmpRootNode.Nodes.Count];
            tmpRootNode.Nodes.CopyTo(tmpNodes, 0);
            tvDirectories.Nodes.AddRange(tmpNodes);
            tvDirectories.ResumeLayout();
        }

        public string GetName()
        {
            return this.Text;
        }

        public void Create(IEditorPlugin editorPlugin)
        {
            // Check if the form is already open
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormObjectBrowser))
                {
                    form.Activate();
                    return;
                }
            }

            // If not, create a new one
            FormObjectBrowser formLog = new FormObjectBrowser(editorPlugin);
            formLog.Show();
        }

        private List<string> currentFilenames;
        private TreeNode previousNode;
        private void tvDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvDirectories.SelectedNode != null && tvDirectories.SelectedNode != previousNode)
            {
                string dirPath = tvDirectories.SelectedNode.Text + '/';

                // Loop backwards through the TreeView nodes to assemble the full path
                TreeNode curNode = tvDirectories.SelectedNode;
                while (curNode.Parent != null)
                {
                    curNode = curNode.Parent;
                    dirPath = curNode.Text + "/" + dirPath;
                }

                lbFiles.BeginUpdate();
                lbFiles.Items.Clear();
                if (objectRepo.TryGetValue(dirPath, out List<string> filenames))
                {
                    currentFilenames = filenames;
                    lbFiles.Items.AddRange(currentFilenames.ToArray());
                    previousNode = tvDirectories.SelectedNode;
                }
                lbFiles.EndUpdate();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lbFiles.BeginUpdate();
            lbFiles.Items.Clear();

            if (txtFilter.Text == "")
            {
                lbFiles.Items.AddRange(currentFilenames.ToArray());
            }
            else
            {
                foreach (string filename in currentFilenames)
                {
                    if (filename.Contains(txtFilter.Text))
                    {
                        lbFiles.Items.Add(filename);
                    }
                }
            }
            lbFiles.EndUpdate();
        }

        private System.Drawing.Point mouseDownPos;
        private void lbFiles_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPos = e.Location;
            lbFiles.SelectedIndex = lbFiles.IndexFromPoint(e.X, e.Y);

            if (lbFiles.SelectedItem == null)
            {
                btnCreateSnapshotNodesAtPlayer.Enabled = false;
                nudSnapshotNodeCount.Enabled = false;
                return;
            }
            btnCreateSnapshotNodesAtPlayer.Enabled = true;
            nudSnapshotNodeCount.Enabled = true;

            if (e.Button == MouseButtons.Right)
            {
                cmsObjectFile.Show(Cursor.Position);
            }
        }

        private void lbFiles_MouseMove(object sender, MouseEventArgs e)
        {
            var moveDelta = e.Location - (Size) mouseDownPos;
            if (e.Button == MouseButtons.Left && lbFiles.SelectedItem != null && (moveDelta.X >= 5 || moveDelta.Y >= 5))
            {
                lbFiles.DoDragDrop(lbFiles.SelectedItem, DragDropEffects.Copy);
            }
        }
        private void lbFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ToDo SelectChanged events for listbox are broken with manual add, implement enable/disable of the controls down the road instead of this check
            if (lbFiles.SelectedIndex == -1 || GroundScene.Get() == null)
            {
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                CreateSnapshotNodeAtPlayer(); // ToDo add a different spawn location if in freecam
            }
        }
        private void CreateDragDropObject(string filename)
        {
            var player = Game.Player;
            var camera = GroundScene.Get().CurrentCamera;
            if (player == null || camera == null)
            {
                return;
            }

            Transform newTransform;
            if (chkUsePlayerRotation.Checked)
            { 
                newTransform = new Transform(player.Transform)
                {
                    Position = cui_hud.GetCursorWorldPosition()
                };
            }
            else
            {
                newTransform = new Transform();
            }
           
            var objTemplate = ObjectTemplateList.GetObjectTemplateByFilename(filename);
            if (objTemplate == null)
            {
                return;
            }

            if (objTemplate.PortalLayoutFilename == "")
            {
                dragDropObject = ObjectTemplate.CreateObject(filename);
            }
            else
            {
                dragDropObject = UtinniCore.Utinni.Object.Ctor;
                dragDropObject.AddNotification(0x019136E4, false); // ToDo Label the magic number

                var pob = PortalPropertyTemplateList.GetPobByCrcString(PersistentCrcString.Ctor(objTemplate.PortalLayoutFilename));
                dragDropObject.SetAppearance(Appearance.Create(pob.ExteriorAppearanceName));
            }

            dragDropObject.ClientObject.SetParentCell(camera.ParentCell);

            CellProperty.SetPortalTransitions(false);
            dragDropObject.TransformO2w = newTransform;
            CellProperty.SetPortalTransitions(true);

            UtinniCore.Utinni.RenderWorld.render_world.AddObjectNotifications(dragDropObject);
            dragDropObject.ClientObject.EndBaselines();
            dragDropObject.AddToWorld();
        }

        private void UpdateDragDropObjectPosition(Vector position)
        {
            if (dragDropObject == null)
            {
                return;
            }

            Transform newTransform = new Transform(dragDropObject.Transform)
            {
                Position = position
            };

            dragDropObject.TransformO2w = newTransform;
        }

        private void ConvertDragDropObjectToWorldSnapshotNode(string objectFilename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshotReaderWriter.Node node = WorldSnapshot.CreateAddNode(objectFilename, dragDropObject.Transform);

                if (node != null)
                {
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(node)));
                }

                // Cleanup the temporary DragDrop object
                dragDropObject.Remove();
                dragDropObject = null;
            });
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            ConvertDragDropObjectToWorldSnapshotNode((string)e.Data.GetData(DataFormats.Text));
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) // ToDo custom format 
            {
                this.Focus();
                this.BringToFront();
                e.Effect = DragDropEffects.Copy;
                if (dragDropObject == null)
                {
                    string dragData = (string)e.Data.GetData(DataFormats.Text); // ToDo custom format 

                    GroundSceneCallbacks.AddUpdateLoopCall(() =>
                    {
                        CreateDragDropObject(dragData);
                    });
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void OnDragOver(object sender, DragEventArgs e)
        {
            if (dragDropObject == null)
            {
                return;
            }

            Panel pnl = (Panel)sender;
            var point = pnl.PointToClient(Cursor.Position);
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                Vector pos = new Vector();
                if (cui_hud.CollideCursorWithWorld(point.X, point.Y, pos, dragDropObject))
                {
                    UpdateDragDropObjectPosition(pos);
                }
            });
        }

        private void CreateSnapshotNodeAtPlayer()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                WorldSnapshotReaderWriter.Node node = WorldSnapshot.CreateAddNode((string)lbFiles.SelectedItem, Game.Player.Transform);

                if (node != null)
                {
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(node)));
                }
            });
        }

        private void btnCreateSnapshotNodesAtPlayer_Click(object sender, EventArgs e)
        {
            // ToDo SelectChanged events for listbox are broken with manual add, implement enable/disable of the controls down the road instead of this check
            if (lbFiles.SelectedIndex == -1 || GroundScene.Get() == null)
            {
                return; 
            }

            for (int i = 0; i < nudSnapshotNodeCount.Value; i++)
            {
                CreateSnapshotNodeAtPlayer();
            }
        }

        private void tsmiCreateSnapshotNodeAtPlayer_Click(object sender, EventArgs e)
        {
            CreateSnapshotNodeAtPlayer();
        }

        

    }
}

