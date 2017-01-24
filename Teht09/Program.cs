using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int luku = 1;

            Console.Write("Anna kokonaisnumero " + luku + " > ");
            int numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                luku++;
                summa = (summa + numero);
                Console.Write("Anna kokonaisnumero " + luku + " > ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.Write("summa: " + summa + "\n");

        }

    }

}