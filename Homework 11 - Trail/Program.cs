using System;

namespace Homework_11___Trail
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate Grid
            int[,] grid = new int[5, 5];
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    grid[y, x] = 0;
                }
                Console.WriteLine();
            }
            drawGrid(grid);

            //Set Intital Position
            int currentX = 0;
            int currentY = 0;

            //Set Initial Direction
            int faceing = 0;   //0 east 1 south 2 west 3 north
     
            //Get Inputs
            Console.WriteLine("How long do you want the trail?");
            int trail = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What pattern do you want(L,R or F)");
            char[] pattern = Console.ReadLine().ToCharArray();
            Console.WriteLine("How many moves?");
            int moves = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < moves; i++)
            {
                //**UPDATE WHOLE GRID 

                for (int y = 0; y < grid.GetLength(0); y++)
                {
                    for (int x = 0; x < grid.GetLength(1); x++)
                    {
                        if (grid[y, x] >= 1)
                        {
                            grid[y, x]--;
                        }

                    }
                }
                //**THIS SECTION OF CODE MANAGES MOVEMENT***

                if (pattern[i % pattern.Length] == 'R')
                {
                    faceing++;
                    if (faceing == 4)
                    {
                        faceing = 0;
                    }
                    //UPDATE CURRENT GRID VALUE  
                    grid[currentY, currentX] = trail;
                    if (faceing == 0)
                    {
                        currentX++;
                    }
                    if (faceing == 1)
                    {
                        currentY++;
                    }
                    if (faceing == 2)
                    {
                        currentX--;
                    }
                    if (faceing == 3)
                    {
                        currentY--;
                    }
                    //***DO THIS FOR EACH DIRECTION ***
                    //Need to deal with edges
                }
                if (pattern[i % pattern.Length] == 'L')
                {
                    faceing--;
                    if (faceing == -1)
                    {
                        faceing = 3;
                    }
                    //UPDATE CURRENT GRID VALUE  
                    grid[currentY, currentX] = trail;
                    if (faceing == 0)
                    {
                        currentX++;
                    }
                    if (faceing == 1)
                    {
                        currentY++;
                    }
                    if (faceing == 2)
                    {
                        currentX--;
                    }
                    if (faceing == 3)
                    {
                        currentY--;
                    }
                    //***DO THIS FOR EACH DIRECTION ***
                    //Need to deal with edges
                }

                if (pattern[i % pattern.Length] == 'F')
                {
                    //UPDATE CURRENT GRID VALUE  
                    grid[currentY, currentX] = trail;
                    if (faceing == 0)
                    {
                        currentX++;
                    }
                    if (faceing == 1)
                    {
                        currentY++;
                    }
                    if (faceing == 2)
                    {
                        currentX--;
                    }
                    if (faceing == 3)
                    {
                        currentY--;
                    }
                    //***DO THIS FOR EACH DIRECTION ***
                    //Need to deal with edges
                }

                
                drawGrid(grid);
            }
            Console.ReadLine();
        }
        static void drawGrid(int[,] grid)
        {
            //Draw Grid
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    Console.Write("{0}", grid[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
//2D for loop to copy
//            for (int y = 0; y < grid.GetLength(0); y++)
//           {
//                for (int x = 0; x < grid.GetLength(1); x++)
//                {
//
//                }
//            }