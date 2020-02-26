using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
    //прямоугольный параллелепипед
    class Cuboid : Figures
    {
        public float a { get; set; }
        public float b { get; set; }
        public float h { get; set; }
        public float area { get; set; }
        public float volume { get; set; }
        public Cuboid(float a_, float b_, float h_,float X, float Y)
        {
            this.a = a_;
            this.b = b_;
            this.h = h_;
            this.x = X;
            this.y = Y;

            // 2(ab + bc + ac).
            this.area = (2 * ((a_ * b_) + (b_ * h_) + (a_ * h_)));
            //V = a*b*c;
            this.volume = a_ * b_ * h_;
        }
        public override float Perimetr()
        {
            //4*(a+b+c)
            return (float)(4 * (a+b+h));
        }
        public override float Area()
        {
            // 2(ab + bc + ac).
            return (float)(2*(a * b + b * h + a * h));
        }
        public float Volume()
        {
            return (float)(a * b * h);
        }
        public override void Draw(Pen lul, System.Windows.Forms.Panel kek)
        {
            //рисуем первый квадрат
            Graphics g = kek.CreateGraphics();

            //находим все его точки
            Point one = new Point((int)x, (int)y);
            Point one2 = new Point((int)(x + a), (int)y);
            //* *

            //* *
            Point two = new Point((int)x, (int)(y + b));
            Point two2 = new Point((int)(x + a), (int)(y + b));

            //рисуем переехавший квадрат
            g.DrawRectangle(lul, x + h, y + h, a, b);
            
            
            //находим все его точки
            Point three = new Point((int)(x + h), (int)(y + h));
            Point three2 = new Point((int)(a + x +h), (int)(y + h));
            //* *

            //* *
            Point four = new Point((int)(x + h), (int)(b + y + h));
            Point four2 = new Point((int)(a+x + h), (int)(b+y + h));

            //коннектим линиями первый ряд точек со вторым
           g.DrawLine(lul, one, three);
           g.DrawLine(lul, one2, three2);

            g.DrawLine(lul, two, four);

            lul.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            lul.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            g.DrawLine(lul, two2, four2);

            g.DrawRectangle(lul, x, y, a, b);
        }
    }
}
