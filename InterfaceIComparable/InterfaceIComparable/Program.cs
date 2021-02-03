using InterfaceIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            //Forma Original

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        List<Employee> employees = new List<Employee>();
            //        while (!sr.EndOfStream)
            //        {
            //            employees.Add(new Employee(sr.ReadLine()));
            //        }

            //        employees.Sort();

            //        foreach (Employee employee in employees)
            //        {
            //            Console.WriteLine(employee);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occured");
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                string[] ArquivoInteiro = File.ReadAllLines(path);
                List<Employee> employees = new Employee().CarregaTudoNumeLista(ArquivoInteiro);
                employees.Sort();
                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
