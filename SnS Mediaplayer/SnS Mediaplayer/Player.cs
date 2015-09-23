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

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        
    public Player()
        {
            InitializeComponent();
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            wplayer.URL = TrackList.SelectedText;
            wplayer.controls.play();
            string DisplayName = TrackList.SelectedText.Replace(".mp3", "");
            // Hier moet de Folder worden gereplaced met niks
            DisplayName = TrackList.SelectedText.Replace("", "");
            InfoList.Text = DisplayName;
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media Files|*.mp3";
            openFileDialog1.Title = "Select a Media File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            }
            TrackList.Items.Add(openFileDialog1.FileName);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void TrackList_DragDrop(object sender, DragEventArgs e)
        {
            TrackList.Items.Add(sender);
        }
    }
}
