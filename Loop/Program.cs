using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 5;

            //for (int i = 0; i < number; i++)
            //    Console.WriteLine(i);

            //Console.ReadLine();

            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.ReadLine();
           
        }
    }
}
