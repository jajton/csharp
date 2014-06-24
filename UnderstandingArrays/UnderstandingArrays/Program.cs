using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 16;
            //numbers[3] = 15;
            //numbers[4] = 23;

            //int[] numbers = new int[] {1,2,4,3,6,645,132};

            //Console.WriteLine(numbers[1].ToString());
            //Console.ReadLine();

            //string[] names = new string[] {"Ton", "Jose", "Mike", "Pedro"};

            //foreach (string name in names) {
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            string zig = "YOu can get what you want out of life" + 
                "if you can help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();
        }
    }
}
