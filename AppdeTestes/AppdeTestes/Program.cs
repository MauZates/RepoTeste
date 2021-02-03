using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inicial = "07:05";
            string final = "07:05";

            int iniTime = int.Parse(inicial.Replace(":", ""));
            int fimTime = int.Parse(final.Replace(":", ""));

            //if (iniTime.ToString().Length == 3)
            //{
            //    Console.WriteLine(iniTime.ToString("D4"));
            //}
            Console.WriteLine(iniTime);
            Console.WriteLine(fimTime);
        }
    }
}
