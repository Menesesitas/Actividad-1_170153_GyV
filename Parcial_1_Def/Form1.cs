using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashUp
{
    public partial class Form1 : Form
    {
        static Figure f;
        Point ptX, ptY, mouse;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        Canvas canvas;
        float deltaX = 0;
        float deltaY = 1;
        Scene scene;
        bool isMouseDown = false;
        bool sliderLimit = false;
        private bool play = false;
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;
        }

        private void Init()
        {
            bmpX = new Bitmap(PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height);
            bmpY = new Bitmap(PCT_SLIDEER_Y.Width, PCT_SLIDEER_Y.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            PCT_SLIDEER_X.Image = bmpX;
            PCT_SLIDEER_Y.Image = bmpY;

            gX.DrawLine(Pens.DimGray, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.DarkGreen, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.DarkGreen, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            scene = new Scene();
            canvas = new Canvas(PCT_CANVAS);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        //PCT_CANVAS Methods
        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                //canvas.DrawPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e) //This method activates when a mouse button is pressed on the canvas
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e) //This method activates when a mouse button is released of the canvas
        {
            isMouseDown = false;
            PCT_CANVAS.Select();
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e) //It works when we drag and drop the figure in a certain postion
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                f.UpdateAttributes();
                mouse = e.Location;
            }
        }


        //Transformation Methods 
        //Resize Transformation
        private void sliderY_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.DarkGreen, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            PCT_SLIDEER_Y.Invalidate();
        }

        private void sliderY_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.DarkGreen, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                PCT_SLIDEER_Y.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;
                ptY.Y = e.Location.Y;
            }
        }

        private void sliderY_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

        //Rotation Transformation
        private void sliderX_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        private void sliderX_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
                gX.FillEllipse(Brushes.DarkGreen, e.X, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

                PCT_SLIDEER_X.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;
                f.Arotation += deltaX;
                ptX.X = e.Location.X;
            }
        }

        private void sliderX_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
            gX.FillEllipse(Brushes.DarkGreen, PCT_SLIDEER_X.Width / 2, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

            PCT_SLIDEER_X.Invalidate();
        }


        //Updates
        private void timer1_Tick(object sender, EventArgs e)
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
                    if (counter == 0) {
                        counter = 1;
                        trackBar.Value = trackBar.Minimum;
                    }
                    trackBar.Value++;
                    RunAnimation();
                }
                else if (trackBar.Value > 0 && sliderLimit)
                {
                    trackBar.Value=trackBar.Minimum;
                    RunAnimation();
                }
                else sliderLimit = !sliderLimit;
            }
        }

        private void refresh(Figure figs, float x, float y) 
        {

            if (figs != null)
            {
                figs.TranslateToOrigin();
                figs.Scale(1 / figs.Ascale); 
                figs.Ascale *= 1 / figs.Ascale;
                figs.Scale(y); 
                figs.Rotate(-figs.Arotation + x); 
                figs.Arotation = x; 
                figs.Ascale = y; 
                figs.TranslatePoints(figs.Centroid);
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
        //Add figure Method
        private void ADD_button_Click(object sender, EventArgs e)
        {
            f = new Figure(trackBar.Maximum);
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (treeView1.Nodes.Count + 1));
            node.Tag = f;
            treeView1.Nodes.Add(node);
        }

        private void PLAY_button_Click(object sender, EventArgs e)
        {
            play = !play;

            if (play)
                PLAY_button.Text = "PAUSE";
            else
                PLAY_button.Text = "PLAY";
        }

        private void REC_button_Click(object sender, EventArgs e)
        {
            f.frames[trackBar.Value] = true;
            f.positions[trackBar.Value] = f.Centroid;
            f.rotations[trackBar.Value] = f.Arotation;
            f.sizes[trackBar.Value] = f.Ascale;
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)treeView1.SelectedNode.Tag;
            ADD_button.Select();
        }

        public static bool IsControlDown()
        {
            return (Control.ModifierKeys & Keys.Control) == Keys.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (f == null)
                return false;

            switch (keyData)
            {
                case Keys.Left:
                    f.Centroid.X -= 3;
                    break;
                case Keys.Right:
                    f.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }
            PCT_CANVAS.Select();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        const int WM_KEYDOWN = 0x0100;

        //Animation scroll
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            RunAnimation();
        }
    }
}
