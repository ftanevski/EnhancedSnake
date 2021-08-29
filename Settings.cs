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
    public partial class Settings : Form
    {
        string hoverSound = "https://www.soundjay.com/buttons/button-3.wav";
        string clickSound = "https://www.soundjay.com/buttons/button-09a.wav";
        public static int numOfFood;
        public Settings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = clickSound;
            sPlayer.Play();

            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = hoverSound;
            sPlayer.Play();
        }

        private void rbOne_Click(object sender, EventArgs e)
        {
            numOfFood = 1;
        }

        private void rbTwo_Click(object sender, EventArgs e)
        {
            numOfFood = 2;
        }

        private void rbThree_Click(object sender, EventArgs e)
        {
            numOfFood = 3;
        }

        private void rbFour_Click(object sender, EventArgs e)
        {
            numOfFood = 4;
        }

        private void rbFive_Click(object sender, EventArgs e)
        {
            numOfFood = 5;
        }
    }
}
