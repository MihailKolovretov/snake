using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Snake : Figura
    {
        public Snake(Point tail, int length, Derection derection)
        {
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, derection);
                pList.Add(p);
            }
        }
    }
}
