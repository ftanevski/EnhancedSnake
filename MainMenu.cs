using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EnhancedSnake
{
    public partial class MainMenu : Form
    {
        string hoverSound = "https://www.soundjay.com/buttons/button-3.wav";
        string clickSound = "https://www.soundjay.com/buttons/button-09a.wav";
        public MainMenu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = clickSound;
            sPlayer.Play();
        }

        private void btnPlayGame_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = hoverSound;
            sPlayer.Play();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = clickSound;
            sPlayer.Play();

            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = hoverSound;
            sPlayer.Play();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = clickSound;
            sPlayer.Play();

            Help help = new Help();
            help.ShowDialog();
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = hoverSound;
            sPlayer.Play();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = clickSound;
            sPlayer.Play();
            this.Close();
        }

        private void btnExitGame_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = hoverSound;
            sPlayer.Play();
        }
    }
}
