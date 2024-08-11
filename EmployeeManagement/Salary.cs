using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Salary : Form
    {
        int DP = 0, DE = 0, DB = 0, TT = 0, GTR = 0, BA = 0;
       
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            GetEmp();
            ShowSalary();
            GetAttendance();
            GetBonus();
            
            SalaryGridView.EnableHeadersVisualStyles = false;
          

        }

        private void ShowSalary()
        {
            string sql = " Select * from SalaryTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SalaryGridView.DataSource = dt;

        }
        private void GetEmp()
        {
            string sql = "select * from EmployeeTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            da.Fill(dt);
            EmpId.ValueMember = "EmpId";
            EmpId.DataSource = dt;
        }

        private void GetAttendance()
        {
            string sql = "select * from AttendanceTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            dt.Columns.Add("AttNum", typeof(int));
            da.Fill(dt);
            AttNum.ValueMember = "AttNum";
            AttNum.DataSource = dt;
        }
        private void GetAttendanceinfo()
        {

            string sql = "select * from AttendanceTbl where AttNum=" + AttNum.SelectedValue.ToString() + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DayPres.Text = dr["DayPres"].ToString();
                DayAbs.Text = dr["DayAbs"].ToString();
                DayExcused.Text = dr["DayExcused"].ToString();

            }
        }

        private void GetBonus()
        {
            string sql = "select * from BonusTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            dt.Columns.Add("BName", typeof(string));
            da.Fill(dt);
            BId.ValueMember = "BName";
            BId.DataSource = dt;
        }
        private void GetBonusAmount()
        {

            string sql = "select * from BonusTbl where BName='" + BId.SelectedValue.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BAmt.Text = dr["BAmt"].ToString();
              
            }
        }
        private void GetEmpName()
        {

            string sql = "select * from EmployeeTbl where EmpId=" + EmpId.SelectedValue.ToString() + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpName.Text = dr["EmpName"].ToString();
                EmpBasSal.Text = dr["EmpBasSal"].ToString();
            }
        }
        private void clear()
        {
            EmpId.Text = EmpName.Text = DayPres.Text = DayAbs.Text = DayExcused.Text =string.Empty;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Suzlon Energy Ltd", new Font("Arial", 15, FontStyle.Bold), Brushes.Red, new Point(150,5));
            e.Graphics.DrawString("----------------------------------------------------------------------------------", new Font("Arial", 15), Brushes.Black, new Point(0,25));
          //  e.Graphics.DrawString("Employee Salary Slip", new Font("Arial", 12, FontStyle.Bold), Brushes.Red, new Point(50, 45));

            string SalNum = SalaryGridView.SelectedRows[0].Cells[0].Value.ToString();
            string EmpId = SalaryGridView.SelectedRows[0].Cells[1].Value.ToString();
            string EmpName = SalaryGridView.SelectedRows[0].Cells[2].Value.ToString();
            string EmpBasSal = SalaryGridView.SelectedRows[0].Cells[3].Value.ToString();
            string BAmt = SalaryGridView.SelectedRows[0].Cells[4].Value.ToString();
            string EmpBalance = SalaryGridView.SelectedRows[0].Cells[5].Value.ToString();
            string SalPeriod = SalaryGridView.SelectedRows[0].Cells[6].Value.ToString();


            e.Graphics.DrawString("Salary No:-" + SalNum, new Font("Arial", 11,FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Employee Id:-" + EmpId, new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, new Point(50, 130));
            e.Graphics.DrawString("Employee Name:-" +EmpName, new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, new Point(50, 160));
            e.Graphics.DrawString("Base Salary:-" + EmpBasSal, new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, new Point(50,190));
            e.Graphics.DrawString("Bonus:-" + BAmt, new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, new Point(50, 220));
            e.Graphics.DrawString("Total Salary:-" + EmpBalance, new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, new Point(50, 250));
            e.Graphics.DrawString("Period:-" + SalPeriod, new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, new Point(50, 280));


            e.Graphics.DrawString("----------------------------------------------------------------------------------", new Font("Arial", 15), Brushes.Black, new Point(0,320));
            e.Graphics.DrawString("Thank you", new Font("Arial", 15, FontStyle.Bold), Brushes.Red, new Point(200, 340));
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Salary Slip",500,650);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            if (h == null)
            {
                h.Parent = this;
            }
            h.Show();
            this.Hide();

        }

        private void Home1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            if (h == null)
            {
                h.Parent = this;
            }
            h.Show();
            this.Hide();
        }

        private void Employee1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            if (em == null)
            {
                em.Parent = this;
            }
            em.Show();
            this.Hide();
        }

        private void Bonus1_Click(object sender, EventArgs e)
        {
            Bonus b = new Bonus();
            if (b == null)
            {
                b.Parent = this;
            }
            b.Show();
            this.Hide();
        }

        private void Attendance1_Click(object sender, EventArgs e)
        {
            Attendance a = new Attendance();
            if (a == null)
            {
                a.Parent = this;
            }
            a.Show();
            this.Hide();
        }

        private void EmpId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmpName();
            GetAttendance();
            GetBonus();
        }

       

        private void BId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBonusAmount();
        }

        private void AttNum_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAttendanceinfo();
        }

        private void Total_Click(object sender, EventArgs e)
        {
           if(EmpBasSal.Text == "" || DayPres.Text == "" | BAmt.Text == "")
            {

                MessageBox.Show("Please Fill Data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                DP = Convert.ToInt32(DayPres.Text);
                DE = Convert.ToInt32(DayExcused.Text);
                DB = Convert.ToInt32(EmpBasSal.Text) / 28;
                TT = ((DB) * DP) + ((DB / 2) * DE);
                BA = Convert.ToInt32(BAmt.Text);
                GTR = TT + BA;
                EmpBalance.Text = GTR.ToString();

            }


        }



        private void Save_Click(object sender, EventArgs e)
        {

            if (EmpBasSal.Text == "" || DayPres.Text == "" | BAmt.Text == ""||EmpBalance.Text=="")
            {
                MessageBox.Show("Please Fill Data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string sql = "insert into SalaryTbl values('" + EmpId.Text + "','" + EmpName.Text + "','" + EmpBasSal.Text + "','" + BAmt.Text + "','" + EmpBalance.Text + "','" + SalPeriod.Value.Date + "')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Record Inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowSalary();
                clear();
            }   
        }
    
    
    
    
    
    
    
    }
}
