using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MazeGame
{
   
    public class Maze
    {
        private int width;
        private int height;
        private Player player;
        private IMazeObjects[,] MazeObjectArray;
        private Random rand; 
        public Maze(int w, int h)
        {
            width = w;
            height = h;
            MazeObjectArray = new IMazeObjects[w, h];
            player = new Player()
            {
                X = 1, // Player starts at (1, 1) in this example
                Y = 1
            };
            rand = new Random();

            // Initialize the maze with walls and empty spaces
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 || y == 0 || y == height - 1 || x == width - 1)
                    {
                       
                      MazeObjectArray[x, y] = new Wall(); // Outer walls
                    }
                    
                    else if (rand.Next(0, 100) < 30) // 30% chance to place a random wall
                    {
                        MazeObjectArray[x, y] = new Wall();
                    }
                    else
                    {
                        MazeObjectArray[x, y] = new EmptySpaces(); // Empty spaces
                    }
                }
            }

        }


        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == player.X && y == player.Y)
                    {
                        Console.Write(player.Icon);
                    }
                    else if(x== width - 2 &&y== height - 2)
                    {
                        // Place the exit as an empty space, e.g., (width - 2, height - 2)
                        MazeObjectArray[x, y] = new EmptySpaces();
                        Console.WriteLine(MazeObjectArray[x, y].Icon + " ");

                    }
                   else {
                        Console.Write(MazeObjectArray[x, y].Icon);
                    }
                }

               

                Console.WriteLine();
            }
        }
        
        public void MovePlayer()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            ConsoleKey keyy = input.Key;
            int dx = 0, dy = 0;
            switch(keyy)
            {
                case ConsoleKey.UpArrow:
                   dy=-1;
                    break;
                case ConsoleKey.DownArrow:
                    dy = 1 ;
                    break;
                case ConsoleKey.LeftArrow:
                    dx=-1;
                    break;
                case ConsoleKey.RightArrow:
                    dx=1;
                    break;
            }
            UpdatePlayer(dx, dy);
        }
        private void UpdatePlayer(int dx, int dy)
        {
            int newx = player.X + dx;
            int newy = player.Y + dy;

            if (newx < width && newx >= 0 && newy < height && newy >= 0)
            {
                if (newx == width - 2 && newy == height - 2)
                {
                    Console.SetCursorPosition(player.X, player.Y);
                    Console.Write(MazeObjectArray[player.X, player.Y].Icon);

                    player.X = newx;
                    player.Y = newy;

                    Console.SetCursorPosition(player.X, player.Y);
                    Console.Write(player.Icon);

                    Console.SetCursorPosition(0, height);
                    Console.WriteLine("You reached the exit! Congratulations!");
                    Environment.Exit(0); // Exit the game
                }
                else if (!MazeObjectArray[newx, newy].IsSolid)
                {
                    // Clear the old player position
                    Console.SetCursorPosition(player.X, player.Y);
                    Console.Write(MazeObjectArray[player.X, player.Y].Icon);

                    player.X = newx;
                    player.Y = newy;

                    // Draw the player at the new position
                    Console.SetCursorPosition(player.X, player.Y);
                    Console.Write(player.Icon);
                }
            }
        }



    }
}
