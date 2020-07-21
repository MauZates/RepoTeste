using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao146.Entities.Exceptions
{
    /// <summary>
    /// Domain Exeption Account
    /// </summary>
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
