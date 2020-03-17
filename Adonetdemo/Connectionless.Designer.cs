namespace Adonetdemo
{
    partial class Connectionless
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
            this.DEPTNO = new System.Windows.Forms.Label();
            this.txtDeptno = new System.Windows.Forms.TextBox();
            this.btExtract = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cbDeptno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DEPTNO
            // 
            this.DEPTNO.AutoSize = true;
            this.DEPTNO.Location = new System.Drawing.Point(197, 144);
            this.DEPTNO.Name = "DEPTNO";
            this.DEPTNO.Size = new System.Drawing.Size(70, 13);
            this.DEPTNO.TabIndex = 0;
            this.DEPTNO.Text = "Enter Deptno";
            this.DEPTNO.Click += new System.EventHandler(this.DEPTNO_Click);
            // 
            // txtDeptno
            // 
            this.txtDeptno.Location = new System.Drawing.Point(621, 134);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(100, 20);
            this.txtDeptno.TabIndex = 1;
            // 
            // btExtract
            // 
            this.btExtract.Location = new System.Drawing.Point(474, 134);
            this.btExtract.Name = "btExtract";
            this.btExtract.Size = new System.Drawing.Size(75, 23);
            this.btExtract.TabIndex = 2;
            this.btExtract.Text = "Extract";
            this.btExtract.UseVisualStyleBackColor = true;
            this.btExtract.Click += new System.EventHandler(this.btExtract_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(224, 215);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(480, 157);
            this.dgvData.TabIndex = 3;
            // 
            // cbDeptno
            // 
            this.cbDeptno.FormattingEnabled = true;
            this.cbDeptno.Location = new System.Drawing.Point(300, 136);
            this.cbDeptno.Name = "cbDeptno";
            this.cbDeptno.Size = new System.Drawing.Size(121, 21);
            this.cbDeptno.TabIndex = 4;
            this.cbDeptno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Connectionless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDeptno);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btExtract);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.DEPTNO);
            this.Name = "Connectionless";
            this.Text = "Connectionless";
            this.Load += new System.EventHandler(this.Connectionless_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DEPTNO;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btExtract;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cbDeptno;
    }
}