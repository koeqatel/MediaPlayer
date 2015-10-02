using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnS_Mediaplayer
{
    public partial class FileDialog : Form
    {
        public static string FolderPath = "Null";
        public FileDialog()
        {
            InitializeComponent();
        }

        private void FilesInFolder_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog1.SelectedPath;
                VisibleFolder.Text = FolderPath;
                string[] Files = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (var File in Files)
                {
                    FilesInFolder.Items.Add(File);
                }
            }
        }
    }
}
