using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


            DateTime d7 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d8 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d7);
            Console.WriteLine(d8);

        }
    }
}
