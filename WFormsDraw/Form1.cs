using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace when_the_moon_hits_your_skin
{
    public partial class Form1 : Form
    {
        static int x=0, y=0, h=0, a=0, b=0;

        Pic kartina = new Pic(620,400, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           
            Pen redPen = new Pen(Color.Red, 1);
            Brush redBrush = new SolidBrush(Color.Green);
           

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suma of areas:  " + kartina.SumArea().ToString());
            MessageBox.Show("Suma of perimeters:  " + kartina.SumPerimetr().ToString());
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            x = textBox1.Text == "" ? x = 0 : Convert.ToInt32(textBox1.Text);
            y = textBox2.Text == "" ? y = 0 : Convert.ToInt32(textBox2.Text);
            a = textBox4.Text == "" ? a = 0 : Convert.ToInt32(textBox4.Text);
            b = textBox3.Text == "" ? b = 0 : Convert.ToInt32(textBox3.Text);
            h = textBox5.Text == "" ? h = 0 : Convert.ToInt32(textBox5.Text);

            panel1.Controls.Clear();
            panel1.Refresh();

            Pen redPen = new Pen(Color.Red, 1);
            Brush redBrush = new SolidBrush(Color.Green);
            switch (comboBox1.Text)
            {
                case "Square":

                    Square sponge_bob = new Square(a, x, y);
                    kartina.figurki.Add(sponge_bob);

                    // kartina.figurki[0].Draw(redPen, panel1);
                    sponge_bob.Draw(redPen, panel1);
                    break;
                case "Rectangle":
                    Rect keker = new Rect(a, b, x, y);
                    kartina.figurki.Add(keker);

                    //kartina.figurki[2].Draw(redPen, panel1);
                    keker.Draw(redPen, panel1);
                    break;
                case "Shady Rectangle":

                    Rect_Stretched grill = new Rect_Stretched(a, b, x, y);
                    kartina.figurki.Add(grill);

                    grill.Draw(redPen, panel1);
                    //kartina.figurki[1].Draw(redPen, panel1);

                    break;
                case "Cube":
                    Cube rubick = new Cube(30, 100, 100);
                    kartina.figurki.Add(rubick);
                    rubick.Draw(redPen, panel1);
                    //  kartina.figurki[3].Draw(redPen, panel1);
                    break;
                case "Quad Pyramid":
                    Quad_pyramid squad = new Quad_pyramid(a, h, x, y);
                    kartina.figurki.Add(squad);
                    squad.Draw(redPen, panel1);
                    //  kartina.figurki[4].Draw(redPen, panel1);
                    break;
                case "Cuboid":
                    Cuboid cuba = new Cuboid(a, b, h, x, y);
                    kartina.figurki.Add(cuba);
                    cuba.Draw(redPen, panel1);
                    // kartina.figurki[5].Draw(redPen, panel1);
                    break;
            }
        }


        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        private void shading(Rect_Stretched kek)
        {
            
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
/*
             //прямоугольник
             Rect keker = new Rect(20, 50);
             keker.Draw(redPen, panel1);


              //заштрихованный прямоугольник
           Rect_Stretched grill = new Rect_Stretched(100, 100) { x = 200, y = 200 };
           grill.Draw(redPen,panel1);

             //квадрат
             Square sponge_bob = new Square(150);
             sponge_bob.Draw(redPen, panel1);


             //Куб
             Cube rubick = new Cube(30) { x = 100, y = 100 };
             rubick.Draw(redPen, panel1);

            //Прямоугольный параллелипипед
            Cuboid cuba = new Cuboid(90, 60, 20) { x = 100, y = 100 };
            cuba.Draw(redPen, panel1);


            //Пирамида четырехугольная
           Quad_pyramid squad = new Quad_pyramid(20, 200) { x = 200, y = 200 };
           squad.Draw(redPen, panel1);
           */

/*
Rect keker = new Rect(20, 50,0,0);
Rect_Stretched grill = new Rect_Stretched(100, 100, 200, 200);
Square sponge_bob = new Square(150, 200, 200);
Quad_pyramid squad = new Quad_pyramid(20, 70, 100, 100);
Cube rubick = new Cube(30, 100, 100);
Cuboid cuba = new Cuboid(90, 60, 20, 100, 100);

kartina.figurki.Add(keker);
kartina.figurki.Add(grill);
kartina.figurki.Add(sponge_bob);
kartina.figurki.Add(squad);
kartina.figurki.Add(rubick);
kartina.figurki.Add(cuba);
*/

// MessageBox.Show(kartina.SumArea().ToString());
// MessageBox.Show(kartina.SumPerimetr().ToString());

/*
    panel1.Refresh();
    kartina.figurki[2].Draw(redPen, panel1);
    kartina.Move();

*/


/*
Point kek = new Point(20, 20);
Point rofler = new Point(180, 100);
Point lul1 = new Point(300, 300);
Graphics g = panel1.CreateGraphics();
Point[] lul = new Point[3] { kek, rofler,lul1 };
g.DrawLines(redPen, lul);
*/
//Brush red = new SolidBrush(Color.Red);
//Pen redPen = new Pen(red, 8);

//gObject.DrawEllipse(redPen, 10, 10, 8, 8);
//g.FillRectangle(red, 10, 10, 100, 50);
// g.DrawEllipse()