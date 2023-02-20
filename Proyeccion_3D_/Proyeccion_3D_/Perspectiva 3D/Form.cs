using System.Drawing;
using System.Windows.Forms;

namespace Perspectiva_3D
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Vertex[] _vert_;
        public Scene _scene_;
        public int[,] _faces_;
        public int _angle_;

        public Form()
        {
            InitializeComponent();

            timer1.Start();

            init();

            _scene_ = new Scene(new Figure(_vert_, _faces_));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            _scene_.Draw(g, ClientSize.Width, ClientSize.Height);
        }

        private void init()
        {
            _vert_ = new Vertex[]
            {
                new Vertex(-1, 1, -1),
                new Vertex(1, 1, -1),
                new Vertex(1, -1, -1),
                new Vertex  (-1, -1, -1),
                new Vertex(-1, 1, 1),
                new Vertex(1, 1, 1),
                new Vertex(1, -1, 1),
                new Vertex(-1, -1, 1)
            };

            _faces_ = new int[,]
            {
                {
                    0, 1, 2, 3
                },
                {
                    1, 5, 6, 2
                },
                {
                    5, 4, 7, 6
                },
                {
                    4, 0, 3, 7
                },
                {
                    0, 4, 5, 1
                },
                {
                    3, 2, 6, 7
                }
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            _angle_ += 2;
        }
    }
}