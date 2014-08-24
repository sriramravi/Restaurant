namespace Restarent
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnItem = new System.Windows.Forms.Button();
            this.GBAddNewEntry = new System.Windows.Forms.GroupBox();
            this.GBPrintBill = new System.Windows.Forms.GroupBox();
            this.btnTotay = new System.Windows.Forms.Button();
            this.DGToday = new System.Windows.Forms.DataGridView();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprintOderNo = new System.Windows.Forms.TextBox();
            this.DGPrint = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GbMakeOrder = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBItemCollection = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbltableno = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.CBUserName = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtQuantityOrder = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblcashType = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblVATDbvalue = new System.Windows.Forms.Label();
            this.lblBalanceAmountValue = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.txtTotalPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lbltotalPayableAmountValue = new System.Windows.Forms.Label();
            this.LblTotalPayableAmount = new System.Windows.Forms.Label();
            this.lblVatamountvalue = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.lblcurrentoderno = new System.Windows.Forms.Label();
            this.DGMakeorder = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.GBAddNewEntry.SuspendLayout();
            this.GBPrintBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GbMakeOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMakeorder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(50, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 29);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add New Item";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(992, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Print Existing Bill ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(160, 69);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(232, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(160, 121);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 20);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 171);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // btnItem
            // 
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(127, 247);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(203, 40);
            this.btnItem.TabIndex = 6;
            this.btnItem.Text = "Save Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // GBAddNewEntry
            // 
            this.GBAddNewEntry.Controls.Add(this.dataGridView1);
            this.GBAddNewEntry.Controls.Add(this.btnItem);
            this.GBAddNewEntry.Controls.Add(this.label3);
            this.GBAddNewEntry.Controls.Add(this.txtPrice);
            this.GBAddNewEntry.Controls.Add(this.label2);
            this.GBAddNewEntry.Controls.Add(this.txtQuantity);
            this.GBAddNewEntry.Controls.Add(this.label1);
            this.GBAddNewEntry.Controls.Add(this.txtItemName);
            this.GBAddNewEntry.Location = new System.Drawing.Point(6, 83);
            this.GBAddNewEntry.Name = "GBAddNewEntry";
            this.GBAddNewEntry.Size = new System.Drawing.Size(923, 482);
            this.GBAddNewEntry.TabIndex = 1;
            this.GBAddNewEntry.TabStop = false;
            this.GBAddNewEntry.Text = "Add New Entry";
            this.GBAddNewEntry.Enter += new System.EventHandler(this.GBAddNewEntry_Enter);
            // 
            // GBPrintBill
            // 
            this.GBPrintBill.Controls.Add(this.button1);
            this.GBPrintBill.Controls.Add(this.btnTotay);
            this.GBPrintBill.Controls.Add(this.DGToday);
            this.GBPrintBill.Controls.Add(this.btnPrintOrder);
            this.GBPrintBill.Controls.Add(this.label4);
            this.GBPrintBill.Controls.Add(this.txtprintOderNo);
            this.GBPrintBill.Controls.Add(this.DGPrint);
            this.GBPrintBill.Location = new System.Drawing.Point(90, 55);
            this.GBPrintBill.Name = "GBPrintBill";
            this.GBPrintBill.Size = new System.Drawing.Size(833, 480);
            this.GBPrintBill.TabIndex = 0;
            this.GBPrintBill.TabStop = false;
            this.GBPrintBill.Text = "Print Bill";
            // 
            // btnTotay
            // 
            this.btnTotay.Location = new System.Drawing.Point(564, 20);
            this.btnTotay.Name = "btnTotay";
            this.btnTotay.Size = new System.Drawing.Size(148, 36);
            this.btnTotay.TabIndex = 4;
            this.btnTotay.Text = "To View the Today order";
            this.btnTotay.UseVisualStyleBackColor = true;
            this.btnTotay.Click += new System.EventHandler(this.btnTotay_Click);
            // 
            // DGToday
            // 
            this.DGToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGToday.Location = new System.Drawing.Point(515, 64);
            this.DGToday.Name = "DGToday";
            this.DGToday.Size = new System.Drawing.Size(275, 265);
            this.DGToday.TabIndex = 5;
            this.DGToday.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGToday_MouseDoubleClick);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(143, 357);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(146, 53);
            this.btnPrintOrder.TabIndex = 3;
            this.btnPrintOrder.Text = "PRINT";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter Order Number";
            // 
            // txtprintOderNo
            // 
            this.txtprintOderNo.Location = new System.Drawing.Point(254, 35);
            this.txtprintOderNo.Name = "txtprintOderNo";
            this.txtprintOderNo.Size = new System.Drawing.Size(100, 20);
            this.txtprintOderNo.TabIndex = 1;
            this.txtprintOderNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprintOderNo_KeyPress);
            this.txtprintOderNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // DGPrint
            // 
            this.DGPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPrint.Location = new System.Drawing.Point(15, 69);
            this.DGPrint.Name = "DGPrint";
            this.DGPrint.Size = new System.Drawing.Size(454, 260);
            this.DGPrint.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 218);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // GbMakeOrder
            // 
            this.GbMakeOrder.Controls.Add(this.groupBox2);
            this.GbMakeOrder.Controls.Add(this.groupBox1);
            this.GbMakeOrder.Location = new System.Drawing.Point(53, 66);
            this.GbMakeOrder.Name = "GbMakeOrder";
            this.GbMakeOrder.Size = new System.Drawing.Size(927, 493);
            this.GbMakeOrder.TabIndex = 9;
            this.GbMakeOrder.TabStop = false;
            this.GbMakeOrder.Text = "MakeOrder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBItemCollection);
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Controls.Add(this.lblItemName);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.lbltableno);
            this.groupBox2.Controls.Add(this.txtTableNo);
            this.groupBox2.Controls.Add(this.CBUserName);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.txtQuantityOrder);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.btnMakeOrder);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.lblOrderNumber);
            this.groupBox2.Controls.Add(this.lblcashType);
            this.groupBox2.Controls.Add(this.txtOrderNumber);
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 438);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // CBItemCollection
            // 
            this.CBItemCollection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBItemCollection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBItemCollection.FormattingEnabled = true;
            this.CBItemCollection.Location = new System.Drawing.Point(206, 112);
            this.CBItemCollection.Name = "CBItemCollection";
            this.CBItemCollection.Size = new System.Drawing.Size(100, 21);
            this.CBItemCollection.TabIndex = 18;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(312, 162);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(14, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "0";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(60, 113);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(204, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Make New Order";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbltableno
            // 
            this.lbltableno.AutoSize = true;
            this.lbltableno.Location = new System.Drawing.Point(67, 69);
            this.lbltableno.Name = "lbltableno";
            this.lbltableno.Size = new System.Drawing.Size(51, 13);
            this.lbltableno.TabIndex = 0;
            this.lbltableno.Text = "Table No";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(204, 70);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(100, 20);
            this.txtTableNo.TabIndex = 1;
            this.txtTableNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableNo_KeyPress);
            // 
            // CBUserName
            // 
            this.CBUserName.FormattingEnabled = true;
            this.CBUserName.Location = new System.Drawing.Point(204, 197);
            this.CBUserName.Name = "CBUserName";
            this.CBUserName.Size = new System.Drawing.Size(100, 21);
            this.CBUserName.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(72, 157);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(61, 201);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(57, 13);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "UserName";
            // 
            // txtQuantityOrder
            // 
            this.txtQuantityOrder.Location = new System.Drawing.Point(204, 155);
            this.txtQuantityOrder.Name = "txtQuantityOrder";
            this.txtQuantityOrder.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityOrder.TabIndex = 3;
            this.txtQuantityOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityOrder_KeyPress);
            this.txtQuantityOrder.Leave += new System.EventHandler(this.txtQuantityOrder_Leave);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(268, 248);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(95, 283);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(130, 44);
            this.btnMakeOrder.TabIndex = 7;
            this.btnMakeOrder.Text = "ADD";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(204, 248);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(48, 25);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(70, 13);
            this.lblOrderNumber.TabIndex = 9;
            this.lblOrderNumber.Text = "OrderNumber";
            // 
            // lblcashType
            // 
            this.lblcashType.AutoSize = true;
            this.lblcashType.Location = new System.Drawing.Point(60, 245);
            this.lblcashType.Name = "lblcashType";
            this.lblcashType.Size = new System.Drawing.Size(58, 13);
            this.lblcashType.TabIndex = 11;
            this.lblcashType.Text = "Cash Type";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(204, 25);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 23);
            this.txtOrderNumber.TabIndex = 10;
            this.txtOrderNumber.Enter += new System.EventHandler(this.txtOrderNumber_Enter);
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            this.txtOrderNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOrderNumber_KeyUp);
            this.txtOrderNumber.Leave += new System.EventHandler(this.txtOrderNumber_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.lblVATDbvalue);
            this.groupBox1.Controls.Add(this.lblBalanceAmountValue);
            this.groupBox1.Controls.Add(this.lblBalanceAmount);
            this.groupBox1.Controls.Add(this.txtTotalPaidAmount);
            this.groupBox1.Controls.Add(this.lblPaidAmount);
            this.groupBox1.Controls.Add(this.lbltotalPayableAmountValue);
            this.groupBox1.Controls.Add(this.LblTotalPayableAmount);
            this.groupBox1.Controls.Add(this.lblVatamountvalue);
            this.groupBox1.Controls.Add(this.lblTotalAmountValue);
            this.groupBox1.Controls.Add(this.lblVat);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.lblvalue);
            this.groupBox1.Controls.Add(this.lblcurrentoderno);
            this.groupBox1.Controls.Add(this.DGMakeorder);
            this.groupBox1.Location = new System.Drawing.Point(372, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 438);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Order";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(6, 316);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 42);
            this.btnPay.TabIndex = 28;
            this.btnPay.Text = "PAY/ PRINT";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblVATDbvalue
            // 
            this.lblVATDbvalue.AutoSize = true;
            this.lblVATDbvalue.Location = new System.Drawing.Point(331, 344);
            this.lblVATDbvalue.Name = "lblVATDbvalue";
            this.lblVATDbvalue.Size = new System.Drawing.Size(13, 13);
            this.lblVATDbvalue.TabIndex = 27;
            this.lblVATDbvalue.Text = "0";
            // 
            // lblBalanceAmountValue
            // 
            this.lblBalanceAmountValue.AutoSize = true;
            this.lblBalanceAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmountValue.Location = new System.Drawing.Point(439, 415);
            this.lblBalanceAmountValue.Name = "lblBalanceAmountValue";
            this.lblBalanceAmountValue.Size = new System.Drawing.Size(16, 16);
            this.lblBalanceAmountValue.TabIndex = 26;
            this.lblBalanceAmountValue.Text = "0";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Location = new System.Drawing.Point(259, 415);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(106, 13);
            this.lblBalanceAmount.TabIndex = 25;
            this.lblBalanceAmount.Text = "BALANCE AMOUNT";
            // 
            // txtTotalPaidAmount
            // 
            this.txtTotalPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPaidAmount.Location = new System.Drawing.Point(381, 385);
            this.txtTotalPaidAmount.Name = "txtTotalPaidAmount";
            this.txtTotalPaidAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPaidAmount.TabIndex = 18;
            this.txtTotalPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPaidAmount_KeyPress);
            this.txtTotalPaidAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalPaidAmount_KeyUp);
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Location = new System.Drawing.Point(283, 391);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(82, 13);
            this.lblPaidAmount.TabIndex = 24;
            this.lblPaidAmount.Text = "PAID AMOUNT";
            // 
            // lbltotalPayableAmountValue
            // 
            this.lbltotalPayableAmountValue.AutoSize = true;
            this.lbltotalPayableAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalPayableAmountValue.Location = new System.Drawing.Point(439, 364);
            this.lbltotalPayableAmountValue.Name = "lbltotalPayableAmountValue";
            this.lbltotalPayableAmountValue.Size = new System.Drawing.Size(16, 16);
            this.lbltotalPayableAmountValue.TabIndex = 23;
            this.lbltotalPayableAmountValue.Text = "0";
            // 
            // LblTotalPayableAmount
            // 
            this.LblTotalPayableAmount.AutoSize = true;
            this.LblTotalPayableAmount.Location = new System.Drawing.Point(222, 367);
            this.LblTotalPayableAmount.Name = "LblTotalPayableAmount";
            this.LblTotalPayableAmount.Size = new System.Drawing.Size(143, 13);
            this.LblTotalPayableAmount.TabIndex = 22;
            this.LblTotalPayableAmount.Text = "TOTAL PAYABLE AMOUNT";
            // 
            // lblVatamountvalue
            // 
            this.lblVatamountvalue.AutoSize = true;
            this.lblVatamountvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatamountvalue.Location = new System.Drawing.Point(439, 340);
            this.lblVatamountvalue.Name = "lblVatamountvalue";
            this.lblVatamountvalue.Size = new System.Drawing.Size(16, 16);
            this.lblVatamountvalue.TabIndex = 21;
            this.lblVatamountvalue.Text = "0";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(439, 316);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(16, 16);
            this.lblTotalAmountValue.TabIndex = 20;
            this.lblTotalAmountValue.Text = "0";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(302, 343);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(34, 13);
            this.lblVat.TabIndex = 19;
            this.lblVat.Text = "VAT -";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(261, 319);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 13);
            this.lblTotalAmount.TabIndex = 18;
            this.lblTotalAmount.Text = "TOTAL AMOUNT(+)";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalue.Location = new System.Drawing.Point(140, 17);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(16, 16);
            this.lblvalue.TabIndex = 9;
            this.lblvalue.Text = "0";
            // 
            // lblcurrentoderno
            // 
            this.lblcurrentoderno.AutoSize = true;
            this.lblcurrentoderno.Location = new System.Drawing.Point(15, 16);
            this.lblcurrentoderno.Name = "lblcurrentoderno";
            this.lblcurrentoderno.Size = new System.Drawing.Size(119, 13);
            this.lblcurrentoderno.TabIndex = 8;
            this.lblcurrentoderno.Text = "Current Order Number : ";
            // 
            // DGMakeorder
            // 
            this.DGMakeorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMakeorder.Location = new System.Drawing.Point(6, 33);
            this.DGMakeorder.Name = "DGMakeorder";
            this.DGMakeorder.Size = new System.Drawing.Size(509, 267);
            this.DGMakeorder.TabIndex = 7;
            this.DGMakeorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGMakeorder_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.GbMakeOrder);
            this.Controls.Add(this.GBPrintBill);
            this.Controls.Add(this.GBAddNewEntry);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.GBAddNewEntry.ResumeLayout(false);
            this.GBAddNewEntry.PerformLayout();
            this.GBPrintBill.ResumeLayout(false);
            this.GBPrintBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GbMakeOrder.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMakeorder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.GroupBox GBAddNewEntry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBPrintBill;
        private System.Windows.Forms.Button btnTotay;
        private System.Windows.Forms.DataGridView DGToday;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprintOderNo;
        private System.Windows.Forms.DataGridView DGPrint;
        private System.Windows.Forms.GroupBox GbMakeOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBItemCollection;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbltableno;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.ComboBox CBUserName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtQuantityOrder;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblcashType;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblVATDbvalue;
        private System.Windows.Forms.Label lblBalanceAmountValue;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.TextBox txtTotalPaidAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lbltotalPayableAmountValue;
        private System.Windows.Forms.Label LblTotalPayableAmount;
        private System.Windows.Forms.Label lblVatamountvalue;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Label lblcurrentoderno;
        private System.Windows.Forms.DataGridView DGMakeorder;
        private System.Windows.Forms.Button button1;
    }
}