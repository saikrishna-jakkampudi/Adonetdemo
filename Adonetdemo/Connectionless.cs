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
    public partial class Connectionless : Form
    {
        SqlConnection con = null;

        SqlDataAdapter Adp = null;

        public Connectionless()
        {
            InitializeComponent();
        }

        private void DEPTNO_Click(object sender, EventArgs e)
        {

        }

        private void Connectionless_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-AIVD17Q");

            Adp = new SqlDataAdapter("select *  from deptdata", con);

            DataSet DS = new DataSet();

            Adp.Fill(DS, "Emp");

            cbDeptno.DisplayMember = "Dname";

            cbDeptno.ValueMember = "Deptno";

            cbDeptno.DataSource = DS.Tables["Emp"];


        }

        private void btExtract_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("select * from Empdata where Deptno=@D", con);

           Adp.SelectCommand.Parameters.AddWithValue("@D", cbDeptno.SelectedValue);

            DataSet DS = new DataSet();

            Adp.Fill(DS, "Emp");

            dgvData.DataSource = DS.Tables["Emp"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }
    }
}
