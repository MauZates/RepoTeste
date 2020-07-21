using System;
using System.Globalization;
using ExercicioDeFixacao146.Entities;
using ExercicioDeFixacao146.Entities.Exceptions;

namespace ExercicioDeFixacao146
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
            catch (DomainException exp)
            {
                Console.WriteLine("Withdraw error" + exp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
