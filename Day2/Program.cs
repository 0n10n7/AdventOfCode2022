using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rounds = 0;
            int points = 0;
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay2.txt"))
            {  
                if(line.Contains('X')){//ROCK
                    points++;
                    if(line.Contains('A')){
                        points +=3;
                    }
                    if(line.Contains('B')){
                        //no points change
                    }
                    if(line.Contains('C')){
                        points +=6;
                    }
                }
                else if(line.Contains('Y')){//PAPER
                    points += 2;
                    if(line.Contains('A')){
                        points +=6;
                    }
                    if(line.Contains('B')){
                        points +=3;
                    }
                    if(line.Contains('C')){
                        //no points change
                    }
                }
                else if(line.Contains('Z')){//SCISSORS
                    points += 3;
                    if(line.Contains('A')){
                        //no points change
                    }
                    if(line.Contains('B')){
                        points +=6;
                    }
                    if(line.Contains('C')){
                        points +=3;
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