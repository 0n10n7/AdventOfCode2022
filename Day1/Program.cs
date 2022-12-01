using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Program");
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay1.txt"))
            {  
                System.Console.WriteLine(line);
            }  
        }
    }
}
