using System;

namespace PrincessGame
{
    public class Player
    {
        public Position Position => new Position(_position.X, _position.Y);
        public int Lives { get; private set; }
        public bool IsWinner { get; set; }

        public bool IsInGame => Lives > 0 && !IsWinner;

        private readonly Position _position;

        public Player(Position position, int lives)
        {
            _position = position;
            Lives = lives;
        }

        public void MoveTo(ConsoleKey direction)
        {
            _position.Move(direction);
        }

        public void StepOnTrap(int damage)
        {
            Lives -= damage;
        }
    }
}
