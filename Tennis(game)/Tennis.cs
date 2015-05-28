using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class Tennis
{
    public static void Main()
    {
        Console.Title = "  Tennis";
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth = 80;           
        string players;
           
        do
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 31, Console.BufferHeight / 2 - 1);
            Console.Write("Press (1) for one player, (2) for two players or (q) to quit: ");
            players = Console.ReadLine();
            if (players == "q")
            {
                System.Environment.Exit(-1);
            }
        } while (!(players == "1" || players == "2"));
                        
        if (players == "1")
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveSecondPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveSecondPlayerDown();
                    }
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Main();
                    }
                }
                MoveBall();
                Console.Clear();
                DrawFirstPlayer();
                PlayerComputer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                Thread.Sleep((int) (50 - speed));
            }
        }
           
        if (players == "2")
        {
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
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Main();
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
    }

    public static int padSize = 7;
    public static int ballPositionX = Console.WindowWidth / 2;
    public static int ballPositionY = Console.WindowHeight / 2;
    public static bool ballDirectionUp = true;
    public static bool ballDirectionRight = true;
    public static int firstPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
    public static int secondPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
    public static int firstPlayerPoints = 0;
    public static int secondPlayerPoints = 0;
    public static double speed = 0;
    public static Random randomGenerator = new Random();
        
        public static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    public static void ResetAllPosition()
    {
        ballPositionX = Console.WindowWidth / 2; 
        ballPositionY = Console.WindowHeight / 2;
        firstPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
        secondPlayerPosition = Console.WindowHeight / 2 - padSize / 2;
    }

    public static void DrawFirstPlayer()
    {
        for (int y = firstPlayerPosition; y < firstPlayerPosition + padSize; y++)
        {
            PrintAtPosition(0, y, ']');
        }
    }

    public static void DrawSecondPlayer()
    {
        for (int y = secondPlayerPosition; y < secondPlayerPosition + padSize; y++)
        {
            PrintAtPosition(Console.WindowWidth - 1, y, '[');
        }
    }

    public static void DrawBall()
    {
        PrintAtPosition(ballPositionX, ballPositionY, '@');
    }

    public static void PrintResult()
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - 2, 0);
        Console.Write("{0} - {1}", firstPlayerPoints, secondPlayerPoints);
    }

    public static void MoveFirstPlayerUp()
    {
        if (firstPlayerPosition > 0)
        {
            firstPlayerPosition--;
        }           
    }
       
    public static void MoveFirstPlayerDown()
    {
        if (firstPlayerPosition + padSize < Console.WindowHeight)
        {
            firstPlayerPosition++;
        }
    }
        
    public static void MoveSecondPlayerUp()
    {
        if (secondPlayerPosition > 0)
        {
            secondPlayerPosition--;
        }
    }
        
    public static void MoveSecondPlayerDown()
    {
        if (secondPlayerPosition + padSize < Console.WindowHeight)
        {
            secondPlayerPosition++;
        }
    }
        
    public static void PlayerComputer()
    {
        int randomNumber = randomGenerator.Next(0, 3);
        if (randomNumber != 1)
        {
            if (ballDirectionUp && ballPositionX < Console.WindowWidth/2 && !ballDirectionRight)
            {
                MoveFirstPlayerUp();
            }
            if(!ballDirectionUp && ballPositionX < Console.WindowWidth/2 && !ballDirectionRight)
            {
                MoveFirstPlayerDown();
            }
        }
    }
        
    public static void MoveBall()
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
            Console.WriteLine("Left player win!");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2 + 2);
            Console.WriteLine("Press key to continue...");
            Console.ReadKey();
        }
        
        if (ballPositionX == 0)
        {
            secondPlayerPoints++;
            ResetAllPosition();
            ballDirectionRight = false;
            speed = 0;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
            Console.WriteLine("Right player win!");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2 + 2);
            Console.WriteLine("Press key to continue...");
            Console.ReadKey();
        }

        if (ballPositionX < 2)
        {
            if (ballPositionY >= firstPlayerPosition-1 && ballPositionY <= firstPlayerPosition + padSize)
            {
                Console.Beep(586, 26);
                ballDirectionRight = true;
                ballPositionX++;
                if (speed < 25)
                {
                    speed += 2.5;
                }
            }
        }
            
        if (ballPositionX > Console.WindowWidth - 3)
        {
            if (ballPositionY >= secondPlayerPosition-1 && ballPositionY <= secondPlayerPosition + padSize) 
            {
                Console.Beep(586, 26);
                ballDirectionRight = false;
                ballPositionX--;
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

