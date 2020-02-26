using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
    class Rect : Figures
    {
        public float a { get; set; }
        public float b { get; set; }
        public Rect(float a, float b, float X, float Y){
            this.a = a;
            this.b = b;
            this.x = X;
            this.y = Y;
        }
        public override float Area()
        {
            return (float)(a * b);
        }
        public override float Perimetr()
        {
            return (float)(2 * (a + b));
        }
        public override void Draw(Pen lul, System.Windows.Forms.Panel kek)
        {
            Graphics g = kek.CreateGraphics();
            g.DrawRectangle(lul, x, y, a, b);
        }
        
    }
    
}
