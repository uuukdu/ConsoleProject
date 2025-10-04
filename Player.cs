using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int row, int col)
        {
            X = col / 2;
            Y = row / 2;
        }

        public void PrintPlayer()
        {
            Console.SetCursorPosition(X * 2, Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("P");
            Console.ResetColor();
        }
    }
}
