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
            p_Draw p1 = new p_Draw();
            p1.x = 4;
            p1.y = 9;
            p1.s = '$';
            p1.Draw();

            p_Draw p2 = new p_Draw();
            p2.x = 1;
            p2.y = 5;
            p2.s = '@';
            p2.Draw();

            Console.ReadKey();
        }
    }
}
