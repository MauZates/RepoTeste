using _204Generics.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PrimeiraVezEstudada            
            //PrintService printService = new PrintService();

            //Console.Write("How Many Values? ");

            //if (int.TryParse(Console.ReadLine(), out int n))
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (int.TryParse(Console.ReadLine(), out int x))
            //        {
            //            printService.AddValue(x);
            //        }
            //    }
            //}

            //printService.Print();
            //Console.WriteLine("First: " + printService.First());
            #endregion

            #region SegundaVezEstudada
            PrintService<int> printService = new PrintService<int>();
            //PrintService<string> printService = new PrintService<string>();

            Console.Write("How Many Values? ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int x))
                    {
                        printService.AddValue(x);
                    }
                }
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            #endregion


            #region RegiaoEstudosEstranhos
            //var culturaBrasileira = CultureInfo.CreateSpecificCulture("pt-BR");
            //string x = "R$1000,50";
            //decimal val = decimal.Parse(x, NumberStyles.Currency, culturaBrasileira);
            //Console.WriteLine(val);
            #endregion

        }
    }
}
