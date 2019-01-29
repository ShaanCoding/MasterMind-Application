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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules rules = new Rules();
            rules.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits credits = new Credits();
            credits.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Highscoremenu highscoremenu = new Highscoremenu();
            highscoremenu.Show();
        }
    }
}
