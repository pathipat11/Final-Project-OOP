﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_OOP
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Infomation obj = new Infomation();
            obj.Show();
            this.Hide();
        }
    }
}
