using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InterfaceIComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get => _name; set => _name = value; }
        private string _name { get; set; }

        public double Salary { get => _salary; set => _salary = value; }
        private double _salary { get; set; }

        public Employee()
        {

        }

        /// <summary>
        /// Construtor que recebe um arquivo csv
        /// </summary>
        /// <param name="csvEmployee">Cada linha do arquivo csv exemplo Mary Lary,1500.00</param>
        //public Employee(string csvEmployee)
        //{
        //    string[] employeeLine = csvEmployee.Split(',');
        //    _name = employeeLine[0];
        //    _salary = double.Parse(employeeLine[1],CultureInfo.InvariantCulture);
        //}

        //public int CompareTo(object obj)
        //{
        //    if (!(obj is Employee))
        //    {
        //        throw new ArgumentException("The object is not a Employee");
        //    }

        //    Employee temp = obj as Employee;

        //    return _name.CompareTo(temp._name);
        //}

        public override string ToString()
        {
            return _name + " = " + _salary.ToString("F2", CultureInfo.InvariantCulture);
        }        

        public List<Employee> CarregaTudoNumeLista(string[] allFile)
        {
            List<Employee> allEmployee = new List<Employee>();
            foreach (var lineFile in allFile)
            {
                allEmployee.Add(new Employee()
                {
                    _name = lineFile.Split(',')[0],
                    _salary = double.Parse(lineFile.Split(',')[1], CultureInfo.InvariantCulture)
                });
            }
            return allEmployee;
        }
    }
}
