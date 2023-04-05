using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project_OOP
{
    public partial class Payment : Form
    {
        List<Users> users = new List<Users>();
        public Payment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Infomation obj = new Infomation();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Model obj = new Model();
            obj.Show();
            this.Hide();
        }
        public string name;
        public string price;
        public string date;
        public string bor;
        public string time;
        private void Payment_Load(object sender, EventArgs e)
        {
            BnameTb.Text = name;
            PriceTb.Text = price;
            DateTb.Text = date;
            BorrowTb.Text= bor;
            TimeTb.Text = time;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"D:\Pathipat\IN401105\Final-Project-OOP\Final-Project-OOP\bin\Debug\net6.0-windows"+"\\New folder\\" + BnameTb.Text+".txt";
                StreamWriter A = new StreamWriter(filePath);
                using (A)
                {
                    A.WriteLine(label8.Text + ":" + BnameTb.Text);
                    A.WriteLine(label13.Text + ":" + PriceTb.Text);
                    A.WriteLine(label3.Text + ":" + DateTb.Text);
                    A.WriteLine(label5.Text + ":" + BorrowTb.Text);
                    A.WriteLine(label9.Text + ":" + TimeTb.Text);

                    MessageBox.Show("Succeed");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurd!", "Directory not found!");
            }
        }
    }
}
