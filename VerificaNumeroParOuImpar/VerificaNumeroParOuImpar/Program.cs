using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificaNumeroParOuImpar.Class;

namespace VerificaNumeroParOuImpar
{
    /// <summary>
    /// Classe program principal
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número");
            int.TryParse(Console.ReadLine().ToString(), out int numAux);
            Number numb = new Number(numAux,true);
            Console.WriteLine(numb);       
        }
    }
}
