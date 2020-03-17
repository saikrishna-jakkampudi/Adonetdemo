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
    public partial class Cursor : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public Cursor()
        {
            InitializeComponent();
        }

        private void Cursor_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-AIVD17Q");
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_CursorEx", Con);

            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            Adp.SelectCommand.Parameters.AddWithValue("@Deptno", int.Parse(txtDeptno.Text));

            SqlParameter P = new SqlParameter("@Status", SqlDbType.NVarChar, 200);

            P.Direction = ParameterDirection.Output;

            Adp.SelectCommand.Parameters.Add(P);

            DataSet DS = new DataSet();

            Adp.Fill(DS);

            MessageBox.Show(P.Value.ToString());
        }
    }
}
