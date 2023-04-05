using Final_Project_OOP.product;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Project_OOP
{
    public partial class Infomation : Form
    {
        List<Users> users = new List<Users>();
        List<Product> products;
        private Users _users;
        public Infomation()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            NameTb.Text = "";
            CardTb.Text = "";
            MailTb.Text = "";
            PhoneTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int n = InformationDGV.Rows.Add();
            InformationDGV.Rows[n].Cells[0].Value = "Borrow";
            InformationDGV.Rows[n].Cells[1].Value = NameTb.Text;
            InformationDGV.Rows[n].Cells[2].Value = CardTb.Text;
            InformationDGV.Rows[n].Cells[3].Value = MailTb.Text;
            InformationDGV.Rows[n].Cells[4].Value = PhoneTb.Text;
            InformationDGV.Rows[n].Cells[5].Value = DateCb.Text;
            InformationDGV.Rows[n].Cells[6].Value = TimeLb.Text;

            string manage = "Borrow";
            string name = NameTb.Text;
            string cardID = CardTb.Text;
            string mail = MailTb.Text;
            string phone = PhoneTb.Text;
            string date = DateCb.Text;
            string time = TimeLb.Text;

            _users = new Users(manage, name, cardID, mail, phone, date, time);
            this.DialogResult = DialogResult.OK;

            Reset();
        }

        private void DeleteBtb_Click(object sender, EventArgs e)
        {
            int numRows = InformationDGV.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = InformationDGV.Rows.Count - 1;
                    InformationDGV.Rows.Remove(InformationDGV.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Reset();
        }

        private void Infomation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeLb.Text = DateTime.Now.ToShortTimeString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Model obj = new Model();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
            this.Hide();
        }

        private void TurnTb_Click(object sender, EventArgs e)
        {
            int n = InformationDGV.Rows.Add();
            InformationDGV.Rows[n].Cells[0].Value = "Return Bike";
            InformationDGV.Rows[n].Cells[1].Value = NameTb.Text;
            InformationDGV.Rows[n].Cells[2].Value = CardTb.Text;
            InformationDGV.Rows[n].Cells[3].Value = MailTb.Text;
            InformationDGV.Rows[n].Cells[4].Value = PhoneTb.Text;
            InformationDGV.Rows[n].Cells[5].Value = DateCb.Text;
            InformationDGV.Rows[n].Cells[6].Value = TimeLb.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            /*//save data from list to csv file
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
            }*/
            if (InformationDGV.Rows.Count > 0)
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int columnCount = InformationDGV.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[InformationDGV.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += InformationDGV.Columns[i].HeaderText.ToString() + "\t";

                        }
                        for (int i = 1; (i - 1) < InformationDGV.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCSV[i] += InformationDGV.Rows[i - 1].Cells[j].Value.ToString() + "\t";

                            }

                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Mainpage obj = new Mainpage();
            obj.Show();
            this.Hide();
        }
    }
}