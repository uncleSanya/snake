using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorLine : Figure
    {
        public HorLine(int xLeft, int xRight, int y, char s)
        {
            pline = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,s);
                pline.Add(p);
            }
        }
    }
}
