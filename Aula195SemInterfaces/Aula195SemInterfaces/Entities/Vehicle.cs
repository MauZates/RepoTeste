using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula195SemInterfaces.Entities
{
    class Vehicle
    {
        /// <summary>
        /// Possível utilizar o get e o set das duas formas possível que está sendo mostrado
        /// </summary>
        public string Model
        {
            //get
            //{
            //    return _model;
            //}
            //set
            //{
            //    _model = value;
            //}

            /// OU
            get => _model;
            set => _model = value;
        }

        private string _model { get; set; }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="model"></param>
        public Vehicle(string model)
        {
            _model = model;
        }
    }
}
