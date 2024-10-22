using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    public static class Fill
    {
        public static int[,] Board
        {
            get { return Layout.GameArray; }
            set { Layout.GameArray = value; }
        }

        public static void FillLeft()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int y = 2; y <= 4; y++)
                {
                    if (Board[i, y] != 0)
                    {
                        int tempY = y;
                        while (tempY > 1 && Board[i, tempY - 1] == 0)
                        {
                            Board[i, tempY - 1] = Board[i, tempY];
                            Board[i, tempY] = 0;
                            tempY--;
                        }
                    }
                }
            }
        }

        public static void FillRight()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int y = 3; y >= 1; y--)
                {
                    if (Board[i, y] != 0)
                    {
                        int tempY = y;
                        while (tempY < 4 && Board[i, tempY + 1] == 0)
                        {
                            Board[i, tempY + 1] = Board[i, tempY];
                            Board[i, tempY] = 0;
                            tempY++;
                        }
                    }
                }
            }


        }

        public static void FillUp()
        {
            for (int i = 2; i <= 4; i++)
            {
                for (int y = 1; y <= 4; y++)
                {
                    if (Board[i, y] != 0)
                    {
                        int tempI = i;
                        while (tempI > 1 && Board[tempI - 1, y] == 0)
                        {
                            Board[tempI - 1, y] = Board[tempI, y];
                            Board[tempI, y] = 0;
                            tempI--;
                        }
                    }
                }
            }
        }

        public static void FillDown()
        {
            for (int i = 3; i >= 1; i--)
            {
                for (int y = 1; y <= 4; y++)
                {
                    if (Board[i, y] != 0)
                    {
                        int tempI = i;
                        while (tempI < 4 && Board[tempI + 1, y] == 0)
                        {
                            Board[tempI + 1, y] = Board[tempI, y];
                            Board[tempI, y] = 0;
                            tempI++;
                        }
                    }
                }
            }
        }

    }
}
