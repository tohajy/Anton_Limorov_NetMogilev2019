using System;

namespace PrincessGame
{
    class Program
    {
        private static Field _field;
        private static Player _player;

        static void Main(string[] args)
        {
            InitGame();

            do
            {
                ConsoleKey direction = Console.ReadKey().Key;

                if (direction != ConsoleKey.LeftArrow && direction != ConsoleKey.RightArrow &&
                    direction != ConsoleKey.UpArrow && direction != ConsoleKey.DownArrow)
                    continue;

                _player.MoveTo(direction);
                _field.Set(_player);

                Render(_field, _player, onlyPersons: true);

                if (!_player.IsInGame)
                {
                    Render(_field, _player);

                    Console.WriteLine();
                    Console.WriteLine("Do you want to play one more time? (y/n)");

                    if (Console.ReadKey().KeyChar.ToString() == "y")
                    {
                        InitGame();
                    }
                    else
                    {
                        break;
                    }
                }

            } while (_player.IsInGame);
        }

        private static void InitGame()
        {
            Position.Max = 10;

            _field = new Field(10, 10);
            _player = new Player(new Position(0, 0), 10);

            _field.Set(_player);
            Render(_field, _player, onlyPersons: true);
        }

        public static void Render(Field field, Player gamer, bool onlyPersons = false)
        {
            Console.Clear();
            Console.WriteLine("Use Arrow buttons to move the Knight");
            Console.WriteLine();

            if (gamer.IsInGame)
            {
                Console.WriteLine($"Player lives: {gamer.Lives}");
            }
            else
            {
                Console.WriteLine(gamer.IsWinner ? "You won!" : "Wasted!");

                onlyPersons = false;
            }

            char[,] markup = field.Markup;

            for (var i = -1; i < markup.GetLength(0) + 1; i++)
            {
                for (var j = -1; j < markup.GetLength(1) + 1; j++)
                {
                    if (i == -1 || i == 10 || j == -1 || j == 10)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        if (onlyPersons)
                        {
                            if (markup[j, i] == 'g' || markup[j, i] == 'p' || markup[j, i] == 'o')
                            {
                                Console.Write(markup[j, i]);
                            }
                            else
                            {
                                Console.Write(default(char));
                            }
                        }
                        else
                        {
                            Console.Write(markup[j, i]);
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
