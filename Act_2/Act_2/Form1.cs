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

        Point a, b, c, d; // Cuadrado
        Point x, y, z, w; // Rotación
        double angle;
        Point pivot;


        private void button1_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text;
            angle = Convert.ToInt32(textBox1.Text);
            angle = -(angle * Math.PI / 180);
            Rota();
            g.Clear(Color.Black);
            Renderplane();
            RenderSqr(x, y, z, w);
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

        private void Rota()
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
    }
}
