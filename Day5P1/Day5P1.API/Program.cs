using System;
using System.IO;
using System.Collections.Generic;

namespace Day5P1.API
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> maze = new List<string>();
            using(StreamReader reader = new StreamReader("../Day5P1Data.txt"))
            {
                while(!reader.EndOfStream)
                {
                    maze.Add(reader.ReadLine());
                }
            }

            MazeNavigator mazeNavigator = new MazeNavigator();
            int stepsForMaze = mazeNavigator.StepsToGetOut(maze);

            Console.WriteLine(stepsForMaze);
        }
    }
}
