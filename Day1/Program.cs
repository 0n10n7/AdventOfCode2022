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
                    Console.WriteLine("Sum is:");
                    Console.WriteLine(calories[counter]);
                    counter++;
                    sum=0;
                }
                // Console.WriteLine($"The current number is {currentNumber}");
                // Console.WriteLine($"The current sum is {sum}");
                // Console.WriteLine(line);
            }
            int maxCalorie = 0;
            int secondMaxCalorie = 0;
            int thirdMaxCalorie = 0;
            for(int i = 0; i< calories.Count; i ++){
                int currentNumber = calories[i];
                if(currentNumber > maxCalorie){
                    thirdMaxCalorie = secondMaxCalorie;
                    secondMaxCalorie = maxCalorie;
                    maxCalorie = currentNumber;
                }
                else if(currentNumber > secondMaxCalorie){
                    thirdMaxCalorie = secondMaxCalorie;
                    secondMaxCalorie = currentNumber;
                }
                else if(currentNumber > thirdMaxCalorie){
                    thirdMaxCalorie = currentNumber;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(calories.Count);
            Console.WriteLine("MAX CALORIE:");
            Console.WriteLine(maxCalorie);
            Console.WriteLine("SECOND MAX CALORIE:");
            Console.WriteLine(secondMaxCalorie);
            Console.WriteLine("THIRD MAX CALORIE:");
            Console.WriteLine(thirdMaxCalorie);
            Console.WriteLine("SUM CALORIE:");
            Console.WriteLine(maxCalorie + secondMaxCalorie + thirdMaxCalorie);
        }
    }
}
