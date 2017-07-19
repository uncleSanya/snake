using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VertLine : Figure
    {
        public VertLine(int x, int yTop, int yBot, char s)
        {
            pline = new List<Point>();
            for (int y=yTop; y<=yBot; y++)
            {
                Point p = new Point(x,y,s);
                pline.Add(p);
            }
        }
    }
}
