namespace EmployeeManagement
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.AttenGridView = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salary1 = new System.Windows.Forms.Label();
            this.Attendance1 = new System.Windows.Forms.Label();
            this.Employee1 = new System.Windows.Forms.Label();
            this.Bonus1 = new System.Windows.Forms.Label();
            this.Home1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.DayExcused = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DayAbs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DayPres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttenGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Navy;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.Location = new System.Drawing.Point(732, 174);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 26);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Navy;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Edit.Location = new System.Drawing.Point(516, 173);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 26);
            this.Edit.TabIndex = 25;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Navy;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Save.Location = new System.Drawing.Point(302, 173);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 26);
            this.Save.TabIndex = 24;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AttenGridView
            // 
            this.AttenGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttenGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AttenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttenGridView.Location = new System.Drawing.Point(0, 253);
            this.AttenGridView.Name = "AttenGridView";
            this.AttenGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttenGridView.Size = new System.Drawing.Size(1167, 270);
            this.AttenGridView.TabIndex = 23;
            this.AttenGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttenGridView_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(395, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(87, 3);
            this.panel6.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.Salary1);
            this.panel2.Controls.Add(this.Attendance1);
            this.panel2.Controls.Add(this.Employee1);
            this.panel2.Controls.Add(this.Bonus1);
            this.panel2.Controls.Add(this.Home1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 36);
            this.panel2.TabIndex = 0;
            // 
            // Salary1
            // 
            this.Salary1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary1.Location = new System.Drawing.Point(507, 9);
            this.Salary1.Name = "Salary1";
            this.Salary1.Size = new System.Drawing.Size(74, 21);
            this.Salary1.TabIndex = 5;
            this.Salary1.Text = "Salary";
            this.Salary1.Click += new System.EventHandler(this.Salary1_Click);
            // 
            // Attendance1
            // 
            this.Attendance1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance1.Location = new System.Drawing.Point(391, 9);
            this.Attendance1.Name = "Attendance1";
            this.Attendance1.Size = new System.Drawing.Size(99, 21);
            this.Attendance1.TabIndex = 4;
            this.Attendance1.Text = "Attendance";
            // 
            // Employee1
            // 
            this.Employee1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee1.Location = new System.Drawing.Point(187, 9);
            this.Employee1.Name = "Employee1";
            this.Employee1.Size = new System.Drawing.Size(98, 21);
            this.Employee1.TabIndex = 3;
            this.Employee1.Text = "Employees";
            this.Employee1.Click += new System.EventHandler(this.Employee1_Click);
            // 
            // Bonus1
            // 
            this.Bonus1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus1.Location = new System.Drawing.Point(309, 9);
            this.Bonus1.Name = "Bonus1";
            this.Bonus1.Size = new System.Drawing.Size(65, 21);
            this.Bonus1.TabIndex = 2;
            this.Bonus1.Text = "Bonus";
            this.Bonus1.Click += new System.EventHandler(this.Bonus1_Click);
            // 
            // Home1
            // 
            this.Home1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home1.Location = new System.Drawing.Point(86, 9);
            this.Home1.Name = "Home1";
            this.Home1.Size = new System.Drawing.Size(54, 21);
            this.Home1.TabIndex = 0;
            this.Home1.Text = "Home";
            this.Home1.Click += new System.EventHandler(this.Home1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Period);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.DayExcused);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DayAbs);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.DayPres);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.AttenGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 526);
            this.panel1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(908, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "Period";
            // 
            // Period
            // 
            this.Period.Location = new System.Drawing.Point(912, 96);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(185, 26);
            this.Period.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(752, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Excused";
            // 
            // DayExcused
            // 
            this.DayExcused.Location = new System.Drawing.Point(756, 95);
            this.DayExcused.Name = "DayExcused";
            this.DayExcused.Size = new System.Drawing.Size(130, 26);
            this.DayExcused.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(592, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Absence";
            // 
            // DayAbs
            // 
            this.DayAbs.Location = new System.Drawing.Point(596, 96);
            this.DayAbs.Name = "DayAbs";
            this.DayAbs.Size = new System.Drawing.Size(130, 26);
            this.DayAbs.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Present";
            // 
            // DayPres
            // 
            this.DayPres.Location = new System.Drawing.Point(437, 95);
            this.DayPres.Name = "DayPres";
            this.DayPres.Size = new System.Drawing.Size(130, 26);
            this.DayPres.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Name";
            // 
            // EmpId
            // 
            this.EmpId.FormattingEnabled = true;
            this.EmpId.Location = new System.Drawing.Point(81, 94);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(115, 27);
            this.EmpId.TabIndex = 28;
            this.EmpId.SelectionChangeCommitted += new System.EventHandler(this.EmpIdCb_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Employee Id";
            // 
            // EmpName
            // 
            this.EmpName.Enabled = false;
            this.EmpName.Location = new System.Drawing.Point(223, 95);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(185, 26);
            this.EmpName.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagement.Properties.Resources.Back;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1133, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 526);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttenGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView AttenGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Salary1;
        private System.Windows.Forms.Label Attendance1;
        private System.Windows.Forms.Label Employee1;
        private System.Windows.Forms.Label Bonus1;
        private System.Windows.Forms.Label Home1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EmpId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DayExcused;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DayAbs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DayPres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker Period;
    }
}