﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimicAPI.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}
