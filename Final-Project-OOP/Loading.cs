using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Final_Project_OOP
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            Myprogress.Value = startp;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Infomation Mylogin = new Infomation();
                this.Hide();
                Mylogin.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
