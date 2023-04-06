using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_Neukunde
{
    class Mensch
    {
        //Eigenschaften
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Stadt { get; set; }

        //Konstruktor mit 4 Argumenten
        public Mensch(string vorname, string name, string mail, string stadt)
        {
            Vorname = vorname;
            Name = name;
            Mail = mail;
            Stadt = stadt;
        }
        //Konstruktor mit 2 Argumenten
        public Mensch(string vorname, string name)
        {
            Vorname = vorname;
            Name = name;
        }

        //Beispiel für eine Methode
        public void sichVorstellen()
        {
            if (Vorname != null && Name != null && Mail != null && Stadt != null)
            {
                Console.WriteLine("Kontrollieren Sie Ihre Eingaben!");
                Console.WriteLine("Sie sind ein neuer Kunde");
                Console.WriteLine(Vorname + " " + Name + " aus " + Stadt);
                Console.WriteLine("Mail: " + Mail);
            }
            else
            {
                Console.WriteLine("Kontrollieren Sie Ihre Eingaben!");
                Console.WriteLine("Sie sind Kunde " + Vorname + " " + Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string antwort;
            Console.Write("Neukunde (n) oder bereits Kunde (k): ");
            antwort = Console.ReadLine();

            if (antwort == "n")
            {
                // Mensch neukunde = new Mensch("Denis", "Müller", "123@gmx.de", "Leipzig");
                // neukunde.sichVorstellen();
                Console.Write("Vorname: ");
                string vor = Console.ReadLine();
                Console.Write("Nachname: ");
                string nach = Console.ReadLine();
                Console.Write("Mail: ");
                string ma = Console.ReadLine();
                Console.Write("Stadt: ");
                string st = Console.ReadLine();
                Mensch neukunde = new Mensch(vor, nach, ma, st);
                neukunde.sichVorstellen();
            }
            else
            {
                //Mensch kunde = new Mensch("Heidi", "Zaun");
                Console.Write("Vorname: ");
                string vor = Console.ReadLine();
                Console.Write("Nachname: ");
                string nach = Console.ReadLine();
                Mensch kunde = new Mensch(vor, nach);
                kunde.sichVorstellen();
            }

            Console.ReadLine();
        }
    }
}

