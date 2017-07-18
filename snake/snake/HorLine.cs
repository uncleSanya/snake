using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorLine
    {
        List<p_Draw> pline;

        public HorLine()
        {
            pline = new List<p_Draw>();
            p_Draw p1 = new p_Draw(5, 5, '*');
            p_Draw p2 = new p_Draw(6, 5, '*');
            p_Draw p3 = new p_Draw(7, 5, '*');
            pline.Add(p1);
            pline.Add(p2);
            pline.Add(p3);
        }
        public void Draw()
        {
            foreach (p_Draw i in pline)
            {
                i.Draw();
            }
        }
    }
}
