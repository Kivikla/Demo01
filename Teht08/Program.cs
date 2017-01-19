using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Anna luku1 > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku2 > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku3 > ");
            luku3 = int.Parse(Console.ReadLine());
            if (luku1 > luku2 && luku1 > luku3) Console.Write(luku1);
            else if (luku2 > luku1 && luku2 > luku3) Console.Write(luku2);
            else Console.Write(luku3);
        }
    }
}
