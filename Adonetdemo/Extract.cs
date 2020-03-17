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
    public partial class Extract : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Extract()
        {
            InitializeComponent();
        }

        private void Extract_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Employee;Data Source=DESKTOP-AIVD17Q");



        }

        private void txtDeptno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGetdata_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd =new SqlCommand("Select * from Empdata where Deptno=@D",con);

            cmd.Parameters.AddWithValue("@D", int.Parse(txtDeptno.Text));

            SqlDataReader R = cmd.ExecuteReader(); //

            DataSet DS = new DataSet();  // Empty Database

            DS.Tables.Add("Deptdata");  // Creating Table is Empty

            DS.Tables["Deptdata"].Load(R);  // Table is loaded with execute Reader

            dgvData.DataSource = DS.Tables["Deptdata"];

            con.Close();

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("select * from Empdata where hiredate between @S and @E", con);

            cmd.Parameters.AddWithValue("@S", DateTime.Parse(dateTimePicker1.Text));

            cmd.Parameters.AddWithValue("@E", DateTime.Parse(dateTimePicker3.Text));

            SqlDataReader R = cmd.ExecuteReader();

            DataSet DS = new DataSet();  // Empty Database

            DS.Tables.Add("Deptdata");  // Creating Table is Empty

            DS.Tables["Deptdata"].Load(R);  // Table is loaded with execute Reader

            dgvData.DataSource = DS.Tables["Deptdata"];

            con.Close();

        }

        private void btGo_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("select * from viewemp", con);

            //cmd.Parameters.AddWithValue("@S", DateTime.Parse(dateTimePicker1.Text));

            //cmd.Parameters.AddWithValue("@E", DateTime.Parse(dateTimePicker3.Text));

            SqlDataReader R = cmd.ExecuteReader();

            DataSet DS = new DataSet();  // Empty Database

            DS.Tables.Add("Deptdata");  // Creating Table is Empty

            DS.Tables["Deptdata"].Load(R);  // Table is loaded with execute Reader

            dgvData.DataSource = DS.Tables["Deptdata"];

            con.Close();
        }
    }
}
