using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoListas
{
    /// <summary>
    /// Classe Program, onde é execultado o scopo do projeto
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método statico onde se inicia o program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Funcionarios> funcionarios = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine("-----------------------------------");
            }

            bool exist = false;
            while (!exist)
            {
                Console.Write("Digite o Id do funcionario que deseja incrementar o salario: ");
                string idFunc = Console.ReadLine();
                bool id = int.TryParse(idFunc, out int IdValido);
                if (id)
                {
                    Funcionarios func = funcionarios.Find(x => x.Id == IdValido);

                    if (func != null)
                    {
                        Console.Write("Digite a porcentagem que deseja aumentar: ");
                        double _porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        func.IncrementarSalario(_porcentagem);
                        exist = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Esse id não existe tente novamente");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Digite números!");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Atualizando a lista de funcionarios: ");
            foreach (Funcionarios obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
