namespace Adonetdemo
{
    partial class Exampleform
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtMGR = new System.Windows.Forms.TextBox();
            this.dtpHiredata = new System.Windows.Forms.DateTimePicker();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtComm = new System.Windows.Forms.TextBox();
            this.cbDeptno = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "MGR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "HireDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Deptno";
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(488, 59);
            this.txtEmpno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(148, 22);
            this.txtEmpno.TabIndex = 8;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(488, 106);
            this.txtEname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(148, 22);
            this.txtEname.TabIndex = 9;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(488, 161);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(148, 22);
            this.txtJob.TabIndex = 10;
            this.txtJob.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMGR
            // 
            this.txtMGR.Location = new System.Drawing.Point(488, 204);
            this.txtMGR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMGR.Name = "txtMGR";
            this.txtMGR.Size = new System.Drawing.Size(148, 22);
            this.txtMGR.TabIndex = 11;
            // 
            // dtpHiredata
            // 
            this.dtpHiredata.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHiredata.Location = new System.Drawing.Point(488, 253);
            this.dtpHiredata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHiredata.Name = "dtpHiredata";
            this.dtpHiredata.Size = new System.Drawing.Size(298, 22);
            this.dtpHiredata.TabIndex = 12;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(488, 304);
            this.txtSal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(148, 22);
            this.txtSal.TabIndex = 13;
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(488, 343);
            this.txtComm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(148, 22);
            this.txtComm.TabIndex = 14;
            // 
            // cbDeptno
            // 
            this.cbDeptno.FormattingEnabled = true;
            this.cbDeptno.Location = new System.Drawing.Point(488, 381);
            this.cbDeptno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDeptno.Name = "cbDeptno";
            this.cbDeptno.Size = new System.Drawing.Size(179, 24);
            this.cbDeptno.TabIndex = 15;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(488, 477);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(112, 28);
            this.btSubmit.TabIndex = 16;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // Exampleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 554);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exampleform";
            this.Text = "Exampleform";
            this.Load += new System.EventHandler(this.Exampleform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtMGR;
        private System.Windows.Forms.DateTimePicker dtpHiredata;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.ComboBox cbDeptno;
        private System.Windows.Forms.Button btSubmit;
    }
}