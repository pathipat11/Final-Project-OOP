using Final_Project_OOP.product;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_OOP
{
    public partial class Model : Form
    {
        List<Users> Users = new List<Users>();
        List<Product> product;
        Product selectedProduct;
        public Model()
        {
            InitializeComponent();
            product = new List<Product>();
            product.Add(new Bike1());
            product.Add(new Bike2());
            product.Add(new Bike3());
            product.Add(new Bike4());
            product.Add(new Bike5());
            product.Add(new Bike6());
            product.Add(new Bike7());
            product.Add(new Bike8());
            product.Add(new Bike9());
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            Infomation obj = new Infomation();
            obj.Show();
            this.Hide();
        }

        private void B1Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[0];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B2Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[1];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B3Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[2];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B4Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[3];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B5Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[4];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B6Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[5];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B7Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[6];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B8Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[7];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void B9Btn_Click(object sender, EventArgs e)
        {
            selectedProduct = product[8];
            this.pictureBox3.Image = selectedProduct.getImage();
            this.BnameTb.Text = selectedProduct.getName();
            this.PriceTb.Text = selectedProduct.getPrice().ToString();
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.name = BnameTb.Text;
            obj.price = PriceTb.Text;
            obj.date = dateTimePicker1.Text;
            obj.bor = comboBox1.Text;
            obj.time = label5.Text;
            obj.Show();
            this.Hide();   
        
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToShortTimeString();
        }

        private void Model_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void DeleteBtb_Click(object sender, EventArgs e)
        {
            BnameTb.Text = "";
            PriceTb.Text = "";

        }
    }
}
