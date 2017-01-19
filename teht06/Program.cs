using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 0.0702;
            double bensa = 1.595;
            double matka, kuluu, euro;

            Console.WriteLine("Anna matka kilometreinä > ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            kuluu = matka * kulutus;
            euro = kuluu * bensa;

            Console.WriteLine("Bensaa kuluu " + kuluu + " litraa, kustannus " + euro + " euroa");
            Console.ReadLine();
        }
    }
}
