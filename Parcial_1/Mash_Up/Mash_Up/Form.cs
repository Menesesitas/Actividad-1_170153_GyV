namespace Mash_Up
{
    public partial class Form : System.Windows.Forms.Form
    {
        static Figure f;
        static States s;
        Point ptX, ptY, mouse;
        PointF inicio, final;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        Canvas canvas;
        Scene scene;

        float deltaX = 0;
        float deltaY = 1;

        bool isMouseDown = false;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;

        const int WM_KEYUP = 0x0101;
        const int WM_KEYDOWN = 0x0100;

        public Form()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;
        }

        private void Init()
        {
            bmpX = new Bitmap(SliderX.Width, SliderX.Height);
            bmpY = new Bitmap(SliderY.Width, SliderY.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            SliderX.Image = bmpX;
            SliderY.Image = bmpY;

            gX.DrawLine(Pens.WhiteSmoke, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.CornflowerBlue, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.WhiteSmoke, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.CornflowerBlue, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            scene = new Scene();
            Figure fig = new Figure();
            fig.Add(new PointF(100, 120));
            fig.Add(new PointF(1400, 120));
            scene.Figures.Add(fig);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)treeView.SelectedNode.Tag;
            AddButton.Select();
        }

        private void SliderY_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            SliderY.Invalidate();
        }

        private void SliderY_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                SliderY.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;//------------------
                ptY.Y = e.Location.Y;
            }
        }
        private void SliderY_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

        private void SliderX_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, SliderX.Height / 2, SliderX.Width, SliderX.Height / 2);
            gX.FillEllipse(Brushes.Aquamarine, SliderX.Width / 2, SliderX.Height / 4, SliderX.Height / 2, SliderX.Height / 2);

            SliderX.Invalidate();
        }
        private void SliderX_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, SliderX.Height / 2, SliderX.Width, SliderX.Height / 2);
                gX.FillEllipse(Brushes.Aquamarine, e.X, SliderX.Height / 4, SliderX.Height / 2, SliderX.Height / 2);

                SliderX.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;
                ptX.X = e.Location.X;
            }
        }

        private void SliderX_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(pictureBox);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (f != null && (IsMouseDownX || IsMouseDownY))
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);
                f.TranslatePoints(f.Centroid);
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            f = new Figure();
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Figure" + (treeView.Nodes.Count + 1));
            node.Tag = f;
            treeView.Nodes.Add(node);
        }

        private void RecButton_Click(object sender, EventArgs e)
        {
            inicio = new PointF(f.Centroid.X, f.Centroid.Y);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            pictureBox.Select();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                mouse = e.Location;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar.Value < 100)
            {
                trackBar.Value = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            final = new PointF(f.Centroid.X, f.Centroid.Y);
            scene = new Scene();
            Figure fig = new Figure();
            fig.Add(inicio);
            fig.Add(final);
            scene.Figures.Add(fig);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void treeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = " ::::::: " + (float)trackBar.Value + "s";
        }
    }
}