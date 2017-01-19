using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, apu;

            Console.WriteLine("Anna luku > ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);

            Console.WriteLine("Anna toinen luku > ");
            string line1 = Console.ReadLine();
            luku2 = int.Parse(line1);

            Console.WriteLine("Anna kolmas luku > ");
            string line2 = Console.ReadLine();
            luku3 = int.Parse(line2);

            if ( luku2 > luku1)
            {
                apu = luku2;
                luku1 = luku2;
                luku2 = apu;
            }
            if (luku3 > luku2)
            {
                apu = luku3;
                luku2 = luku3;
                luku3 = apu;
            }
            if (luku2 > luku1)
            {
                apu = luku2;
                luku1 = luku2;
                luku2 = apu;
            }
            Console.WriteLine("Suurin luku on " + luku1);
            Console.ReadLine();
        }
    }
}
