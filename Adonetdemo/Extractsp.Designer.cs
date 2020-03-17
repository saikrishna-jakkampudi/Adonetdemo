namespace Adonetdemo
{
    partial class Extractsp
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
            this.btSubmit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbDeptno
            // 
            this.cbDeptno.Enabled = false;
            this.cbDeptno.FormattingEnabled = true;
            this.cbDeptno.Location = new System.Drawing.Point(386, 332);
            this.cbDeptno.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeptno.Name = "cbDeptno";
            this.cbDeptno.Size = new System.Drawing.Size(179, 21);
            this.cbDeptno.TabIndex = 31;
            this.cbDeptno.SelectedIndexChanged += new System.EventHandler(this.cbDeptno_SelectedIndexChanged);
            // 
            // txtComm
            // 
            this.txtComm.Enabled = false;
            this.txtComm.Location = new System.Drawing.Point(386, 290);
            this.txtComm.Margin = new System.Windows.Forms.Padding(4);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(148, 20);
            this.txtComm.TabIndex = 30;
            // 
            // txtSal
            // 
            this.txtSal.Enabled = false;
            this.txtSal.Location = new System.Drawing.Point(386, 246);
            this.txtSal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(148, 20);
            this.txtSal.TabIndex = 29;
            // 
            // dtpHiredata
            // 
            this.dtpHiredata.Enabled = false;
            this.dtpHiredata.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHiredata.Location = new System.Drawing.Point(386, 201);
            this.dtpHiredata.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHiredata.Name = "dtpHiredata";
            this.dtpHiredata.Size = new System.Drawing.Size(298, 20);
            this.dtpHiredata.TabIndex = 28;
            // 
            // txtMGR
            // 
            this.txtMGR.Enabled = false;
            this.txtMGR.Location = new System.Drawing.Point(386, 163);
            this.txtMGR.Margin = new System.Windows.Forms.Padding(4);
            this.txtMGR.Name = "txtMGR";
            this.txtMGR.Size = new System.Drawing.Size(148, 20);
            this.txtMGR.TabIndex = 27;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(386, 116);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(148, 20);
            this.txtJob.TabIndex = 26;
            // 
            // txtEname
            // 
            this.txtEname.Enabled = false;
            this.txtEname.Location = new System.Drawing.Point(386, 68);
            this.txtEname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(148, 20);
            this.txtEname.TabIndex = 25;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(386, 23);
            this.txtEmpno.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(148, 20);
            this.txtEmpno.TabIndex = 24;
            this.txtEmpno.Leave += new System.EventHandler(this.txtEmpno_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Deptno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Comm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "HireDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "MGR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "EmployeeName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Empno";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(337, 422);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(112, 28);
            this.btSubmit.TabIndex = 32;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Increment";
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(386, 379);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 20);
            this.txtIncrement.TabIndex = 34;
            // 
            // Extractsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 463);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSubmit);
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
            this.Name = "Extractsp";
            this.Text = "Extractsp";
            this.Load += new System.EventHandler(this.Extractsp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIncrement;
    }
}