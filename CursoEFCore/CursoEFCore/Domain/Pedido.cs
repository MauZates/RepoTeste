using CursoEFCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCore.Domain
{
    public class Pedido
    {
        private int _idPedido { get; set; }
        public int IdPedido { get => _idPedido; set => _idPedido = value; }

        private int _clienteId { get; set; }
        public int ClienteId { get => _clienteId; set => _clienteId = value; }

        private Cliente _cliente { get; set; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }

        private DateTime _iniciadoEm { get; set; }
        public DateTime IniciadoEm { get => _iniciadoEm; set => _iniciadoEm = value; }

        private DateTime _finalizadoEm { get; set; }
        public DateTime FinalizadoEm { get => _finalizadoEm; set => _finalizadoEm = value; }

        private TipoFrete _tipoFrete { get; set; }
        public TipoFrete TipoFrete { get => _tipoFrete; set => _tipoFrete = value; }

        private StatusPedido _statusPedido { get; set; }
        public StatusPedido StatusPedido { get => _statusPedido; set => _statusPedido = value; }

        private string _observacao { get; set; }
        public string Observacao { get => _observacao; set => _observacao = value; }

        public ICollection<PedidoItem> Itens { get; set; }

    }
}
