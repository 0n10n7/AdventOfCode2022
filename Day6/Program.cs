using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string fourLetters = "";
            char firstLetter = ' ';
            char secondLetter = ' ';
            char thirdLetter = ' ';
            char fourthLetter = ' ';
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay6.txt"))
            {
                for(int i = 0; i < line.Length ; i++)
                {
                    Console.Write($"{i+1} :    ");
                    fourthLetter = thirdLetter;
                    Console.Write(fourthLetter);
                    thirdLetter = secondLetter;
                    Console.Write(thirdLetter);
                    secondLetter = firstLetter;
                    Console.Write(secondLetter);
                    firstLetter = line[i];
                    Console.Write($"{firstLetter} \t");
                    fourLetters =  fourthLetter.ToString() + thirdLetter.ToString() +  secondLetter.ToString() + firstLetter.ToString();
                    int counter = 0;
                    var duplicates = new List<char>();

                    Console.WriteLine(fourLetters);
                    foreach (var item in fourLetters)
                    {
                        if (fourLetters.IndexOf(item) != fourLetters.LastIndexOf(item) && !duplicates.Contains(item))
                        {
                            duplicates.Add(item);
                        }
                        else{
                            counter++;
                        }
                    }
                    if(counter == 4){
                        Console.WriteLine($" {i+1} :   WEVE GOT ONE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    }
                    if(i+1 == 1000 || i+1 == 2000 || i+1 ==3000) Console.ReadLine();
                    
                }
                
            }
            
        }
    }
}
