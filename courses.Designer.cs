namespace databaseLP
{
    partial class courses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.courseFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseDesc = new System.Windows.Forms.TextBox();
            this.deleteBtn = new databaseLP.RJButton();
            this.editBtn = new databaseLP.RJButton();
            this.abdBtn = new databaseLP.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 579);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Course Name:";
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(183, 32);
            this.courseName.Multiline = true;
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(151, 29);
            this.courseName.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.courseName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.courseFee);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.courseDesc);
            this.panel1.Location = new System.Drawing.Point(77, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 239);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Wheat;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monthly Fee:";
            // 
            // courseFee
            // 
            this.courseFee.Location = new System.Drawing.Point(183, 164);
            this.courseFee.Multiline = true;
            this.courseFee.Name = "courseFee";
            this.courseFee.Size = new System.Drawing.Size(151, 29);
            this.courseFee.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Wheat;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description:";
            // 
            // courseDesc
            // 
            this.courseDesc.Location = new System.Drawing.Point(183, 101);
            this.courseDesc.Multiline = true;
            this.courseDesc.Name = "courseDesc";
            this.courseDesc.Size = new System.Drawing.Size(151, 29);
            this.courseDesc.TabIndex = 13;
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
            this.deleteBtn.Location = new System.Drawing.Point(77, 470);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(131, 40);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
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
            this.editBtn.Location = new System.Drawing.Point(237, 412);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(131, 40);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Edit";
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
            this.abdBtn.Location = new System.Drawing.Point(77, 412);
            this.abdBtn.Name = "abdBtn";
            this.abdBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.abdBtn.Size = new System.Drawing.Size(131, 40);
            this.abdBtn.TabIndex = 20;
            this.abdBtn.Text = "Add";
            this.abdBtn.TextColor = System.Drawing.Color.White;
            this.abdBtn.UseVisualStyleBackColor = false;
            this.abdBtn.Click += new System.EventHandler(this.abdBtn_Click);
            // 
            // courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1486, 635);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.abdBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "courses";
            this.Text = "courses";
            this.Load += new System.EventHandler(this.courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox courseFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox courseDesc;
        private RJButton deleteBtn;
        private RJButton editBtn;
        private RJButton abdBtn;
    }
}