using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sekunnit > ");
            int sekunnit = int.Parse(Console.ReadLine());
            int tunnit = sekunnit / 3600;
            int min = sekunnit / 60 - tunnit * 60;
            int sek = sekunnit % 60;
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa {0} tuntia {1} minuuttia {2} sekuntia", tunnit, min, sek);
        }
    }
}
