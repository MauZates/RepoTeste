using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
