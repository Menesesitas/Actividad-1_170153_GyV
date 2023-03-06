
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Graphic_Engine
{
    public class Triangle
    {
        public List<Vertex> Pts = new List<Vertex>();
        public Point[] Pts2D = new Point[3];


        public void Add(Vertex point)
        {
            Pts.Add(point);
        }

        internal void Add(object p)
        {
            throw new NotImplementedException();
        }
    }
}