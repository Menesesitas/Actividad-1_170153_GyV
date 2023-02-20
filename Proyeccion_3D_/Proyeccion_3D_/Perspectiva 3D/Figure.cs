using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspectiva_3D
{
    public class Figure
    {
        public Figure(Vertex[] vertex, int[,] faces)
        {
            Vertices = vertex;
            Faces = faces;
        }

        public Vertex[] Vertices { get; set; }

        public int[,] Faces { get; set; }
    }
}
