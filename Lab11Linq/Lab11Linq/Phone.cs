using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Linq
{
    class Phone
    {

        public string name;
        public string Lname;
        public string adres;
        public int number_of_card;
        public int time_of_citys_talks;
        public int balance;
        public const int pref_number = +375;
        public int international_communication;
        public int debet;
        public int position;

        public string Name { get; set; }
        public string Company { get; set; }

        public Phone(string Name,string Company)
        {
            this.Name = Name;
            this.Company = Company;
        }

        public Phone(string name, string Lname, string adres, int number_of_card, int time_of_citys_talks, int balance, int pref_number, int international_communication, int debet, int position)
        {
            this.name = name;
            this.Lname = Lname;
            this.adres = adres;
            this.number_of_card = number_of_card;
            this.time_of_citys_talks = time_of_citys_talks;
            this.balance = balance;
            pref_number = +375;
            this.international_communication = international_communication;
            this.debet = debet;
            this.position = position;
        }
    }
}
