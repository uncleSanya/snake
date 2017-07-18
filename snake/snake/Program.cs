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

            List < int > kekaem = new List<int>();
            kekaem.Add(1);
            kekaem.Add(4);
            kekaem.Add(7);

            foreach (int i in kekaem)
            {
                Console.WriteLine(i);
            }

            List<p_Draw> kakaem = new List<p_Draw>();
            kakaem.Add(p1);
            kakaem.Add(p2);

            foreach (p_Draw i in kakaem)
            {
                i.Draw();
            }

            Console.ReadKey();
        }
    }
}
