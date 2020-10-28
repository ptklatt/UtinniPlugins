/**
 * MIT License
 *
 * Copyright (c) 2020 Philip Klatt
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
**/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtinniCore.Swg.Math;
using UtinniCore.Utinni;
using UtinniCore.Utinni.CuiHud;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Commands;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI;
using UtinniCoreDotNet.UI.Forms;
using UtinniCoreDotNet.UI.Theme;
using UtinniCoreDotNet.Utility;
using Appearance = UtinniCore.Utinni.Appearance;

namespace TJT.UI.Forms
{
    public partial class FormObjectBrowser : UtinniForm, IEditorForm
    {
        private readonly IEditorPlugin editorPlugin;
        private readonly UtINI ini;

        private readonly Dictionary<string, List<string>> objectRepo = new Dictionary<string, List<string>>();

        private readonly string[] excludeDirectories = 
        {
            "cell",
            "construction_contract",
            "counting",
            "draft_schematic",
            "factory",
            "group",
            "guild",
            "jedi_manager",
            "manufacture_schematic",
            "mission",
            "object",
            "player",
            "path_waypoint",
            "token",
            "universe",
            "waypoint"
        };

        private static UtinniCore.Utinni.Object dragDropObject;
        private bool hasValidDragLocation;

        public FormObjectBrowser(IEditorPlugin editorPlugin)
        {
            InitializeComponent();

            this.editorPlugin = editorPlugin;
            ini = editorPlugin.GetConfig();

            CreateSettings();
            ini.Load();

            Width = ini.GetInt("ObjectBrowser", "width");
            Height = ini.GetInt("ObjectBrowser", "height");
            chkKeepOnTop.Checked = ini.GetBool("ObjectBrowser", "keepOnTop");

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

            lbFiles.QueryContinueDrag += lbFiles_QueryContinueDrag;

            editorPlugin.GetHotkeyManager().Add(new Hotkey("ToggleObjectBrowserKeepOnTop", "Toggle Object Browser KeepOnTop", "Shift, Control + T", ToggleKeepOnTop, false));
        }

