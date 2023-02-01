using System;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Console.Title = "Game";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WindowWidth = 40;
            Console.WindowHeight = 18;
            Console.CursorVisible = false;

            int coints = 0;
            int playerX = 1, playerY = 1;

            char[,] map =
            {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
                { '#', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', 'o', ' ', ' ', ' ', '#', 'o', ' ', '#', },
                { '#', ' ', '#', '#', ' ', 'o', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', 'o', '#', },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', },
                { '#', 'o', ' ', ' ', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', 'o', '#', },
                { '#', ' ', ' ', '#', ' ', 'o', ' ', ' ', ' ', ' ', 'o', ' ', ' ', '#', ' ', ' ', '#', },
                { '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', },
                { '#', '#', '#', '#', ' ', ' ', ' ', ' ', 'o', ' ', ' ', ' ', ' ', '#', 'o', ' ', '#', },
                { '#', 'o', 'o', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'o', ' ', ' ', ' ', ' ', '#', },
                { '#', 'o', 'o', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',}
            };
            while (isOpen)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('@');
                Console.SetCursorPosition(19, 3);
                Console.WriteLine($"Собрано монет: {coints}/15");
                Console.SetCursorPosition(0, 15);
                Console.Write($"Управление стрелочками.");

                ConsoleKeyInfo userKey = Console.ReadKey();
                switch (userKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[playerX - 1, playerY] != '#')
                        {
                            playerX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[playerX + 1, playerY] != '#')
                        {
                            playerX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[playerX, playerY - 1] != '#')
                        {
                            playerY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[playerX, playerY + 1] != '#')
                        {
                            playerY++;
                        }
                        break;
                }

                if (map[playerX, playerY] == 'o')
                {
                    coints += 1;
                    map[playerX, playerY] = ' ';
                }

                Console.Clear();
            }
        }
    }
}
