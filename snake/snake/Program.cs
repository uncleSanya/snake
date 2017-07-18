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
            int x1 = 2;
            int y1 = 4;
            char s1 = '&';
            
            Draw(x1,y1,s1);

            int x2 = 15;
            int y2 = 3;
            char s2 = '%';

            Draw(x2,y2,s2);

            Console.ReadKey();
        }
        static void Draw(int x, int y, char s)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(s);
        }
    }
}
