using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlHelperDemo;
using System.Configuration;
using System.Data.SqlClient;

namespace Restarent
{
    public partial class Home : Form
    {
        string GetUserDetails = "";
        public Home(string value)
        {
            InitializeComponent();

            GetUserDetails=value;
            string StrGetUserRights=sqlProductProvider.GetSingleStr("select UserRights  from tbl_mas_usermaster where UserName='"+GetUserDetails+"'");
                if(Convert.ToInt32(StrGetUserRights)==1)
                {
                    menuStrip1.Enabled=true;
                }
                else
                {
                     menuStrip1.Enabled=false ;
                }
            WindowState = FormWindowState.Maximized;

            GridBind();

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            dataGridView1.Columns.Add(Deletelink);


            DataGridViewLinkColumn Deletelink1 = new DataGridViewLinkColumn();
            Deletelink1.UseColumnTextForLinkValue = true;
            Deletelink1.HeaderText = "delete";
            Deletelink1.DataPropertyName = "lnkColumn";
            Deletelink1.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink1.Text = "Delete";
            DGMakeorder.Columns.Add(Deletelink1);

            GBAddNewEntry.Visible = false;
            GBPrintBill.Visible = false;
            GbMakeOrder.Visible = true;

            string StrGetordeerNumber = sqlProductProvider.GetSingleStr("Select isnull(Max(OrderNumber),0) from tbl_Trans_MakeOrder");
            txtOrderNumber.Text = StrGetordeerNumber == "0" ? "1" :(Convert.ToInt32(StrGetordeerNumber)+1).ToString();
            lblvalue.Text = txtOrderNumber.Text;
          

            string StrGetTaxDetails=sqlProductProvider.GetSingleStr("select taxpercentage from tbl_mas_tax where GETDATE() between begindate and expiredate");
            lblVATDbvalue.Text=Convert.ToDecimal(StrGetTaxDetails).ToString();

            CBItemBind();
            CBuserNameBind();

            DGMakeorder.DataSource = null;

                                  
        }


        private void CBItemBind()
        {
            DataSet Ds = new DataSet();
            Ds = sqlProductProvider.Getdata("Select ItemName,itemid from tbl_Mas_Item");
            CBItemCollection.Items.Clear();
            CBItemCollection.Items.Insert(0, "Select");
            CBItemCollection.DataSource = Ds.Tables[0];
            CBItemCollection.ValueMember = "itemid";
            CBItemCollection.DisplayMember = "ItemName";
            // dataGridView1.DataMember = Ds.Tables["tbl_Mas_Item"];
        }

        private void CBuserNameBind()
        {
            DataSet Ds = new DataSet();
            Ds = sqlProductProvider.Getdata("Select UserName,userTrid from tbl_Mas_UserMaster");
            CBUserName.Items.Clear();
            CBUserName.Items.Insert(0, "Select");
            CBUserName.DataSource = Ds.Tables[0];
            CBUserName.ValueMember = "userTrid";
            CBUserName.DisplayMember = "UserName";
            // dataGridView1.DataMember = Ds.Tables["tbl_Mas_Item"];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (tabControl1.SelectedIndex == 0)
            {
                GBAddNewEntry.Visible = false;
                GbMakeOrder.Visible = true;
                GBPrintBill.Visible = false;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                GBAddNewEntry.Visible = true;
                GbMakeOrder.Visible = false;
                GBPrintBill.Visible = false;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                GBAddNewEntry.Visible = false;
                GbMakeOrder.Visible = false;
                GBPrintBill.Visible = true;
            }
            else {
                GBAddNewEntry.Visible = false;
                GbMakeOrder.Visible = false;
                GBPrintBill.Visible = false;
            }
        }
      

        private void btnItem_Click(object sender, EventArgs e)
        {
           // GridBind();
            if (txtItemName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Item Name Required");
                return;
            }
            if (txtQuantity.Text.Trim().Length < 1)
            {
                MessageBox.Show("Quantity Required");
                return;
            }
            if (txtPrice.Text.Trim().Length < 1)
            {
                MessageBox.Show("Price Required");
                return;
            }

            try
            {
                string StrGetStatus = sqlProductProvider.GetSingleStr("Pro_AddNewItem '" + txtItemName.Text + "','" + txtQuantity.Text + "','" + txtPrice.Text + "'");
                if (StrGetStatus == "Success")
                {
                    GridBind();
                    MessageBox.Show("Item Inserted Successfully");
                    txtItemName.Text = "";
                    txtQuantity.Text = "";
                    txtPrice.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex.Message.ToString());
                return;
            }
        }



