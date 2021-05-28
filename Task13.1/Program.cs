using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            foreach (var item in Enumerable.Range(1, 40)) 
            {
                new Thread(NewMatrix).Start();
            }
        }
        static void NewMatrix()
        {
            char[] yMatrix;
            int xPosition, yPosition, sleep, length;

            while (true)
            {
                xPosition = new Random().Next(0, Console.WindowWidth);
                yPosition = 0;
                sleep = new Random().Next(50, 500);
                length = new Random().Next(3, 10);
                yMatrix = new char[length];

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    for (var i = 0; i < length; i++)
                        yMatrix[i] = (char)new Random().Next(33, 126);

                    for (var i = 0; i < length; i++)
                    {
                        if (i == length - 2) Console.ForegroundColor = ConsoleColor.Green;
                        if (i == length - 1) Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(xPosition, yPosition + i);
                        Console.Write(yMatrix[i]);
                    }

                    Console.SetCursorPosition(xPosition, yPosition);
                    Console.Write(' ');

                    if (yPosition++ >= Console.WindowHeight - length - 1)
                    {
                        for (var i = 0; i < length; i++)
                        {
                            Console.SetCursorPosition(xPosition, yPosition + i);
                            Console.Write(' ');
                        }
                        break;
                    }
                    yMatrix.DefaultIfEmpty();
                    Thread.Sleep(sleep);
                }
            }
        }
    }
}
