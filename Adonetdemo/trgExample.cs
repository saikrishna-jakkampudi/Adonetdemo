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
    public partial class trgExample : Form
    {
        SqlConnection con = null;
        SqlDataAdapter Adp = null;

        public trgExample()
        {
            InitializeComponent();
        }

        private void trgExample_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-AIVD17Q");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_delete", con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Empno", int.Parse(txtTrigger.Text));
            SqlParameter P = new SqlParameter("@Status",SqlDbType.NVarChar,200);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            MessageBox.Show(P.Value.ToString());

        }
    }
}
