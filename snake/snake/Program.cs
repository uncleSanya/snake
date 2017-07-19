using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4,9,'$');
            p1.Draw();

            Point p2 = new Point(1, 5, '@');
            p2.Draw();

            HorLine line = new HorLine(10,30,5,'&');
            line.Draw();

            VertLine newline = new VertLine(20, 5, 15, '&');
            newline.Draw();

            Console.ReadKey();
        }
    }
}
