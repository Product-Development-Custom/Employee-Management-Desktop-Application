using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Attendance : Form
    {
        int AttNum = 0;
        
        public Attendance()
        {
            InitializeComponent();
           
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            ShowAttendance();
            GetEmp();
            GetEmpName();

            AttenGridView.EnableHeadersVisualStyles = false;
           
        }


        private void ShowAttendance()
        {
            string sql = " Select * from AttendanceTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AttenGridView.DataSource = dt;

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
        private void GetEmpName()
        {
            
            string sql = "select * from EmployeeTbl where EmpId="+EmpId.SelectedValue.ToString()+"";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpName.Text = dr["EmpName"].ToString();
            }
        }
        private void clear()
        {
            EmpId.Text = EmpName.Text = DayPres.Text = DayAbs.Text = DayExcused.Text = Period.Text = string.Empty;
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
        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmpName();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "" || EmpName.Text == "" || DayPres.Text == "" || DayAbs.Text == "" || DayExcused.Text == "")
            {
                MessageBox.Show("Please Enter Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = " insert into AttendanceTbl values('" + EmpId.Text + "','" + EmpName.Text + "','" + DayPres.Text + "','" + DayAbs.Text + "','" + DayExcused.Text + "','" + Period.Value.Date + "')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowAttendance();
                MessageBox.Show("Record Inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "" || EmpName.Text == "" || DayPres.Text == "" || DayAbs.Text == "" || DayExcused.Text == "")
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = " update AttendanceTbl Set DayPres='" + DayPres.Text + "',DayAbs='" + DayAbs.Text + "', DayExcused='" + DayExcused.Text + "',Period='" + Period.Value.Date + "' where AttNum='" + AttNum + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowAttendance();
                MessageBox.Show("Record Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void AttenGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpId.Text = AttenGridView.SelectedRows[0].Cells[1].Value.ToString();
            EmpName.Text = AttenGridView.SelectedRows[0].Cells[2].Value.ToString();
            DayPres.Text = AttenGridView.SelectedRows[0].Cells[3].Value.ToString();
            DayAbs.Text = AttenGridView.SelectedRows[0].Cells[4].Value.ToString();
            DayExcused.Text = AttenGridView.SelectedRows[0].Cells[5].Value.ToString();
            Period.Text = AttenGridView.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpId.Text == "")
            {
                AttNum = 0;
            }
            else
            {
                AttNum= Convert.ToInt32(AttenGridView.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (AttNum == 0)
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string sql = "delete from AttendanceTbl where AttNum='" + AttNum + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowAttendance();
                MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

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

        private void Salary1_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            if (s == null)
            {
                s.Parent = this;
            }
            s.Show();
            this.Hide();
        }
    }
}
