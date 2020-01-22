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
            Console.WriteLine("First name with 'A' : " + s1);

            Console.WriteLine("------------------------------------");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last name with 'A' : " + s2);
            Console.WriteLine("------------------------------------");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position with 'A' : " + pos1);
            Console.WriteLine("------------------------------------");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position with 'A' : " + pos2);
            Console.WriteLine("------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------");

            //list.Remove("Alex");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------");

            list.RemoveAll(x => x[0] == 'A');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------");

            

        }
    }
}
