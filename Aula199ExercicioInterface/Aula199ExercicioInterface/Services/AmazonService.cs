using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula199ExercicioInterface.Services
{
    class AmazonService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.10;
        private const double MonthlyInterest = 0.05;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
