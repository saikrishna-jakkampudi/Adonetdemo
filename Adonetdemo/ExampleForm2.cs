using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adonetdemo
{
    public partial class ExampleForm2 : Form
    {
        SqlConnection con =null;

        SqlDataAdapter Adp = null;

        DataSet DS = null;

        public ExampleForm2()
        {
            InitializeComponent();
        }

        private void ExampleForm2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-AIVD17Q");

            Adp = new SqlDataAdapter("select * from deptdata", con);

            DS = new DataSet();

            Adp.Fill(DS, "D");

            cbDeptno.DataSource = DS.Tables["D"];

            cbDeptno.ValueMember = "Deptno";

            cbDeptno.DisplayMember = "Dname";
        }

        
        private void btUpdate_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select * from Empdata where empno=@E", con);

            Adp.SelectCommand.Parameters.AddWithValue("@E",int.Parse(txtEmpno.Text));

            DS = new DataSet();

            Adp.Fill(DS, "E");

            DataRow R = DS.Tables["E"].Rows[0];

            R[2]    = txtJob.Text;

            R[3]    = txtMGR.Text;

            R[5]    = int.Parse(txtSal.Text);

            R[6]    = int.Parse(txtComm.Text);

            R[7]    = int.Parse(cbDeptno.Text);

            SqlCommandBuilder cmb = new SqlCommandBuilder(Adp); // Assigning to Database

            Adp.InsertCommand = cmb.GetUpdateCommand();

            Adp.Update(DS, "E");

            MessageBox.Show("1 Row Updated");

            clear();

        }
        private void clear()
        {
            txtEmpno.Text = "";

            txtEname.Text = "";

            txtJob.Text = "";

            txtMGR.Text = "";

            txtSal.Text = "";

            txtComm.Text = "";

            cbDeptno.Text = "";

            dtpHiredata.Text = "";
        }


        private void txtEmpno_Leave_1(object sender, EventArgs e)
        {

            Adp = new SqlDataAdapter("Select * from Empdata where empno=@E", con);

            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));

            DS = new DataSet();

            Adp.Fill(DS, "E");

            DataRow R = DS.Tables["E"].Rows[0];

            txtEname.Text = R[1].ToString();

            txtJob.Text = R[2].ToString();

            txtMGR.Text = R[3].ToString();

            dtpHiredata.Text = R[4].ToString();

            txtSal.Text = R[5].ToString();

            txtComm.Text = R[6].ToString();

            cbDeptno.Text = R[7].ToString();
        }

        private void txtEmpno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
