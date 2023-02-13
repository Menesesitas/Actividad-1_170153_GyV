namespace mashUp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.PANEL_LEFT = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PLAY_button = new System.Windows.Forms.Button();
            this.REC_button = new System.Windows.Forms.Button();
            this.ADD_button = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.framesLabel = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_X = new System.Windows.Forms.PictureBox();
            this.panelR = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_Y = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.PANEL_LEFT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).BeginInit();
            this.panelR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(158, 101);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1150, 530);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trackBar.Location = new System.Drawing.Point(-5, -4);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(1148, 45);
            this.trackBar.TabIndex = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // PANEL_LEFT
            // 
            this.PANEL_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PANEL_LEFT.Controls.Add(this.checkBox1);
            this.PANEL_LEFT.Controls.Add(this.PLAY_button);
            this.PANEL_LEFT.Controls.Add(this.REC_button);
            this.PANEL_LEFT.Controls.Add(this.ADD_button);
            this.PANEL_LEFT.Controls.Add(this.treeView1);
            this.PANEL_LEFT.Location = new System.Drawing.Point(0, 52);
            this.PANEL_LEFT.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_LEFT.Name = "PANEL_LEFT";
            this.PANEL_LEFT.Size = new System.Drawing.Size(150, 626);
            this.PANEL_LEFT.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("ROG Fonts", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(16, 411);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Animate All";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PLAY_button
            // 
            this.PLAY_button.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY_button.Location = new System.Drawing.Point(9, 553);
            this.PLAY_button.Margin = new System.Windows.Forms.Padding(2);
            this.PLAY_button.Name = "PLAY_button";
            this.PLAY_button.Size = new System.Drawing.Size(125, 45);
            this.PLAY_button.TabIndex = 3;
            this.PLAY_button.Text = "PLAY ▶";
            this.PLAY_button.UseVisualStyleBackColor = true;
            this.PLAY_button.Click += new System.EventHandler(this.PLAY_button_Click);
            // 
            // REC_button
            // 
            this.REC_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REC_button.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REC_button.Location = new System.Drawing.Point(9, 497);
            this.REC_button.Margin = new System.Windows.Forms.Padding(2);
            this.REC_button.Name = "REC_button";
            this.REC_button.Size = new System.Drawing.Size(125, 45);
            this.REC_button.TabIndex = 2;
            this.REC_button.Text = "REC ⚫";
            this.REC_button.UseVisualStyleBackColor = true;
            this.REC_button.Click += new System.EventHandler(this.REC_button_Click);
            // 
            // ADD_button
            // 
            this.ADD_button.BackColor = System.Drawing.Color.Black;
            this.ADD_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD_button.FlatAppearance.BorderSize = 0;
            this.ADD_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ADD_button.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_button.ForeColor = System.Drawing.Color.White;
            this.ADD_button.Location = new System.Drawing.Point(9, 445);
            this.ADD_button.Margin = new System.Windows.Forms.Padding(2);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(125, 45);
            this.ADD_button.TabIndex = 1;
            this.ADD_button.Text = "ADD +";
            this.ADD_button.UseVisualStyleBackColor = false;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.treeView1.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(3, 12);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(145, 386);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Location = new System.Drawing.Point(158, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 44);
            this.panel1.TabIndex = 10;
            // 
            // framesLabel
            // 
            this.framesLabel.AutoSize = true;
            this.framesLabel.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framesLabel.ForeColor = System.Drawing.Color.White;
            this.framesLabel.Location = new System.Drawing.Point(11, 9);
            this.framesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.framesLabel.Name = "framesLabel";
            this.framesLabel.Size = new System.Drawing.Size(343, 29);
            this.framesLabel.TabIndex = 9;
            this.framesLabel.Text = "Mash Up 2023 UDLAP";
            // 
            // panelDown
            // 
            this.panelDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDown.Controls.Add(this.PCT_SLIDEER_X);
            this.panelDown.Location = new System.Drawing.Point(158, 636);
            this.panelDown.Margin = new System.Windows.Forms.Padding(2);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1129, 42);
            this.panelDown.TabIndex = 11;
            // 
            // PCT_SLIDEER_X
            // 
            this.PCT_SLIDEER_X.Location = new System.Drawing.Point(14, 11);
            this.PCT_SLIDEER_X.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_SLIDEER_X.Name = "PCT_SLIDEER_X";
            this.PCT_SLIDEER_X.Size = new System.Drawing.Size(1119, 15);
            this.PCT_SLIDEER_X.TabIndex = 0;
            this.PCT_SLIDEER_X.TabStop = false;
            this.PCT_SLIDEER_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseDown);
            this.PCT_SLIDEER_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseMove);
            this.PCT_SLIDEER_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseUp);
            // 
            // panelR
            // 
            this.panelR.Controls.Add(this.PCT_SLIDEER_Y);
            this.panelR.Location = new System.Drawing.Point(1314, 52);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(150, 626);
            this.panelR.TabIndex = 4;
            // 
            // PCT_SLIDEER_Y
            // 
            this.PCT_SLIDEER_Y.Location = new System.Drawing.Point(19, 48);
            this.PCT_SLIDEER_Y.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_SLIDEER_Y.Name = "PCT_SLIDEER_Y";
            this.PCT_SLIDEER_Y.Size = new System.Drawing.Size(15, 572);
            this.PCT_SLIDEER_Y.TabIndex = 0;
            this.PCT_SLIDEER_Y.TabStop = false;
            this.PCT_SLIDEER_Y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseDown);
            this.PCT_SLIDEER_Y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseMove);
            this.PCT_SLIDEER_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1443, 708);
            this.Controls.Add(this.framesLabel);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PANEL_LEFT);
            this.Controls.Add(this.PCT_CANVAS);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Mash_Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.PANEL_LEFT.ResumeLayout(false);
            this.PANEL_LEFT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).EndInit();
            this.panelR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Panel PANEL_LEFT;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_X;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_Y;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PLAY_button;
        private System.Windows.Forms.Button REC_button;
        private System.Windows.Forms.Label framesLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

