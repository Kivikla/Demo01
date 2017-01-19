using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, number2, number3;
            Console.WriteLine("Anna kolme lukua.");
            Console.Write("Anna ensimmäinen luku: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            number3 = int.Parse(Console.ReadLine());
            int sum = number + number2 + number3;
            Console.WriteLine("Sum: " + sum);
            double div = sum / 3.0;
            Console.WriteLine(div);
        }
    }
}
