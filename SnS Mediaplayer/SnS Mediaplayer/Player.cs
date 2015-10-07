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
        static string[] WorkingName = new string[100];
        public bool Debug = false;

        #region Time integers
        int PlayTimerInt;
        int PauseTimerInt;
        int StopTimerInt;
        #endregion

        OpenFileDialog Dialog = new OpenFileDialog();
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
                Random rnd = new Random(Convert.ToInt32(DateTime.Now.Ticks.ToString().Substring(0, 6)));
                if (TrackList.Items.Count != 0)
                {
                    Track
                }
            }
        }

        public void InfoListAdd()
        {
            try
            {
                wplayer.URL = WorkingName[TrackList.SelectedIndex].ToString();
                InfoList.Text = "Name: " + Dialog.SafeFileNames[TrackList.SelectedIndex];
                InfoList.Text = InfoList.Text + "\nFile size: " + "Work in progress";
                InfoList.Text = InfoList.Text + "\nAlbum Name: " + "Work in progress";
                InfoList.Text = InfoList.Text + "\nAlbum Artist: " + "Once again, work in progress";
                InfoList.Text = InfoList.Text + "\nTrack Length: " + wplayer.currentMedia.duration;
            }
            catch (Exception)
            {

            }
        }

        #region Play Button
        private void Playbutton_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedItem != null)
            {
                InfoListAdd();
                PlayTimer.Start();
                wplayer.controls.play();
                Shuffle();
            }
        }
        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            if (PlayTimerInt > 150 || PlayTimerInt < 1)
                PlayButton.Image = Image.FromFile("Textures\\Play Pulse.gif");
        }
        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            if (PlayTimerInt > 150 || PlayTimerInt < 1)
                PlayButton.Image = Image.FromFile("Textures\\Play.png");
        }
        #endregion

        #region Pause Button
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedItem != null)
            {
                PauseTimer.Start();
                PauseButton.Image = Image.FromFile("Textures\\Pause Click.gif");
                wplayer.controls.pause();
            }
        }
        private void PauseButton_MouseEnter(object sender, EventArgs e)
        {
            if (PauseTimerInt > 150 || PauseTimerInt < 1)
                PauseButton.Image = Image.FromFile("Textures\\Pause Pulse.gif");
        }
        private void PauseButton_MouseLeave(object sender, EventArgs e)
        {
            if (PauseTimerInt > 150 || PauseTimerInt < 1)
                PauseButton.Image = Image.FromFile("Textures\\Pause.png");
        }
        #endregion

        #region Stop Button
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedItem != null)
            {
                StopTimer.Start();
                StopButton.Image = Image.FromFile("Textures\\Stop Click.gif");
                wplayer.controls.stop();
            }
        }
        private void StopButton_MouseEnter(object sender, EventArgs e)
        {
            if (StopTimerInt > 150 || StopTimerInt < 1)
                StopButton.Image = Image.FromFile("Textures\\Stop Pulse.gif");
        }
        private void StopButton_MouseLeave(object sender, EventArgs e)
        {
            if (StopTimerInt > 150 || StopTimerInt < 1)
                StopButton.Image = Image.FromFile("Textures\\Stop.png");
        }
        #endregion

        private void FileButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            Dialog.Multiselect = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                string[] Files = Dialog.FileNames;
                foreach (string File in Files)
                {
                    TrackList.Items.Add(Dialog.SafeFileNames[i]);
                    WorkingName[i] = File;
                    Console.WriteLine(WorkingName[i].ToString());
                    i = i + 1;
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
            if (PlayTimerInt == 1)
            {
                PlayButton.Image = Image.FromFile("Textures\\Play Click.gif");
            }

            if (PlayTimerInt > 140)
            {
                PlayTimer.Stop();
                PlayTimerInt = 0;
                PlayButton.Image = Image.FromFile("Textures\\Play.png");
            }
        }
        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            PauseTimerInt = PauseTimerInt + 1;
            if (PauseTimerInt == 1)
            {
                PauseButton.Image = Image.FromFile("Textures\\Pause Click.gif");
            }

            if (PauseTimerInt > 140)
            {
                PauseTimer.Stop();
                PauseTimerInt = 0;
                PauseButton.Image = Image.FromFile("Textures\\Pause.png");
            }
        }
        private void StopTimer_Tick(object sender, EventArgs e)
        {
            StopTimerInt = StopTimerInt + 1;
            if (StopTimerInt == 1)
            {
                StopButton.Image = Image.FromFile("Textures\\Stop Click.gif");
            }

            if (StopTimerInt > 140)
            {
                StopTimer.Stop();
                StopTimerInt = 0;
                StopButton.Image = Image.FromFile("Textures\\Stop.png");
            }
        }
        #endregion

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoListAdd();
        }
    }
}
