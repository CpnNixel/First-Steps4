using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
    class Rect_Stretched : Rect
    {
        public bool is_streched = true;
        public Rect_Stretched(float a, float b, float X, float Y) :base(a,b,X,Y)
        {
        }
        public override void Draw(Pen lul, System.Windows.Forms.Panel kek)
        {
            Graphics g = kek.CreateGraphics();
            g.DrawRectangle(lul, x, y, a, b);

            Point one = new Point((int)x, (int)y);
            Point d = new Point((int)(x + a), (int)(y + b));

            Point two = new Point((int)x, (int)(y+b/2));
            Point d2 = new Point((int)(x + a/2), (int)(y + b));

            Point three = new Point((int)(x+b/2), (int)(y ));
            Point d3 = new Point((int)(x + a), (int)(y + b/2));


            g.DrawLine(lul, one, d);
            g.DrawLine(lul, two, d2);
            g.DrawLine(lul, three, d3);

        }
    }
}
