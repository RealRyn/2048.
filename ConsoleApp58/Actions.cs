using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Actions
    {
       // private Layout board = new Layout();
        private bool winCondition = false;

        public int[,] Board
        {
            get { return Layout.GameArray; }
            set { Layout.GameArray = value; }
        }

        public bool WinCondition
        {
            get { return winCondition; }
            set { }
        }

        public Actions()
        {

        }



        public int[,] CloneBoard()
        {
            int iCounter = Board.GetLength(0);
            int yCounter = Board.GetLength(1);

            int[,] newBoard = new int[iCounter, yCounter];

            for (int i = 0; i < newBoard.GetLength(0); i++)
            {
                for (int y = 0; y < newBoard.GetLength(1); y++)
                {
                    newBoard[i, y] = Board[i, y];
                }
            }

            return newBoard;
        }

        private bool IfChanged(int[,] beforeBoard)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    if (beforeBoard[i, y] != Board[i,y])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public void Move(string dir)
        {
            int[,] boardBefore = CloneBoard();

            if (Layout.SearchValue(2048) == true)
            {
                WinCondition = true;
            }

            if (dir == "left")
            {
                Left();
            }
            else if (dir == "right")
            {
                Right();
            }
            else if (dir == "up")
            {
                Up();
            }
            else if (dir == "down")
            {
                Down();
            }

            if (IfChanged(boardBefore) == true)
            {
                Position.NewTwo(Board);

            }
        }
        protected void Left()
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
            Merging.MergeLeft();
            Fill.FillLeft();


        }


        public void Right()
        {

            // Slide all tiles to the right
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

            Merging.MergeRight();
            Fill.FillRight();

        }


        public void Up()
        {


            // First, move all tiles upward without merging
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

     
            Merging.MergeUp();

            
            Fill.FillUp();


        }


        public void Down()
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

            
            Merging.MergeDown();
        
            Fill.FillDown();


        }
    }
}
