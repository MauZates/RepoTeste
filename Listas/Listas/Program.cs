using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Andre");

            foreach (string nomes in list)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("List Count : " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First name with 'A' :" + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last name with 'A' :" + s2);


        }
    }
}
