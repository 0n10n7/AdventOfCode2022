using System;
using System.Collections.Generic;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<char> column1 = new List<char>();
            List<char> column2 = new List<char>();
            List<char> column3 = new List<char>();
            List<char> column4 = new List<char>();
            List<char> column5 = new List<char>();
            List<char> column6 = new List<char>();
            List<char> column7 = new List<char>();
            List<char> column8 = new List<char>();
            List<char> column9 = new List<char>();
            List<List<char>> listOfList = new List<List<char>>();
            listOfList.Add(column1);
            listOfList.Add(column2);
            listOfList.Add(column3);
            listOfList.Add(column4);
            listOfList.Add(column5);
            listOfList.Add(column6);
            listOfList.Add(column7);
            listOfList.Add(column8);
            listOfList.Add(column9);
            int counter = 0;
            int round = 0;
            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay5.txt"))
            {
                round ++;
                string onlyNumber = "";
                if(counter <9)
                {
                    if(line[1] != ' '&& line[1]!= '[' && line[1]!=']')
                    {
                        column1.Add(line[1]);
                        Console.Write(line[1]);
                    }
                    if(line[5] != ' '&& line[5]!= '[' && line[5]!=']')
                    {
                        column2.Add(line[5]);
                        Console.Write(line[5]);
                    }
                    if(line[9] != ' '&& line[9]!= '[' && line[9]!=']')
                    {
                        column3.Add(line[9]);
                        Console.Write(line[9]);
                    }
                    if(line[13] != ' '&& line[13]!= '[' && line[13]!=']')
                    {
                        column4.Add(line[13]);
                        Console.Write(line[13]);
                    }
                    if(line[17] != ' '&& line[17]!= '[' && line[17]!=']')
                    {
                        column5.Add(line[17]);
                        Console.Write(line[17]);
                    }
                    if(line[21] != ' '&& line[21]!= '[' && line[21]!=']')
                    {
                        column6.Add(line[21]);
                        Console.Write(line[21]);
                    }
                    if(line[25] != ' '&& line[25]!= '[' && line[25]!=']')
                    {
                        column7.Add(line[25]);
                        Console.Write(line[25]);
                    }
                    if(line[29] != ' '&& line[29]!= '[' && line[29]!=']')
                    {
                        column8.Add(line[29]);
                        Console.Write(line[29]);
                    }
                    if(line[33] != ' '&& line[33]!= '[' && line[33]!=']')
                    {
                        column9.Add(line[33]);
                        Console.Write(line[33]);
                    }
                    Console.WriteLine("");
                    counter ++;
                }
                else if(counter == 9)
                {
                    Console.WriteLine("Beep");
                    counter ++;
                }
                else
                {
                    Console.Write($"{round} : ");
                    // REMOVE MOVE
                    onlyNumber = line.Remove(0,5);
                    // REMOVE TO
                    onlyNumber = onlyNumber.Remove(onlyNumber.Length-5,4);
                    // REMOVE FROM
                    onlyNumber = onlyNumber.Remove(onlyNumber.Length-8,6);
                    Console.WriteLine(onlyNumber);
                    int move =int.Parse(onlyNumber.Remove(onlyNumber.Length-2,2)) ;
                    Console.WriteLine(move);
                    int from = int.Parse(onlyNumber[onlyNumber.Length-2].ToString());
                    Console.WriteLine(from);
                    int to = int.Parse(onlyNumber[onlyNumber.Length-1].ToString());
                    Console.WriteLine(to);
                    
                    List<char> Blurp = new List<char>();
                    for(int i = 0; i<move; i++)
                    {
                        char moved = listOfList[from-1][0];
                        listOfList[from-1].RemoveAt(0);
                        Blurp.Add(moved);

                    }
                    listOfList[to-1].InsertRange(0, Blurp);

                    Console.Write(column1[0].ToString());
                    Console.Write(column2[0].ToString());
                    Console.Write(column3[0].ToString());
                    Console.Write(column4[0].ToString());
                    Console.Write(column5[0].ToString());
                    Console.Write(column6[0].ToString());
                    Console.Write(column7[0].ToString());
                    Console.Write(column8[0].ToString());
                    Console.WriteLine(column9[0].ToString());
                }
            }
        }
    }
}
