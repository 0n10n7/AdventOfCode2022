using System;
using System.Collections.Generic;

namespace Day8
{
    class Tree
    {
        public int height;
        public int x;
        public int y;

        public Tree(int Height, int X, int Y)
        {
            height = Height;
            x = X;
            y = Y;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int xPointer = 1;
            int yPointer = 1;
            
            List<Tree> trees= new List<Tree>();
            List<Tree> visibleTrees= new List<Tree>();

            foreach (string line in System.IO.File.ReadLines(@"AdventOfCodeInputDay8.txt"))
            {
                foreach (char Letter in line)
                {
                    trees.Add(new Tree(Letter, xPointer, yPointer));
                    xPointer++;
                }
                yPointer++;
                xPointer=1;
            }
            foreach (var item in trees)
            {
                bool xLarger = false;
                bool yLarger = false;
                bool diagonalLarger1 = false;
                bool diagonalLarger2 = false;
                bool diagonalLarger3 = false;
                bool diagonalLarger4 = false;
                List<Tree> largerTrees = new List<Tree>();
                foreach (var tree in trees)
                {
                    if(tree.height > item.height){
                        largerTrees.Add(tree);
                    }
                }
                foreach (var largerTree in largerTrees)
                {
                    xLarger = false;
                    yLarger = false;
                    diagonalLarger1 = false;
                    diagonalLarger2 = false;
                    diagonalLarger3 = false;
                    diagonalLarger4 = false;
                    if(item.x==largerTree.x){
                        Console.WriteLine("There is a larger tree in the same x cord {0}" , largerTree);
                        xLarger=true;
                    }
                    if(item.y==largerTree.y){
                        Console.WriteLine("There is a larger tree in the same y cord {0}" , largerTree);
                        yLarger=true;
                    }
                    for(int i = 0; i < largerTrees.Count; i++){
                        if(item.x+i==largerTree.x && item.y+i==largerTree.y){
                            Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                            diagonalLarger1=true;
                        }
                        if(item.x+i==largerTree.x && item.y-i==largerTree.y){
                            Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                            diagonalLarger2=true;
                        }
                        if(item.x-i==largerTree.x && item.y+i==largerTree.y){
                            Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                            diagonalLarger3=true;
                        }
                        if(item.x-i==largerTree.x && item.y-i==largerTree.y){
                            Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                            diagonalLarger4=true;
                        }
                    }

                }
                if(xLarger && yLarger && diagonalLarger1 && diagonalLarger2 && diagonalLarger3 && diagonalLarger4){
                    Console.WriteLine("Tree is invisible from the outside");
                }
                else{
                    Console.WriteLine("Tree is visible from the outside");
                    visibleTrees.Add(item);
                }
            }
            Console.WriteLine("answer is: {0}",visibleTrees.Count);
        }
    }
}
