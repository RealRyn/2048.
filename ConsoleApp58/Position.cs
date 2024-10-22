using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    public static class Position
    {

        static Random random = new Random();

        // I know "goto" isn't optimal, it is just for the purpose of experimenting 
        public static int[,] StartingNumbers(int[,] gameArray)
        {
            int counter = 0;

        Generate:
            int iPos = RandomPosition(1, 5);
            int yPos = RandomPosition(1, 5);

            if (gameArray[iPos, yPos] == 2)
            {
                goto Generate;
            }
            gameArray[iPos, yPos] = 2;
            counter++;

            if (counter < 2)
            {
                goto Generate;
            }

            return gameArray;
        }

        public static int RandomPosition(int minValue, int maxValue)
        {
            int pos = 0;
            pos = random.Next(minValue, maxValue);
            return pos;
        }
        public static int[,] NewTwo(int[,] gameArray)
        {
            int counter = 0;

        Generate:
            int iPos = RandomPosition(1, 5);
            int yPos = RandomPosition(1, 5);

            if (gameArray[iPos, yPos] != 0)
            {
                goto Generate;
            }
            gameArray[iPos, yPos] = 2;
            counter++;

            if (counter < 1)
            {
                goto Generate;
            }

            return gameArray;
        }

    }
}
