using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioEncapsulamento
{
	internal class ContaBancaria
	{
		#region FormaMau

		//public static int Conta { get; private set; }
		//public static string Nome { get; set; }
		//public static double ValorInicial { get; set; }
		//public static string ControleFrases { get; set; }

		//public ContaBancaria(int conta, string nome, double valorInicial)
		//{
		//	Conta = conta;
		//	Nome = nome;
		//	ValorInicial = valorInicial;
		//}

		//public override string ToString()
		//{
		//	if (ControleFrases == "s")
		//	{
		//		return "Dados da conta atualizados: \n" +
		//						"Conta " + Conta +
		//						", Titular: " + Nome +
		//						", Saldo: $ " + ValorInicial.ToString("F2", CultureInfo.InvariantCulture);
		//	}

		//	return "Dados da conta: \n" +
		//		"Conta " + Conta +
		//		", Titular: " + Nome +
		//		", Saldo: $ " + ValorInicial.ToString("F2", CultureInfo.InvariantCulture);
		//}

		//public static double SomarValor(double depositado)
		//{
		//	ControleFrases = "s";
		//	return ValorInicial += depositado;
		//}

		//public static double Saque(double saque)
		//{
		//	ControleFrases = "s";
		//	return ValorInicial = ValorInicial - saque - 5;
		//}

		#endregion

		public int Numero { get; private set; }
		public string Titular { get; set; }
		public double Saldo { get; private set; }

		public ContaBancaria(int numero, string titular)
		{
			Numero = numero;
			Titular = titular;
		}

		public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) => Deposito(depositoInicial);

		public void Deposito(double quantia) => Saldo += quantia;

		public void Saque(double quantia) => Saldo -= quantia + 5;

		public override string ToString() => "Conta "
				+ Numero
				+ ", Titular: "
				+ Titular
				+ ", Saldo: $"
				+ Saldo.ToString("F2", CultureInfo.InvariantCulture);

	}
}
