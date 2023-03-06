using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Engine
{
    public class Anillo
    {
        public Anillo(float innerRadius, float outerRadius, int numSegments, float height, ref Mesh mesh)
        {
            for (int i = 0; i < numSegments; i++)
            {
                float theta1 = (float)(2 * Math.PI * i / numSegments);
                float x1 = (float)Math.Cos(theta1) * innerRadius;
                float z1 = (float)Math.Sin(theta1) * innerRadius;

                float theta2 = (float)(2 * Math.PI * (i + 1) / numSegments);
                float x2 = (float)Math.Cos(theta2) * innerRadius;
                float z2 = (float)Math.Sin(theta2) * innerRadius;

                float theta3 = (float)(2 * Math.PI * i / numSegments);
                float x3 = (float)Math.Cos(theta3) * outerRadius;
                float z3 = (float)Math.Sin(theta3) * outerRadius;

                float theta4 = (float)(2 * Math.PI * (i + 1) / numSegments);
                float x4 = (float)Math.Cos(theta4) * outerRadius;
                float z4 = (float)Math.Sin(theta4) * outerRadius;

                Vertex a = new Vertex(x1, 0, z1);
                Vertex b = new Vertex(x2, 0, z2);
                Vertex c = new Vertex(x3, height, z3);
                Vertex d = new Vertex(x4, height, z4);

                Triangle t1 = new Triangle();
                t1.Add(a);
                t1.Add(b);
                t1.Add(c);

                Triangle t2 = new Triangle();
                t2.Add(b);
                t2.Add(d);
                t2.Add(c);

                mesh.Figures.Add(t1);
                mesh.Figures.Add(t2);
            }
        }
    }
}
