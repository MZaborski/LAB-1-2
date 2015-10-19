using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rzezba R = new Rzezba();
            R.informacja();
            R.wyswietl_info();

            Obraz O = new Obraz("Dama z gronostajem", "Leonardo da Vinci", 1491, 100000000, 1);
            O.informacja();
            O.wyswietl_info();

            Console.ReadLine();
        }
    }
}
