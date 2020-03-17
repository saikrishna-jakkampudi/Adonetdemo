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
    public partial class Radio : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        public Radio()
        {
            InitializeComponent();
        }

        private void Radio_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=order;Data Source=DESKTOP-AIVD17Q");
            Adp = new SqlDataAdapter("Select * from Productdetails", Con);
            DS = new DataSet();
            Adp.Fill(DS, "PD");
            dataGridView1.DataSource = DS.Tables["PD"];
        }
    }
}
