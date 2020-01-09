using System;
using System.Globalization;

namespace ExercicioEncapsulamento
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region FormaMau

			//Console.Write("Entre com o número da Conta: ");
			//int conta = int.Parse(Console.ReadLine());
			//Console.Write("Entre com o titular da Conta: ");
			//string nome = Console.ReadLine();
			//Console.Write("Haverá deposito inicial (s/n)? ");
			//char depoisitoInicial = char.Parse(Console.ReadLine());

			//double valorInicial = 0.0;

			//if (depoisitoInicial.ToString() == "s")
			//{
			//	Console.Write("Ente com o valor inicial: ");
			//	valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			//}

			//Console.WriteLine();
			//ContaBancaria contaBancaria = new ContaBancaria(conta, nome, valorInicial);
			//Console.WriteLine(contaBancaria);
			//Console.WriteLine();

			//Console.Write("Entre um valor para depósito: ");
			//double depositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			//Console.WriteLine();

			//ContaBancaria.SomarValor(depositado);
			//Console.WriteLine(contaBancaria);

			//Console.WriteLine();
			//Console.Write("Entre um valor para saque: ");
			//double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			//ContaBancaria.Saque(saque);
			//Console.WriteLine();
			//Console.WriteLine(contaBancaria);

			#endregion

			ContaBancaria conta;

			Console.Write("Entre com o número da conta: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Entre o titular da conta: ");
			string titular = Console.ReadLine();
			Console.Write("Haverá depósito inicial (s/n)? ");
			char resp = char.Parse(Console.ReadLine());

			if (resp == 's' || resp == 'S')
			{
				Console.Write("Ente com o valor inicial: ");
				double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta = new ContaBancaria(numero,titular, depositoInicial);
			} else
			{
				conta = new ContaBancaria(numero, titular);
			}

			Console.WriteLine();
			Console.WriteLine("Dados da conta:");
			Console.WriteLine(conta);

			Console.WriteLine();
			Console.Write("Entre um valor para depósito: ");
			double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta.Deposito(quantia);

			Console.WriteLine();
			Console.WriteLine("Dados da conta atualizados:");
			Console.WriteLine(conta);

			Console.WriteLine();
			Console.Write("Entre um valor para saque: ");
			quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta.Saque(quantia);

			Console.WriteLine();
			Console.WriteLine("Dados da conta atualizados:");
			Console.WriteLine(conta);
		}
	}
}