        public void GridBind()
        {
            DataSet Ds=new DataSet();
            Ds=sqlProductProvider.Getdata("Select ItemName,Quantity,Price from tbl_Mas_Item");
            dataGridView1.DataSource = Ds.Tables[0];
           // dataGridView1.DataMember = Ds.Tables["tbl_Mas_Item"];
            
            
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //need to add the logic for row removed
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtItemName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtQuantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int row;
                //Get the row index
                row = e.RowIndex;            

                string strGetDeletedStatus = sqlProductProvider.GetSingleStr("delete from tbl_Mas_item where ItemName='"+dataGridView1.Rows[row].Cells[1].Value.ToString()+"'");
                GridBind();
            }
        }

       
       

        //private void LoadText()
        //{
        //    string ConString = ConfigurationManager.AppSettings["SqlConnStr"];
        //    using (SqlConnection con = new SqlConnection(ConString))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT ItemName FROM tbl_Mas_Item", con);
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
        //        while (reader.Read())
        //        {
        //            MyCollection.Add(reader.GetString(0));
        //        }
        //       // txtItemnameOrder.AutoCompleteMode = AutoCompleteMode.Append;
        //       // txtItemnameOrder.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        txtItemnameOrder.AutoCompleteCustomSource = MyCollection;                
        //        con.Close();
        //    }
        //}

           

        private void clearfields()
        {
            //txtTableNo.Text = "";
            //txtItemnameOrder.Text = "";
            CBItemCollection.Text = "Select";
            txtQuantityOrder.Text = "";
            CBUserName.Text = "Select";
            radioButton1.Checked = true;
            lblAmount.Text = "";
        }

