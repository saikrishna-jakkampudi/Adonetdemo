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
    public partial class Insert : Form
    {
        SqlConnection Con = null;

        SqlCommand cmd = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Load(object sender, EventArgs e)
        {
            // step1

            Con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-AIVD17Q");
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text.Trim().Length != 0)
            {
                MessageBox.Show("Enter the Deatils");
            }
            else
            {
                try
                {
                    //Step2

                    Con.Open();

                    //Step3

                    cmd = new SqlCommand(" insert into Emp values(@Eno,@En,@G,@D)", Con); // ("+int.Parse(txtEmpno.Text)+","+txtEname

                    cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));

                    cmd.Parameters.AddWithValue("@En", txtEname.Text);

                    cmd.Parameters.AddWithValue("@G", cbGender.Text);

                    cmd.Parameters.AddWithValue("D", DateTime.Parse(dtpdob.Text));

                    //Step 4

                    int R = cmd.ExecuteNonQuery();

                    MessageBox.Show(R + "Inserted");

                }
                catch (SqlException E)
                {
                    if (E.Message.Contains("PK_Emp"))

                        MessageBox.Show("Empno cannot be duplicate");

                    if (E.Message.Contains("CK_Dob"))

                        MessageBox.Show("Age must be minimum 21");

                    if (E.Message.Contains("CK_Gender"))

                        MessageBox.Show("Gender Must be Selected");

                }

                catch (FormatException E)
                {
                    MessageBox.Show("Enter all Details");
                }

                //Step 5
                finally
                {
                    Con.Close();

                }

                //  ExecuteNonQUery for DML Commands
                //  ExecuteReader for select command 
                //  Excecute Scalar for one value                     
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
