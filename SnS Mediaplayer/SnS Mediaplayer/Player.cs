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
        // We moeten nog ff uitzoeken hoe we File en Folder van elkaar af halen.
        string FilePath = null;
        string FolderPath = null;
        string DisplayName;
         


        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Player()
        {
            //How should i know it's not my job...
            InitializeComponent();
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            wplayer.URL = FolderPath + TrackList.SelectedText;
            wplayer.controls.play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {

                wplayer.controls.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }
        
        private void FileButton_Click(object sender, EventArgs e)
        {
//          Laat alleen mp3's zien, moet nog kijken naar wav, ogg, enz. die doen het nog niet
            openFileDialog1.Filter = "Media Files|*.mp3";
            openFileDialog1.Title = "Select a Media File";
//                      als er in filedialog op "OK" is geklikt...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
//              Hiervan moeten we alleen filepath laten zien, maar hij moet wel refereren naar folder + file.
                TrackList.Items.Add(openFileDialog1.FileName);
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                long numberOfBytes = fi.Length;
            }
        }

        private void TrackList_DragDrop(object sender, DragEventArgs e)
        {
            TrackList.Items.Add(sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = wplayer.status;
        }

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PauseButton_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(120);
            PauseButtonPulse.Visible = true;
            PauseButton.Visible = false;
        }

        private void PauseButtonPulse_MouseLeave(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(120);
            PauseButton.Visible = true;
            PauseButtonPulse.Visible = false;
        }

        private void StopButtonPulse_MouseLeave(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(120);
            StopButton.Visible = true;
            StopButtonPulse.Visible = false;
        }
        private void StopButton_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(120);
            StopButtonPulse.Visible = true;
            StopButton.Visible = false;
        }

        private void PlayButtonPulse_MouseLeave(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(120);
            PlayButton.Visible = true;
            PlayButtonPulse.Visible = false;
        }

        private void PlayButton_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(120);
            PlayButtonPulse.Visible = true;
            PlayButton.Visible = false;
        }
    }
}
