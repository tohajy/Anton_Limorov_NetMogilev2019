using System;

namespace PrincessGame
{
    public class Position
    {
        public static int Max { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public void Move(ConsoleKey direction)
        {
            switch (direction)
            {
                case ConsoleKey.LeftArrow when X - 1 >= 0:
                    X--;
                    break;
                case ConsoleKey.RightArrow when X + 1 <= Max - 1:
                    X++;
                    break;
                case ConsoleKey.DownArrow when Y + 1 <= Max - 1:
                    Y++;
                    break;
                case ConsoleKey.UpArrow when Y - 1 >= 0:
                    Y--;
                    break;
            }
        }
    }
}
