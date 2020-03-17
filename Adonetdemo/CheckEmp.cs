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
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Adonetdemo
{
    public partial class CheckEmp : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
      

        public CheckEmp()
        {
            InitializeComponent();
        }

        private void CheckEmp_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-AIVD17Q");
            Adp = new SqlDataAdapter("Select * from EMPDATA", Con);
            DS = new DataSet();
            Adp.Fill(DS, "PD");
            dataGridView1.DataSource = DS.Tables["PD"];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (row_index != i)
                {
                    dataGridView1.Rows[i].Cells["CheckBox"].Value = false;
                }
            }

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            FileStream FS = new FileStream(@"C:\Users\Admin\Desktop\Bill3.pdf", FileMode.Create);
            Document Doc = new Document();
            PdfWriter.GetInstance(Doc, FS);
            Doc.Open();

            Chunk C = new Chunk("Employee Details\n", FontFactory.GetFont("Verdana"));
            C.Font.Color = new iTextSharp.text.BaseColor(0, 55, 180);
            C.Font.SetStyle(1);
            C.Font.Size = 15;
            Paragraph P = new Paragraph(C);
            P.Alignment = Element.ALIGN_CENTER;
            Doc.Add(P);

            PdfPTable table = new PdfPTable(8);
            table.DefaultCell.HorizontalAlignment = Element.ALIGN_MIDDLE;
            PdfPCell cell = new PdfPCell(new Phrase(" Id"));
            table.AddCell(cell);
            cell=new PdfPCell(new Phrase(" Name"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Job"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Manager"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Hiredate"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Salary"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Commission"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Department"));
            table.AddCell(cell);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if ((bool)(dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        
                        string Empid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string Ename = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string Job = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        string Mgr = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        string Hiredate = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        string Sal = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        string Comm = dataGridView1.Rows[i].Cells[7].Value.ToString();
                        string Deptno = dataGridView1.Rows[i].Cells[8].Value.ToString();

                      


                       

                      
                        //PdfPCell cell = new PdfPCell(new Phrase("Empid"));
                        //cell.Colspan = 8;
                        //cell.HorizontalAlignment = 1;
                        
                        table.AddCell(Empid);
                   
                        table.AddCell(Ename);
                
                        table.AddCell(Job);
                      
                        table.AddCell(Mgr);
                        
                        table.AddCell(Hiredate);
                    
                        table.AddCell(Sal);
                  
                        table.AddCell(Comm);
                       
                        table.AddCell(Deptno);

                       

                         P= new Paragraph("EMP ID :" + Empid + "\n Ename :" + Ename + "\n Job :" + Job + "\n Mgr :" + Mgr + "\n Hiredate :" + Hiredate + "\n Sal :" + Sal + "\n Comm :" + Comm + "\n Deptno :" + Deptno);
                        //Doc.Add(P);
                        //Doc.Close();
                       
                        //PDF PD = new PDF(Empid, Ename, Job, Mgr, Hiredate, Sal, Comm, Deptno);
                        //PD.Show();


                    }

                }
              
            }
            Doc.Add(table);
            MessageBox.Show("File Generated Successfully");
            Doc.Close();
           
        }
    }
}
