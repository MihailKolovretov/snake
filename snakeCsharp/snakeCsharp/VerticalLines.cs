using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class VerticalLines : Figura// наследует от родительского класса фигура
    {
       
        public VerticalLines(int yTop, int yDown, int x, string simb)
        {
            pList = new List<Point>(); //создаем новый список точек
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, simb);
                pList.Add(p);
            }
        }
      
    }
}
