using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
    class Square : Figures
    {
        public float a { get; set; }
        public Square(float a,float X,float Y)
        {
            this.a = a;
            this.x = X;
            this.y = Y;
        }
        public override float Area()
        {
            return (float)(a * a);
        }
        public override float Perimetr()
        {
            return (float)(4 * a);
        }
        public override void Draw(Pen lul, System.Windows.Forms.Panel kek)
        {
            Graphics g = kek.CreateGraphics();
            g.DrawRectangle(lul, x, y, a, a);
        }
    }
}