using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);// вывод окна размером 80*25.
            //игровое поле
            HorisontalLines Upline = new HorisontalLines(0, 79, 0, "-");//верхняя горизонтальная линия
            Upline.Draw();
            HorisontalLines Downline = new HorisontalLines(0, 79, 24, "_");//нижняя горизонтальная линия
            Downline.Draw();
            VerticalLines Leftline = new VerticalLines(0, 24, 0, "|");//левая вертикальная линия
            Leftline.Draw();
            VerticalLines Rightline = new VerticalLines(0, 24, 79, "|");// правая горизонтальная линия
            Rightline.Draw();
            // тело змейки
            Point p = new Point(4, 5, "*");// задаем начальную точку змейки
            Snake snake = new Snake(p, 4, Derection.RIGHT);// начальная точка змейки, длинна хвоста змейки и направление движения.
            snake.Draw();// вывод змейки
            // движение змейки
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                System.Threading.Thread.Sleep(100);
                snake.Move();
            }
            

            
        }
    }
}
