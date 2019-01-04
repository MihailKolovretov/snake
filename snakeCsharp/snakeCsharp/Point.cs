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



        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}
