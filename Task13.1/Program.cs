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
            List<Thread> threads = new List<Thread>();
            
        }
        static void NewMatrix()
        {
            q1:
            var width = Console.WindowWidth;
            var height = Console.WindowHeight;

            int xPosition = new Random().Next(0, width);
            int yPosition = 0;

            int sleep = new Random().Next(100, 500);

            string yMatrix = "";
            var length = new Random().Next(3, 10);

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                for (var i = 0; i < length; i++)
                    yMatrix += (char)new Random().Next(33, 126);

                for (var i = 0; i < length; i++)
                {
                    if(i == length-2) Console.ForegroundColor = ConsoleColor.Green;
                    if(i == length-1) Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xPosition, yPosition + i);
                    Console.Write(yMatrix[i]);
                }
                yMatrix = "";
                Thread.Sleep(sleep);
                if (yPosition++ > Console.WindowHeight - length-1) goto q1;
            }
        }
    }
}
