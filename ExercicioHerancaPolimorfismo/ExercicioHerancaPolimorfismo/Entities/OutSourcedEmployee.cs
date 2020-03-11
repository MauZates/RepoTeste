using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
