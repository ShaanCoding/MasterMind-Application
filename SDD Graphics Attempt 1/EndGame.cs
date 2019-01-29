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

namespace SDD_Graphics_Attempt_1
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
            int winstate = Game.winstate;
            string[] SecretCode = Game.SecretCode;
            if (winstate == 1)
            {
                int Highscore = Game.score;
                label2.Text = "Congratulations You Win! \nHighscore:" + Highscore;
            }
            else if (winstate == 0)
            {
                label2.Text = "Bad Luck You Lose! The Score Was: ";
                for(int i = 0; i < 4; i++)
                {
                    label2.Text += SecretCode[i];
                }
            }
        }

        private void EndGame_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int winstate = Game.winstate;
            if (winstate == 1)
            {
                this.Hide();
                Highscore highscore = new Highscore();
                highscore.Show();
            }
            if (winstate == 0) 
            {
                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
        }
    }
}
