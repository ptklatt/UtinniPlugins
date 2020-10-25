using UtinniCoreDotNet.UI.Forms;

namespace TJT.UI.Forms
{
    public partial class FormSnapshotSaveAsDialog : UtinniForm
    {
        public string SaveAsName;

        public FormSnapshotSaveAsDialog(string snapshotName)
        {
            InitializeComponent();
            txtSnapshotName.Text = snapshotName;
        }

        private void txtSnapshotName_TextChanged(object sender, System.EventArgs e)
        {
            SaveAsName = txtSnapshotName.Text;
        }
    }
}
