using System;

namespace ExeVetor01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Salarios = new int[10];
            int n = 10;
            int MaiorSalario = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i} salário: ");
                int salario = int.Parse(Console.ReadLine());
                Salarios[i] = salario;

                if (Salarios[i] > MaiorSalario)
                {
                    MaiorSalario = Salarios[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("O maior salario é o " + MaiorSalario);
        }
    }
}
