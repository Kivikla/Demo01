using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna numero: ");
            number = int.Parse(Console.ReadLine()); // "10" -> 10
            // show number "text"
            if (number == 0 || number == 1) Console.WriteLine("0");
            else if (number == 2 || number == 3) Console.WriteLine("1");
            else if (number == 4 || number == 5) Console.WriteLine("2");
            else if (number == 6 || number == 7) Console.WriteLine("3");
            else if (number == 7 || number == 8) Console.WriteLine("4");
            else Console.WriteLine("5");
            
            }
    }
}
