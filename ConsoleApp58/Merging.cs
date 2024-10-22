using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    public static class Merging
    {
        public static int[,] Board
        {
            get { return Layout.GameArray; }
            set { Layout.GameArray = value; }
        }

        public static void MergeLeft()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    if (Board[i, y] != 0 && Board[i, y] == Board[i, y + 1])
                    {
                        Board[i, y] *= 2;
                        Board[i, y + 1] = 0;
                    }
                }
            }
        }

        public static void MergeRight()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int y = 4; y > 1; y--)
                {
                    if (Board[i, y] != 0 && Board[i, y] == Board[i, y - 1])
                    {
                        Board[i, y] *= 2;
                        Board[i, y - 1] = 0;
                    }
                }
            }
        }

        public static void MergeUp()
        {

            for (int y = 1; y <= 4; y++)
            {
                for (int i = 2; i <= 4; i++) 
                {
                    if (Board[i, y] != 0 && Board[i, y] == Board[i - 1, y])
                    {
                        Board[i - 1, y] *= 2;
                        Board[i, y] = 0;
                    }
                }
            }

        }


        public static void MergeDown()
        {


            for (int y = 1; y <= 4; y++)
            {
                for (int i = 3; i >= 1; i--) 
                {
                    if (Board[i, y] != 0 && Board[i, y] == Board[i + 1, y])
                    {
                        Board[i + 1, y] *= 2;
                        Board[i, y] = 0;
                    }
                }
            }

        }
    }
}
