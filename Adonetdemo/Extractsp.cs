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
    public partial class Extractsp : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public Extractsp()
        {
            InitializeComponent();
        }

        private void Extractsp_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-AIVD17Q");
        }

        private void cbDeptno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpno_Leave(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_Extract", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEmpno.Text));

            //SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 200);

            //P.Direction = ParameterDirection.Output;

            //Adp.SelectCommand.Parameters.Add(P);

            DataSet DS = null;

            DS = new DataSet();

            Adp.Fill(DS, "E");// E is a name given as we are giving the instructions to extract
                                                   //txtEname.Text = DS.Tables["E"].Rows[0][1].ToString();

            DataRow R = null;

            if (DS.Tables["E"].Rows.Count !=0)  //p.value.Tostring().lengtht==0
            {

            
          /*  DataRow*/ R = DS.Tables["E"].Rows[0];
                            txtEname.Text = R[1].ToString();
                            txtJob.Text = R[2].ToString();
                            txtMGR.Text = R[3].ToString();
                            dtpHiredata.Text = R[4].ToString();
                            txtSal.Text = R[5].ToString();
                            txtComm.Text = R[6].ToString();
                            cbDeptno.Text = R[7].ToString();
            }
            else
            {
                MessageBox.Show("No Emp Exists");
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_Updatedata", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtEmpno.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@IncrementPercantage", double.Parse(txtIncrement.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@NewJob", txtJob.Text);
            SqlParameter P = new SqlParameter("@Status", SqlDbType.NVarChar,25);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            MessageBox.Show(P.Value.ToString());
        }
    }
}
