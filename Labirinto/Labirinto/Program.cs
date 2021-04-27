//using System;

//namespace Labirinto
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            System.IO.StreamReader st = new System.IO.StreamReader(@"C:\arquivoteste1.txt");
//            // Joga too o conteúdo do arquivo numa variável string.
//            string arquivo = st.ReadToEnd();
//            // Fecha.
//            st.Close();
//            string[,] arrayLabirinto = new string[5, 5];

//            // Exibe todos os caracteres.
//            for (int l = 0; l < arquivo.Length; l++)
//            {
//                for (int c = 0; c < arquivo.Length; c++)
//                {
//                    for (int i = 0; i < arquivo.Length; i++)
//                    {
//                        arrayLabirinto[l, c] = arquivo[i].ToString();
//                    }
//                }
//            }

//            for (int i = 0; i < arrayLabirinto.Length; i++)
//            {
//                for (int j = 0; j < arrayLabirinto.Length; j++)
//                {
//                    Console.Write(arrayLabirinto[i, j]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

using System;
using System.IO;
namespace Labirinto
{
    class Program
    {
        public static void Main()
        {
            string path = @"C:\arquivoteste1.txt";

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);

            int linha = 5;
            int coluna = 8;

            int i = 0;
            int j = 0;

            char[,] chars = new char[linha, coluna];

            foreach (string s in readText)
            {
                j = 0;
                foreach (char caracter in s.ToCharArray())
                {
                    if (!string.IsNullOrEmpty(caracter.ToString()) && caracter.ToString().Trim() != "")
                    {
                        if (caracter.ToString().Trim() == "E" || caracter.ToString().Trim() == "S")
                        {
                            chars[i, j] = '*';
                        }
                        else
                        {
                            chars[i, j] = caracter;
                        }
                    }
                    else
                    {
                        chars[i, j] = '*';
                    }
                    j++;
                }
                i++;
            }

            for (int k = 0; k < linha; k++)
            {
                for (int l = 0; l < coluna; l++)
                {
                    Console.Write(chars[k, l]);
                }
                Console.WriteLine();
            }
        }
    }
}