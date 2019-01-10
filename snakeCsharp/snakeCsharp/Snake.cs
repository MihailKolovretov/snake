using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Snake : Figura
    {
        Derection derection;

        public Snake(Point tail, int length, Derection _derection)
        {
            derection = _derection;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, derection);
                pList.Add(p);
            }
        }

        internal void Move()// двигает змейку в сторону derection
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();// удаление хвоста
            head.Draw();// вывод символа головы
        }

        public Point GetNextPoint()// получает следующую точку для головы змейки 
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, derection);
            return nextPoint;
        }
    }
}
