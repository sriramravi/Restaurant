using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using SqlHelperDemo;
using System.Data.SqlClient;
using Restarent;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 || textBox2.Text.Length != 0)
            {

                string StrGetStatus = sqlProductProvider.LoginStatus(textBox1.Text, textBox2.Text);
                if (StrGetStatus == "Success")
                {
                    //Succes full Login  
                    Restarent.Home HO = new Home(textBox1.Text);                    
                    HO.Show();
                    Restaurant.Form1 f1 = new Form1();
                    f1.Close();
                    return;
                    
                }
                else if (StrGetStatus == "Failure")
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Incorect Login details. Please check the Userid/Password.");
                    return;
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("UserName Not Found..");
                    return;
                }
            }
            else

            {
                MessageBox.Show("User Name/ Password Required.");
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           textBox1.Focus();
           this.AcceptButton = button1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Restarent.ChangePassword cp = new ChangePassword();
            cp.Show();
        }

      
    }
}
