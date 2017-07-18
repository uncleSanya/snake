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
            p_Draw p1 = new p_Draw(4,9,'$');
            p1.Draw();

            p_Draw p2 = new p_Draw(1, 5, '@');
            p2.Draw();

            Console.ReadKey();
        }
    }
}
