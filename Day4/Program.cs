using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay4.txt"))
            {
                string firstHalf = "";
                string lastHalf = "";
                string firstHalf2 = "";
                string lastHalf2 = "";
                int counter = 0;
                int counter2 = 0;
                int pair = 0;
                
                for(int i = 0; i<line.Length; i++)
                {
                    string currentLetter = line[i].ToString();
                    if(currentLetter != "," && pair == 0){

                        if(currentLetter != "-" && counter == 0)
                        {
                            firstHalf += currentLetter;
                            // Console.Write("BEEP ");
                        }
                        else if(currentLetter == "-")
                        {
                            counter ++;
                            // Console.WriteLine("BaaP ");
                        }
                        else
                        {
                            lastHalf += currentLetter;
                            // Console.Write("BOOP ");
                        }
                    }
                    else if(currentLetter == ",")
                    {
                        pair ++;
                        // Console.WriteLine("Swap");
                    }
                    else
                    {
                        if(currentLetter != "-" && counter2 == 0)
                        {
                            firstHalf2 += currentLetter;
                            // Console.Write("BEEP ");
                        }
                        else if(currentLetter == "-")
                        {
                            counter2 ++;
                            // Console.WriteLine("BaaP ");
                        }
                        else
                        {
                            lastHalf2 += currentLetter;
                            // Console.Write("BOOP ");
                        }
                    }
                }
                Console.WriteLine(line);
                // Console.Write(firstHalf);
                // Console.Write($" and {lastHalf}");
                // Console.WriteLine();
                // Console.Write(firstHalf2);
                // Console.Write($" and {lastHalf2}");

                int upperLimit = Math.Max(int.Parse(lastHalf),int.Parse(lastHalf2));
                Console.WriteLine($"upper limit is set at {upperLimit}");
                int lowerLimit = Math.Min(int.Parse(firstHalf),int.Parse(firstHalf2));
                Console.WriteLine($"lower limit is set at {lowerLimit}");

                //checks if upper and lower limt belongs to first pair
                if(upperLimit == int.Parse(lastHalf) && lowerLimit == int.Parse(firstHalf))
                {
                    Console.WriteLine($" {firstHalf} and {lastHalf} is larger than {firstHalf2} and {lastHalf2}");
                    answer ++;
                }
                //checks if upper and lower limit belongs to the second pair
                else if(upperLimit == int.Parse(lastHalf2) && lowerLimit == int.Parse(firstHalf2))
                {
                    Console.WriteLine($" {firstHalf2} and {lastHalf2} is larger than {firstHalf} and {lastHalf}");
                    answer ++;
                }
                else if((int.Parse(firstHalf) <= int.Parse(lastHalf2)) && ( int.Parse(lastHalf)>= int.Parse(firstHalf2))){
                    answer ++;
                }

            }
            Console.WriteLine(answer);
            
        }
    }
}
