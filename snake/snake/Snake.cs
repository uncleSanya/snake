﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Snake(Point start, int lenght, Napr napr)
        {
            pline = new List<Point>();
            for (int i = 0; i<lenght; i++)
            {
                Point p = new Point(start);
                p.Move(i, napr);
                pline.Add(p);
            }
        }
    }
}
