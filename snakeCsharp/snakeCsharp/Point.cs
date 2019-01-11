using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Point
    {
        public int x;
        public int y;
        public string simb;

        public Point(int _x, int _y, string _simb) {
            x = _x;
            y = _y;
            simb = _simb;
        }


        public Point(Point p) // создаем новыю точку точкой
        {
            x = p.x;
            y = p.y;
            simb = p.simb;
        }

        public void Move(int offset, Derection derection) // метод смещения точки в зависимости от направления
        {
            if (derection == Derection.RIGHT)
            {
                x = x + offset;
            }
            else if (derection == Derection.LEFT)
            {
                x = x - offset;
            }
            else if (derection == Derection.DOWN)
            {
                y = y + offset;
            }
            else if (derection == Derection.UP)
            {
                y = y - offset;
            }
        }

        public void Draw() // вывод точки
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }

        public void Clear()
        {
            simb = " ";
            Draw();
        }



        public override string ToString()// магия
        {
            return x + ", " + ", " + simb;
        }
    }
}
