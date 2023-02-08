namespace Mash_Up
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RecButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SliderX = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SliderY = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderX)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mash Up 2023 UDLAP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 100);
            this.panel1.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.AddButton.CausesValidation = false;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(14, 806);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 35);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add Figure";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RecButton
            // 
            this.RecButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.RecButton.ForeColor = System.Drawing.Color.White;
            this.RecButton.Location = new System.Drawing.Point(12, 847);
            this.RecButton.Name = "RecButton";
            this.RecButton.Size = new System.Drawing.Size(125, 35);
            this.RecButton.TabIndex = 4;
            this.RecButton.Text = "Record State";
            this.RecButton.UseVisualStyleBackColor = false;
            this.RecButton.Click += new System.EventHandler(this.RecButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(14, 924);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(125, 35);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.trackBar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(173, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1725, 888);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pictureBox.Location = new System.Drawing.Point(13, 72);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1615, 721);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(13, 10);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(1615, 56);
            this.trackBar.TabIndex = 0;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.SliderX);
            this.panel3.Location = new System.Drawing.Point(14, 799);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1614, 75);
            this.panel3.TabIndex = 4;
            // 
            // SliderX
            // 
            this.SliderX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SliderX.Location = new System.Drawing.Point(20, 24);
            this.SliderX.Name = "SliderX";
            this.SliderX.Size = new System.Drawing.Size(1572, 25);
            this.SliderX.TabIndex = 3;
            this.SliderX.TabStop = false;
            this.SliderX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SliderX_MouseDown);
            this.SliderX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SliderX_MouseMove);
            this.SliderX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderX_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.SliderY);
            this.panel4.Location = new System.Drawing.Point(1635, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 864);
            this.panel4.TabIndex = 8;
            // 
            // SliderY
            // 
            this.SliderY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SliderY.Location = new System.Drawing.Point(26, 23);
            this.SliderY.Name = "SliderY";
            this.SliderY.Size = new System.Drawing.Size(25, 815);
            this.SliderY.TabIndex = 2;
            this.SliderY.TabStop = false;
            this.SliderY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SliderY_MouseDown);
            this.SliderY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SliderY_MouseMove);
            this.SliderY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderY_MouseUp);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 957);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView.ForeColor = System.Drawing.Color.White;
            this.treeView.Location = new System.Drawing.Point(0, 100);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(150, 700);
            this.treeView.TabIndex = 8;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView_KeyPress);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.StopButton.CausesValidation = false;
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(13, 885);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(125, 35);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop Button";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1924, 1003);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.RecButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form";
            this.Text = "Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SliderX)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SliderY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button AddButton;
        private Button RecButton;
        private Button PlayButton;
        private Panel panel2;
        private PictureBox SliderX;
        private PictureBox SliderY;
        private PictureBox pictureBox;
        private TrackBar trackBar;
        private System.Windows.Forms.Timer timer;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private TreeView treeView;
        private Button StopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}