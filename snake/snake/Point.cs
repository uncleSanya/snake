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

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
