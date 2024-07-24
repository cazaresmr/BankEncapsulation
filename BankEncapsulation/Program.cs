using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            string input = "";

            while (input != "exit")
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Get Balance");
                Console.WriteLine("Type 'exit' to quit.");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            account.Deposit(amount);
                            Console.WriteLine($"You have deposited {amount:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount entered.");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Your balance is {account.GetBalance():C}");
                        break;

                    case "exit":
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
