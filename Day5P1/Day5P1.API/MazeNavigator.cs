using System.Collections.Generic;
using System;

namespace Day5P1
{
    public class MazeNavigator
    {
        public int StepsToGetOut(List<string> mazeInStringForm)
        {
            int stepCount = 0;
            int currentLocation = 0;

            // get input list into a list of integers
            List<int> maze = new List<int>();
            foreach(string step in mazeInStringForm)
            {
                maze.Add(Convert.ToInt32(step));
            }

            // travel through maze, keeping track of the number of steps taken
            while(currentLocation < maze.Count)
            {
                if(maze[currentLocation] >= 3)
                {
                    maze[currentLocation]--;
                    currentLocation += maze[currentLocation]+1;
                    stepCount++;
                }
                else
                {
                    maze[currentLocation]++;
                    currentLocation += maze[currentLocation]-1;
                    stepCount++;
                }
            }

            return stepCount;
        }
    }
}