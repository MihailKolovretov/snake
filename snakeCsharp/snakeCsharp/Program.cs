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
            Point p1 = new Point();
            p1.Draw(8,8,"#");

            Point p2 = new Point();
            p2.Draw(4, 4, "*");

            Console.ReadLine();
        }
    }
}
