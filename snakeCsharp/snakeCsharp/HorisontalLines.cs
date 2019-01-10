using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class HorisontalLines : Figura// наследует от родительского класса фигура
    {
        

        public HorisontalLines(int xLeft, int xRight, int y, string simb)
        {
            pList = new List<Point>(); //создаем список точек от левого х до правого х
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, simb);
                pList.Add(p);
            }
        }
      
    }
}
