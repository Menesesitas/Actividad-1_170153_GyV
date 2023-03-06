using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Engine
{
    public class Circle
    {
        public Circle(int radius,int height, int slices, ref Mesh mesh, bool front)
        {
            double initialAngle = 0;
            double finalAngle = (360 / slices) * (Math.PI / 180);

            if (front)
            {
                for (int i = 0; i < slices; i++)
                {
                    Triangle t = new Triangle(); 
                    t.Add(new Vertex(0, 0, height));
                    t.Add(new Vertex((float)(radius * Math.Cos(initialAngle)), (float)(radius * Math.Sin(initialAngle)), height));
                    t.Add(new Vertex((float)(radius * Math.Cos(finalAngle)), (float)(radius * Math.Sin(finalAngle)), height));

                    mesh.Figures.Add(t);

                    initialAngle = finalAngle;
                    finalAngle += (360.0 / slices) * (Math.PI / 180.0);
                }
            }
            else
            {
                for (int i = 0; i < slices; i++)
                {
                    Triangle t = new Triangle();
                    t.Add(new Vertex(0, 0, height));
                    t.Add(new Vertex((float)(radius * Math.Cos(finalAngle)), (float)(radius * Math.Sin(finalAngle)), height));
                    t.Add(new Vertex((float)(radius * Math.Cos(initialAngle)), (float)(radius * Math.Sin(initialAngle)), height));

                    mesh.Figures.Add(t);

                    initialAngle = finalAngle;
                    finalAngle += (360.0 / slices) * (Math.PI / 180.0);
                }
            }
        }

        public object Figures { get; internal set; }
    }
}