        private void MakeOrderBind()
        {
            DataSet Ds = new DataSet();
            Ds = sqlProductProvider.Getdata("Select Orderid,OrderNumber,TableNo,ItemName,Quantity,Price,UserName,CashType  from tbl_Trans_MakeOrder where OrderNumber='"+txtOrderNumber.Text.Trim()+"'");
            DGMakeorder.DataSource = Ds.Tables[0];
            // dataGridView1.DataMember = Ds.Tables["tbl_Mas_Item"];
            
           
            decimal StrTotalAmount = 0;
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    decimal strgetPrice = Convert.ToDecimal(Ds.Tables[0].Rows[i]["price"].ToString());
                    StrTotalAmount = StrTotalAmount + strgetPrice;

                    //DGMakeorder.Rows[i].Cells[1].Visible.Equals(false);

                }
            }

            lblTotalAmountValue.Text = StrTotalAmount.ToString();
            lblVatamountvalue.Text = Convert.ToDecimal((StrTotalAmount / 100) * Convert.ToDecimal(lblVATDbvalue.Text.ToString())).ToString("0.00");
            lbltotalPayableAmountValue.Text = Convert.ToDecimal(StrTotalAmount + Convert.ToDecimal(lblVatamountvalue.Text)).ToString("0.00");

             string StrpaidStatus= sqlProductProvider.GetSingleStr("Select isnull(paidstatus,0) from tbl_Trans_MakeOrder where OrderNumber='" + txtOrderNumber.Text.Trim() + "'");


             if (Convert.ToInt32(StrpaidStatus == "" ? "0" : StrpaidStatus) == 1)
             {
                 btnPay.Enabled = false;                 
                 txtTotalPaidAmount.ReadOnly = true;
             }
             else
             {
                 btnPay.Enabled = true;
                 txtTotalPaidAmount.ReadOnly = false;
             }

             txtTotalPaidAmount.Text = lbltotalPayableAmountValue.Text;
        }
      


      
        private void lblTotalAmountValue_Click(object sender, EventArgs e)
        {
        
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                e.Handled = true;
            base.OnKeyPress(e);
        }

      
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text.Trim().Length < 1)
            {
                MessageBox.Show("Order No Required");
                txtOrderNumber.Focus();
                return;
            }
            if (txtTableNo.Text.Trim().Length < 1)
            {
                MessageBox.Show("Table No Required");
                txtTableNo.Focus();
                return;
            }
            if (CBItemCollection.Text.Trim()=="Select")
            {
                MessageBox.Show("Item Required");
                CBItemCollection.Focus();
                return;
            }
            if (txtQuantityOrder.Text.Trim().Length < 1)
            {
                MessageBox.Show("Quantity Required");
                txtQuantityOrder.Focus();
                return;
            }

            //if (CBUserName.SelectedText =="Select")
            //{
            //    MessageBox.Show("UserName Required");
            //    CBUserName.Focus();
            //    return;
            //}

            string StrGetCashMode = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
            sqlProductProvider.GetSingleStr("Pro_MakeNewOrder 'Insert','" + Convert.ToInt32(txtOrderNumber.Text.Trim()) + "','" + Convert.ToInt32(txtTableNo.Text.Trim()) + "','" + CBItemCollection.Text.Trim() + "','" + Convert.ToDecimal(txtQuantityOrder.Text.Trim()) + "','" + Convert.ToDecimal(lblAmount.Text.Trim()) + "','" + CBUserName.Text + "','','" + StrGetCashMode + "','0.0','"+Convert.ToDecimal( lblVATDbvalue.Text)+"','0.0','0.0',0");

            //,'"+Convert.ToDecimal(lbltotalPayableAmountValue.Text)+"','"+Convert.ToDecimal(lblVATDbvalue.Text)+"','"+Convert.ToDecimal( txtTotalPaidAmount.Text.Trim())+"','"+Convert.ToDecimal(lblBalanceAmountValue.Text)+"'
            MakeOrderBind();

            //DataSet Ds = new DataSet();
            //Ds = sqlProductProvider.Getdata("Select OrderNumber,TableNo,ItemName,Quantity,Price,UserName,CashType  from tbl_Trans_MakeOrder where OrderNumber='" + txtOrderNumber.Text.Trim() + "'");
            //DGMakeorder.DataSource = Ds.Tables[0];

            clearfields();
            //decimal StrTotalAmount = 0;
            //if(Ds.Tables[0].Rows.Count>0)
            //{
            //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            //    {
            //        decimal strgetPrice =Convert.ToDecimal(Ds.Tables[0].Rows[i]["price"].ToString());
            //        StrTotalAmount = StrTotalAmount + strgetPrice;

            //    }
            //}

            //lblTotalAmountValue.Text = StrTotalAmount.ToString();
            //lblVatamountvalue.Text =Convert.ToDecimal( (StrTotalAmount / 100) * Convert.ToDecimal(lblVATDbvalue.Text.ToString())).ToString("0.00");
            //lbltotalPayableAmountValue.Text = Convert.ToDecimal(StrTotalAmount+Convert.ToDecimal(lblVatamountvalue.Text)).ToString("0.00");


        }

        //private void txtItemnameOrder_KeyUp(object sender, KeyEventArgs e)
        //{
        //   // LoadText();
        //}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string StrGetordeerNumber = sqlProductProvider.GetSingleStr("Select Max(OrderNumber) from tbl_Trans_MakeOrder");
            txtOrderNumber.Text = StrGetordeerNumber == "" ? "1" : (Convert.ToInt32(StrGetordeerNumber) + 1).ToString();
            lblvalue.Text = txtOrderNumber.Text;
            txtTableNo.Text = "";
            clearfields();
            DGMakeorder.DataSource = null;
            lblTotalAmountValue.Text = "0";
            lblVatamountvalue.Text = "0";
            lbltotalPayableAmountValue.Text = "0";
            txtTotalPaidAmount.Text = "0";
            lblBalanceAmountValue.Text = "0";
        }

        private void txtQuantityOrder_Leave(object sender, EventArgs e)
        {
            try
            {
                if (CBItemCollection.Text.Trim()=="Select")
                {
                    lblAmount.Text = "0.0";
                    
                }
                else
                {
                   string StrGetValue = sqlProductProvider.GetSingleStr("select price from tbl_mas_item where ItemName='" + CBItemCollection.Text.Trim() + "' ");
                    decimal GetDbValue = Convert.ToDecimal(StrGetValue);
                    lblAmount.Text = Convert.ToDecimal(Convert.ToDecimal(txtQuantityOrder.Text.Trim()) * GetDbValue).ToString(); 
                }
            }
            catch (Exception ex)
            {
                lblAmount.Text = "0.0";

            }
        }

        private void txtQuantityOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void txtTableNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void txtTotalPaidAmount_KeyUp(object sender, KeyEventArgs e)
        {
           if (Convert.ToDecimal(lbltotalPayableAmountValue.Text) >= Convert.ToDecimal(txtTotalPaidAmount.Text))
            {
                lblBalanceAmountValue.Text = (Convert.ToDecimal(lbltotalPayableAmountValue.Text) - Convert.ToDecimal(txtTotalPaidAmount.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Please Enter lessor amout");
                txtTotalPaidAmount.Text = "";
                txtTotalPaidAmount.Focus();
            }
        }

        private void txtOrderNumber_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtOrderNumber_Leave(object sender, EventArgs e)
        {
            MakeOrderBind();
            lblvalue.Text = txtOrderNumber.Text;

        }

        private void txtOrderNumber_Enter(object sender, EventArgs e)
        {
            MakeOrderBind();
            lblvalue.Text = txtOrderNumber.Text;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (txtTotalPaidAmount.Text.Length < 1)
            {
                MessageBox.Show("Please Enter Paid Amout");
                return;
            }
            if (Convert.ToDecimal(lbltotalPayableAmountValue.Text) >= Convert.ToDecimal(txtTotalPaidAmount.Text))
            {
                string StrGetCashMode = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
                string strGetmsgStatus = sqlProductProvider.GetSingleStr("Pro_MakeNewOrder 'Update','" + Convert.ToInt32(txtOrderNumber.Text.Trim()) + "',0,'',0,0,'','','" + StrGetCashMode + "','" + Convert.ToDecimal(lbltotalPayableAmountValue.Text) + "','" + Convert.ToDecimal(lblVatamountvalue.Text) + "','" + Convert.ToDecimal(txtTotalPaidAmount.Text.Trim()) + "','" + Convert.ToDecimal(lblBalanceAmountValue.Text) + "',1");
                if (strGetmsgStatus == "AlreadyPaid")
                {
                    MessageBox.Show("Already Paid");
                    return;
                }
                else
                {
                    MessageBox.Show("Saved Successfully");
                    return;
                }
            }
          
            //,'"+Convert.ToDecimal(lbltotalPayableAmountValue.Text)+"','"+Convert.ToDecimal(lblVATDbvalue.Text)+"','"+Convert.ToDecimal( txtTotalPaidAmount.Text.Trim())+"','"+Convert.ToDecimal(lblBalanceAmountValue.Text)+"'
           
        }

        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            MakeOrderBind();
            lblvalue.Text = txtOrderNumber.Text;
        }

        private void txtTotalPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewuser Cu = new CreateNewuser();
            Cu.Show();
        }

        private void DGMakeorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int row;
                //Get the row index
                        row = e.RowIndex;
                string strGetDeletedStatus = sqlProductProvider.GetSingleStr("delete from tbl_Trans_MakeOrder where OrderId='" + DGMakeorder.Rows[row].Cells[1].Value.ToString() + "'");
                MakeOrderBind();
            }
        }

        private void GBAddNewEntry_Enter(object sender, EventArgs e)
        {

        }

        private void btnTotay_Click(object sender, EventArgs e)
        {
            DataSet Ds = new DataSet();
            Ds = sqlProductProvider.Getdata("Pro_PrintOrder '" + txtprintOderNo.Text + "','Today'");
            DGToday.DataSource = Ds.Tables[0];
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //DataSet Ds = new DataSet();
            //Ds = sqlProductProvider.Getdata("Pro_PrintOrder '"+txtprintOderNo.Text +"','Print'");
            //DGPrint.DataSource = Ds.Tables[0];
           
        }

        private void txtprintOderNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void DGToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtprintOderNo.Text = DGToday.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet Ds = new DataSet();
            Ds = sqlProductProvider.Getdata("Pro_PrintOrder '" + txtprintOderNo.Text + "','Print'");
            DGPrint.DataSource = Ds.Tables[0];
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            sqlProductProvider.cmd("insert into tbl_Print_backUp values('" + txtprintOderNo.Text + "','" + GetUserDetails + "')");
        }

      
        
    }
}
