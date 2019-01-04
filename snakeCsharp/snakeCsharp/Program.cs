using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Program
    {
        static void Draw(int x, int y, string simb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 4;
            string simb1 = "*";

            Draw(x1,y1,simb1);


            int x2 = 2;
            int y2 = 6;
            string simb2 = "#";
            Draw(x2, y2, simb2);



            Console.ReadLine();
        }
    }
}
