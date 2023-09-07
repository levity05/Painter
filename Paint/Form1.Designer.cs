namespace Paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.white = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.gren = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.add_color = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 537);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.flowLayoutPanel1.Controls.Add(this.white);
            this.flowLayoutPanel1.Controls.Add(this.red);
            this.flowLayoutPanel1.Controls.Add(this.orange);
            this.flowLayoutPanel1.Controls.Add(this.yellow);
            this.flowLayoutPanel1.Controls.Add(this.gren);
            this.flowLayoutPanel1.Controls.Add(this.blue);
            this.flowLayoutPanel1.Controls.Add(this.black);
            this.flowLayoutPanel1.Controls.Add(this.add_color);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 89);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.white.Location = new System.Drawing.Point(3, 3);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(35, 35);
            this.white.TabIndex = 0;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.button3_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.red.Location = new System.Drawing.Point(44, 3);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(35, 35);
            this.red.TabIndex = 1;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.button3_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orange.Location = new System.Drawing.Point(85, 3);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(35, 35);
            this.orange.TabIndex = 2;
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.button3_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellow.Location = new System.Drawing.Point(126, 3);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(35, 35);
            this.yellow.TabIndex = 3;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.button3_Click);
            // 
            // gren
            // 
            this.gren.BackColor = System.Drawing.Color.Lime;
            this.gren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gren.Location = new System.Drawing.Point(3, 44);
            this.gren.Name = "gren";
            this.gren.Size = new System.Drawing.Size(35, 35);
            this.gren.TabIndex = 4;
            this.gren.UseVisualStyleBackColor = false;
            this.gren.Click += new System.EventHandler(this.button3_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Cyan;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blue.Location = new System.Drawing.Point(44, 44);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(35, 35);
            this.blue.TabIndex = 5;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.button3_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.black.Location = new System.Drawing.Point(85, 44);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(35, 35);
            this.black.TabIndex = 6;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_color
            // 
            this.add_color.BackColor = System.Drawing.SystemColors.Control;
            this.add_color.Location = new System.Drawing.Point(126, 44);
            this.add_color.Name = "add_color";
            this.add_color.Size = new System.Drawing.Size(34, 34);
            this.add_color.TabIndex = 7;
            this.add_color.UseVisualStyleBackColor = false;
            this.add_color.Click += new System.EventHandler(this.button10_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.trackBar1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 98);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 73);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор толщины";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.trackBar1.Location = new System.Drawing.Point(3, 35);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(3, 177);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(157, 33);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.Location = new System.Drawing.Point(3, 216);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(157, 33);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Info;
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.save);
            this.flowLayoutPanel3.Controls.Add(this.clear);
            this.flowLayoutPanel3.Controls.Add(this.AddPhoto);
            this.flowLayoutPanel3.Controls.Add(this.eraser);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(639, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(169, 537);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // AddPhoto
            // 
            this.AddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddPhoto.Location = new System.Drawing.Point(3, 255);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(157, 33);
            this.AddPhoto.TabIndex = 5;
            this.AddPhoto.Text = "Add Photo";
            this.AddPhoto.UseVisualStyleBackColor = false;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eraser.Location = new System.Drawing.Point(3, 294);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(157, 33);
            this.eraser.TabIndex = 6;
            this.eraser.Text = "Eraser";
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Painter 2023 v-1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button3_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button save;
        private Button clear;
        private Button white;
        private Button red;
        private Button orange;
        private Button yellow;
        private Button gren;
        private Button blue;
        private Button black;
        private TrackBar trackBar1;
        private Label label1;
        private Button add_color;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private FlowLayoutPanel flowLayoutPanel3;
        private OpenFileDialog openFileDialog1;
        private Button AddPhoto;
        private Button eraser;
    }
}