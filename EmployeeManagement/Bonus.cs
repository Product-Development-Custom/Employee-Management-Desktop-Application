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
    public partial class Bonus : Form
    {
        int BId = 0;

        public Bonus()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
            Home h = new Home();
            if (h == null)
            {
                h.Parent = this;
            }
            h.Show();
            this.Hide();


        }

        private void ShowEmployee()
        {
            string sql = " Select * from BonusTbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BonusGridView.DataSource = dt;

        }
        private void clear()
        {
            BName.Text = BAmt.Text = string.Empty;

        }

        private void Bonus_Load(object sender, EventArgs e)
        {
            ShowEmployee();

           

            BonusGridView.EnableHeadersVisualStyles = false;
            
        }



        private void BonusGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BName.Text = BonusGridView.SelectedRows[0].Cells[1].Value.ToString();
            BAmt.Text = BonusGridView.SelectedRows[0].Cells[2].Value.ToString();
            if (BName.Text == "")
            {
                BId = 0;
            }
            else
            {
                BId = Convert.ToInt32(BonusGridView.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (BName.Text == "" || BAmt.Text == "")
            {
                MessageBox.Show("Please Enter Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "insert into BonusTbl values('" + BName.Text + "','" + BAmt.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowEmployee();
                MessageBox.Show("Record Inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (BName.Text == "" || BAmt.Text=="")
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "Update BonusTbl Set BName='" + BName.Text + "',BAmt='" + BAmt.Text + "' where BId='" + BId + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowEmployee();
                MessageBox.Show("Record Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (BId == 0)
            {
                MessageBox.Show("Please Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string sql = "delete from BonusTbl where BId='" + BId + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowEmployee();
                MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           Home h=new Home();
            if (h == null)
            {
                h.Parent = this;
            }
            h.Show();
            this.Hide();
        }
    }
}
