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
           Point p1 = new Point(1, 3, "#");
           p1.Draw();

           Point p2 = new Point(1, 5, "*");
           p2.Draw();

            HorisontalLines line = new HorisontalLines(5, 15, 8, "+");
            line.Drow();

            VerticalLines Vline = new VerticalLines(4, 15, 5, "#");
            Vline.Draw();

            Console.ReadLine();
        }
    }
}
