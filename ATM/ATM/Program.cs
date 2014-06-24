using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a transaction 1. Depost 2. Withdraw 3: Check Balance");
            Console.Write("Please enter your selection: ");

            string caseSwitch = Console.ReadLine();
            int balance = 500;
            
            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("1. Deposit");
                   
                 
                        int amount;
                        // amount to deposit
                        Console.Write("Amount money to depost: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        amount = 500 + amount;
                        Console.WriteLine("Current money: {0}", amount);
                        Console.ReadLine();
                
                    break;

                case "2":
                    Console.WriteLine("2. Withdraw");

                   
                    Console.Write("Enter amount to withdraw: ");
                    string withdraw = System.Console.ReadLine();

                    int w;
                    System.Int32.TryParse(withdraw, out w);
                    
                    Console.WriteLine("Your current balance is: {0}",balance-w);
                    Console.ReadLine();
                    break;

                case "3":
                   
                    Console.WriteLine("Balance: {0}", balance);
                    Console.ReadLine();
                    break;

            }
           
        }
    }
}
