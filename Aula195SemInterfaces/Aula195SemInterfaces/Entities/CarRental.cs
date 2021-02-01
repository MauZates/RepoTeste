using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula195SemInterfaces.Entities
{
    class CarRental
    {
        public DateTime Start
        {
            get => _start;
            set => _start = value;
        }
        private DateTime _start { get; set; }

        public DateTime Finish
        {
            get => _finish;
            set => _finish = value;
        }
        private DateTime _finish { get; set; }

        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            _start = start;
            _finish = finish;
            Vehicle = vehicle;
        }
    }
}
