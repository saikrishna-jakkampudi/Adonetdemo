namespace Adonetdemo
{
    partial class ExampleForm2
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
            this.btUpdate = new System.Windows.Forms.Button();
            this.cbDeptno = new System.Windows.Forms.ComboBox();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.dtpHiredata = new System.Windows.Forms.DateTimePicker();
            this.txtMGR = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(386, 420);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 28);
            this.btUpdate.TabIndex = 33;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cbDeptno
            // 
            this.cbDeptno.FormattingEnabled = true;
            this.cbDeptno.Location = new System.Drawing.Point(386, 324);
            this.cbDeptno.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeptno.Name = "cbDeptno";
            this.cbDeptno.Size = new System.Drawing.Size(179, 21);
            this.cbDeptno.TabIndex = 32;
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(386, 286);
            this.txtComm.Margin = new System.Windows.Forms.Padding(4);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(148, 20);
            this.txtComm.TabIndex = 31;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(386, 247);
            this.txtSal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(148, 20);
            this.txtSal.TabIndex = 30;
            // 
            // dtpHiredata
            // 
            this.dtpHiredata.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHiredata.Location = new System.Drawing.Point(386, 196);
            this.dtpHiredata.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHiredata.Name = "dtpHiredata";
            this.dtpHiredata.Size = new System.Drawing.Size(298, 20);
            this.dtpHiredata.TabIndex = 29;
            // 
            // txtMGR
            // 
            this.txtMGR.Location = new System.Drawing.Point(386, 147);
            this.txtMGR.Margin = new System.Windows.Forms.Padding(4);
            this.txtMGR.Name = "txtMGR";
            this.txtMGR.Size = new System.Drawing.Size(148, 20);
            this.txtMGR.TabIndex = 28;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(386, 104);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(148, 20);
            this.txtJob.TabIndex = 27;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(386, 49);
            this.txtEname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(148, 20);
            this.txtEname.TabIndex = 26;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(386, 2);
            this.txtEmpno.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(148, 20);
            this.txtEmpno.TabIndex = 25;
            this.txtEmpno.TextChanged += new System.EventHandler(this.txtEmpno_TextChanged);
            this.txtEmpno.Leave += new System.EventHandler(this.txtEmpno_Leave_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Deptno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Comm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "HireDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "MGR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "EmployeeName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Empno";
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(612, 420);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 34;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // ExampleForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.cbDeptno);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.dtpHiredata);
            this.Controls.Add(this.txtMGR);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExampleForm2";
            this.Text = "ExampleForm2";
            this.Activated += new System.EventHandler(this.ExampleForm2_Load);
            this.Load += new System.EventHandler(this.ExampleForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox cbDeptno;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.DateTimePicker dtpHiredata;
        private System.Windows.Forms.TextBox txtMGR;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdelete;
    }
}