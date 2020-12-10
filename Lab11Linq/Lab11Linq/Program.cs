using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Linq
{
    class Program
    {
        class Player
        {
            public string Name { get; set; }
            public string Team { get; set; }
        }
        class Team
        {
            public string Name { get; set; }
            public string Country { get; set; }
        }

        static void Main(string[] args)
        {
            string[] ForWork = new string[] 
            { "September", "October", "November", "December", "January", "February", "Mart", "April", "May", "June", "July", "August" };

            Console.WriteLine("Enter month's length");
            int n = Convert.ToInt32(Console.ReadLine());

            IEnumerable m1 = from m in ForWork
                             where m.Length == n
                             select m;
            foreach (string m in m1) Console.WriteLine($"{m}");

            Console.WriteLine("----------------");

            IEnumerable m2 = from m in ForWork
                             where m.Equals("December") || m.Equals("January") || m.Equals("February") ||
                             m.Equals("June") || m.Equals("July") || m.Equals("August")
                             select m;
            foreach(string m in m2) Console.WriteLine($"{m}");

            Console.WriteLine("----------------");

            IEnumerable m3 = from m in ForWork
                             orderby m
                             select m;
            foreach(string m in m3) Console.WriteLine($"{m}");

            Console.WriteLine("----------------");

            IEnumerable m4 = from m in ForWork
                             where m.Length >= 4 && m.Contains("u")
                             select m;
            foreach(string m in m4) Console.WriteLine($"{m}");


            List<Phone> ListOfPhones = new List<Phone>();
            Phone phone1 = new Phone("Kirill", "Pochta", "Ул.Пономаренко", 31231231, 30, 20, +375, 0,100,1);
            Phone phone2 = new Phone("Вася", "Myren", "Ул.Василькова", 2991561, 20, 10, +375, 1,200,2);
            Phone phone3 = new Phone("Vasya", "Pupsin", "Ул.Васькипа", 32231, 5, 50, +375, 0,300,3);
            Phone phone4 = new Phone("Pusya", "Include", "Ул.Васькипа", 1231, 5, 70, +375, 0,400,4);
            Phone phone5 = new Phone("Vanderman", "I", "Ул.Васькипа", 231, 5, 20, +375, 0,500,5);
            Phone phone6 = new Phone("Ale", "Kotorie", "Ул.Васькипа", 131, 5, 50, +375, 1,600,6);
            Phone phone7 = new Phone("Gde", "dengi", "Ул.Васькипа", 31, 5, 20, +375, 1,700,7);
            Phone phone8 = new Phone("money", "Kakie", "Ул.Васькипа", 311, 5, 20, +375, 0,800,10);

            ListOfPhones.Add(phone1);
            ListOfPhones.Add(phone2);
            ListOfPhones.Add(phone3);
            ListOfPhones.Add(phone4);
            ListOfPhones.Add(phone5);
            ListOfPhones.Add(phone6);
            ListOfPhones.Add(phone7);
            ListOfPhones.Add(phone8);

            Console.WriteLine("----------------");

            Console.WriteLine("Enter time of talks in city ");

            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------");

            IEnumerable m5 = from m in ListOfPhones
                             where m.time_of_citys_talks == n1
                             select m;
            foreach (Phone m in m5) Console.WriteLine($"{m.Lname} {m.name}");

            IEnumerable m6 = from m in ListOfPhones
                             where m.international_communication.Equals(1)
                             select m;
            foreach (Phone m in m6) Console.WriteLine($"{m.Lname} {m.name}");

            Console.WriteLine("----------------");

            IEnumerable m7 = from m in ListOfPhones
                             where m.position.Equals(10)
                             select m;

            foreach (Phone m in m7) Console.WriteLine($"{m.Lname} {m.name}");

            Console.WriteLine("----------------");
            Console.WriteLine("Enter debet");
            int n2 = Convert.ToInt32(Console.ReadLine());
            IEnumerable m8 = from m in ListOfPhones
                             where m.debet==n2
                             select m;

            foreach (Phone m in m8) Console.WriteLine($"{m.Lname} {m.name}");

            Console.WriteLine("----------------");

            IEnumerable m9 = from m in ListOfPhones
                             orderby m.Lname
                             select m;

            foreach (Phone m in m9) Console.WriteLine($"{m.Lname}");

            Console.WriteLine("----------------");

            List<Phone1> phones = new List<Phone1>
            {
                new Phone1 {Name="Lumia 430", Company="Microsoft" },
                new Phone1 {Name="Mi 5", Company="Xiaomi" },
                new Phone1 {Name="LG G 3", Company="LG" },
                new Phone1 {Name="iPhone 5", Company="Apple" },
                new Phone1 {Name="Lumia 930", Company="Microsoft" },
                new Phone1 {Name="iPhone 6", Company="Apple" },
                new Phone1 {Name="Lumia 630", Company="Microsoft" },
                new Phone1 {Name="LG G 4", Company="LG" }
            };

            var phoneGroups = from phone in phones
                              group phone by phone.Company; /// группировка 

            Console.WriteLine("----------------");

            foreach (IGrouping<string, Phone1> g in phoneGroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.Name);
                Console.WriteLine();
            }

            int[] numbers = new int[] {1,2,3,4,5,6,7,8};
            int result = numbers.Aggregate((x, y) => x + y); /// агрегация 
            Console.WriteLine(result);

            Console.WriteLine("----------------");

            var m10 = from m in phones select m.Name;  /// проекция 
            foreach(string u in m10) Console.WriteLine(u);

            Console.WriteLine("----------------");

            IEnumerable m11 = from m in phones
                              orderby m.Company /// сортировак 
                              select m;
            foreach (Phone1 m in m11) Console.WriteLine(m.Company);

            Console.WriteLine("----------------");

            bool ThereArethisNumber = numbers.Contains(3); /// Кванторы 
            Console.WriteLine(ThereArethisNumber);

            Console.WriteLine("----------------");

             List<Team> teams = new List<Team>()
            {
                new Team { Name = "Bavariya", Country ="German" },
                new Team { Name = "Barselona", Country ="Spain" }
            };
            List<Player> players = new List<Player>()
            {
                new Player {Name="Messi", Team="Bavariya"},
                new Player {Name="Neymar", Team="Barselona"},
                new Player {Name="Robben", Team="Bavariya"}
            };

            var result1 = from pl in players ///join
                         join t in teams on pl.Team equals t.Name
                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            foreach (var item in result1) Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
        }
    }
}
