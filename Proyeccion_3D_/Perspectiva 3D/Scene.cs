using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Perspectiva_3D
{
    public class Scene
    {
        private Figure _fig_;
        public Pen _line_ = new Pen(Color.OrangeRed);
        public int _angle_;

        public Scene(Figure figures)
        {
            _fig_ = figures;
        }

        public void Draw(Graphics graphics, int viewWidth, int viewHeight)
        {
            graphics.Clear(Color.FromArgb(0,0,0));

            // Draw x-axis
            graphics.DrawLine(new Pen(Color.Yellow), 0, viewHeight / 2, viewWidth, viewHeight / 2);

            // Draw y-axis
            graphics.DrawLine(new Pen(Color.Yellow), viewWidth / 2, 0, viewWidth / 2, viewHeight);

            var projected = new Vertex[_fig_.Vertices.Length];
            for (var i = 0; i < _fig_.Vertices.Length; i++)
            {
                var vertex = _fig_.Vertices[i];

                var transformed = vertex.RotateX(0);

                if (_angle_ > 0 && _angle_ < 90)
                {
                    transformed = vertex.RotateX(_angle_);
                }
                else if (_angle_ > 90 && _angle_ < 180)
                {
                    transformed = vertex.RotateY(_angle_);
                }
                else if (_angle_ > 180 && _angle_ < 270)
                {
                    transformed = vertex.RotateZ(_angle_);
                }
                else
                {
                    transformed = vertex.RotateX(_angle_).RotateY(_angle_).RotateZ(_angle_);
                }
                projected[i] = transformed.Project(viewWidth, viewHeight, 256, 6);
            }

            for (var j = 0; j < 6; j++)
            {
                graphics.DrawLine(_line_,
                    (int)projected[_fig_.Faces[j, 0]].X,
                    (int)projected[_fig_.Faces[j, 0]].Y,
                    (int)projected[_fig_.Faces[j, 1]].X,
                    (int)projected[_fig_.Faces[j, 1]].Y);

                graphics.DrawLine(_line_,
                    (int)projected[_fig_.Faces[j, 1]].X,
                    (int)projected[_fig_.Faces[j, 1]].Y,
                    (int)projected[_fig_.Faces[j, 2]].X,
                    (int)projected[_fig_.Faces[j, 2]].Y);

                graphics.DrawLine(_line_,
                    (int)projected[_fig_.Faces[j, 2]].X,
                    (int)projected[_fig_.Faces[j, 2]].Y, 
                    (int)projected[_fig_.Faces[j, 3]].X, 
                    (int)projected[_fig_.Faces[j, 3]].Y);

                graphics.DrawLine(_line_,
                    (int)projected[_fig_.Faces[j, 3]].X, 
                    (int)projected[_fig_.Faces[j, 3]].Y,
                    (int)projected[_fig_.Faces[j, 0]].X, 
                    (int)projected[_fig_.Faces[j, 0]].Y);
            }
            _angle_++;
        }
    }
}
