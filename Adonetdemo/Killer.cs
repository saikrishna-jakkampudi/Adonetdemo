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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Adonetdemo
{
    public partial class Killer : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        public Killer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i != dataGridView1.CurrentCell.RowIndex)
                    dataGridView1.Rows[i].Cells[0].Value = false;

                }
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value = true;
            }

            
        }

        private void Killer_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=order;Data Source=DESKTOP-AIVD17Q");
            Adp = new SqlDataAdapter("Select * from Productdetails", Con);
            DS = new DataSet();
            Adp.Fill(DS,"PD");
            dataGridView1.DataSource = DS.Tables["PD"];
            
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value!=null)
                {
                    if ((bool)(dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        String Pid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        Adp = new SqlDataAdapter("Select * from Productdetails where ProductId=@Pid", Con);
                        Adp.SelectCommand.Parameters.AddWithValue("@Pid", Pid);
                        DS = new DataSet();
                        Adp.Fill(DS, "P");
                        DataRow R = DS.Tables["P"].Rows[0];
                        string PID = R[0].ToString();
                        string Desc = R[1].ToString();
                        string Price = R[2].ToString();
                        ProductDetails PD = new ProductDetails(PID, Desc, Price);
                        PD.Show();
                      
                    }

                }

            }
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //label4.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            //label5.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            //label6.Text = dataGridView1.Rows[2].Cells[0].Value.ToString();
        }
    }
}
