using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VertLine
    {
        List<Point> pline;

        public VertLine(int x, int yTop, int yBot, char s)
        {
            pline = new List<Point>();
            for (int y=yTop; y<=yBot; y++)
            {
                Point p = new Point(x,y,s);
                pline.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in pline)
            {
                p.Draw();
            }
        }
    }
}
