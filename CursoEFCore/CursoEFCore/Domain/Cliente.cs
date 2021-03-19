using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCore.Domain
{
    public class Cliente
    {
        private int _id { get; set; }
        public int Id { get => _id; set => _id = value; }

        private string _nome { get; set; }
        public string Nome { get => _nome; set => _nome = value; }

        private string _telefone { get; set; }
        public string Telefone { get => _telefone; set => _telefone = value; }

        private string _cep { get; set; }
        public string CEP { get => _cep; set => _cep = value; }

        private string _estado { get; set; }
        public string Estado { get => _estado; set => _estado = value; }

        private string _cidade { get; set; }
        public string Cidade { get => _cidade; set => _cidade = value; }

    }
}
