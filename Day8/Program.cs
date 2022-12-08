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
            foreach (var tree in trees)
            {
                Console.WriteLine("New Tree");
                bool xLarger = false;
                bool yLarger = false;
                bool xLarger2 = false;
                bool yLarger2 = false;
                // bool diagonalLarger1 = false;
                // bool diagonalLarger2 = false;
                // bool diagonalLarger3 = false;
                // bool diagonalLarger4 = false;
                List<Tree> largerTrees = new List<Tree>();
                foreach (var largerTree in trees)
                {
                    if(largerTree.height > tree.height){
                        largerTrees.Add(largerTree);
                    }
                }
                foreach (var largerTree in largerTrees)
                {
                    
                    // // diagonalLarger1 = false;
                    // // diagonalLarger2 = false;
                    // // diagonalLarger3 = false;
                    // // diagonalLarger4 = false;
                    if(tree.x==largerTree.x && tree.y < largerTree.y && xLarger==false){
                        Console.WriteLine("There is a larger tree above {0}" , largerTree);
                        xLarger=true;
                    }
                    if(tree.x==largerTree.x && tree.y > largerTree.y && xLarger2==false){
                        Console.WriteLine("There is a larger below {0}" , largerTree);
                        xLarger2=true;
                    }
                    if(tree.y==largerTree.y && tree.x < largerTree.x && yLarger==false){
                        Console.WriteLine("There is a larger tree to the right {0}" , largerTree);
                        yLarger=true;
                    }
                    if(tree.y==largerTree.y && tree.x > largerTree.x && yLarger2==false){
                        Console.WriteLine("There is a larger tree to the left {0}" , largerTree);
                        yLarger2=true;
                    }
                    if(xLarger && yLarger && xLarger2 && yLarger2){//&& diagonalLarger1 && diagonalLarger2 && diagonalLarger3 && diagonalLarger4
                    break;
                }
                    // for(int i = 0; i < largerTrees.Count; i++){
                    //     if(item.x+i==largerTree.x && item.y+i==largerTree.y){
                    //         Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                    //         diagonalLarger1=true;
                    //     }
                    //     if(item.x+i==largerTree.x && item.y-i==largerTree.y){
                    //         Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                    //         diagonalLarger2=true;
                    //     }
                    //     if(item.x-i==largerTree.x && item.y+i==largerTree.y){
                    //         Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                    //         diagonalLarger3=true;
                    //     }
                    //     if(item.x-i==largerTree.x && item.y-i==largerTree.y){
                    //         Console.WriteLine("There is a larger tree diagonally {0}" , largerTree);
                    //         diagonalLarger4=true;
                    //     }
                    // }

                }
                if(xLarger && yLarger && xLarger2 && yLarger2 ){//&& diagonalLarger1 && diagonalLarger2 && diagonalLarger3 && diagonalLarger4
                    Console.WriteLine("Tree is invisible from the outside");
                }
                else{
                    Console.WriteLine("Tree is visible from the outside");
                    visibleTrees.Add(tree);
                }
            }
            Console.WriteLine("answer is: {0}",visibleTrees.Count);
        }
    }
}
