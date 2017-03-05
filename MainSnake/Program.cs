using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MainSnake
{
    class Program
    {
        static void Main(string[] args)
        {


            Walls walls = new Walls(30, 33);
            walls.Draw();



            Point p = new Point(5,4,'*');
            Snake snake = new Snake(p, 2, Direction.RIGHT);
            snake.Draw(); 

            FoodGreator foodCreator = new FoodGreator(28,31,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score count = new Score(0);
            count.Draw();
            while (true)
            {

                if (walls.IsHit(snake) || snake.IsHitTail())
                                {
                                     break;
                                 }
                if (snake.Eat(food))
                {
             
                    food = foodCreator.CreateFood();
                    food.Draw();
                    count.Draw();
                }
                else
                {
                 
                }

                if (Console.KeyAvailable)
                {
                    snake.Move();
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HadleKey(key.Key);

                }


            }




            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            count.Draw2();
            Console.ReadLine(); 


        }

    }
}
