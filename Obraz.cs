using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Obraz : Przedmiot
    {
        private int wysokosc;
        private int szerokosc;
        private string technika;

        public Obraz(string n, string t, int d, int w, int i)
        {
            nazwa = n;
            tworca = t;
            data_powstania = d;
            wartosc = w;
            id_przedmiotu = i;
            Console.WriteLine("Podaj wysokosc obrazu");
            wysokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc obrazu");
            szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj technike obrazu");
            technika = Console.ReadLine();
        }

        public void dodaj_obraz()
        {
            Console.WriteLine("Podaj nazwe obrazu");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj tworce obrazu");
            tworca = Console.ReadLine();
            Console.WriteLine("Podaj date powstania obrazu");
            data_powstania = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc obrazu");
            wartosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ID obrazu");
            id_przedmiotu = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc obrazu");
            wysokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc obrazu");
            szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj technike obrazu");
            technika = Console.ReadLine();
        }
        override public void wyswietl_info()
        {
            Console.WriteLine("Nazwa obrazu: {0}", nazwa);
            Console.WriteLine("Tworca obrazu: {0}", tworca);
            Console.WriteLine("Data powstania obrazu: {0} ", data_powstania);
            Console.WriteLine("Wartosc obrazu: {0}", wartosc);
            Console.WriteLine("ID obrazu: {0}", id_przedmiotu);
            Console.WriteLine("Wysokosc obrazu: {0}cm", wysokosc);
            Console.WriteLine("Szerokosc obrazu: {0}cm", szerokosc);
            Console.WriteLine("Technika obrazu: {0}", technika);
        }
    }
}
