using System;

namespace Day3 // Note: actual namespace depends on the project name.
{
            
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay3.txt"))
            {
                
                char[] alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
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
                Console.WriteLine();
                firstSet.IntersectWith(lastSet);

                System.Console.WriteLine($"{line} split in two halfs becomes: {first} and {last}");
                Console.WriteLine($"they share the letter {firstSet.First()}");
                for(int i = 0; i < alphabet.Length; i++){
                    if(firstSet.First() == alphabet[i]){
                        Console.WriteLine($"added {i+1} due to letter being {alphabet[i].ToString()}");
                        sum += i+1;
                    }
                }
                
            }
            Console.WriteLine($"sum is {sum}"); 
        }
    }
}