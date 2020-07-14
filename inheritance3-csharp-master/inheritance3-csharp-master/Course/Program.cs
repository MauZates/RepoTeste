using System;
using System.Collections.Generic;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>
            {
                new SavingsAccount(1001, "Alex", 500.0, 0.01),
                new BusinessAccount(1002, "Maria", 500.0, 400),
                new SavingsAccount(1003, "Bob", 500.0, 0.01),
                new BusinessAccount(1004, "Anna", 500.0, 500.0)
            };
            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
