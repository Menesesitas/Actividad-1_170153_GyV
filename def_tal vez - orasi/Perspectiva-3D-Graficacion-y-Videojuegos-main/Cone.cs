using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Engine
{
    public class Cone 
    {
        public Vertex top;

        public Cone(int radius, int height, int slices, ref Mesh mesh) 
        {
            top = new Vertex(0,0, height);

            Circle pizzaa = new Circle(radius,0, slices, ref mesh, false);
            int triangleNumber = mesh.Figures.Count;

            for(int i = 0; i < triangleNumber; i++)
            {
                Triangle t = new Triangle();
                t.Add(mesh.Figures[i].Pts[1]);
                t.Add(top);
                t.Add(mesh.Figures[i].Pts[2]);

                mesh.Figures.Add(t);
            }
        }
    }
}
