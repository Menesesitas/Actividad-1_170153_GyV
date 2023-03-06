using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphical_Engine;

namespace Graphic_Engine
{
    public class Canvas
    {

        Opt canvas;
        PictureBox PCT_CANVAS;
        int hWidth, hHeight;
        Point a, b, c, d;

        Scene scene;
        Mesh mesh;
        Triangle f1, f2, f3, f4, f5, f6, f1D, f2D, f3D, f4D, f5D, f6D; 
        Matrix m;
        Vertex camera;
        Vertex[] normal, line1, line2;
        Double[] l;
        Cone cono;

        public Canvas(PictureBox pct)
        {
            PCT_CANVAS = pct;
            canvas = new Opt(PCT_CANVAS.Size);
            pct.Image = canvas.bitmap;

            scene = new Scene();
            mesh = new Mesh();
            m = new Matrix();
            scene.Meshes.Add(mesh);

            canvas.FastClear();
            PCT_CANVAS.Invalidate();
            
        }

        public void drawMidPoint()
        {
            hWidth = (int)(PCT_CANVAS.Width / 2f);
            hHeight = (int)(PCT_CANVAS.Height / 2f);

            a = new Point(hWidth - hWidth, hHeight);
            b = new Point(hWidth + hWidth, hHeight);
            c = new Point(hWidth, hHeight - hHeight);
            d = new Point(hWidth, hHeight + hHeight);

            canvas.DrawLine(a, b, Color.Yellow);
            canvas.DrawLine(c, d, Color.Yellow);

            PCT_CANVAS.Invalidate();
        }

        public void Cono()
        {
            cono = new Cone(1, 2, 25, ref mesh);
            line1 = new Vertex[mesh.Figures.Count];
            line2 = new Vertex[mesh.Figures.Count];
            normal = new Vertex[mesh.Figures.Count];
            l = new double[mesh.Figures.Count];
            camera = new Vertex(0, 0, 3);

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
                normal[i].X /= (float)l[i]; normal[i].Y /= (float)l[i]; normal[i].Z /= (float)l[i];
            }

            Render();
        }

        public void Cilindro()
        {
            Cilinder cylinder = new Cilinder(1, 3, 25, ref mesh);

            line1 = new Vertex[mesh.Figures.Count];
            line2 = new Vertex[mesh.Figures.Count];
            normal = new Vertex[mesh.Figures.Count];
            l = new double[mesh.Figures.Count];
            camera = new Vertex(0, 0, 3);

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
            }

