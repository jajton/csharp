using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter Key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //Console.ReadLine();


            //Console.WriteLine("Would you prefer what is behing door number 1, 2, or 3?");
            //string userValue = Console.ReadLine();

            //if (userValue == "1")
            //{
            //    Console.WriteLine("You won a new car!");
            //    Console.ReadLine();
            //}
            //else if (userValue == "2") 
            //{
            //    Console.WriteLine("You won a new boat!");
            //    Console.ReadLine();
            //}
            //else if (userValue == "3")
            //{
            //    Console.WriteLine("You won a new bike");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, we didn't understand. You lose!");
            //    Console.ReadLine();
            //}

            //Console.WriteLine("Would you prefer what is behing door number 1, 2, or 3?");
            //string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")
            //{
            //    message = "You won a new car!";
            //}
            //else if (userValue == "2")
            //{
            //    message = "You won a new boat!";
            //}
            //else if (userValue == "3")
            //{
            //    message = "You won a new bike!";
            //}
            //else
            //{
            //    message = "Sorry, I cant uderstand you!";
            //}

            //Console.WriteLine(message);
            //Console.ReadLine();

            Console.WriteLine("Would you prefer what is behing door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();
        }
        
            
    }
   
}
