using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula195SemInterfaces.Entities
{
    class Invoice
    {
        public double BasicPayment
        {
            get => _basicPayment;
            set => _basicPayment = value;
        }
        private double _basicPayment { get; set; }

        public double Tax
        {
            get => _tax;
            set => _tax = value;
        }
        private double _tax { get; set; }

        public double TotalPayment
        {
            get { return _totalPayment; }
            private set { }
        }

        private double _totalPayment
        {
            get { return _basicPayment + _tax; }
            set { }
        }

        /// <summary>
        /// Construtor da classe com todos os atributos
        /// </summary>
        /// <param name="basicPayment"></param>
        /// <param name="tax"></param>
        public Invoice(double basicPayment, double tax)
        {
            _basicPayment = basicPayment;
            _tax = tax;
        }

        public override string ToString()
        {
            return "Basic payment: "
                + _basicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + _tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + _totalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
