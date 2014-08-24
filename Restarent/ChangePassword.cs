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
    public partial class ChangePassword : Form
    {

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //validation start
            if (txtUserName.Text.Length == 0)
            {
                txtUserName.BackColor = System.Drawing.Color.Aqua;
                txtUserName.Focus();
                MessageBox.Show("UserName Required");
                return;
            }
            else
            {
                txtUserName.BackColor = System.Drawing.Color.White;
            }
            if (txtNewPassword.Text.Length == 0)
            {
                txtNewPassword.BackColor = System.Drawing.Color.Aqua;
                txtNewPassword.Focus();
                MessageBox.Show("New Password Required");
                return;
            }
            else
            {
                txtNewPassword.BackColor = System.Drawing.Color.White;
            }
            if (txtConfirmnewPassword.Text.Length == 0)
            {
                txtConfirmnewPassword.BackColor = System.Drawing.Color.Aqua;
                txtConfirmnewPassword.Focus();
                MessageBox.Show("ConfirmNew Password Required");
                return;
            }
            else
            {
                txtConfirmnewPassword.BackColor = System.Drawing.Color.White;
            }
            if (txtNewPassword.Text != txtConfirmnewPassword.Text)
            {
                txtNewPassword.BackColor = System.Drawing.Color.Aqua;
                txtNewPassword.Focus();
                txtConfirmnewPassword.BackColor = System.Drawing.Color.Aqua;
                txtConfirmnewPassword.Focus();
                MessageBox.Show("New Password and Confirm NewPassword should be same");
                return;
            }
            else
            {
                txtConfirmnewPassword.BackColor = System.Drawing.Color.White;
                txtNewPassword.BackColor = System.Drawing.Color.White;
            }
            

            //validation start

            //Check Logic 

            string StrQuery = "Pro_ChangePassword '" + txtUserName.Text + "','" + txtConfirmnewPassword.Text + "','" + dateTimePicker1.Text + "'";
            string StrGetStatus = sqlProductProvider.GetSingleStr(StrQuery);
            if (StrGetStatus == "Invalid")
            {
                MessageBox.Show("Invalid UserName");
                return;
            }
            else if (StrGetStatus == "Success")
            {
                MessageBox.Show("Password Changed Successfully");
                return;
            }
            else
            {
                MessageBox.Show("Invalid Details");
                return;
            }


        } 

       
       
        

        private void ChangePassword_Load_1(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
