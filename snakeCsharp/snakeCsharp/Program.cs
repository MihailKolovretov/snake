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

            HorisontalLines Upline = new HorisontalLines(0, 79, 0, "+");
            Upline.Draw();
            HorisontalLines Downline = new HorisontalLines(0, 79, 24, "+");
            Downline.Draw();
            VerticalLines Leftline = new VerticalLines(0, 24, 0, "#");
            Leftline.Draw();
            VerticalLines Rightline = new VerticalLines(0, 24, 79, "#");
            Rightline.Draw();
            Console.ReadLine();
        }
    }
}
