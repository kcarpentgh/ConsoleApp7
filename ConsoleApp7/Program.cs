using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string stringinput = Console.ReadLine();
            int numberinput = Convert.ToInt32(stringinput);
            bool result = (numberinput % 2 == 0);

            if (result == true)
                Console.WriteLine("This is an even number.");
            else
                Console.WriteLine("This is an odd number.");

            Console.ReadKey();

        }
    }
}
