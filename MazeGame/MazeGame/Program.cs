namespace MazeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maze Game!!");
            Console.WriteLine("Use the arrow keys to navigate the maze.");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(true); // Wait for user input before starting

            Maze maze = new Maze(40, 20); // Create a new maze with dimensions 40x20
            maze.DrawMaze(); // Draw the maze
            while (true)
            {
               
                maze.MovePlayer(); // Handle player movement
            }
        }
    }
}
