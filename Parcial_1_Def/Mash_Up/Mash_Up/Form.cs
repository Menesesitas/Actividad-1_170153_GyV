using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mash_Up
{
    public partial class Form : System.Windows.Forms.Form
    {
        static Figure f;
        static States s;
        Point ptX, ptY, mouse;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        Canvas canvas;
        Scene scene;

        float deltaX = 0;
        float deltaY = 1;

        bool isMouseDown = false;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        private bool play = false;
        bool sliderLimit = false;
        int counter = 0;

       /* const int WM_KEYUP = 0x0101;
        const int WM_KEYDOWN = 0x0100;*/

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

            /*scene = new Scene();
            Figure fig = new Figure();
            fig.Add(new PointF(100, 120));
            fig.Add(new PointF(1400, 120));
            scene.Figures.Add(fig);*/
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
            if (f != null) //&& (IsMouseDownX || IsMouseDownY)
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);
                f.TranslatePoints(f.Centroid);
                f.Ascale *= deltaY;
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene); //This option is in charge of indicating the main points of a created figure

            if (play)
            {
                if (trackBar.Value < trackBar.Maximum && !sliderLimit)
                {
                    if (counter == 0)
                    {
                        counter = 1;
                        trackBar.Value = trackBar.Minimum;
                    }
                    trackBar.Value++;
                    RunAnimation();
                }
                else if (trackBar.Value > 0 && sliderLimit)
                {
                    trackBar.Value = trackBar.Minimum;
                    RunAnimation();
                }
                else sliderLimit = !sliderLimit;
            }
        }
        private void RunAnimation()
        {
            if (checkBox1.Checked) foreach (Figure figure in scene.Figures) FigureAnimation(figure);
            else FigureAnimation(f);
        }
        private void FigureAnimation(Figure figs)
        {
            int firstSavedFrame = -1;
            int finalSavedFrame = -1;
            float difference;

            float rotAngle; //Rotation preset on that frame
            float scaleFactor; //How much the size of the figure will increase on that frame

            if (scene.Figures.Count == 0 || figs.frames[trackBar.Value]) return; //It detects if we have created figures before starting an animation
            else
            {
                for (int i = trackBar.Value; i >= 0; i--)
                {
                    if (figs.frames[i])
                    {
                        firstSavedFrame = i;
                        break;
                    }
                }

                for (int i = trackBar.Value; i <= figs.positions.Length - 1; i++)
                {
                    if (figs.frames[i])
                    {
                        finalSavedFrame = i;
                        break;
                    }
                }
            }
            if (firstSavedFrame != -1 && finalSavedFrame != -1) //If there exist an initial and final frame the animation can start
            {

                difference = ((float)trackBar.Value - firstSavedFrame) / (finalSavedFrame - firstSavedFrame);

                rotAngle = ((figs.rotations[finalSavedFrame] - figs.rotations[firstSavedFrame]) * difference) + figs.rotations[firstSavedFrame]; //la rotacion guardada en el frame siguiente (guardado), menos la rotacion del frame anterior (guardado) podemos obtener cuantos grados hay entre ellos. Luego obtejemos el valor del punto en el que estamos con el porcentaje. Finalmente le sumamos los grados del inicio para poder obtener la rotacion inicial
                scaleFactor = ((figs.sizes[finalSavedFrame] - figs.sizes[firstSavedFrame]) * difference) + figs.sizes[firstSavedFrame];

                figs.Follow(figs.positions[firstSavedFrame], figs.positions[finalSavedFrame], difference); //This helps to go to the next point.
                refresh(figs, rotAngle, scaleFactor); //Values are updated even before the tick
            }
        }
        private void refresh(Figure figs, float x, float y) //Funciona igual que el tick, pero solo para guardar valores, así no tenemos que esperar a la computadora para guardar valores
        {

            if (figs != null)
            {
                figs.TranslateToOrigin();
                figs.Scale(1 / figs.Ascale); //Cada que avancemos o retrocedamos un frame de la animación, elimina la escala que tenga volviendola 1
                figs.Ascale *= 1 / figs.Ascale;
                figs.Scale(y); //Para despues modificar la escala por el valor que mandamos a pedir
                figs.Rotate(-figs.Arotation + x); //Cada que avancemos o retrocedamos un frame de la animación, elimina la rotación que tenga dejandolo en el angulo 0, y despues le añade la rotación que mandamos
                figs.Arotation = x; //una vez modificado guardamos la nueva rotacion
                figs.Ascale = y; //una vez modificado guardamos la nueva escala
                figs.TranslatePoints(figs.Centroid);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            f = new Figure(trackBar.Maximum);
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (treeView.Nodes.Count + 1));
            node.Tag = f;
            treeView.Nodes.Add(node);
        }

        private void RecButton_Click(object sender, EventArgs e)
        {
            f.frames[trackBar.Value] = true;
            f.positions[trackBar.Value] = f.Centroid;
            f.rotations[trackBar.Value] = f.Arotation;
            f.sizes[trackBar.Value] = f.Ascale;
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
            play = !play;

            if (play)
                PlayButton.Text = "PAUSE";
            else
                PlayButton.Text = "PLAY ANIMATION";
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
                s.AddS(new PointF(e.X, e.Y));
            }
        }

        private void treeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            RunAnimation();
        }
    }
}