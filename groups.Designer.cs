namespace databaseLP
{
    partial class groups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.classMx = new System.Windows.Forms.TextBox();
            this.className = new System.Windows.Forms.TextBox();
            this.classTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.tchBox = new System.Windows.Forms.ComboBox();
            this.groupTxb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classDays = new System.Windows.Forms.TextBox();
            this.rjButton1 = new databaseLP.RJButton();
            this.deleteBtn = new databaseLP.RJButton();
            this.editBtn = new databaseLP.RJButton();
            this.abdBtn = new databaseLP.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(877, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список Групп";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(523, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 633);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя Группы:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.classMx);
            this.panel1.Controls.Add(this.className);
            this.panel1.Controls.Add(this.classTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.courseBox);
            this.panel1.Controls.Add(this.tchBox);
            this.panel1.Controls.Add(this.groupTxb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.classDays);
            this.panel1.Location = new System.Drawing.Point(58, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 411);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "Нет мест:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(208, 364);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // classMx
            // 
            this.classMx.Location = new System.Drawing.Point(208, 301);
            this.classMx.Multiline = true;
            this.classMx.Name = "classMx";
            this.classMx.Size = new System.Drawing.Size(151, 29);
            this.classMx.TabIndex = 30;
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(208, 33);
            this.className.Multiline = true;
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(151, 29);
            this.className.TabIndex = 29;
            // 
            // classTime
            // 
            this.classTime.Location = new System.Drawing.Point(208, 251);
            this.classTime.Multiline = true;
            this.classTime.Name = "classTime";
            this.classTime.Size = new System.Drawing.Size(151, 29);
            this.classTime.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Часы:";
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(208, 94);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(151, 24);
            this.courseBox.TabIndex = 26;
            // 
            // tchBox
            // 
            this.tchBox.FormattingEnabled = true;
            this.tchBox.Location = new System.Drawing.Point(208, 148);
            this.tchBox.Name = "tchBox";
            this.tchBox.Size = new System.Drawing.Size(151, 24);
            this.tchBox.TabIndex = 24;
            // 
            // groupTxb
            // 
            this.groupTxb.AutoSize = true;
            this.groupTxb.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupTxb.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTxb.Location = new System.Drawing.Point(20, 305);
            this.groupTxb.Name = "groupTxb";
            this.groupTxb.Size = new System.Drawing.Size(159, 27);
            this.groupTxb.TabIndex = 23;
            this.groupTxb.Text = "Макc Кол-во:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "Дни:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Предмет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Учитель";
            // 
            // classDays
            // 
            this.classDays.Location = new System.Drawing.Point(208, 201);
            this.classDays.Multiline = true;
            this.classDays.Name = "classDays";
            this.classDays.Size = new System.Drawing.Size(151, 29);
            this.classDays.TabIndex = 13;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(249, 834);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(168, 57);
            this.rjButton1.TabIndex = 29;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 15;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::databaseLP.Properties.Resources.remove__2_;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(58, 776);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(174, 45);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Chocolate;
            this.editBtn.BackgroundColor = System.Drawing.Color.Chocolate;
            this.editBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editBtn.BorderRadius = 15;
            this.editBtn.BorderSize = 0;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = global::databaseLP.Properties.Resources.edit__2_;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(275, 713);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(174, 45);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Изменить";
            this.editBtn.TextColor = System.Drawing.Color.White;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // abdBtn
            // 
            this.abdBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.abdBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.abdBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abdBtn.BorderRadius = 15;
            this.abdBtn.BorderSize = 0;
            this.abdBtn.FlatAppearance.BorderSize = 0;
            this.abdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abdBtn.ForeColor = System.Drawing.Color.White;
            this.abdBtn.Image = global::databaseLP.Properties.Resources.add__1_;
            this.abdBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abdBtn.Location = new System.Drawing.Point(58, 713);
            this.abdBtn.Name = "abdBtn";
            this.abdBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.abdBtn.Size = new System.Drawing.Size(174, 45);
            this.abdBtn.TabIndex = 26;
            this.abdBtn.Text = "Добавить";
            this.abdBtn.TextColor = System.Drawing.Color.White;
            this.abdBtn.UseVisualStyleBackColor = false;
            this.abdBtn.Click += new System.EventHandler(this.abdBtn_Click);
            // 
            // groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1599, 889);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.abdBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "groups";
            this.Text = "groups";
            this.Load += new System.EventHandler(this.groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox classMx;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.TextBox classTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.ComboBox tchBox;
        private System.Windows.Forms.Label groupTxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox classDays;
        private RJButton deleteBtn;
        private RJButton editBtn;
        private RJButton abdBtn;
        private RJButton rjButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}