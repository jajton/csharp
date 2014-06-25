using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue1 = superSecretFormula1();
            string myValue2 = superSecretFormula2("Sunshine");

           

            Console.WriteLine(myValue1);
            Console.WriteLine(myValue2);
       
            Console.ReadLine();
            Console.ReadLine();

        }
        private static string superSecretFormula1()
        {
            return "Hello World!";
        }

        private static string superSecretFormula2(string name)
        {
            return String.Format("Hi, {0}!", name);
        }
      
    }
}
