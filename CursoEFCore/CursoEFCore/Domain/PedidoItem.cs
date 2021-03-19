using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCore.Domain
{
    public class PedidoItem
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }

        public int IdProduto { get; set; }

        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }

        public decimal Desconto { get; set; }

    }
}
