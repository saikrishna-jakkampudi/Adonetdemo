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
    public partial class CursorEx2 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public CursorEx2()
        {
            InitializeComponent();
        }

        private void CursorEx2_Load(object sender, EventArgs e)
        {
            Con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-AIVD17Q");
           
           
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_CursorEx2", Con);

            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            Adp.SelectCommand.Parameters.AddWithValue("@Deptno", int.Parse(txtDeptno.Text));

            DataSet DS = new DataSet();

            Adp.Fill(DS, "T");

            dgvDatagrid.DataSource = DS.Tables["T"];
        }
    }
}
