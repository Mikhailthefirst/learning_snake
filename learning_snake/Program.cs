using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace learning_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //изначально 80,25 но на ноуте ругается(
            Console.SetBufferSize(120, 30);

            //рама
           // HorizontallLine topLine = new HorizontallLine(0, 78, 0, '+');
            //HorizontallLine bottomLine = new HorizontallLine(0, 78, 24, '+');
            //VerticallLine leftLine = new VerticallLine(0, 24, 0, '+');
            //VerticallLine rightLine = new VerticallLine(0, 24, 78, '+');
            HorizontallLine topLine = new HorizontallLine(0, 118, 0, '+');
            HorizontallLine bottomLine = new HorizontallLine(0, 118, 29, '+');
            VerticallLine leftLine = new VerticallLine(0, 29, 0, '+');
            VerticallLine rightLine = new VerticallLine(0, 29, 118, '+');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            //и точка
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(118, 29, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }


            Console.ReadLine();
        }

    }
}
