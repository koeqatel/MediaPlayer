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

        public Player()
        {
            InitializeComponent();
        }
        private void Playbutton_Click(object sender, EventArgs e)
        {
            wplayer.URL = BrowserDialog.SelectedPath;
            wplayer.controls.play();
            string DisplayName = BrowserDialog.SelectedPath.Replace(".mp3", "");
            InfoList.Text = DisplayName;
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            BrowserDialog.ShowDialog();
            FileTextbox.Text = BrowserDialog.SelectedPath;
            string[] filePaths = Directory.GetFiles(BrowserDialog.SelectedPath);
            foreach (string Track in filePaths)
            {
                TrackList.Text = TrackList.Text + Track + "\n";
            }
        }
    }
}