            Render();
        }

        public void Esfera() //This method generates a sphere
        {
            Sphere sphere = new Sphere(2, 90, ref mesh);

            line1 = new Vertex[mesh.Figures.Count];
            line2 = new Vertex[mesh.Figures.Count];
            normal = new Vertex[mesh.Figures.Count];
            l = new double[mesh.Figures.Count];
            camera = new Vertex(0, 0, 3);

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
            }

            Render();
        }

        public void Anillo() // This method generates a ring
        {
            Anillo ring = new Anillo(2, 1.75f, 50, 1, ref mesh);

            line1 = new Vertex[mesh.Figures.Count];
            line2 = new Vertex[mesh.Figures.Count];
            normal = new Vertex[mesh.Figures.Count];
            l = new double[mesh.Figures.Count];
            camera = new Vertex(0, 0, 3);

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
            }

            Render();
        }

        
        public void Render() //The method tranform 3D points into 2D points, clears the canvas, and draws the faces of the cube inside the canvas with the 2D points
        {
            canvas.FastClear();
            drawMidPoint();

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                mesh.Figures[i].Pts2D[0] = new Point((int)(hWidth + (150 * (mesh.Figures[i].Pts[0].X / (3 - mesh.Figures[i].Pts[0].Z)))), (int)(hHeight + (150 * (mesh.Figures[i].Pts[0].Y / (3 - mesh.Figures[i].Pts[0].Z)))));
                mesh.Figures[i].Pts2D[1] = new Point((int)(hWidth + (150 * (mesh.Figures[i].Pts[1].X / (3 - mesh.Figures[i].Pts[1].Z)))), (int)(hHeight + (150 * (mesh.Figures[i].Pts[1].Y / (3 - mesh.Figures[i].Pts[1].Z)))));
                mesh.Figures[i].Pts2D[2] = new Point((int)(hWidth + (150 * (mesh.Figures[i].Pts[2].X / (3 - mesh.Figures[i].Pts[2].Z)))), (int)(hHeight + (150 * (mesh.Figures[i].Pts[2].Y / (3 - mesh.Figures[i].Pts[2].Z)))));
            }

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                if (normal[i].X * (mesh.Figures[i].Pts[0].X - camera.X) + normal[i].Y * (mesh.Figures[i].Pts[0].Y - camera.Y) + normal[i].Z * (mesh.Figures[i].Pts[0].Z - camera.Z) < 0)
                {
                    //canvas.DrawFilledTriangle(mesh.Figures[i].Pts2D[0], mesh.Figures[i].Pts2D[1], mesh.Figures[i].Pts2D[2], Color.FromArgb(32, 194, 14)); //It possible to use this method rather than "DrawWireframeTraingle" in order to draw the figures, but with the difference that the figures have a filling color.
                    canvas.DrawWireFrameTriangle(mesh.Figures[i].Pts2D[0], mesh.Figures[i].Pts2D[1], mesh.Figures[i].Pts2D[2], Color.FromArgb(150, 50, 255));
                }
            }
            PCT_CANVAS.Invalidate();
        }
            

        //The next three methods are for rotating the cube on the X, Y, and Z axis respectively

        public void RotationX()
        {

            for(int i = 0; i < mesh.Figures.Count; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mesh.Figures[i].Pts[j] = new Vertex(m.rotMatrix_X[0, 0] * mesh.Figures[i].Pts[j].X, (m.rotMatrix_X[1, 1] * mesh.Figures[i].Pts[j].Y) + (m.rotMatrix_X[1, 2] * mesh.Figures[i].Pts[j].Z), (m.rotMatrix_X[2, 1] * mesh.Figures[i].Pts[j].Y) + (m.rotMatrix_X[2, 2] * mesh.Figures[i].Pts[j].Z));
                }
            }

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
                normal[i].X /= (float)l[i]; normal[i].Y /= (float)l[i]; normal[i].Z /= (float)l[i];
            }
            Render();
        }

        public void RotationY()
        {
            for(int i =0; i < mesh.Figures.Count; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mesh.Figures[i].Pts[j] = new Vertex((m.rotMatrix_Y[0, 0] * mesh.Figures[i].Pts[j].X) + (m.rotMatrix_Y[0, 2] * mesh.Figures[i].Pts[j].Z), m.rotMatrix_Y[1, 1] * mesh.Figures[i].Pts[j].Y, ((m.rotMatrix_Y[2, 0] * mesh.Figures[i].Pts[j].X) + (m.rotMatrix_Y[2, 2] * mesh.Figures[i].Pts[j].Z)));// (m.rotMatrix_X[2, 1] * mesh.Figures[i].Pts[j].Y) + (m.rotMatrix_X[2, 2] * mesh.Figures[i].Pts[j].Z));
                }
            }

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
                normal[i].X /= (float)l[i]; normal[i].Y /= (float)l[i]; normal[i].Z /= (float)l[i];
            }
            Render();
        }

        public void RotationZ()
        {

            for(int i = 0; i < mesh.Figures.Count; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mesh.Figures[i].Pts[j] = new Vertex(((m.rotMatrix_Z[0, 0] * mesh.Figures[i].Pts[j].X) + (m.rotMatrix_Z[0, 1] * mesh.Figures[i].Pts[j].Y)), ((m.rotMatrix_Z[1, 0] * mesh.Figures[i].Pts[j].X) + (m.rotMatrix_Z[1, 1] * mesh.Figures[i].Pts[j].Y)), m.rotMatrix_Z[2, 2] * mesh.Figures[i].Pts[j].Z);
                }
            }

            for (int i = 0; i < mesh.Figures.Count; i++)
            {
                line1[i] = new Vertex(mesh.Figures[i].Pts[1].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[1].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[1].Z - mesh.Figures[i].Pts[0].Z);
                line2[i] = new Vertex(mesh.Figures[i].Pts[2].X - mesh.Figures[i].Pts[0].X, mesh.Figures[i].Pts[2].Y - mesh.Figures[i].Pts[0].Y, mesh.Figures[i].Pts[2].Z - mesh.Figures[i].Pts[0].Z);
                normal[i] = new Vertex(line1[i].Y * line2[i].Z - line1[i].Z * line2[i].Y, line1[i].Z * line2[i].X - line1[i].X * line2[i].Z, line1[i].X * line2[i].Y - line1[i].Y * line2[i].X);
                l[i] = Math.Sqrt((normal[i].X * normal[i].X) + (normal[i].Y * normal[i].Y) + (normal[i].Z * normal[i].Z));
                normal[i].X /= (float)l[i]; normal[i].Y /= (float)l[i]; normal[i].Z /= (float)l[i];
            }
            Render();
        }
    }
}