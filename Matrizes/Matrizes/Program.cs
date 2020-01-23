using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[5, 5];

            Console.WriteLine(mat.Length); // Tamanho total 5 * 5 = 25
            Console.WriteLine(mat.Rank); // primeira dimensao da matriz, quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); //dimensao 0 da matriz tem tamanho 5
            Console.WriteLine(mat.GetLength(1)); //dimensao 1 da matriz tem tamanho 5

        }
    }
}
