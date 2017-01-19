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
            //Ask number
            int number1, number2, number3;
            
            Console.WriteLine("Give number > ");
            string line = Console.ReadLine();
            number1 = int.Parse(line);
            Console.WriteLine("Give number > ");
            string line2 = Console.ReadLine();
            number2 = int.Parse(line2);
            Console.WriteLine("Give number > ");
            string line3 = Console.ReadLine();
            number3 = int.Parse(line3);

            Console.WriteLine(number1 + number2 + number3);

            Console.WriteLine((number1 + number2 + number3) / 3);

            Console.ReadLine();
        }
    }
}
