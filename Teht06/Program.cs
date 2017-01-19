using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double kulutus, bhinta;
            kulutus = 7.02;
            bhinta = 1.595;
            Console.Write("Anna matka: ");
            matka = int.Parse(Console.ReadLine());
            double kokonaiskulutus = kulutus * matka / 100;
            Console.WriteLine("Bensaa kuluu: " + kokonaiskulutus);
            double kustannus = kulutus + bhinta;
            Console.WriteLine("Kustannus {0} euroa", kustannus);
        }
    }
}
