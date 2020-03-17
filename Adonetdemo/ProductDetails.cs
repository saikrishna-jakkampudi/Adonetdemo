using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adonetdemo
{
    public partial class ProductDetails : Form
    {
        public ProductDetails(string PID,string Desc,string Price)
        {
            InitializeComponent();

            label4.Text = PID;
            label5.Text = Desc;
            label6.Text = Price;

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
