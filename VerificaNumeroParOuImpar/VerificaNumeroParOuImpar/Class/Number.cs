using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaNumeroParOuImpar.Class
{
    public class Number
    {
        /// <summary>
        /// Número Público
        /// </summary>
        public int Num
        {
            get { return _num; }   // get method
            set { _num = value; }
        }

        /// <summary>
        /// Numero privado
        /// </summary>
        private int _num { get; set; }
        
        /// <summary>
        /// Booleano de par ou impar, sendo true Par e false IMPAR, público
        /// </summary>
        public bool ParOuImpar
        {
            get { return _parOuImpar; }
            set { _parOuImpar = value; }
        }

        /// <summary>
        /// Propriedade privada
        /// True = Par
        /// Flae = Impar
        /// </summary>
        private bool _parOuImpar { get; set; }

        /// <summary>
        /// construtor padrão sem argumentos
        /// </summary>
        public Number()
        {
            
        }

        /// <summary>
        /// construtor que recebe o número, e chama o método VerificarParOuImpar()
        /// </summary>
        /// <param name="_number">Número informado em tela</param>
        /// <param name="_parOuImpar"></param>
        public Number(int _number,bool _parOuImpar)
        {
            _num = _number;
            VerificarParOuImpar();
        }

        /// <summary>
        /// Vétodo que verifica se o número informado é impar
        /// </summary>
        private void VerificarParOuImpar()
        {
            if (_num % 2 == 0)
            {
                _parOuImpar = true;
            }
            else
            {
                _parOuImpar = false;
            }
        }

        /// <summary>
        /// Método to string do par ou impar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "O número " + _num + " é " + (_parOuImpar == true ? "Par" : "Ímpar");
        }
    }
}
