using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char s;

        public Point(int x, int y, char s)
        {
            this.x = x;
            this.y = y;
            this.s = s;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            s = p.s;
        }

        public void Move(int i, Napr napr)
        {
            if (napr == Napr.RIGHT)
            {
                x += i;
            }

            if (napr == Napr.LEFT)
            {
                x -= i;
            }

            if (napr == Napr.UP)
            {
                y -= i;
            }

            if (napr == Napr.DOWN)
            {
                y += i;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        public override string ToString()
        {
            return x+","+y+","+s;
        }
    }
}
