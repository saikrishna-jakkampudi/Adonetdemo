namespace Adonetdemo
{
    partial class Bigtrigger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderid = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtOrderdesc = new System.Windows.Forms.TextBox();
            this.cbbCustomerid = new System.Windows.Forms.ComboBox();
            this.cbbSalesmanid = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.Productid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClick = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orderid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "OrderDescription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Salesman Name";
            // 
            // txtOrderid
            // 
            this.txtOrderid.Enabled = false;
            this.txtOrderid.Location = new System.Drawing.Point(202, 68);
            this.txtOrderid.Name = "txtOrderid";
            this.txtOrderid.Size = new System.Drawing.Size(100, 20);
            this.txtOrderid.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(535, 68);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 1;
            // 
            // txtOrderdesc
            // 
            this.txtOrderdesc.Location = new System.Drawing.Point(202, 114);
            this.txtOrderdesc.Name = "txtOrderdesc";
            this.txtOrderdesc.Size = new System.Drawing.Size(100, 20);
            this.txtOrderdesc.TabIndex = 1;
            // 
            // cbbCustomerid
            // 
            this.cbbCustomerid.FormattingEnabled = true;
            this.cbbCustomerid.Location = new System.Drawing.Point(535, 117);
            this.cbbCustomerid.Name = "cbbCustomerid";
            this.cbbCustomerid.Size = new System.Drawing.Size(121, 21);
            this.cbbCustomerid.TabIndex = 2;
            // 
            // cbbSalesmanid
            // 
            this.cbbSalesmanid.FormattingEnabled = true;
            this.cbbSalesmanid.Location = new System.Drawing.Point(535, 172);
            this.cbbSalesmanid.Name = "cbbSalesmanid";
            this.cbbSalesmanid.Size = new System.Drawing.Size(121, 21);
            this.cbbSalesmanid.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productid,
            this.ProductDesc,
            this.Quantity,
            this.UnitPrice,
            this.TotalCost});
            this.dgvDisplay.Location = new System.Drawing.Point(87, 222);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(569, 150);
            this.dgvDisplay.TabIndex = 5;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
            this.dgvDisplay.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellLeave);
            this.dgvDisplay.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_RowLeave);
            this.dgvDisplay.SelectionChanged += new System.EventHandler(this.dgvDisplay_SelectionChanged);
            // 
            // Productid
            // 
            this.Productid.HeaderText = "Product ID";
            this.Productid.Name = "Productid";
            this.Productid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Productid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductDesc
            // 
            this.ProductDesc.HeaderText = "Description";
            this.ProductDesc.Name = "ProductDesc";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            // 
            // btClick
            // 
            this.btClick.Location = new System.Drawing.Point(318, 401);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(75, 23);
            this.btClick.TabIndex = 6;
            this.btClick.Text = "Click";
            this.btClick.UseVisualStyleBackColor = true;
            this.btClick.Click += new System.EventHandler(this.btClick_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClick);
            this.panel1.Controls.Add(this.dgvDisplay);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbbSalesmanid);
            this.panel1.Controls.Add(this.cbbCustomerid);
            this.panel1.Controls.Add(this.txtOrderdesc);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtOrderid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 432);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btBill
            // 
            this.btBill.Location = new System.Drawing.Point(27, 74);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(75, 23);
            this.btBill.TabIndex = 8;
            this.btBill.Text = "Addbill";
            this.btBill.UseVisualStyleBackColor = true;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // Bigtrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 484);
            this.Controls.Add(this.btBill);
            this.Controls.Add(this.panel1);
            this.Name = "Bigtrigger";
            this.Text = "Bigtrigger";
            this.Load += new System.EventHandler(this.Bigtrigger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderid;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtOrderdesc;
        private System.Windows.Forms.ComboBox cbbCustomerid;
        private System.Windows.Forms.ComboBox cbbSalesmanid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btClick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBill;
        private System.Windows.Forms.DataGridViewComboBoxColumn Productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
    }
}