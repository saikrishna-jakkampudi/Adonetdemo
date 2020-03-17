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
    public partial class Updateprcoedure : Form
    {
        SqlConnection con = null;
        SqlDataAdapter Adp = null;
        public Updateprcoedure()
        {
            InitializeComponent();
        }

        private void Updateprcoedure_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-AIVD17Q");
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_Update2emp", con);

            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEmpno.Text));

            Adp.SelectCommand.Parameters.AddWithValue("@Ename", txtEname.Text);

            //Adp.SelectCommand.Parameters.AddWithValue("@Gender",cbGender.Text);

            Adp.SelectCommand.Parameters.AddWithValue("@Dob",DateTime.Parse(dtpDob.Text));

            Adp.SelectCommand.Parameters.AddWithValue("@Deptno", int.Parse(txtDeptno.Text));

            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 200);

            P.Direction = ParameterDirection.Output;

            Adp.SelectCommand.Parameters.Add(P);

            DataSet DS = new DataSet();

            Adp.Fill(DS);

            MessageBox.Show(P.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_Deleteemp", con);

            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEmpno.Text));

            ////Adp.SelectCommand.Parameters.AddWithValue("@Ename", txtEname.Text);

            //////Adp.SelectCommand.Parameters.AddWithValue("@Gender",cbGender.Text);

            ////Adp.SelectCommand.Parameters.AddWithValue("@Dob", DateTime.Parse(dtpDob.Text));

            ////Adp.SelectCommand.Parameters.AddWithValue("@Deptno", int.Parse(txtDeptno.Text));

            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 200);

            P.Direction = ParameterDirection.Output;

            Adp.SelectCommand.Parameters.Add(P);

            DataSet DS = new DataSet();

            Adp.Fill(DS);

            MessageBox.Show(P.Value.ToString());
        }
    }
}
