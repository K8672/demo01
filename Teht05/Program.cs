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
            int number, seconds, minutes, hours;

            Console.WriteLine("Give seconds > ");
            string line = Console.ReadLine();
            number = int.Parse(line);

            minutes = (number % 3600) / 60;
            hours = number / 3600;
            seconds = number % 3600 % 60;

            Console.WriteLine("Hour " + hours + " Min " + minutes + " Seconds! " + seconds);

            Console.ReadLine();
        }
    }
}
