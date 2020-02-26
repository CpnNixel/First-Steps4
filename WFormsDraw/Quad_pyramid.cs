using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
    //пирамида четырехугольная
    class Quad_pyramid :Figures
    {
        public float a { get; set; }
        public float h { get; set; }
        //грань
        public float b { get; set; }
        public float radius { get; set; }
        public Quad_pyramid(float a_,float h_,float X, float Y)
        {
            this.a = a_;
            this.h = h_;
            this.x = X;
            this.y = Y;

            this.radius = (float)(a / 2);
            this.b = (float)Math.Sqrt(h_ * h_ + this.radius*this.radius);
        }
       
        public float Volume()
        {
            //1/3 * h*a^2
            return (float)((h * a * a) / 3);
        }
        public override float Area()
        {
            return (float)(a * a + 2 * a * Math.Sqrt(b * b - radius * radius));
        }
        public override float Perimetr()
        {
            return (float)(((Math.Sqrt(3)) / 4) * a * a);
        }
      
        public  override void Draw(Pen lul, System.Windows.Forms.Panel kek)
        {
            //рисуем первый квадрат
            Graphics g = kek.CreateGraphics();
           // g.DrawRectangle(lul, x, y, a, b);

            //находим все его точки
            Point one = new Point((int)x, (int)y);
            Point two = new Point((int)(x+a), (int)(y));
            Point three = new Point((int)(x+a+a/2), (int)(y+Math.Sqrt(2)*a)/2);
            Point four = new Point((int)(x+a/2), (int)(y + Math.Sqrt(2) * a)/2);


            Point r = new Point((int)((x + a + a / 2)-x), (int)(y-h));
            // Point r2 = new Point((int)(((x + (x + a + a / 2)) / 2) + h), ((int)(((x + (x + a + a / 2)) / 2) - h)));
            //A,B,C,D
           

            g.DrawLine(lul, four, three);
          
            g.DrawLine(lul, one, four);

            //H
            //g.DrawLine(lul, r, r2);
            //AH,BH,CH,DH
            g.DrawLine(lul, one, r);

            g.DrawLine(lul, three, r);
            g.DrawLine(lul, four, r);

            lul.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            lul.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            g.DrawLine(lul, one, two);
            g.DrawLine(lul, three, two);
            g.DrawLine(lul, two, r);
        }
    }
}
