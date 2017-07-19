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
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80,25);

            HorLine upline = new HorLine(0,78,0,'*');
            upline.Draw();

            VertLine leftline = new VertLine(0, 0, 24, '*');
            leftline.Draw();

            HorLine downline = new HorLine(0, 78, 24, '*');
            downline.Draw();

            VertLine rightline = new VertLine(78, 0, 24, '*');
            rightline.Draw();

            Console.ReadKey();
        }
    }
}
