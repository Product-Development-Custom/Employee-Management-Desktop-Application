using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Employee : Form
    {
        int EmpId = 0;

        public Employee()
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

        private void Employee_Load(object sender, EventArgs e)
        {
            ShowEmployee();

           EmpGridView.EnableHeadersVisualStyles = false;
         }


        private void ShowEmployee()
        {
            string sql = " Select * from EmployeeTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EmpGridView.DataSource = dt;

        }
        private void clear()
        {
            EmpName.Text = EmpGen.Text = EmpAdd.Text = EmpJDate.Text = EmpQual.Text = EmpBasSal.Text = EmpPos.Text = EmpPhone.Text = EmpDOB.Text = string.Empty;


        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (EmpName.Text == "" || EmpAdd.Text == "" || EmpPhone.Text == "" || EmpGen.SelectedIndex == -1 || EmpAdd.Text == "" || EmpBasSal.Text == "" || EmpPos.SelectedIndex == -1 || EmpQual.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string sql = "insert into EmployeeTbl values('" + EmpName.Text + "','" + EmpGen.SelectedItem.ToString() + "','" + EmpDOB.Value.Date + "','" + EmpPhone.Text + "','" + EmpAdd.Text + "','" + EmpPos.SelectedItem.ToString() + "','" + EmpJDate.Value.Date + "','" + EmpQual.SelectedItem.ToString() + "','" + EmpBasSal.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowEmployee();
                MessageBox.Show("Record Inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();


            }
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (EmpName.Text == "" || EmpAdd.Text == "" || EmpPhone.Text == "" || EmpGen.SelectedIndex == -1 || EmpAdd.Text == "" || EmpBasSal.Text == "" || EmpPos.SelectedIndex == -1 || EmpQual.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string sql = "update EmployeeTbl Set  EmpName ='" + EmpName.Text + "',EmpGen ='" + EmpGen.SelectedItem.ToString() + "',EmpDOB='" + EmpDOB.Value.Date + "',EmpPhone='" + EmpPhone.Text + "',EmpAdd='" + EmpAdd.Text + "',EmpPos='" + EmpPos.SelectedItem.ToString() + "', EmpJDate='" + EmpJDate.Value.Date + "',EmpQual='" + EmpQual.SelectedItem.ToString() + "', EmpBasSal='" + EmpBasSal.Text + "'where EmpId='" + EmpId + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowEmployee();
                MessageBox.Show("Record Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void EmpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            EmpName.Text = EmpGridView.SelectedRows[0].Cells[1].Value.ToString();
            EmpGen.SelectedItem = EmpGridView.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = EmpGridView.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhone.Text = EmpGridView.SelectedRows[0].Cells[4].Value.ToString();
            EmpAdd.Text = EmpGridView.SelectedRows[0].Cells[5].Value.ToString();
            EmpPos.SelectedItem = EmpGridView.SelectedRows[0].Cells[6].Value.ToString();
            EmpJDate.Text = EmpGridView.SelectedRows[0].Cells[7].Value.ToString();
            EmpQual.SelectedItem = EmpGridView.SelectedRows[0].Cells[8].Value.ToString();
            EmpBasSal.Text = EmpGridView.SelectedRows[0].Cells[9].Value.ToString();
            if (EmpName.Text == "")
            {
                EmpId = 0;
            }
            else
            {
                EmpId = Convert.ToInt32(EmpGridView.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (EmpId == 0)
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string sql = "delete from EmployeeTbl where EmpId='" + EmpId + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowEmployee();
                MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

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
    }
}
