using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<char> Letters = new List<char>();
            Letters.Add(' ');
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay6.txt"))
            {
                for(int i = 0; i < line.Length ; i++)
                {
                    string fourLetters = "";
                    Console.Write($"{i+1} :    ");
                    if(Letters.Count>=14)
                    {
                        Letters.RemoveAt(0);
                    }

                    Letters.Add(line[i]);
                    for(int j = 0; j<Letters.Count;j++){
                        fourLetters += Letters[j];
                    }
                    
                    int counter = 0;

                    Console.WriteLine(fourLetters);
                    foreach (var item in fourLetters)
                    {
                        if (fourLetters.IndexOf(item) != fourLetters.LastIndexOf(item))
                        {
                        }
                        else{
                            counter++;
                        }
                    }
                    if(counter == 14){
                        Console.WriteLine($" {i+1} :   WEVE GOT ONE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    }
                    if(i +1 == 500 || i+1 == 1000 || i+1 == 2000 || i+1 ==3000) Console.ReadLine();
                    
                }
                
            }
            
        }
    }
}
