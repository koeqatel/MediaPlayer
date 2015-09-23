using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SnS_Mediaplayer
{
    public partial class Player : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        // Displays an OpenFileDialog so the user can select a Cursor.
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        
    public Player()
        {
            InitializeComponent();
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            wplayer.URL = openFileDialog1.FileName; ;
            wplayer.controls.play();
            string DisplayName = openFileDialog1.FileName.Replace(".mp3", "");
            InfoList.Text = DisplayName;
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media Files|*.mp3";
            openFileDialog1.Title = "Select a Media File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            }

            //            BrowserDialog.ShowDialog();
            //            FileTextbox.Text = BrowserDialog.SelectedPath;
            //            string[] filePaths = Directory.GetFiles(BrowserDialog.SelectedPath);
            //            foreach (string Track in filePaths)
            //            {
            //                string Name = Track.Replace(BrowserDialog.SelectedPath, "");
            //                Name = Name.Replace("\\", "");
            //                TrackList.Text = TrackList.Text + Name + "\n";
            //            }
        }
    }
}
