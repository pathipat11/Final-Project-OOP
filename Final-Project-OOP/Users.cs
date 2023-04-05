using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    internal class Users
    {
        private string manage, name, cardID, mail, phone, date, time;
        public Users(string manage,string name, string cardID, string mail, string phone, string date, string time)
        {
            this.manage = manage;
            this.name = name;
            this.cardID = cardID;
            this.mail = mail;
            this.phone = phone;
            this.date = date;
            this.time = time;
        }
        public string Manage { get => manage;}
        public string Name { get => name; }
        public string CardID { get => cardID; }
        public string Mail { get => mail; }
        public string Phone { get => phone; }
        public string Date { get => date; }
        public string Time { get => time;}
    }

}
