using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
    class Cube : Figures 
    {
        public float a { get; set; }
        public float area { get; set; }
        public float volume { get; set; }
        public Cube(float a_,float X, float Y)
        {
            this.a = a_;
            this.x = X;
            this.y = Y;
            this.area = (float)(6 * a_ * a_);
            this.volume = (float)(a_ * a_ * a_);

        }
        public override float Perimetr()
        {
            return (float)(12 * a);
        }
        public override float Area()
        {
            return (float)((6 * a * a));
        }
        public float Volume()
        {
            return (float)(a * a * a);
        }
        public override void Draw(Pen lul, System.Windows.Forms.Panel kek)
        {
            //рисуем первый квадрат
            Graphics g = kek.CreateGraphics();
            g.DrawRectangle(lul, x, y, a, a);

            //находим все его точки
            Point one = new Point((int)x, (int)y);
            Point one2 = new Point((int)(x + a), (int)y);
            //* *

            //* *
            Point two = new Point((int)x, (int)(y + a));
            Point two2 = new Point((int)(x + a), (int)(y + a));

            //рисуем переехавший квадрат
            g.DrawRectangle(lul, x+a/2, y+a/2, a, a);
            //находим все его точки
            Point three = new Point((int)(x + a / 2), (int)(y + a / 2));
            Point three2 = new Point((int)(a+ x + a / 2), (int)(y + a / 2));
            //* *

            //* *
            Point four = new Point((int)(x + a / 2), (int)(a +y + a / 2));
            Point four2 = new Point((int)(a + x + a / 2), (int)(a + y + a / 2));

            //коннектим линиями первый ряд точек со вторым
            g.DrawLine(lul, one, three);
            g.DrawLine(lul, one2, three2);

            g.DrawLine(lul, two, four);
            g.DrawLine(lul, two2, four2);

            //g.DrawLine(lul, one, two2);



            //  Point one = new Point()
            // g.DrawRectangle(lul, x, y, a, b);
        }
    }
}
