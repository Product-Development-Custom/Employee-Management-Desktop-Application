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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            try
            {
                string sql = "select * from LoginTbl where UserName='"+UserName.Text+"'AND Password='"+Password.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                  
                    Home h = new Home();
                    if (h == null)
                    {
                        h.Parent = this;
                    }
                    h.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid UserName Or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
               
            }
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == false)
            {
                Password.UseSystemPasswordChar= true;
            }
            else
            {
                Password.UseSystemPasswordChar=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Register r = new Register();
            if (r == null)
            {
                r.Parent = this;
            }
            r.Show();
            this.Hide();
        }
    }
}
