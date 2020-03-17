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
    public partial class Bigtrigger : Form
    {
        SqlConnection Con=null;
        SqlDataAdapter Adp =null;
      
        public Bigtrigger()
        {
            InitializeComponent();
        }

        private void Bigtrigger_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=order;Data Source=DESKTOP-AIVD17Q");
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select count(*) from Orderdetails", Con);
            DataSet DS = new DataSet();
            Adp.Fill(DS,"O");
            txtOrderid.Text = (int.Parse(DS.Tables["O"].Rows[0][0].ToString())+ 1).ToString();

            Adp = new SqlDataAdapter("Select SalesmanId,SalesmanName from SalesmanDetails", Con);
            Adp.Fill(DS, "S");
            cbbSalesmanid.DataSource = DS.Tables["S"];
            cbbSalesmanid.DisplayMember = "SalesmanName";
            cbbSalesmanid.ValueMember = "SalesManId";

            Adp = new SqlDataAdapter("Select Customerid,CustomerName from CustomerDetails", Con);
            Adp.Fill(DS, "C");
            cbbCustomerid.DataSource = DS.Tables["C"];
            cbbCustomerid.DisplayMember = "CustomerName";
            cbbCustomerid.ValueMember = "CustomerId";

            panel1.Visible = true;
        }

        private void btClick_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_InsertorderProdcuts", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@oid", txtOrderid.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@OrderDesc", txtOrderdesc.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@OrderDate", DateTime.Parse(dateTimePicker1.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Discount", txtDiscount.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@Custid", cbbCustomerid.SelectedValue);
            Adp.SelectCommand.Parameters.AddWithValue("@SalesId", cbbSalesmanid.SelectedValue);

            DataTable MyTable = new DataTable();
            MyTable.Columns.Add("Orderid", typeof(String));
            MyTable.Columns.Add("Productid", typeof(String));
            MyTable.Columns.Add("Qty", typeof(Int32));
           // MessageBox.Show(dgvDisplay.Rows.Count.ToString());


            for (int i=0; i < dgvDisplay.Rows.Count - 1;i++)
            {
                MyTable.Rows.Add(txtOrderid.Text,dgvDisplay.Rows[i].Cells[0].Value.ToString(),dgvDisplay.Rows[i].Cells[2].Value.ToString());
            }

            SqlParameter P = new SqlParameter("@ord_pro", MyTable);
            P.SqlDbType = SqlDbType.Structured;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            MessageBox.Show("Order Placed");
            panel1.Visible = false;
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplay.CurrentCell.ColumnIndex.Equals(0))
            {
                Adp = new SqlDataAdapter("Select ProductId from Productdetails", Con);
                DataSet DS = new DataSet();
                Adp.Fill(DS, "PID");
                foreach (DataGridViewRow row in dgvDisplay.Rows)
                {
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource = DS.Tables["PID"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "ProductId";
                }
                //MessageBox.Show("Clicked");
            }
        }

        private void dgvDisplay_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDisplay.CurrentRow.Cells[0].Value != null)
            //{
            //    if (!dgvDisplay.CurrentCell.ColumnIndex.Equals(0))
            //    {
            //        Adp = new SqlDataAdapter("Select * from Productdetails where ProductID=@P", Con);
            //        Adp.SelectCommand.Parameters.AddWithValue("@P", dgvDisplay.CurrentRow.Cells[0].Value);
            //        DataSet DS = new DataSet();
            //        Adp.Fill(DS, "P");
            //        dgvDisplay.CurrentRow.Cells[1].Value = DS.Tables["P"].Rows[0][1];
            //        dgvDisplay.CurrentRow.Cells[3].Value = DS.Tables["P"].Rows[0][2];
            //    }
            //}
          
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDisplay.CurrentRow.Cells[0].Value != null)
            {
                if (!dgvDisplay.CurrentCell.ColumnIndex.Equals(0))
                {
                    Adp = new SqlDataAdapter("Select * from Productdetails where ProductID=@P", Con);
                    Adp.SelectCommand.Parameters.AddWithValue("@P", dgvDisplay.CurrentRow.Cells[0].Value);
                    DataSet DS = new DataSet();
                    Adp.Fill(DS, "P");
                    dgvDisplay.CurrentRow.Cells[1].Value = DS.Tables["P"].Rows[0][1];
                    dgvDisplay.CurrentRow.Cells[3].Value = DS.Tables["P"].Rows[0][2];
                }
            }
           
        }

        private void dgvDisplay_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplay.CurrentRow.Cells[2].Value != null)
            {
                int Q = int.Parse(dgvDisplay.CurrentRow.Cells[2].Value.ToString());
                int P = int.Parse(dgvDisplay.CurrentRow.Cells[3].Value.ToString());
                dgvDisplay.CurrentRow.Cells[4].Value = Q * P;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
