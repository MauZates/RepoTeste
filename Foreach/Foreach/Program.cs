using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { " Maria ", " Jose ", " Souza " };
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
