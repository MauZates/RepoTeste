using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula199ExercicioInterface.Entities
{
    public class Installment
    {
        private DateTime _dueDate { get; set; }
        public DateTime DueDate
        {
            get => _dueDate;
            set => _dueDate = value; 
        }
        
        private double _amount { get; set; }
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public Installment()
        {

        }

        public Installment(DateTime dueDate, double amount)
        {
            _dueDate = dueDate;
            _amount = amount;
        }

        public override string ToString()
        {
            return _dueDate.ToString("dd/MM/yyyy")
                + " - "
                + _amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
