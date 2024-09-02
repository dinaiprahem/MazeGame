# Maze Game

Welcome to the Maze Game repository! This project is a console-based maze game written in C#. The game features a player navigating through a maze using keyboard arrow keys to reach the exit.

## Project Overview

### Game Features

- **Maze Generation**: A random maze is generated each time the game starts with a mix of walls and empty spaces.
- **Player Movement**: The player moves through the maze using the arrow keys on the keyboard.
- **Exit**: The goal is to reach the designated exit point within the maze.
- **Console Interface**: The game is played in the console, and the player is represented by an `@` symbol.

### Technologies

- **Programming Language**: C#
- **Development Environment**: Visual Studio

## Usage

- **Arrow Keys**: Move the player up, down, left, or right.
- **Objective**: Reach the exit located at `(width - 2, height - 2)`.

## Code Structure

- **`Program.cs`**: Entry point for the game.
- **`Maze.cs`**: Contains the logic for maze generation, drawing, and player movement.
- **`Player.cs`**: Defines the player and their properties.
- **`IMazeObjects.cs`**: Interface for maze objects like walls and empty spaces.
- **`EmptySpaces.cs`**: Represents empty spaces in the maze.
- **`Wall.cs`**: Represents walls in the maze.

## UML Diagram

![UML Diagram](MazeGame.png)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, feel free to contact me via [GitHub Issues](https://github.com/dinaiprahem/MazeGame/issues).

