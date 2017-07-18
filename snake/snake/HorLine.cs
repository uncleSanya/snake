using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorLine
    {
        List<Point> pline;

        public HorLine()
        {
            pline = new List<Point>();
            Point p1 = new Point(5, 5, '*');
            Point p2 = new Point(6, 5, '*');
            Point p3 = new Point(7, 5, '*');
            pline.Add(p1);
            pline.Add(p2);
            pline.Add(p3);
        }
        public void Draw()
        {
            foreach (Point i in pline)
            {
                i.Draw();
            }
        }
    }
}
