using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEx01Resolvido.Entities
{
    class HourContract
    {
        /// <summary>
        /// Date of Contract
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Value per Hour
        /// </summary>
        public double ValuePerHour { get; set; }
        /// <summary>
        /// Hours worked
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// Standard constructor
        /// </summary>
        public HourContract()
        {

        }
        /// <summary>
        /// Constructor with 3 arguments
        /// </summary>
        /// <param name="date">Contract date</param>
        /// <param name="valuePerHour">Value per hour</param>
        /// <param name="hours">Contract Hours</param>
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        /// <summary>
        /// multiply ValuePerHour with hours
        /// </summary>
        /// <returns> Return TotalValue</returns>
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
