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
        string DisplayName;
        public bool Debug = true;

        int PlayTimerInt;
        int PauseTimerInt;
        int StopTimerInt;


        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public Player()
        {
            //How should i know it's not my job...
            InitializeComponent();
            if (Debug == true)
            {
                DebugLabel1.Visible = true;
                DebugLabel2.Visible = true;
            }
        }

        public void Shuffle()
        {
            if (Random.Checked == true)
            {
                Random rnd = new Random();
                if (TrackList.Items.Count != 0)
                    TrackList.SelectedIndex = rnd.Next(0, TrackList.Items.Count);
            }
        }

        #region Play Button
        private void Playbutton_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedItem != null)
            {
                PlayTimer.Start();
                wplayer.URL = TrackList.SelectedItem.ToString();
                wplayer.controls.play();
                Shuffle();
            }
        }
        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            PlayButton.Image = Image.FromFile("Textures\\Play Pulse.gif");
        }
        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.Image = Image.FromFile("Textures\\Play.png");
        }
        #endregion

        #region Pause Button
        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseButton.Image = Image.FromFile("Textures\\Pause Click.gif");
            wplayer.controls.pause();
        }
        private void PauseButton_MouseEnter(object sender, EventArgs e)
        {
            PauseButton.Image = Image.FromFile("Textures\\Pause Pulse.gif");
        }
        private void PauseButton_MouseLeave(object sender, EventArgs e)
        {
            PauseButton.Image = Image.FromFile("Textures\\Pause.png");
        }
        #endregion

        #region Stop Button
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Image = Image.FromFile("Textures\\Stop Click.gif");
            wplayer.controls.stop();
        }
        private void StopButton_MouseEnter(object sender, EventArgs e)
        {
            StopButton.Image = Image.FromFile("Textures\\Stop Pulse.gif");
        }
        private void StopButton_MouseLeave(object sender, EventArgs e)
        {
            StopButton.Image = Image.FromFile("Textures\\Stop.png");
        }
        #endregion

        private void FileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Multiselect = true;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                string[] Files = Dialog.FileNames;
                foreach (var File in Files)
                {
                    TrackList.Items.Add(File);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wplayer.status != "")
                StatusLabel.Text = wplayer.status;
        }

        #region Timers
        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            PlayTimerInt = PlayTimerInt + 1;
            DebugLabel1.Text = PlayTimerInt.ToString();
            if (PlayTimerInt == 1)
            {
                PlayButton.Image = Image.FromFile("Textures\\Play Click.gif");
            }

            if (PlayTimerInt > 125)
            {
                PlayTimer.Stop();
                PlayTimerInt = 0;
                PlayButton.Image = Image.FromFile("Textures\\Play.png");
            }
        }
        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            PauseTimerInt = PauseTimerInt + 1;
        }
        private void StopTimer_Tick(object sender, EventArgs e)
        {
            StopTimerInt = StopTimerInt + 1;
        }
        #endregion
    }
}
