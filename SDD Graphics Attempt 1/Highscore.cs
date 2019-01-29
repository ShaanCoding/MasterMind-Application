using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SDD_Graphics_Attempt_1
{
    public partial class Highscore : Form
    {
        //Initialization Of Music & Form
        string highscoreName;
        string score;
        public Highscore()
        {
            InitializeComponent();
            score = Convert.ToString(Game.score);
            textBox1.Text = Convert.ToString(score);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Writing To Notepad File From Users Name In Highscore & Then Jumps Form
            StreamWriter scoreTextfile;
            if (!File.Exists("highscorefile.txt"))
            {
                scoreTextfile = new StreamWriter("highscorefile.txt");
            }
            else
            {
                scoreTextfile = File.AppendText("highscorefile.txt");
            }
            scoreTextfile.WriteLine(score + " " + highscoreName + " " + " " + DateTime.Now);
            scoreTextfile.Close();
            this.Hide();
            Highscoremenu highscoremenu = new Highscoremenu();
            highscoremenu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            highscoreName = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
