using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula199ExercicioInterface.Entities
{
    public class Contract
    {
        private int _number { get; set; }
        public int Number { get => _number; set => _number = value; }

        private DateTime _date { get; set; }
        public DateTime Date { get => _date; set => _date = value; }

        private double _totalValue { get; set; }
        public double TotalValue { get => _totalValue; set => _totalValue = value; }

        public List<Installment> Installments { get; set; }

        /// <summary>
        /// Construtor Base
        /// </summary>
        public Contract()
        {

        }

        /// <summary>
        /// Construtor com 3 argumentos
        /// </summary>
        /// <param name="number"></param>
        /// <param name="date"></param>
        /// <param name="totalValue"></param>
        public Contract(int number, DateTime date, double totalValue)
        {
            _number = number;
            _date = date;
            _totalValue = totalValue;
            Installments = new List<Installment>(); // ou coloca aqui ou vc coloca lá na declaração da propriedade
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
