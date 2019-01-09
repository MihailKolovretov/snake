using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Все общие куски кода суем в родительский класс они становятся доступны в дочерних классах
 * 
 * 
 * 
 * */
namespace snakeCsharp
{
    class Figura// класс фигура(родительский)
    {
       protected List<Point> pList;// одинаковые куски кода суем в родительский класс

        public void Draw()// выводим список точек
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
