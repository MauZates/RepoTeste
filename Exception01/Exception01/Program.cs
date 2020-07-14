using System;

namespace Exception01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divison by zero is not allowed");
            }
            catch (FormatException)
            {
                Console.WriteLine("is not a number");
            }
        }
    }
}
