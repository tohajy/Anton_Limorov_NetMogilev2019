using System;
using System.Collections.Generic;

namespace PrincessGame
{
    public class Field
    {
        public char[,] Markup { get; }
        private Position _currentGamerPosition;
        private readonly List<Position> _bombedTraps;

        public Field(int size, int traps)
        {
            Markup = GenerateField(size, traps);
            _bombedTraps = new List<Position>(traps);
        }

        public void Set(Player player)
        {
            if (_currentGamerPosition == null)
            {
                _currentGamerPosition = player.Position;
            }
            else
            {
                char nextPoint = Markup[player.Position.X, player.Position.Y];
                Markup[_currentGamerPosition.X, _currentGamerPosition.Y] = default(char);

                if (nextPoint == 'x')
                {
                    int damage = GetDamage(max: 10);
                    player.StepOnTrap(damage);
                    _bombedTraps.Add(player.Position);
                }
                else if (nextPoint == 'p')
                {
                    player.IsWinner = true;
                }
                else
                {
                    foreach (var trapPosition in _bombedTraps)
                    {
                        Markup[trapPosition.X, trapPosition.Y] = 'o';
                    }
                }

                _currentGamerPosition = player.Position;
            }

            Markup[_currentGamerPosition.X, _currentGamerPosition.Y] = 'g';
        }

        private static int GetDamage(int max)
        {
            var rn = new Random();
            return rn.Next(1, max);
        }

        private static char[,] GenerateField(int size, int traps)
        {
            var field = new char[size, size];

            var rn = new Random();

            while (traps > 0)
            {
                var positions = GetRandomPositions(size, rn);

                if ((positions.X == 0 || positions.X == 9) && (positions.Y == 0 || positions.Y == 9) || field[positions.X, positions.Y] == 'x')
                    continue;

                field[positions.X, positions.Y] = 'x';
                traps--;
            }

            field[9, 9] = 'p';

            return field;
        }

        private static Position GetRandomPositions(int range, Random rn)
        {
            return new Position(rn.Next(0, range), rn.Next(0, range));
        }
    }
}
