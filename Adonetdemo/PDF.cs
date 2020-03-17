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
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();

        }

        public PDF(string empid, string ename, string job, string mgr, string hiredate, string sal, string comm, string deptno)
        {
        }

        private void PDF_Load(object sender, EventArgs e)
        {

        }
    }
}
