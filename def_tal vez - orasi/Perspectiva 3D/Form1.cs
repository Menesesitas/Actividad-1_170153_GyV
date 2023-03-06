using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Engine
{
    public partial class Form1 : Form
    {

        Canvas canvas;
        bool xRotation = true;
        bool yRotation = false;
        bool zRotation = false;
        int rotationCount = 0;

        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(PCT_CANVAS);
            canvas.drawMidPoint();
 
            //canvas.Cono();
            //canvas.Cilindro();
            //canvas.Esfera();
            canvas.Anillo();

            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            {
                if (rotationCount < 90)
                {
                    canvas.RotationX();
                }
                else if (rotationCount < 180)
                {
                    canvas.RotationY();
                }
                else if (rotationCount < 270)
                {
                    canvas.RotationZ();
                }
                else
                {
                    canvas.RotationX();
                    canvas.RotationY();
                    canvas.RotationZ();
                }

                rotationCount++;

                if (rotationCount == 360)
                {
                    rotationCount = 0;
                }
            }

        }
    }
}
