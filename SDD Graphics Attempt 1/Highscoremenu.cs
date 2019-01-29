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
using System.Media;

namespace SDD_Graphics_Attempt_1
{
    public partial class Highscoremenu : Form
    {
        public Highscoremenu()
        {
            //Initialization Of Music & Start Of Program
            InitializeComponent();
        }

        private void Highscoremenu_Load(object sender, EventArgs e)
        {
            //Reads Text File & Displays Highscore
            using (StreamReader sr = File.OpenText("highscorefile.txt"))
            {
                String highscorewriting = "";
                int i = 0;
                while ((highscorewriting = sr.ReadLine()) != null)
                {
                    i++;
                    label2.Text+=i+"."+highscorewriting+"\n";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stops Music & Jumps Forms
            this.Hide();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
