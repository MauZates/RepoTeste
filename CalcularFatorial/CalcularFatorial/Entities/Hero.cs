using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularFatorial.Entities
{
    /// <summary>
    /// Class hero
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// Name of Hero
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Date of birthday
        /// </summary>
        public DateTime DataDenascimento { get; set; }
        /// <summary>
        /// Kryptonita level
        /// </summary>
        public int Kryptonita { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Hero()
        {

        }

        /// <summary>
        /// Constructor with 3 param
        /// </summary>
        /// <param name="nome"> Name </param>
        /// <param name="dataDenascimento"> Date of Birthday </param>
        /// <param name="kryptonita"> Level </param>
        public Hero(string nome, DateTime dataDenascimento, int kryptonita)
        {
            Nome = nome;
            DataDenascimento = dataDenascimento;
            Kryptonita = kryptonita;
        }

        /// <summary>
        /// Fly Hero according kryptonita level
        /// </summary>
        /// <returns> String </returns>
        public string Fly()
        {
            if (Kryptonita < 2)
            {
                return "Voando...";
            }
            return null;
        }
    }
}
