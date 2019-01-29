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
    public partial class Rules : Form
    {
        public Rules()
        {
            //Initialization Of Form + Music
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Stops Music & Jumps To Next Form
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
