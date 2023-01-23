using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_2
{
    public partial class Form1 : Form
    {
        static Bitmap bmp;
        static Graphics g;

        Point a, b, c, d; // Cuadrado 1
        Point r, t, f, h; // Cuadrado 2
        Point u, i, o, p; // Cuadrado 3
        Point x, y, z, w; // Rotación

        double angle;
        Point pivot;
        bool sqr1Selected = true;
        bool sqr2Selected = true;
        bool sqr3Selected = true;

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqr1Selected)
            {
                sqr1Selected = false;
                sqr2Selected = true;
                sqr3Selected = false;
            }
            else if (sqr2Selected)
            {
                sqr1Selected = false;
                sqr2Selected = false;
                sqr3Selected = true;
            }
            else if (sqr3Selected)
            {
                sqr1Selected = true;
                sqr2Selected = false;
                sqr3Selected = false;
            }
            g.Clear(Color.Black);
            Renderplane();
            if (sqr1Selected)
            {
                RenderSqr(a, b, c, d);
            }
            else if (sqr2Selected)
            {
                RenderSqr2(r, t, f, h);
            }
            else if (sqr3Selected)
            {
                RenderSqr3(u, i, o, p);
            }
            /*sqr1Selected = !sqr1Selected;
            g.Clear(Color.Black);
            Renderplane();
            if (sqr1Selected)
            {
                RenderSqr(a, b, c, d);
            }
            else
            {
                RenderSqr2(r, t, f, h);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text;
            angle = Convert.ToInt32(textBox1.Text);
            angle = -(angle * Math.PI / 180);
            g.Clear(Color.Black);
            Renderplane();
            if (sqr1Selected)
            {
                Rota1();
                RenderSqr(x, y, z, w);
            }
            else if (sqr2Selected)
            {
                Rota2();
                RenderSqr2(x, y, z, w);
            }
            else if (sqr3Selected)
            {
                Rota3();
                RenderSqr3(x, y, z, w);
            }

        }

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pivot = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            Renderplane();

            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            a = new Point(centerX, centerY);
            b = new Point(centerX + 50, centerY);
            c = new Point(centerX + 50, centerY - 50);
            d = new Point(centerX, centerY - 50);

            RenderSqr(a, b, c, d);

            r = new Point(centerX - 25, centerY - 25);
            t = new Point(centerX + 25, centerY - 25);
            f = new Point(centerX + 25, centerY + 25);
            h = new Point(centerX - 25, centerY + 25);

            RenderSqr2(r, t, f, h);

            u = new Point(centerX + 5, centerY - 35);
            i = new Point(centerX + 55, centerY - 35);
            o = new Point(centerX + 55, centerY + 15);
            p = new Point(centerX + 5, centerY + 15);

            RenderSqr3(u, i, o, p);

        }

        private void Renderplane()
        {
            g.DrawLine(Pens.Yellow, new Point(pictureBox1.Width / 2, 0), new Point(pictureBox1.Width / 2, pictureBox1.Height));
            g.DrawLine(Pens.Yellow, new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2));
        }
        private void RenderSqr(Point a, Point b, Point c, Point d)
        {
            g.DrawLine(Pens.Red, a, b);
            g.DrawLine(Pens.Red, b, c);
            g.DrawLine(Pens.Red, c, d);
            g.DrawLine(Pens.Red, d, a);

            pictureBox1.Invalidate();
        }

        private void RenderSqr2(Point r, Point t, Point f, Point h)
        {
            g.DrawLine(Pens.Red, r, t);
            g.DrawLine(Pens.Red, t, f);
            g.DrawLine(Pens.Red, f, h);
            g.DrawLine(Pens.Red, h, r);

            pictureBox1.Invalidate();
        }

        private void RenderSqr3(Point u, Point i, Point o, Point p)
        {
            g.DrawLine(Pens.Red, u, i);
            g.DrawLine(Pens.Red, i, o);
            g.DrawLine(Pens.Red, o, p);
            g.DrawLine(Pens.Red, p, u);

            pictureBox1.Invalidate();
        }

        private void Rota1()
        {
            x.X = (int)(((a.X - pivot.X) * Math.Cos(angle)) - ((a.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            x.Y = (int)(((a.X - pivot.X) * Math.Sin(angle)) + ((a.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            y.X = (int)(((b.X - pivot.X) * Math.Cos(angle)) - ((b.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            y.Y = (int)(((b.X - pivot.X) * Math.Sin(angle)) + ((b.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            z.X = (int)(((c.X - pivot.X) * Math.Cos(angle)) - ((c.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            z.Y = (int)(((c.X - pivot.X) * Math.Sin(angle)) + ((c.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            w.X = (int)(((d.X - pivot.X) * Math.Cos(angle)) - ((d.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            w.Y = (int)(((d.X - pivot.X) * Math.Sin(angle)) + ((d.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
        }
        private void Rota2()
        {
            x.X = (int)(((r.X - pivot.X) * Math.Cos(angle)) - ((r.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            x.Y = (int)(((r.X - pivot.X) * Math.Sin(angle)) + ((r.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            y.X = (int)(((t.X - pivot.X) * Math.Cos(angle)) - ((t.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            y.Y = (int)(((t.X - pivot.X) * Math.Sin(angle)) + ((t.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            z.X = (int)(((f.X - pivot.X) * Math.Cos(angle)) - ((f.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            z.Y = (int)(((f.X - pivot.X) * Math.Sin(angle)) + ((f.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            w.X = (int)(((h.X - pivot.X) * Math.Cos(angle)) - ((h.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            w.Y = (int)(((h.X - pivot.X) * Math.Sin(angle)) + ((h.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
        }
        private void Rota3()
        {
            x.X = (int)(((u.X - pivot.X) * Math.Cos(angle)) - ((u.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            x.Y = (int)(((u.X - pivot.X) * Math.Sin(angle)) + ((u.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            y.X = (int)(((i.X - pivot.X) * Math.Cos(angle)) - ((i.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            y.Y = (int)(((i.X - pivot.X) * Math.Sin(angle)) + ((i.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            z.X = (int)(((o.X - pivot.X) * Math.Cos(angle)) - ((o.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            z.Y = (int)(((o.X - pivot.X) * Math.Sin(angle)) + ((o.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
            w.X = (int)(((p.X - pivot.X) * Math.Cos(angle)) - ((p.Y - pivot.Y) * Math.Sin(angle)) + pivot.X);
            w.Y = (int)(((p.X - pivot.X) * Math.Sin(angle)) + ((p.Y - pivot.Y) * Math.Cos(angle)) + pivot.Y);
        }
    }
}
