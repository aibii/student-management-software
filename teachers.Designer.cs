namespace databaseLP
{
    partial class teachers
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
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTxb = new System.Windows.Forms.TextBox();
            this.dobTxb = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTxb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startDayTxb = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new databaseLP.RJButton();
            this.editBtn = new databaseLP.RJButton();
            this.abdBtn = new databaseLP.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name:";
            // 
            // lastNameTxb
            // 
            this.lastNameTxb.Location = new System.Drawing.Point(360, 176);
            this.lastNameTxb.Multiline = true;
            this.lastNameTxb.Name = "lastNameTxb";
            this.lastNameTxb.Size = new System.Drawing.Size(151, 29);
            this.lastNameTxb.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Name:";
            // 
            // firstNameTxb
            // 
            this.firstNameTxb.Location = new System.Drawing.Point(360, 240);
            this.firstNameTxb.Multiline = true;
            this.firstNameTxb.Name = "firstNameTxb";
            this.firstNameTxb.Size = new System.Drawing.Size(151, 29);
            this.firstNameTxb.TabIndex = 18;
            // 
            // dobTxb
            // 
            this.dobTxb.CustomFormat = "yyyy-MM-dd";
            this.dobTxb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobTxb.Location = new System.Drawing.Point(160, 165);
            this.dobTxb.Name = "dobTxb";
            this.dobTxb.Size = new System.Drawing.Size(151, 22);
            this.dobTxb.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "DOB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone:";
            // 
            // phoneTxb
            // 
            this.phoneTxb.Location = new System.Drawing.Point(160, 211);
            this.phoneTxb.Multiline = true;
            this.phoneTxb.Name = "phoneTxb";
            this.phoneTxb.Size = new System.Drawing.Size(151, 29);
            this.phoneTxb.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.dobTxb);
            this.panel1.Controls.Add(this.startDayTxb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phoneTxb);
            this.panel1.Location = new System.Drawing.Point(200, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 333);
            this.panel1.TabIndex = 20;
            // 
            // startDayTxb
            // 
            this.startDayTxb.CustomFormat = "yyyy-MM-dd";
            this.startDayTxb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDayTxb.Location = new System.Drawing.Point(160, 269);
            this.startDayTxb.Name = "startDayTxb";
            this.startDayTxb.Size = new System.Drawing.Size(151, 22);
            this.startDayTxb.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Joined Date:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(660, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 579);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.deleteBtn.Location = new System.Drawing.Point(200, 578);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(131, 40);
            this.deleteBtn.TabIndex = 25;
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
            this.editBtn.Location = new System.Drawing.Point(360, 520);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(131, 40);
            this.editBtn.TabIndex = 24;
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
            this.abdBtn.Location = new System.Drawing.Point(200, 520);
            this.abdBtn.Name = "abdBtn";
            this.abdBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.abdBtn.Size = new System.Drawing.Size(131, 40);
            this.abdBtn.TabIndex = 23;
            this.abdBtn.Text = "Add";
            this.abdBtn.TextColor = System.Drawing.Color.White;
            this.abdBtn.UseVisualStyleBackColor = false;
            this.abdBtn.Click += new System.EventHandler(this.abdBtn_Click);
            // 
            // teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 669);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.abdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "teachers";
            this.Text = "teachers";
            this.Load += new System.EventHandler(this.teachers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTxb;
        private System.Windows.Forms.DateTimePicker dobTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTxb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker startDayTxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJButton deleteBtn;
        private RJButton editBtn;
        private RJButton abdBtn;
    }
}