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
            borrow.Text= bor;
            TimeTb.Text = time;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //save data from list to csv file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Users item in users)
                    {
                        writer.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                        item.Manage,
                        item.Name,
                        item.CardID,
                        item.Mail,
                        item.Phone,
                        item.Date,
                        item.Time));

                    }
                }
            }
        }
    }
}
