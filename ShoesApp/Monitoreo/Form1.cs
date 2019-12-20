using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
namespace Monitoreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            DataProductsEntities8 DET = new DataProductsEntities8();
            dataGridView1.DataSource = DET.BRTV_ShowChanges();
            timer1.Start();
           

        }
    }
}
