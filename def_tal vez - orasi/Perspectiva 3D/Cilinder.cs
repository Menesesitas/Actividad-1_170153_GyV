﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Engine
{
    public class Cilinder
    {
        public Cilinder(int radious, int height, int slices, ref Mesh mesh)
        {

            //Base
            Circle pizzaB = new Circle(radious,-1, slices, ref mesh, false);
            int totalTrianglesB = mesh.Figures.Count;

            //Top
            Circle pizzaT = new Circle(radious,height -1, slices, ref mesh, true);

            int triangleNumber = mesh.Figures.Count;

            for (int i = 0; i < triangleNumber ; i++)
            {
                Triangle t = new Triangle();
                
                t.Add(mesh.Figures[i].Pts[1]);
                t.Add(mesh.Figures[i + totalTrianglesB].Pts[1]);
                t.Add(mesh.Figures[i].Pts[2]);

                mesh.Figures.Add(t);
            }

            for (int i = 0; i < triangleNumber; i++)
            {
                Triangle t2 = new Triangle();
                t2.Add(mesh.Figures[i + totalTrianglesB].Pts[1]);
                t2.Add(mesh.Figures[i].Pts[1]);
                t2.Add(mesh.Figures[i + totalTrianglesB].Pts[2]);

                mesh.Figures.Add(t2);
            }
        }
    }
}
