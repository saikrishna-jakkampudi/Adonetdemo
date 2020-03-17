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
    public partial class CommandBuilder : Form
    {

        SqlConnection con = null;

        SqlDataAdapter Adp = null;


        public CommandBuilder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-AIVD17Q");

            Adp = new SqlDataAdapter("Select * from Empdata",con);

            DataSet DS = new DataSet();

            SqlCommandBuilder cmb = new SqlCommandBuilder(Adp);

            SqlCommand cmd = cmb.GetDeleteCommand();

            MessageBox.Show(cmd.CommandText);
        }
    }
}
