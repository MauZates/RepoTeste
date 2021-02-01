using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula195SemInterfaces.Entities;

namespace Aula195SemInterfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get => _pricePerHour; set => _pricePerHour = value; }
        private double _pricePerHour { get; set; }

        public double PricePerDay { get => _pricePerDay; set => _pricePerDay = value; }
        private double _pricePerDay { get; set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            _pricePerHour = pricePerHour;
            _pricePerDay = pricePerDay;
        }
        
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = _pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = _pricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
