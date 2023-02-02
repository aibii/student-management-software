namespace databaseLP
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panelSlides = new System.Windows.Forms.Panel();
            this.teachersBtn = new System.Windows.Forms.Button();
            this.groupsBtn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            this.subjectsBtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.feesBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sbjQty = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tchQty = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.classQty = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stQty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.waitlistBtn = new System.Windows.Forms.Button();
            this.panelSlides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSlide
            // 
            this.panelSlide.AutoSize = true;
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(0, 1055);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // panelSlides
            // 
            this.panelSlides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelSlides.Controls.Add(this.waitlistBtn);
            this.panelSlides.Controls.Add(this.teachersBtn);
            this.panelSlides.Controls.Add(this.groupsBtn);
            this.panelSlides.Controls.Add(this.exit);
            this.panelSlides.Controls.Add(this.subjectsBtn);
            this.panelSlides.Controls.Add(this.homebtn);
            this.panelSlides.Controls.Add(this.feesBtn);
            this.panelSlides.Controls.Add(this.studentsBtn);
            this.panelSlides.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlides.Location = new System.Drawing.Point(0, 0);
            this.panelSlides.Name = "panelSlides";
            this.panelSlides.Size = new System.Drawing.Size(319, 1055);
            this.panelSlides.TabIndex = 2;
            // 
            // teachersBtn
            // 
            this.teachersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.teachersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teachersBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teachersBtn.Image = global::databaseLP.Properties.Resources.teacher__4_;
            this.teachersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teachersBtn.Location = new System.Drawing.Point(26, 614);
            this.teachersBtn.Name = "teachersBtn";
            this.teachersBtn.Size = new System.Drawing.Size(279, 64);
            this.teachersBtn.TabIndex = 13;
            this.teachersBtn.Text = "Teachers";
            this.teachersBtn.UseVisualStyleBackColor = false;
            this.teachersBtn.Click += new System.EventHandler(this.teachersBtn_Click_1);
            // 
            // groupsBtn
            // 
            this.groupsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.groupsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.groupsBtn.Image = global::databaseLP.Properties.Resources.student_with_graduation_cap__1__1;
            this.groupsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsBtn.Location = new System.Drawing.Point(21, 353);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Size = new System.Drawing.Size(279, 64);
            this.groupsBtn.TabIndex = 12;
            this.groupsBtn.Text = "Groups";
            this.groupsBtn.UseVisualStyleBackColor = false;
            this.groupsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Image = global::databaseLP.Properties.Resources.logout__1_;
            this.exit.Location = new System.Drawing.Point(21, 967);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 50);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 11;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // subjectsBtn
            // 
            this.subjectsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.subjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectsBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectsBtn.Image = global::databaseLP.Properties.Resources.open_book__7___1_;
            this.subjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectsBtn.Location = new System.Drawing.Point(26, 523);
            this.subjectsBtn.Name = "subjectsBtn";
            this.subjectsBtn.Size = new System.Drawing.Size(274, 68);
            this.subjectsBtn.TabIndex = 10;
            this.subjectsBtn.Text = "Subjects";
            this.subjectsBtn.UseVisualStyleBackColor = false;
            this.subjectsBtn.Click += new System.EventHandler(this.subjectsBtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.AllowDrop = true;
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.Transparent;
            this.homebtn.Image = global::databaseLP.Properties.Resources.student_with_graduation_cap__1__22;
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Location = new System.Drawing.Point(21, 183);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(279, 64);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // feesBtn
            // 
            this.feesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.feesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feesBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feesBtn.Image = global::databaseLP.Properties.Resources.coin__1__1;
            this.feesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feesBtn.Location = new System.Drawing.Point(21, 437);
            this.feesBtn.Name = "feesBtn";
            this.feesBtn.Size = new System.Drawing.Size(279, 64);
            this.feesBtn.TabIndex = 9;
            this.feesBtn.Text = "Fees";
            this.feesBtn.UseVisualStyleBackColor = false;
            this.feesBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.studentsBtn.Image = global::databaseLP.Properties.Resources.student_with_graduation_cap__1__1;
            this.studentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsBtn.Location = new System.Drawing.Point(21, 268);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(279, 64);
            this.studentsBtn.TabIndex = 8;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.UseVisualStyleBackColor = false;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(580, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро Пожаловать";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(319, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1605, 1055);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.sbjQty);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(157, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 173);
            this.panel5.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(134, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Учителей";
            // 
            // sbjQty
            // 
            this.sbjQty.AutoSize = true;
            this.sbjQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbjQty.ForeColor = System.Drawing.Color.Peru;
            this.sbjQty.Location = new System.Drawing.Point(135, 42);
            this.sbjQty.Name = "sbjQty";
            this.sbjQty.Size = new System.Drawing.Size(128, 50);
            this.sbjQty.TabIndex = 1;
            this.sbjQty.Text = "label2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::databaseLP.Properties.Resources.student__3_;
            this.pictureBox4.Location = new System.Drawing.Point(11, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tchQty);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(1048, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 173);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(134, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Учителей";
            // 
            // tchQty
            // 
            this.tchQty.AutoSize = true;
            this.tchQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tchQty.ForeColor = System.Drawing.Color.LightCoral;
            this.tchQty.Location = new System.Drawing.Point(135, 42);
            this.tchQty.Name = "tchQty";
            this.tchQty.Size = new System.Drawing.Size(128, 50);
            this.tchQty.TabIndex = 1;
            this.tchQty.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::databaseLP.Properties.Resources.student__3_;
            this.pictureBox3.Location = new System.Drawing.Point(11, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.classQty);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(602, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 173);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(134, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = " Групп";
            // 
            // classQty
            // 
            this.classQty.AutoSize = true;
            this.classQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classQty.ForeColor = System.Drawing.Color.Goldenrod;
            this.classQty.Location = new System.Drawing.Point(135, 42);
            this.classQty.Name = "classQty";
            this.classQty.Size = new System.Drawing.Size(128, 50);
            this.classQty.TabIndex = 1;
            this.classQty.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::databaseLP.Properties.Resources.student__3_;
            this.pictureBox2.Location = new System.Drawing.Point(11, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.stQty);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(157, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 173);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(134, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Учеников";
            // 
            // stQty
            // 
            this.stQty.AutoSize = true;
            this.stQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stQty.ForeColor = System.Drawing.Color.SteelBlue;
            this.stQty.Location = new System.Drawing.Point(135, 42);
            this.stQty.Name = "stQty";
            this.stQty.Size = new System.Drawing.Size(128, 50);
            this.stQty.TabIndex = 1;
            this.stQty.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::databaseLP.Properties.Resources.student__3_;
            this.pictureBox1.Location = new System.Drawing.Point(11, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // waitlistBtn
            // 
            this.waitlistBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.waitlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waitlistBtn.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitlistBtn.ForeColor = System.Drawing.Color.Transparent;
            this.waitlistBtn.Image = global::databaseLP.Properties.Resources.teacher__4_;
            this.waitlistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.waitlistBtn.Location = new System.Drawing.Point(26, 701);
            this.waitlistBtn.Name = "waitlistBtn";
            this.waitlistBtn.Size = new System.Drawing.Size(279, 64);
            this.waitlistBtn.TabIndex = 14;
            this.waitlistBtn.Text = "Teachers";
            this.waitlistBtn.UseVisualStyleBackColor = false;
            this.waitlistBtn.Click += new System.EventHandler(this.waitlistBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSlides);
            this.Controls.Add(this.panelSlide);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelSlides.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button subjectsBtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button feesBtn;
        private System.Windows.Forms.Panel panelSlides;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Button groupsBtn;
        private System.Windows.Forms.Button teachersBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label classQty;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sbjQty;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tchQty;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button waitlistBtn;
    }
}