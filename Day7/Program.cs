using System;
using System.Collections.Generic;

namespace Day7
{
    class Program
    {
        static int Main(string[] args)
        {
            int currentDir = 0;
            List<string> dirListNames = new List<string>();
            List<int> dir = new List<int>();
            dirListNames.Add("/ ");
            int sum = 0;
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay7.txt"))
            {
                if(line.Contains("cd ") && !line.Contains(".."))
                {
                    dir.Add(sum);
                    sum = 0;
                    dirListNames.Add(line.Remove(0,4));
                    Console.WriteLine(line.Remove(0,4));
                    currentDir++;
                }
                if(char.IsDigit(line[0]))
                {
                    string fileSize = "";
                    for(int i = 0; i < line.Length; i++)
                    {
                        if(char.IsDigit(line[i]))
                        {
                            fileSize += line[i].ToString();
                        }
                        Console.Write("");
                    }
                    sum += int.Parse(fileSize);
                }
                Console.Write("");
            }

            for(int j = 0; j < dir.Count-1; j++){
                string name = dirListNames[j];
                int num = dir[j];
                Console.WriteLine($" dir {name} has files {num}");
            }
        }
    }
}
