using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace when_the_moon_hits_your_skin
{
   
    abstract class Figures
    {
        public float x, y;
        public abstract float Area();
        public abstract float Perimetr();

        public abstract void Draw(Pen lul, System.Windows.Forms.Panel kek);
    }
}
