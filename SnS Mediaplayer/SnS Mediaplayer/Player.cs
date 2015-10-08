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
        static string[] WorkingName = new string[100];
        public bool Debug = true;
        public bool ShouldPlay = false;

        public static int seconds;
        public static int minutes;
        public static int hours;

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

        public string GetLength()
        {
            seconds = Convert.ToInt32(wplayer.currentMedia.duration);
            while (seconds > 60)
            {
                seconds = seconds - 60;
                minutes = minutes + 1;
            }
            while (minutes > 60)
            {
                minutes = minutes - 60;
                hours = hours + 1;
            }
            return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        }

        public void Next()
        {
            //            wplayer.currentMedia.duration;
        }

        public void Repeat()
        {
            if (ShouldPlay == true)
            {
                if (wplayer.status == "Gestopt")
                {
                    Console.WriteLine("Now its going to play the next song");
                }
            }
        }

        public void Shuffle()
        {
            if (Random.Checked == true)
            {
                Random rnd = new Random(Convert.ToInt32(DateTime.Now.Ticks.ToString().Substring(0, 6)));
                List<String> randomized = new List<string>();

                int totalCount = 0;
                while (totalCount != TrackList.Items.Count)
                {
                    int i = rnd.Next(0, TrackList.Items.Count);

                    while (randomized.Contains(TrackList.Items[i]))
                    {
                        i = rnd.Next(0, TrackList.Items.Count);
                    }

                    if (!randomized.Contains(TrackList.Items[i]))
                        randomized.Add(TrackList.Items[i].ToString());

                    totalCount++;
                }

                TrackList.Items.Clear();
                foreach (string s in randomized)
                    TrackList.Items.Add(s);
            }
        }

        public void InfoListAdd()
        {
            try
            {
                InfoList.Text = "Name: " + Dialog.SafeFileNames[TrackList.SelectedIndex];
                InfoList.Text = InfoList.Text + "\nFile size: " + "Work in progress";
                InfoList.Text = InfoList.Text + "\nAlbum Name: " + "Work in progress";
                InfoList.Text = InfoList.Text + "\nAlbum Artist: " + "Once again, work in progress";
                InfoList.Text = InfoList.Text + "\nTrack Length: " + wplayer.currentMedia.durationString;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ResetColor();
                Console.WriteLine("\n");
            }
        }

        #region Play Button
        private void Playbutton_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedItem != null)
            {
                ShouldPlay = true;
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
                ShouldPlay = false;
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
            Repeat();
            DebugLabel1.Text = TrackList.SelectedIndex.ToString();
            
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
            wplayer.URL = WorkingName[TrackList.SelectedIndex].ToString();
            Console.WriteLine(wplayer.currentMedia.name);
            Console.WriteLine(wplayer.currentMedia.durationString);
            InfoListAdd();
        }
    }
}
