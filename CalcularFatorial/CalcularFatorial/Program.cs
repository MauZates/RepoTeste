using System;
using CalcularFatorial.Entities;

namespace CalcularFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //ulong Numero;
            //ulong Fatorial;
            //ulong Contador;

            //Console.WriteLine("Digite o número para calcular o fatorial: ");
            //Numero = ulong.Parse(Console.ReadLine());

            //Fatorial = 1;
            //Contador = 1;

            //while (Contador <= Numero)
            //{
            //    Fatorial *= Contador;
            //    Contador += 1;
            //}

            //Console.WriteLine("O fatorial de " + Numero + " é " + Fatorial);

            Hero hero = new Hero();

            Console.WriteLine("Digite o Nome do Heroi: ");
            hero.Nome = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento ex: XX/XX/XXXX");
            hero.DataDenascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nível de Kryptonita");
            hero.Kryptonita = int.Parse(Console.ReadLine());
            
            Console.WriteLine(hero.Fly());

        }
    }
}
