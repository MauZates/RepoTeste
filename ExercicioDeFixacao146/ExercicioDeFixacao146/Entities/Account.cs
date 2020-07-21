using System;
using System.Collections.Generic;
using System.Text;
using ExercicioDeFixacao146.Entities.Exceptions;

namespace ExercicioDeFixacao146.Entities
{
    public class Account
    {
        /// <summary>
        /// Numero da Conta
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Nome
        /// </summary>
        public string Holder { get; set; }
        /// <summary>
        /// Balance
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// limite de saque
        /// </summary>
        public double WithdawLimit { get; set; }

        /// <summary>
        /// construtor padrao
        /// </summary>
        public Account()
        {

        }

        /// <summary>
        /// construtor com todos os parametos
        /// </summary>
        /// <param name="number"></param>
        /// <param name="holder"></param>
        /// <param name="balance"></param>
        /// <param name="withdawLimit"></param>
        public Account(int number, string holder, double balance, double withdawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdawLimit = withdawLimit;
        }
        
        /// <summary>
        /// realiza um deposito
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// Realiza um Saque
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(double amount)
        {
            if (amount > WithdawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
