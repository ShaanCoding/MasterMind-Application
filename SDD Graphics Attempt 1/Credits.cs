﻿using System;
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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Credits_Load(object sender, EventArgs e)
        {

        }
    }
}
