using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Adonetdemo
{
    
    public partial class Update : Form
    {
        SqlConnection con = null;

        SqlCommand cmd = null;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-AIVD17Q");

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("Update Emp set Ename=@En,Deptno=@Dn where Empno=@E", con);

                cmd.Parameters.AddWithValue("@En", txtEname.Text);

                cmd.Parameters.AddWithValue("@Dn", int.Parse(txtDeptno.Text));

                cmd.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));

                int R = cmd.ExecuteNonQuery();

                if (R != 0)

                    MessageBox.Show(R + "Rows Updated");

                else

                    MessageBox.Show("No Emp Exists");

                
            }

            catch (InvalidOperationException E)
            {
                MessageBox.Show("No Employee exists with this number");
            }

            catch (FormatException E)
            {
                MessageBox.Show("Enter only numerical values");
            }

            catch (SqlException E)
            {
                MessageBox.Show("Check the lenght of EName");
            }
            finally
            {
                con.Close();
            }

        }

        private void btExtarct_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("select * from emp where empno=@eno", con);

                cmd.Parameters.AddWithValue("@eno", int.Parse(txtEmpno.Text));

                SqlDataReader R = cmd.ExecuteReader();

                R.Read();  // You can use this command only once 

                txtEname.Text = R[1].ToString();

                cbGender.Text = R[2].ToString();

                dtpdob.Text = R[3].ToString();

                txtDeptno.Text = R[4].ToString();

                //con.Close();
            }
            catch(InvalidOperationException E)
            {

                MessageBox.Show("No Employee exists with this number");

                txtEname.Text = "";

                cbGender.Text = "";

                txtDeptno.Text = "";

                dtpdob.Text = "";

            }
            catch(FormatException E)
            {

                MessageBox.Show("Enter only numerical values");

            }
            catch(SqlException E)
            {

                MessageBox.Show("Check the lenght of EName");
            }

            finally
            {
                con.Close();
            }

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                cmd = new SqlCommand("delete from emp where empno=@eno", con);

                cmd.Parameters.AddWithValue("@eno", int.Parse(txtEmpno.Text));

                int R = cmd.ExecuteNonQuery();

                if(R > 0)

                MessageBox.Show(R + " Rows deleted");

                if (R == 0)
                {
                    MessageBox.Show("Entered number is not Correct");
                }
            }

          
            catch (FormatException E)
            {
                MessageBox.Show("Enter only numerical values");
            }

            finally
            {
                con.Close();
            }
        }
    }
}
