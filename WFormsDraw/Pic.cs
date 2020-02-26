using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace when_the_moon_hits_your_skin
{
    class Pic
    {
        public float posX { get; set; }
        public float posY { get; set; }
        public float a { get; set; }
        public float b { get; set; }
        public List<Figures> figurki = new List<Figures>();

        public Pic( float A, float B, float x, float y)
        {
            posX = x;
            posY = y;
            a = A;
            b = B;
        }
        public float SumArea()
        {
            float sum = 0;
            foreach(Figures another_one in figurki)
            {
                sum += another_one.Area();
            }
            return sum;
        }
        public float SumPerimetr()
        {
            float sum = 0;
            foreach (Figures another_one in figurki)
            {
                sum += another_one.Perimetr();
            }
            return sum;
        }
        public void Move()
        {
            foreach (Figures another_one in figurki)
            {
                another_one.y -= 10;
            }
        }
    }
}