        private void CreateSettings()
        {
            ini.AddSetting("ObjectBrowser", "width", "525", UtINI.Value.Types.VtInt);
            ini.AddSetting("ObjectBrowser", "height", "510", UtINI.Value.Types.VtInt);
            ini.AddSetting("ObjectBrowser", "keepOnTop", "true", UtINI.Value.Types.VtBool);
            ini.AddSetting("ObjectBrowser", "excludeJunkDirectories", "true", UtINI.Value.Types.VtBool);
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

            bool excludeJunkDirs = ini.GetBool("ObjectBrowser", "excludeJunkDirectories");

            TreeNode tmpRootNode = new TreeNode();
            foreach (KeyValuePair<string, List<string>> dir in objectRepo)
            {
                if (excludeJunkDirs)
                {
                    // ToDo do better
                    bool skip = false;
                    foreach (string excludeDir in excludeDirectories)
                    {
                        if (dir.Key.StartsWith(excludeDir))
                        {
                            skip = true;
                            break;
                        }
                    }

                    if (skip)
                    {
                        continue;
                    }
                }

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

        public Form Create(IEditorPlugin editorPlugin, List<Form> parentChildren)
        {
            // Check if the form is already open
            foreach (Form form in parentChildren)
            {
                if (form.GetType() == typeof(FormObjectBrowser))
                {
                    form.Activate();
                    return null;
                }
            }

            // If not, create a new one
            FormObjectBrowser formObjectBrowser = new FormObjectBrowser(editorPlugin);
            formObjectBrowser.Show();
            parentChildren.Add(formObjectBrowser);
            return formObjectBrowser;
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
                txtDirectoryPath.Text = dirPath;

                lbFiles.BeginUpdate();
                lbFiles.Items.Clear();
                if (objectRepo.TryGetValue(dirPath, out List<string> filenames))
                {
                    currentFilenames = new List<string>();
                    foreach (string fn in filenames)
                    {
                        currentFilenames.Add(fn.Substring(fn.LastIndexOf('/') + 1));
                    }

                    FilterFiles();
                    previousNode = tvDirectories.SelectedNode;
                }
                lbFiles.EndUpdate();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lbFiles.BeginUpdate();
            lbFiles.Items.Clear();
            FilterFiles();
            lbFiles.EndUpdate();
        }

        private void FilterFiles()
        {
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
            var moveDelta = e.Location - (Size)mouseDownPos;
            if (e.Button == MouseButtons.Left && lbFiles.SelectedItem != null) //  && (moveDelta.X >= 1 || moveDelta.Y >= 1)
            {
                lbFiles.DoDragDrop("object/" + txtDirectoryPath.Text + lbFiles.SelectedItem, DragDropEffects.Copy);

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
            if (player == null || camera == null || dragDropObject != null) // ToDo Sometimes this function ets called twice, why
            {
                return;
            }

            var objTemplate = ObjectTemplateList.GetObjectTemplateByFilename(filename);
            if (objTemplate == null)
            {
                return;
            }

            if (objTemplate.AppearanceFilename == "" && objTemplate.ClientDataFilename == "" && objTemplate.PortalLayoutFilename == "")
            {
                return;
            }

            dragDropObject = UtinniCore.Utinni.Object.Ctor;
            dragDropObject.AddNotification(0x019136E4, false); // ToDo Label the magic number

            string appearanceFilename;
            if (objTemplate.PortalLayoutFilename == "")
            {
                appearanceFilename = objTemplate.AppearanceFilename;
            }
            else
            {
                var pob = PortalPropertyTemplateList.GetPobByCrcString(PersistentCrcString.Ctor(objTemplate.PortalLayoutFilename));
                appearanceFilename = pob.ExteriorAppearanceName;
            }

            var apperance = Appearance.Create(appearanceFilename);
            if (apperance == null)
            {
                CleanUpDragDropObject();
                return;
            }
            dragDropObject.SetAppearance(apperance);
            dragDropObject.ClientObject.SetParentCell(camera.ParentCell);
            UtinniCore.Utinni.RenderWorld.render_world.AddObjectNotifications(dragDropObject);

            dragDropObject.AddToWorld();
        }

        private void UpdateDragDropObjectPosition(Vector position)
        {
            if (dragDropObject == null)
            {
                return;
            }

            Vector oldPos = dragDropObject.TransformO2w.Position;
            Transform newTransform = new Transform { Position = position };
            dragDropObject.TransformO2w = newTransform;
            dragDropObject.PositionAndRotationChanged(false, oldPos);
        }

        private void ConvertDragDropObjectToWorldSnapshotNode(string objectFilename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                if (!hasValidDragLocation)
                {
                    // Cleanup the temporary DragDrop object
                    CleanUpDragDropObject();
                    return;
                }

                WorldSnapshotReaderWriter.Node node = WorldSnapshot.CreateAddNode(objectFilename, dragDropObject.Transform);

                if (node != null)
                {
                    editorPlugin.AddUndoCommand(this, new AddUndoCommandEventArgs(new AddWorldSnapshotNodeCommand(node)));
                }

                // Cleanup the temporary DragDrop object
                CleanUpDragDropObject();
            });
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            if (dragDropObject != null)
            {
                ConvertDragDropObjectToWorldSnapshotNode((string)e.Data.GetData(DataFormats.Text));
            }

            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.Graphics.ShowMouseCursor(true);
            });
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) // ToDo custom format 
            {
                this.Focus();
                this.BringToFront();
                if (dragDropObject == null)
                {
                    e.Effect = DragDropEffects.Copy;
                    string dragData = (string)e.Data.GetData(DataFormats.Text); // ToDo custom format 

                    hasValidDragLocation = false;
                    GameCallbacks.AddPreMainLoopCall(() =>
                    {
                        CreateDragDropObject(dragData);
                    });
                }
                else
                {
                    CleanUpDragDropObject();
                    e.Effect = DragDropEffects.None;
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

            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                if (dragDropObject == null)
                {
                    return;
                }

                Panel pnl = (Panel)sender;
                var point = pnl.PointToClient(Cursor.Position);
                Vector pos = new Vector();
                if (cui_hud.CollideCursorWithWorld(point.X, point.Y, pos, dragDropObject))
                {
                    hasValidDragLocation = true;
                    UpdateDragDropObjectPosition(pos);
                }
            });
        }

        private void lbFiles_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.EscapePressed)
            {
                CleanUpDragDropObject();
                e.Action = DragAction.Cancel;
            }
        }

        private void CleanUpDragDropObject()
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                dragDropObject.Remove();
                dragDropObject = null;
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

        private void ToggleKeepOnTop()
        {
            chkKeepOnTop.Checked = !chkKeepOnTop.Checked;
        }

        private void chkKeepOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkKeepOnTop.Checked;
        }
    }
}

