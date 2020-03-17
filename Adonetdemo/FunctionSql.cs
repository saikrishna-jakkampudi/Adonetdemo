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
    public partial class FunctionSql : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public FunctionSql()
        {
            InitializeComponent();
        }

        private void FunctionSql_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-AIVD17Q");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adp = new SqlDataAdapter("Select * from dbo.fn_Second()", Con);
            //Adp.SelectCommand.Parameters.AddWithValue("@Deptno", int.Parse(txtDeptno.Text));

            //  Adp = new SqlDataAdapter("sp_Gros", Con);

            //Adp = new SqlDataAdapter("Select Empno,Ename,dbo.fn_GrossSal(Empno) from EmpLoc", Con);
            //   Adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            //Adp = new SqlDataAdapter("Select Empno,dbo.fn_Hiredate(Empno) from EMPDATA", Con);


            Adp = new SqlDataAdapter("Select Empno,dbo.fn_Hiredate1(Hiredate) from EMPDATA", Con);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "E");
            dataGridView1.DataSource = DS.Tables["E"];
        }
    }
}
