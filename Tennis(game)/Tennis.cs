using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tennis
{
    class Tennis
    {
        static void Main()
        {
            Console.Title = "Tennis";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth = 80;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (keyInfo.Key == ConsoleKey.W)
                    {
                        MoveFirstPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.S)
                    {
                        MoveFirstPlayerDown();
                    }
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveSecondPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveSecondPlayerDown();
                    }
                }
                MoveBall();
                Console.Clear();
                DrawFirstPlayer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                Thread.Sleep((int)(50 - speed));
            }

        }
        static int padSize = 7;
        static int ballPositionX = Console.WindowWidth / 2;
        static int ballPositionY = Console.WindowHeight / 2;
        static bool ballDirectionUp = true;
        static bool ballDirectionRight = true;
        static int firstPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
        static int secondPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
        static int firstPlayerPoints = 0;
        static int secondPlayerPoints = 0;
        static double speed = 0;
        
        static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void ResetAllPosition()
        {
            ballPositionX = Console.WindowWidth / 2; 
            ballPositionY = Console.WindowHeight / 2;
            firstPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
            secondPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
        }

        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition; y < firstPlayerPosition + padSize; y++)
            {
                PrintAtPosition(0, y, ']');
            }
        }

        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y < secondPlayerPosition + padSize; y++)
            {
                PrintAtPosition(Console.WindowWidth - 1, y, '[');
            }
        }

        static void DrawBall()
        {
            PrintAtPosition(ballPositionX, ballPositionY, '@');
        }

        static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, 0);
            Console.Write("{0} - {1}", firstPlayerPoints, secondPlayerPoints);
        }

        static void MoveFirstPlayerUp()
        {
            if (firstPlayerPosition > 0)
            {
                firstPlayerPosition--;
            }           
        }
        static void MoveFirstPlayerDown()
        {
            if (firstPlayerPosition + padSize < Console.WindowHeight)
            {
                firstPlayerPosition++;
            }
        }
        
        static void MoveSecondPlayerUp()
        {
            if (secondPlayerPosition > 0)
            {
                secondPlayerPosition--;
            }
        }
        static void MoveSecondPlayerDown()
        {
            if (secondPlayerPosition + padSize < Console.WindowHeight)
            {
                secondPlayerPosition++;
            }
        }
        static void MoveBall()
        {
            if (ballPositionY == 0)
            {
                Console.Beep(1280, 25);
                ballDirectionUp = false;
            }
            if (ballPositionY == Console.WindowHeight - 1)
            {
                Console.Beep(1280, 25);
                ballDirectionUp = true;
            }

            if (ballPositionX == Console.WindowWidth - 1)
            {
                firstPlayerPoints++;
                ResetAllPosition();
                speed = 0;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
                Console.WriteLine("Player one win!");
                Console.ReadKey();
            }
            if (ballPositionX == 0)
            {
                secondPlayerPoints++;
                ResetAllPosition();
                ballDirectionRight = false;
                speed = 0;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
                Console.WriteLine("Player two win!");
                Console.ReadKey();
            }

            if (ballPositionX < 2)
            {
                if (ballPositionY >= firstPlayerPoints && ballPositionY <= firstPlayerPosition + padSize)
                {
                    Console.Beep(586, 26);
                    ballDirectionRight = true;
                    if (speed < 25)
                    {
                        speed += 2.5;
                    }
                }
            }
            if (ballPositionX > Console.WindowWidth - 3)
            {
                if (ballPositionY >= secondPlayerPosition && ballPositionY <= secondPlayerPosition + padSize) 
                {
                    Console.Beep(586, 26);
                    ballDirectionRight = false;
                    if (speed < 25)
                    {
                        speed += 2.5;
                    }
                }
            }

            if (ballDirectionUp)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }
            if (ballDirectionRight)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
        }
    }
}
