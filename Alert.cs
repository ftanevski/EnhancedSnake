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
    public partial class Alert : Form
    {
        string hoverSound = "https://www.soundjay.com/buttons/button-3.wav";
        string clickSound = "https://www.soundjay.com/buttons/button-09a.wav";

        public Alert()
        {
            InitializeComponent();
        }

        private void Alert_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = clickSound;
            sPlayer.Play();

            this.Close();
        }

        private void Alert_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.SoundLocation = hoverSound;
            sPlayer.Play();
        }
    }
}
