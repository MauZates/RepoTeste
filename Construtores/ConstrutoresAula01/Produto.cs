﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConstrutoresAula01
{
	internal class Produto
	{
		private string _nome;
		private double _preco;
		private int _quantidade;


		public Produto() { }

		public Produto(string nome, double preco, int quantidade)
		{
			_nome = nome;
			_preco = preco;
			_quantidade = quantidade;
		}

		public string Nome
		{
			get { return _nome; }
			set {
				if (value != null && value.Length > 1)
				{
					_nome = value;
				}
			}
		}

		public double ValorTotalEmEstoque()
		{
			return _preco * _quantidade;
		}

		public void AdicionarProdutos(int quantidade)
		{
			_quantidade += quantidade;
		}

		public void RemoverProdutos(int quantidade)
		{
			_quantidade -= quantidade;
		}

		public override string ToString()
		{
			return _nome
			+ ", $ "
			+ _preco.ToString("F2", CultureInfo.InvariantCulture)
			+ ", "
			+ _quantidade
			+ " unidades, Total: $ "
			+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
