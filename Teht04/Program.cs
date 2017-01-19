using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Anna ikä: ");
            age = int.Parse(Console.ReadLine());
            if (age >= 0 && age < 18) Console.WriteLine("Junior");
            else if (age >= 18 && age <= 65) Console.WriteLine("Adult");
            else if (age >= 66 && age <= 100) Console.WriteLine("Too old for this shit.");
            else Console.WriteLine("You should be in grave, fool!");

        }
    }
}
