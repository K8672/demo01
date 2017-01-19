using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask number
            int number;
            Console.Write("Give number > ");
            string line = Console.ReadLine(); // "1"
            number = int.Parse(line); // "1" -> 1
            // Which number...
            switch (number)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                default: Console.WriteLine("other number"); break;
            }
            // wait enter...
            Console.ReadLine();
        }
    }
}