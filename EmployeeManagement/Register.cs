using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Register : Form
    {
        int userId = 0;
        public Register()
        {
            InitializeComponent();
        }

        private void ShowUser()
        {
            string sql = "select * from LoginTbl";
            SqlDataAdapter da=new SqlDataAdapter(sql,Class1.cn);
            DataTable dt=new DataTable();
            da.Fill(dt);
            LoginGridView.DataSource = dt;
            
        }
        private void clear()
        {
            Username.Text=FullName.Text=Email.Text=Password.Text=ReTypePassword.Text=string.Empty;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == false)
            {
                Password.UseSystemPasswordChar = true;
                ReTypePassword.UseSystemPasswordChar = true;
            }
            else
            {
                Password.UseSystemPasswordChar = false;
                ReTypePassword.UseSystemPasswordChar = false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Password.Text != ReTypePassword.Text)
            {
                MessageBox.Show("Password Not Match", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Username.Text == "" || FullName.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {

                string sql = "insert into LoginTbl values('" + Username.Text + "','" + FullName.Text + "','" + Email.Text + "','" + Password.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowUser();
                clear();
                MessageBox.Show("Record Inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            ShowUser();

           LoginGridView.EnableHeadersVisualStyles = false;
           
        }

        private void LoginGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            Username.Text = LoginGridView.SelectedRows[0].Cells[1].Value.ToString();
            FullName.Text = LoginGridView.SelectedRows[0].Cells[2].Value.ToString();
            Email.Text = LoginGridView.SelectedRows[0].Cells[3].Value.ToString();
            Password.Text = LoginGridView.SelectedRows[0].Cells[4].Value.ToString();
            ReTypePassword.Text = LoginGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (Username.Text == "")
            {
                userId = 0;
            }
            else
            {
                userId = Convert.ToInt32(LoginGridView.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
         
          if (Username.Text == "" || FullName.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                string sql = "Delete from LoginTbl where userId='" + userId + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowUser();
                clear();
                MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Password.Text != ReTypePassword.Text)
            {
                MessageBox.Show("Password Not Match", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Username.Text == "" || FullName.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                string sql = "Update LoginTbl set Username='" + Username.Text + "',FullName='" + FullName.Text + "',Email='" + Email.Text + "',Password='" + Password.Text + "' where userId='" + userId + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowUser();
                clear();
                MessageBox.Show("Record Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            if (l == null)
            {
                l.Parent = this;
            }
            l.Show();
            this.Hide();
            
            
        }

        private void LoginGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Username.Text = LoginGridView.SelectedRows[0].Cells[1].Value.ToString();
            FullName.Text = LoginGridView.SelectedRows[0].Cells[2].Value.ToString();
            Email.Text = LoginGridView.SelectedRows[0].Cells[3].Value.ToString();
            Password.Text = LoginGridView.SelectedRows[0].Cells[4].Value.ToString();
            Password.Text = LoginGridView.SelectedRows[0].Cells[4].Value.ToString();
            ReTypePassword.Text = LoginGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (Username.Text == "")
            {
                userId = 0;
            }
            else
            {
                userId = Convert.ToInt32(LoginGridView.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
    }
}
