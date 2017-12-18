using System;
using System.Collections.Generic;

namespace Day3P2
{
    public class DistanceCalculator
    {
        public int FindFirstHigherValueInSpiral(int input)
        {
            // use number to get coordinate
            int value = 1;
            int xCoord = 0;
            int yCoord = 0;
            int segmentLength = 1;
            List<PositionalValue> spiralValues = new List<PositionalValue>();
            // This value will be a hard cap to ensure that the code doesn't hit an infinite loop
            int valueLimit = 1000000;

            // The spiral will be iterated, keeping track of the coordinate. Once the input value is reached use those coordinates.
            while(value < input)
            {
                // right
                if(value == input) {break;}
                for(int i=0; i<segmentLength; i++)
                {
                    // corner case
                    if(i == segmentLength-1)
                    {
                        xCoord++;
                        value++;
                    }
                    else
                    {
                        xCoord++;
                        value++;
                    }
                    if(value == input) {break;}
                }
                
                // up
                if(value == input) {break;}
                for(int i=0; i<segmentLength; i++)
                {
                    yCoord++;
                    value++;
                    if(value == input) {break;}
                }

                segmentLength++;
                // left
                if(value == input) {break;}
                for(int i=0; i<segmentLength; i++)
                {
                    xCoord--;
                    value++;
                    if(value == input) {break;}
                }
                // down
                if(value == input) {break;}
                for(int i=0; i<segmentLength; i++)
                {
                    yCoord--;
                    value++;
                    if(value == input) {break;}
                }
                segmentLength++;
                
                // ensure we are below the hard cap
                if (value > valueLimit) { throw new ArgumentOutOfRangeException("Entered Value", "The value exceeds the set limit."); }
            }

            // use coordinate to calculate the manhattan distance
            int distance = (Math.Abs(xCoord) + Math.Abs(yCoord));
            return distance;
        }
    }
}