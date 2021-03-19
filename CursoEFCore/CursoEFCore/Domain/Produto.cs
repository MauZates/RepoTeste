using CursoEFCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCore.Domain
{
    public class Produto
    {
        private int _idProduto { get; set; }
        public int IdProduto { get => _idProduto; set => _idProduto = value; }

        private string _codigoDeBarras { get; set; }
        public string CodigoDeBarras { get => _codigoDeBarras; set => _codigoDeBarras = value; }

        private string _descricao { get; set; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        private decimal _valor { get; set; }
        public decimal Valor { get => _valor; set => _valor = value; }

        public TipoProduto TpProduto { get; set; }

        private bool _ativo { get; set; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
    }
}
