using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[9];
            int i;

            luvut[0] = 1;
            luvut[1] = 2;
            luvut[2] = 33;
            luvut[3] = 44;
            luvut[4] = 55;
            luvut[5] = 68;
            luvut[6] = 77;
            luvut[7] = 96;
            luvut[8] = 100;

            for ( i = 0; i < luvut.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }
            Console.ReadLine();
        }
    }
}
