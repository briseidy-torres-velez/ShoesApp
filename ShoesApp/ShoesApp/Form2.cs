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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaNegocio cn = new CapaNegocio();
            AddProdET addEt = new AddProdET();
            addEt.Nombre = textBoxAdd.Text;
            addEt.Description = textBoxDesc.Text;
            addEt.Title = textBoxTitle.Text;
            addEt.Observations = textBoxObservacion.Text;
            addEt.PriceClient = decimal.Parse(textBoxPriceClient.Text);
            addEt.PriceMember = decimal.Parse(textBoxPriceMember.Text);
            addEt.IsEnabled = true;

            if (cn.Insert(addEt))
            {
                label2.Text = "Se agrego el producto";
            }
            else
            {
                label2.Text = "No se pudo agregar";
            }
        }
    }
}
