using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        public static void Message()
        {
            Console.Clear();
            Console.WriteLine("Welcome to 2048 by RealRyn. keep im mind you can play with WASD / Arrow keys.");
            Console.WriteLine(" ");

            Layout.ShowBoard();
        }

        public static void Start()
        {
            Actions actions = new Actions();



            while (actions.WinCondition == false)
            {
                Message();


                Console.Write("Enter movement key (W/A/S/D): ");
                var key = Console.ReadKey().Key;
                Console.WriteLine();

                switch (key)
                {
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        actions.Move("left");
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        actions.Move("right");
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        actions.Move("down");
                        break;
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        actions.Move("up");
                        break;
                }


            }
        }
        static void Main(string[] args)
        {
            Start();

        }
    }
}
