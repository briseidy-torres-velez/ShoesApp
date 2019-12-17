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
using Business;

namespace ShoesApp
{
    public partial class Form1 : Form
    {
        CapaDatos cd = new CapaDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapaDatos cn = new CapaDatos();
            Products P = new Products();
            dataGridView1.DataSource = cn.Show1();

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonID_Click(object sender, EventArgs e)
        {
      
            dataGridView1.DataSource = cd.Search(int.Parse(textBoxID.Text));

        }

        private void buttoName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cd.SearchByName(textBoxName.Text);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            cd.Delete(Convert.ToInt32(textBoxID.Text));
            dataGridView1.DataSource = cd.Search(int.Parse(textBoxID.Text));

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
        
            f3.Show();

        }
    }
}
