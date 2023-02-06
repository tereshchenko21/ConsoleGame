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

            int playerX = 1, playerY = 1;

            char[] cointsCollection = new char[1];

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
                Console.SetCursorPosition(0, 15);
                Console.Write("Монеты:");
                for (int i = 0; i < cointsCollection.Length; i++)
                {
                    Console.Write(cointsCollection[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
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
                    map[playerX, playerY] = ' ';
                    char[] tempArray = new char[cointsCollection.Length + 1]; 
                    for (int i = 0; i < cointsCollection.Length; i++)
                    {
                        tempArray[i] = cointsCollection[i];
                    }
                    tempArray[tempArray.Length - 1] = 'o';
                    cointsCollection = tempArray;
                }

                Console.Clear();
            }
        }
    }
}
