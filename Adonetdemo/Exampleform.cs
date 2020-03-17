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
    public partial class Exampleform : Form
    {

        SqlConnection con = null;

        SqlDataAdapter Adp = null;

        DataSet DS = null;
        public Exampleform()
        {
            InitializeComponent();
        }

        private void Exampleform_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-AIVD17Q");

            Adp = new SqlDataAdapter("select * from deptdata",con);

            DS = new DataSet();

            Adp.Fill(DS, "D");

            cbDeptno.DataSource = DS.Tables["D"];

            cbDeptno.ValueMember = "Deptno";

            cbDeptno.DisplayMember = "Dname";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Adp = new SqlDataAdapter("select * from Empdata", con);

                DS = new DataSet();

                Adp.Fill(DS, "E");

                DataRow R = DS.Tables["E"].NewRow();  // Memory allocation

                R[0] = int.Parse(txtEmpno.Text);
                R[1] = txtEname.Text;
                R[2] = txtJob.Text;
                R[3] = int.Parse(txtMGR.Text);
                R[4] = DateTime.Parse(dtpHiredata.Text);
                R[5] = int.Parse(txtSal.Text);
                R[6] = int.Parse(txtComm.Text);
                R[7] = cbDeptno.SelectedValue;

                DS.Tables["E"].Rows.Add(R);    // Assigning to Dataset

                SqlCommandBuilder cmb = new SqlCommandBuilder(Adp); // Assigning to Database

                Adp.InsertCommand = cmb.GetInsertCommand();

                Adp.Update(DS, "E");

                MessageBox.Show("1 Row Inserted");

                clear();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
             
            }
            catch (FormatException E)
            {
                MessageBox.Show("Enter only numerical values");
            }
            catch(InvalidTimeZoneException E)
            {
                MessageBox.Show("Select Time Format in IST format");
            }
            
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

    }
}
