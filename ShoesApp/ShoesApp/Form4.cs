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
using Data;
using System.IO;
using System.Xml;

namespace ShoesApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataProductsEntities8 DET = new DataProductsEntities8();
            timer1.Stop();
            dataGridView1.DataSource = DET.BRTV_InsertChanges();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            DataProductsEntities8 DET = new DataProductsEntities8();

            dataGridView1.Columns[0].HeaderText = "Id";

            foreach (var column in dataGridView1.Columns.Cast<DataGridViewColumn>())
            {
                dt.Columns.Add();
            }



            var cellValues = new object[dataGridView1.Columns.Count];



            foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);



            }



            ds.Tables.Add(dt);



            string FileName = @"C:/Users/Curso/Documents/NewProduct.xml";
            FileStream Stream = new FileStream(FileName, FileMode.Create);
            XmlTextWriter xmlWriter = new XmlTextWriter(Stream, System.Text.Encoding.Unicode);
            ds.WriteXml(xmlWriter);
            xmlWriter.Close();
        
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataProductsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataProductsDataSet.Products);

        }
    }
}
