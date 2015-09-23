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
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        string FilePath = "C://Users//Admin//OneDrive//Sander's Bestanden//Muziek//Nightwish//2011 - Imaginaerum//";
        string File = "01. Taikatalvi.mp3";
        public Form1()
        {
            InitializeComponent();
        }
        private void Playbutton_Click(object sender, EventArgs e)
        {
            wplayer.URL = FilePath + File;
            wplayer.controls.play();
            File = File.Replace(".mp3", "");
            MusicList.Text = File;
            Console.WriteLine("Kipsaté");
            Console.WriteLine("Kipsaté");
        }
    }
}
