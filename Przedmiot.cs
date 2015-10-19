using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Przedmiot : IPrzedmiot
    {
        public string nazwa;
        public string tworca;
        public int data_powstania;
        public int wartosc;
        public int id_przedmiotu;

        public Przedmiot(string n = "Dama z gronostajem", string t = "Leonardo da Vinci", int d = 1490, int w = 100000000, int i = 1)
        {
            nazwa = n;
            tworca = t;
            data_powstania = d;
            wartosc = w;
            id_przedmiotu = i;     
        }
        public Przedmiot()
        {
        }
        abstract public void wyswietl_info();

        public void informacja()
        {
            Console.WriteLine("Informacje o przedmiocie: ");
        }
    }
}
