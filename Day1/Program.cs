using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> calories = new List<int>();
            int counter = 0;
            int sum = 0;
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay1.txt"))
            {
                int currentNumber = 0;
                if(line != ""){
                    currentNumber = int.Parse(line);
                }
                else{
                     currentNumber = 0;
                }
                sum += currentNumber;
                if(line == ""){
                    calories.Add(sum);
                    Console.WriteLine(calories[counter]);
                    counter++;
                    sum=0;
                }
            }
            int maxCalorie = 0;
            for(int i = 0; i< calories.Count; i ++){
                int currentNumber = calories[i];
                if(currentNumber > maxCalorie){
                    maxCalorie = currentNumber;
                }
            }
            Console.WriteLine("MAX CALORIE:");
            Console.WriteLine(maxCalorie);
        }
    }
}
