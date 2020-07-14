using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEx01Resolvido.Entities
{
    /// <summary>
    /// Department Class
    /// </summary>
    class Department
    {
        /// <summary>
        /// Deparment Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Standard constructor
        /// </summary>
        public Department()
        {

        }

        /// <summary>
        /// Constructor with 1 argument
        /// </summary>
        /// <param name="name"> Department name</param>
        public Department(string name)
        {
            Name = name;
        }
    }
}
