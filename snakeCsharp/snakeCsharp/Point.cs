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

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}
