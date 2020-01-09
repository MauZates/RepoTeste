using System;
using System.Globalization;

namespace ConstrutoresAula01
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Padrao
			//Console.WriteLine("Entre os dados do produto:");
			//Console.Write("Nome: ");
			//string Nome = Console.ReadLine();
			//Console.Write("Preço: ");
			//double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			//Console.Write("Quantidade no estoque: ");
			//int Quantidade = int.Parse(Console.ReadLine());

			//Produto produto = new Produto(Nome, Preco, Quantidade);

			//Console.WriteLine();
			//Console.WriteLine("Dados do produto: " + produto);

			//Console.WriteLine();
			//Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
			//int qte = int.Parse(Console.ReadLine());
			//produto.AdicionarProdutos(qte);

			//Console.WriteLine();
			//Console.WriteLine("Dados atualizados: " + produto);

			//Console.WriteLine();
			//Console.Write("Digite o número de produtos a ser removido do estoque: ");
			//qte = int.Parse(Console.ReadLine());
			//produto.RemoverProdutos(qte);

			//Console.WriteLine();
			//Console.WriteLine("Dados atualizados: " + produto);
			#endregion

			Produto p = new Produto("TV", 500.00, 10);

			p.SetNome("TV 4k");

			Console.WriteLine(p.GetNome());

		}
	}
}
