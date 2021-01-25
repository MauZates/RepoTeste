using ProgramMaiorIdade.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMaiorIdade
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();

            for (int i = 0; i < 2; i++)
            {
                string auxNome = "";
                Console.Write("Digite o Nome: ");
                auxNome = Console.ReadLine();

                Console.Write("Digite a Idade: ");
                int.TryParse(Console.ReadLine(), out int auxIdade);

                peoples.Add(new People() { Nome = auxNome, Idade = auxIdade });
                Console.WriteLine();
            }

            peoples = peoples.QuantidadeMaiorIdade(new People());

            Console.WriteLine("Existem " + peoples.Count + (peoples.Count == 1 ? " pessoa maior de idade" : " pessoas maiores de idade"));

        }
    }
}
