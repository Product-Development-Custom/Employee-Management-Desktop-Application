namespace EmployeeManagement
{
    partial class Employee
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
            this.Attendance1 = new System.Windows.Forms.Label();
            this.Employee1 = new System.Windows.Forms.Label();
            this.Bonus1 = new System.Windows.Forms.Label();
            this.Salary1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Home1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.EmpBasSal = new System.Windows.Forms.TextBox();
            this.EmpQual = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EmpJDate = new System.Windows.Forms.DateTimePicker();
            this.EmpPos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmpPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpDOB = new System.Windows.Forms.DateTimePicker();
            this.EmpGen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Attendance1
            // 
            this.Attendance1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance1.Location = new System.Drawing.Point(399, 9);
            this.Attendance1.Name = "Attendance1";
            this.Attendance1.Size = new System.Drawing.Size(99, 21);
            this.Attendance1.TabIndex = 4;
            this.Attendance1.Text = "Attendance";
            this.Attendance1.Click += new System.EventHandler(this.Attendance1_Click);
            // 
            // Employee1
            // 
            this.Employee1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee1.Location = new System.Drawing.Point(187, 9);
            this.Employee1.Name = "Employee1";
            this.Employee1.Size = new System.Drawing.Size(98, 21);
            this.Employee1.TabIndex = 3;
            this.Employee1.Text = "Employees";
            // 
            // Bonus1
            // 
            this.Bonus1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus1.Location = new System.Drawing.Point(309, 9);
            this.Bonus1.Name = "Bonus1";
            this.Bonus1.Size = new System.Drawing.Size(65, 21);
            this.Bonus1.TabIndex = 2;
            this.Bonus1.Text = "Bonus";
            this.Bonus1.Click += new System.EventHandler(this.label3_Click);
            // 
            // Salary1
            // 
            this.Salary1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary1.Location = new System.Drawing.Point(515, 9);
            this.Salary1.Name = "Salary1";
            this.Salary1.Size = new System.Drawing.Size(74, 21);
            this.Salary1.TabIndex = 5;
            this.Salary1.Text = "Salary";
            this.Salary1.Click += new System.EventHandler(this.Salary1_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Navy;
            this.Home.Controls.Add(this.pictureBox2);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.panel6);
            this.Home.Controls.Add(this.Salary1);
            this.Home.Controls.Add(this.Attendance1);
            this.Home.Controls.Add(this.Employee1);
            this.Home.Controls.Add(this.Bonus1);
            this.Home.Controls.Add(this.Home1);
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1173, 36);
            this.Home.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(191, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(84, 3);
            this.panel6.TabIndex = 1;
            // 
            // Home1
            // 
            this.Home1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home1.Location = new System.Drawing.Point(85, 9);
            this.Home1.Name = "Home1";
            this.Home1.Size = new System.Drawing.Size(54, 21);
            this.Home1.TabIndex = 0;
            this.Home1.Text = "Home";
            this.Home1.Click += new System.EventHandler(this.Home1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.EmpGridView);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.EmpBasSal);
            this.panel1.Controls.Add(this.EmpQual);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.EmpJDate);
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.EmpAdd);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.EmpPhone);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpDOB);
            this.panel1.Controls.Add(this.EmpGen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 526);
            this.panel1.TabIndex = 1;
            // 
            // EmpGridView
            // 
            this.EmpGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Location = new System.Drawing.Point(0, 246);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmpGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpGridView.Size = new System.Drawing.Size(1170, 277);
            this.EmpGridView.TabIndex = 27;
            this.EmpGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGridView_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Navy;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.Location = new System.Drawing.Point(754, 195);
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
            this.Edit.Location = new System.Drawing.Point(539, 193);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 26);
            this.Edit.TabIndex = 25;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Update_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Navy;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Save.Location = new System.Drawing.Point(324, 194);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 26);
            this.Save.TabIndex = 24;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(698, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Base Salary";
            // 
            // EmpBasSal
            // 
            this.EmpBasSal.Location = new System.Drawing.Point(702, 85);
            this.EmpBasSal.Name = "EmpBasSal";
            this.EmpBasSal.Size = new System.Drawing.Size(185, 26);
            this.EmpBasSal.TabIndex = 21;
            // 
            // EmpQual
            // 
            this.EmpQual.FormattingEnabled = true;
            this.EmpQual.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "BBA",
            "MBA",
            "BCOM",
            "BTECH"});
            this.EmpQual.Location = new System.Drawing.Point(488, 138);
            this.EmpQual.Name = "EmpQual";
            this.EmpQual.Size = new System.Drawing.Size(185, 27);
            this.EmpQual.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(484, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 21);
            this.label14.TabIndex = 19;
            this.label14.Text = "Qualification";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(484, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "Join Date";
            // 
            // EmpJDate
            // 
            this.EmpJDate.Location = new System.Drawing.Point(488, 85);
            this.EmpJDate.Name = "EmpJDate";
            this.EmpJDate.Size = new System.Drawing.Size(185, 26);
            this.EmpJDate.TabIndex = 17;
            // 
            // EmpPos
            // 
            this.EmpPos.FormattingEnabled = true;
            this.EmpPos.Items.AddRange(new object[] {
            "Manager",
            "Senior",
            "Junior"});
            this.EmpPos.Location = new System.Drawing.Point(702, 139);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.Size = new System.Drawing.Size(185, 27);
            this.EmpPos.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(698, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Position";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(275, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Address";
            // 
            // EmpAdd
            // 
            this.EmpAdd.Location = new System.Drawing.Point(279, 85);
            this.EmpAdd.Multiline = true;
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(185, 80);
            this.EmpAdd.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(906, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Location = new System.Drawing.Point(910, 85);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(185, 26);
            this.EmpPhone.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(906, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "DOB";
            // 
            // EmpDOB
            // 
            this.EmpDOB.Location = new System.Drawing.Point(910, 139);
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Size = new System.Drawing.Size(185, 26);
            this.EmpDOB.TabIndex = 9;
            // 
            // EmpGen
            // 
            this.EmpGen.FormattingEnabled = true;
            this.EmpGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGen.Location = new System.Drawing.Point(73, 138);
            this.EmpGen.Name = "EmpGen";
            this.EmpGen.Size = new System.Drawing.Size(185, 27);
            this.EmpGen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(73, 85);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(185, 26);
            this.EmpName.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagement.Properties.Resources.Back;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(1133, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 526);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.Home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Attendance1;
        private System.Windows.Forms.Label Employee1;
        private System.Windows.Forms.Label Bonus1;
        private System.Windows.Forms.Label Salary1;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Label Home1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EmpBasSal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker EmpJDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EmpPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox EmpQual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox EmpPos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmpAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker EmpDOB;
        private System.Windows.Forms.ComboBox EmpGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}