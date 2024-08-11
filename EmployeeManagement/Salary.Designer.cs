namespace EmployeeManagement
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.Total = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SalaryGridView = new System.Windows.Forms.DataGridView();
            this.Print = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.EmpBasSal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SalPeriod = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.EmpId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.DayAbs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DayExcused = new System.Windows.Forms.TextBox();
            this.DayPres = new System.Windows.Forms.TextBox();
            this.AttNum = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BId = new System.Windows.Forms.ComboBox();
            this.BAmt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpBalance = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salary1 = new System.Windows.Forms.Label();
            this.Attendance1 = new System.Windows.Forms.Label();
            this.Employee1 = new System.Windows.Forms.Label();
            this.Bonus1 = new System.Windows.Forms.Label();
            this.Home1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.Navy;
            this.Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Total.Location = new System.Drawing.Point(737, 195);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(75, 26);
            this.Total.TabIndex = 26;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = false;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Navy;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Save.Location = new System.Drawing.Point(331, 194);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 26);
            this.Save.TabIndex = 24;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SalaryGridView
            // 
            this.SalaryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalaryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryGridView.Location = new System.Drawing.Point(0, 250);
            this.SalaryGridView.Name = "SalaryGridView";
            this.SalaryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalaryGridView.Size = new System.Drawing.Size(1168, 273);
            this.SalaryGridView.TabIndex = 23;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Navy;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Print.Location = new System.Drawing.Point(533, 195);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 26);
            this.Print.TabIndex = 25;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(411, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Base Salary";
            // 
            // EmpBasSal
            // 
            this.EmpBasSal.Enabled = false;
            this.EmpBasSal.Location = new System.Drawing.Point(415, 80);
            this.EmpBasSal.Name = "EmpBasSal";
            this.EmpBasSal.Size = new System.Drawing.Size(185, 26);
            this.EmpBasSal.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(413, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "Period";
            // 
            // SalPeriod
            // 
            this.SalPeriod.Location = new System.Drawing.Point(417, 133);
            this.SalPeriod.Name = "SalPeriod";
            this.SalPeriod.Size = new System.Drawing.Size(185, 26);
            this.SalPeriod.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Bonus";
            // 
            // EmpId
            // 
            this.EmpId.FormattingEnabled = true;
            this.EmpId.Location = new System.Drawing.Point(79, 80);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(94, 27);
            this.EmpId.TabIndex = 8;
            this.EmpId.SelectionChangeCommitted += new System.EventHandler(this.EmpId_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee Id";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // EmpName
            // 
            this.EmpName.Enabled = false;
            this.EmpName.Location = new System.Drawing.Point(207, 80);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(185, 26);
            this.EmpName.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(519, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 3);
            this.panel6.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.DayAbs);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.DayExcused);
            this.panel1.Controls.Add(this.DayPres);
            this.panel1.Controls.Add(this.AttNum);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.BId);
            this.panel1.Controls.Add(this.BAmt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.EmpBalance);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.EmpBasSal);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.SalPeriod);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.EmpId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.SalaryGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 526);
            this.panel1.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(978, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 21);
            this.label18.TabIndex = 41;
            this.label18.Text = "Absence";
            // 
            // DayAbs
            // 
            this.DayAbs.Enabled = false;
            this.DayAbs.Location = new System.Drawing.Point(982, 79);
            this.DayAbs.Name = "DayAbs";
            this.DayAbs.Size = new System.Drawing.Size(109, 26);
            this.DayAbs.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(978, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 21);
            this.label17.TabIndex = 39;
            this.label17.Text = "Excused";
            // 
            // DayExcused
            // 
            this.DayExcused.Enabled = false;
            this.DayExcused.Location = new System.Drawing.Point(982, 136);
            this.DayExcused.Name = "DayExcused";
            this.DayExcused.Size = new System.Drawing.Size(109, 26);
            this.DayExcused.TabIndex = 38;
            // 
            // DayPres
            // 
            this.DayPres.Enabled = false;
            this.DayPres.Location = new System.Drawing.Point(848, 133);
            this.DayPres.Name = "DayPres";
            this.DayPres.Size = new System.Drawing.Size(109, 26);
            this.DayPres.TabIndex = 36;
            // 
            // AttNum
            // 
            this.AttNum.FormattingEnabled = true;
            this.AttNum.Location = new System.Drawing.Point(848, 79);
            this.AttNum.Name = "AttNum";
            this.AttNum.Size = new System.Drawing.Size(109, 27);
            this.AttNum.TabIndex = 35;
            this.AttNum.SelectionChangeCommitted += new System.EventHandler(this.AttNum_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(844, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 21);
            this.label14.TabIndex = 34;
            this.label14.Text = "Attendance";
            // 
            // BId
            // 
            this.BId.FormattingEnabled = true;
            this.BId.Location = new System.Drawing.Point(633, 79);
            this.BId.Name = "BId";
            this.BId.Size = new System.Drawing.Size(179, 27);
            this.BId.TabIndex = 33;
            this.BId.SelectionChangeCommitted += new System.EventHandler(this.BId_SelectionChangeCommitted);
            // 
            // BAmt
            // 
            this.BAmt.Enabled = false;
            this.BAmt.Location = new System.Drawing.Point(633, 133);
            this.BAmt.Name = "BAmt";
            this.BAmt.Size = new System.Drawing.Size(179, 26);
            this.BAmt.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total Salary";
            // 
            // EmpBalance
            // 
            this.EmpBalance.Enabled = false;
            this.EmpBalance.Location = new System.Drawing.Point(207, 134);
            this.EmpBalance.Name = "EmpBalance";
            this.EmpBalance.Size = new System.Drawing.Size(109, 26);
            this.EmpBalance.TabIndex = 29;
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
            this.panel2.Size = new System.Drawing.Size(1171, 36);
            this.panel2.TabIndex = 0;
            // 
            // Salary1
            // 
            this.Salary1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary1.Location = new System.Drawing.Point(515, 9);
            this.Salary1.Name = "Salary1";
            this.Salary1.Size = new System.Drawing.Size(74, 21);
            this.Salary1.TabIndex = 5;
            this.Salary1.Text = "Salary";
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
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(844, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Present";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagement.Properties.Resources.Back;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
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
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 526);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView SalaryGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EmpBasSal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker SalPeriod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EmpId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Salary1;
        private System.Windows.Forms.Label Attendance1;
        private System.Windows.Forms.Label Employee1;
        private System.Windows.Forms.Label Bonus1;
        private System.Windows.Forms.Label Home1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmpBalance;
        private System.Windows.Forms.TextBox BAmt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox DayAbs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox DayExcused;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DayPres;
        private System.Windows.Forms.ComboBox AttNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox BId;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}