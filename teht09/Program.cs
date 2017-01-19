using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, summa = 0;

            do {
                Console.WriteLine("Anna luku > ");
                string line1 = Console.ReadLine();
                luku = int.Parse(line1);
                summa = summa + luku;
            } while (luku != 0);

            Console.WriteLine("Lukujen summa on " + summa);
            Console.ReadLine();
        }
    }
}
