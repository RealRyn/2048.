using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal static class Layout
    {
        private static int[,] gameArray = new int[6, 6];

        public static int[,] GameArray
        {
            get { return gameArray; }
            set { gameArray = value; }
        }

        static Layout()
        {
            GenerateBoard();
            Position.StartingNumbers(GameArray);

        }

        public static void GenerateBoard()
        {
            for (int i = 0; i < GameArray.GetLength(0); i++)
            {
                for (int y = 0; y < GameArray.GetLength(1); y++)
                {
                    if (i == 0 || i == GameArray.GetLength(0) - 1)
                    {
                        GameArray[i, y] = 1;
                    }
                    if (y == 0 || y == GameArray.GetLength(1) - 1)
                    {
                        GameArray[i, y] = 1;
                    }
                }
            }

        }


        public static void WriteCenter(string text)
        {
            Console.Write(text.PadLeft((Console.WindowWidth/2) - 10));
        }
        

        public static void ShowBoard()
        {
            for (int i = 1; i < GameArray.GetLength(0)-1; i++)
            {


                WriteCenter("");

                for (int y = 1; y < GameArray.GetLength(1)-1; y++)
                {
                    if (y == 1)
                    {
                        Console.Write(" | ");
                    }

                    Console.Write(GameArray[i, y] + " | ");
                    
                }
                if (i != GameArray.GetLength(0) - 2)
                {
                    Console.WriteLine();
                    WriteCenter("");
                    Console.WriteLine("-------------------");
                }

                
            }
            Console.WriteLine();
        }

        public static bool SearchValue(int value)
        {
            for (int i = 0; i < GameArray.GetLength(0); i++)
            {
                for (int y = 0; y < GameArray.GetLength(1); y++)
                {
                    if (GameArray[i, y] == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
