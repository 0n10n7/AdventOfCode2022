using System;

namespace Day3 // Note: actual namespace depends on the project name.
{
            
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            int badgeSum = 0;
            int j= 0;
            char[] alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            List<string> pastLines = new List<string>();
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay3.txt"))
            {
                pastLines.Add(line);
                var first = line.Substring(0, (int)(line.Length / 2));
                var last = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));
                List<string> lettersInFirst = new List<string>();
                List<string> lettersInLast = new List<string>();
                foreach(char Letter in first){
                    lettersInFirst.Add(Letter.ToString());
                }
                foreach(char Letter in last){
                    lettersInLast.Add(Letter.ToString());
                }
                var firstSet = new HashSet<char>(first);
                var lastSet = new HashSet<char>(last);
                firstSet.IntersectWith(lastSet);

                System.Console.WriteLine($"{line} split in two halfs becomes: {first} and {last}");
                Console.WriteLine($"they share the letter {firstSet.First()}");
                for(int i = 0; i < alphabet.Length; i++)
                {
                    if(firstSet.First() == alphabet[i]){
                        Console.WriteLine($"added {i+1} due to letter being {alphabet[i].ToString()} \n");
                        sum += i+1;
                    }
                }

                j++;
                if(j >= 3)
                {
                    var line1 = new HashSet<char>(pastLines[0]);
                    var line2 = new HashSet<char>(pastLines[1]);
                    var line3 = new HashSet<char>(pastLines[2]);
                    line1.IntersectWith(line2);
                    line1.IntersectWith(line3);
                    Console.WriteLine($"Badge is {line1.First()}");
                    for(int k = 0; k < alphabet.Length; k++)
                    {
                    if(line1.First() == alphabet[k]){
                        Console.WriteLine($"added {k+1} due to letter being {alphabet[k].ToString()} \n");
                        badgeSum += k+1;
                 
                    }
                }
                    pastLines.Clear();
                    j=0;
                }
            }
            Console.WriteLine($"sum is {sum}"); 
            Console.WriteLine($"badge sum is {badgeSum}"); 
        }
    }
}