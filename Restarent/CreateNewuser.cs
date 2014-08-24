using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlHelperDemo;

namespace Restarent
{
    public partial class CreateNewuser : Form
    {
        public CreateNewuser()
        {
            InitializeComponent();
            GridBind();
            txtuserName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GridBind()
        {
            DataSet Ds = new DataSet();
            Ds = sqlProductProvider.Getdata("select username,Name,Department,Designation,case when UserRights=1 then 'yes' else 'No' end as AdminAccess  from tbl_mas_usermaster");
            dataGridView1.DataSource = Ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "")
            {
                MessageBox.Show("UserName Required");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password Required");
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("Name Required");
                return;
            }

            if (txtDOB.Text == "")
            {
                MessageBox.Show("DOB Required");
                return;
            }
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("Department Required");
                return;
            }
            if (txtDesignation.Text == "")
            {
                MessageBox.Show("Designation Required");
                return;
            }
            if (txtMobileNo.Text == "")
            {
                MessageBox.Show("MobileNo Required");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Required");
                return;
            }
            int checkboxstatus = 0;

            if (checkBox1.Checked == true)
            {
                checkboxstatus = 1;
            }
            else
            {
                checkboxstatus = 0;
            }

            string StrGetStatus = sqlProductProvider.GetSingleStr("Pro_CreateNewUser '" + txtuserName.Text + "','" + txtPassword.Text + "','" + txtname.Text + "','" + txtDOB.Text + "','" + txtDepartment.Text + "','" + txtDesignation.Text + "','" + txtMobileNo.Text + "','" + txtAddress.Text + "'," + checkboxstatus + "");
            if (StrGetStatus == "Success") 
            {
                MessageBox.Show("User Added Successfully");
                txtuserName.Text = "";
                txtPassword.Text = "";
                txtname.Text = "";
                txtDOB.Text = "";
                txtDepartment.Text = "";
                txtDesignation.Text = "";
                txtMobileNo.Text = "";
                txtAddress.Text = "";
                checkBox1.Checked = false;
                GridBind();
                return;
            }
            else if(StrGetStatus=="AlreadyExist")
            {
                MessageBox.Show("User Already Exist");
                txtuserName.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("User Added Successfully");
                txtuserName.Text = "";
                txtPassword.Text = "";
                txtname.Text = "";
                txtDOB.Text = "";
                txtDepartment.Text = "";
                txtDesignation.Text = "";
                txtMobileNo.Text = "";
                txtAddress.Text = "";
                checkBox1.Checked = false;
                GridBind();
                return;
            }
        }
    }
}
