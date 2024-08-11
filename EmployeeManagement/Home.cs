using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {
            Bonus b = new Bonus();
            if (b == null)
            {
                b.Parent = this;
            }
            b.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            if (em == null)
            {
                em.Parent = this;
            }
            em.Show();
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


        private void Empshow()
        {
            string sql = "select Count(*) from EmployeeTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            empno.Text = dt.Rows[0][0].ToString();


        }

        private void Managerc()
        {
            string pos = "Manager";
            string sql = "select Count(*) from EmployeeTbl where EmpPos='" + pos + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            manno.Text = dt.Rows[0][0].ToString();

        }

        private void Salarysum()
        {
            string sql = "select Sum(EmpTotal) from SalaryTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salary.Text = dt.Rows[0][0].ToString();
        }

        private void Bonussum()
        {
            string sql = "select Sum(EmpBonus) from SalaryTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bonus.Text = dt.Rows[0][0].ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Empshow();
            Managerc();
            Salarysum();
            Bonussum();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            if (l == null)
            {
                l.Parent = this;
            }
            l.Show();
            this.Hide();
        }
    }
}
