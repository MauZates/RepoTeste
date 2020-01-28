using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        /// <summary>
        /// Conjunto nao tem posição
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            
            A.Add(3);
            A.Add(5);
            A.Add(7);
            A.Add(9);

            foreach (var NovoA in A)
            {
                Console.WriteLine(NovoA);
            }

            Console.WriteLine();

            HashSet<int> B = new HashSet<int>();

            B.Add(3);
            B.Add(5);
            B.Add(9);
            B.Add(11);
            B.Add(13);

            foreach (var NovoB in B)
            {
                Console.WriteLine(NovoB);
            }

            Console.WriteLine();

            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (B.Contains(n))
            {
                Console.WriteLine(n + " pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine("Não percente ao conjunto B");
            }

            A.Remove(9);
            Console.WriteLine();
            foreach (var NovoA in A)
            {
                Console.WriteLine(NovoA);
            }

            Console.WriteLine();

            A.ExceptWith(B); // Remove de A os que são igual em B // Diferença
            //A.UnionWith(B); //Junta A e B
            //A.IntersectWith(B); // Intersecção com b, ou seja, oq tem igual
            //Linhas acima comentadas para nao dar ruim na aplicação
            foreach (var NovoA in A)
            {
                Console.WriteLine(NovoA);
            }


        }
    }
}
