
using System;
using System.Collections.Generic;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentDir = 0;
            List<string> dirListNames = new List<string>();
            List<int> dir = new List<int>();
            List<List<string>> childList = new List<List<string>>();
            List<string> child = new List<string>();
            List<string> parent = new List<string>();
            List<int> numTotal = new List<int>();
            dirListNames.Add("Larger than /");
            int sum = 0;
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay7.txt"))
            {
                if(line.Contains("cd ") && !line.Contains(".."))
                {
                    List<string> tempchild = new List<string>(child);
                    if(child.Count!=0)parent.Add(line.Remove(0,5));
                    dir.Add(sum);
                    sum = 0;
                    dirListNames.Add(line.Remove(0,5));
                    childList.Add(tempchild);
                    // for(int i = 1; i < tempchild.Count; i++){Console.WriteLine("this is a child in a list : {0}", tempchild[i]);}
                    child.Clear();
                    // Console.WriteLine("CLEAR");
                    // for(int i = 1; i < childList[childList.Count-1].Count; i++){Console.WriteLine("this is a child in a list : {0}", childList[childList.Count-1][i]);}
                    Console.WriteLine(line.Remove(0,5));
                    currentDir++;
                }
                if(line.Contains("dir"))
                {
                    child.Add(line.Remove(0,4));
                    Console.WriteLine("This right here is a child: {0}", line.Remove(0,4));
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
                    }
                    sum += int.Parse(fileSize);
                }
            }
            for(int j = 0; j < childList.Count; j++)
            {
                for(int i = 0; i < childList[j].Count; i++)
                {
                    
                }
            }
            for(int j = 0; j < dir.Count; j++){
                int childsum = 0;
                // Console.WriteLine(childList[j].Count);
                for(int k = 0; k < childList[j].Count-1; k++)
                {
                    if(parent.Contains(childList[j][k])){
                        
                    }
                    // Console.WriteLine("Yup the loop did");
                    childsum += dir[dirListNames.IndexOf(childList[j][k])];
                    Console.WriteLine(childsum);
                }
                string name = dirListNames[j];
                int num = dir[j] + childsum;
                Console.WriteLine($" dir {name} has files {num}");
                if(num<100000){numTotal.Add(num);}
            }
            int answer = 0;
            for(int j = 0; j < numTotal.Count; j++){
                answer += numTotal[j];
            }
            Console.WriteLine(answer);
        }
    }
}
