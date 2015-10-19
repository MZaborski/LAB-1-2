using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rzezba : Przedmiot
    {
        private int wysokosc;
        private string material;

        public Rzezba(string n="Dawid", string t="Michal Aniol", int d=1504, int w=50000000, int i=2, int h=434, string m="Marmur")
        {
            nazwa = n;
            tworca = t;
            data_powstania = d;
            wartosc = w;
            id_przedmiotu = i;
            wysokosc = h;
            material = m;
        }

        public Rzezba()
        {
            Console.WriteLine("Podaj nazwe rzezby");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj tworce rzezby");
            tworca = Console.ReadLine();
            Console.WriteLine("Podaj date powstania rzezby");
            data_powstania = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc rzezby");
            wartosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ID rzezby");
            id_przedmiotu = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc rzezby");
            wysokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj material z ktorego wykonana jest rzezba");
            material = Console.ReadLine();
        }

        override public void wyswietl_info()
        { 
            Console.WriteLine("Nazwa rzezby: {0}", nazwa);
            Console.WriteLine("Tworca rzezby: {0}", tworca);
            Console.WriteLine("Data powstania rzezby: {0} ", data_powstania);
            Console.WriteLine("Wartosc rzezby: {0}", wartosc);          
            Console.WriteLine("ID rzezby: {0}", id_przedmiotu);
            Console.WriteLine("Wysokosc rzezby: {0}cm", wysokosc);
            Console.WriteLine("Material z ktorego wykonana jest rzezba: {0}", material);
        }
    }
}
