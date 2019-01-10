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
            Console.SetBufferSize(80, 25);

            HorisontalLines Upline = new HorisontalLines(0, 79, 0, "-");//верхняя горизонтальная линия
            Upline.Draw();
            HorisontalLines Downline = new HorisontalLines(0, 79, 24, "_");//нижняя горизонтальная линия
            Downline.Draw();
            VerticalLines Leftline = new VerticalLines(0, 24, 0, "|");//левая вертикальная линия
            Leftline.Draw();
            VerticalLines Rightline = new VerticalLines(0, 24, 79, "|");// правая горизонтальная линия
            Rightline.Draw();
           
            
            Point p = new Point(4, 5, "*");
            Snake snake = new Snake(p, 4, Derection.RIGHT);
            snake.Draw();
            Console.ReadLine();
        }
    }
}
