using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo file = new FileInfo(sourcePath);
                file.CopyTo(targetPath);
                string[] lines = System.IO.File.ReadAllLines(sourcePath);

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
