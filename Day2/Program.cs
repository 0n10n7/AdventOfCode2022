using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rounds = 0;
            int points = 0;
            char rock = 'A';
            char paper = 'B';
            char scissors = 'C';
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay2.txt"))
            {  
                if(line.Contains('X')){//LOSE
                    if(line.Contains(rock)){
                        points +=3;
                    }
                    if(line.Contains(paper)){
                        points +=1;
                    }
                    if(line.Contains(scissors)){
                        points += 2;
                    }
                }
                else if(line.Contains('Y')){//DRAW
                points += 3;
                    if(line.Contains(rock)){
                        points +=1;
                    }
                    if(line.Contains(paper)){
                        points +=2;
                    }
                    if(line.Contains(scissors)){
                        points +=3;
                    }
                }
                else if(line.Contains('Z')){//WIN
                points += 6;
                    if(line.Contains(rock)){
                        points +=2;
                    }
                    if(line.Contains(paper)){
                        points +=3;
                    }
                    if(line.Contains(scissors)){
                        points +=1;
                    }
                }
                rounds++;
                Console.WriteLine(line); 
                Console.WriteLine($"Round: {rounds}");
                Console.WriteLine($"Points: {points}");
            }
            Console.WriteLine($"The total number of points is {points}");
        }
    }
}