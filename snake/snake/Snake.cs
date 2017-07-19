
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Napr napr;

        public Snake(Point tail, int lenght, Napr napr)
        {
            this.napr = napr;
            pline = new List<Point>();
            for (int i = 0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, napr);
                pline.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pline.First();
            pline.Remove(tail);
            Point head = GetNextPoint();
            pline.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pline.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, napr);
            return nextPoint;
        }
    }
}
