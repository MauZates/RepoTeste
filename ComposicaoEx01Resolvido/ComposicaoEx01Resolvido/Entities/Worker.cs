using System;
using System.Collections.Generic;
using System.Text;
using ComposicaoEx01Resolvido.Entities.Enums;

namespace ComposicaoEx01Resolvido.Entities
{
    /// <summary>
    /// Class Worker
    /// </summary>
    class Worker
    {
        /// <summary>
        /// Name Worker
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Worker Level
        /// </summary>
        public WorkerLevel Level { get; set; }
        /// <summary>
        /// Base Salary
        /// </summary>
        public double BaseSalary { get; set; }
        /// <summary>
        /// Department of Worker
        /// </summary>
        public Department Department { get; set; }
        /// <summary>
        /// List of Contracts
        /// </summary>
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        /// <summary>
        /// Standard constructor
        /// </summary>
        public Worker()
        {

        }
        /// <summary>
        /// Constructor with more arguments
        /// </summary>
        /// <param name="name"> Name of Worker </param>
        /// <param name="level"> Level of Worker</param>
        /// <param name="baseSalary"> Base Salary of Worker</param>
        /// <param name="department"> Department of Worker</param>
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        /// <summary>
        /// Add Contracts to Worker
        /// </summary>
        /// <param name="contract">Contracts of class HourContracts</param>
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        /// <summary>
        /// Remove Contracts of Worker
        /// </summary>
        /// <param name="contract">Contracts of class HourContracts</param>
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        /// <summary>
        /// Income of Worker
        /// </summary>
        /// <param name="year"> Year of Contract</param>
        /// <param name="month">Month of Contract</param>
        /// <returns>returns the sum of the contract where the year and month are equal to the parameters</returns>
        public double Income(int year,int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
