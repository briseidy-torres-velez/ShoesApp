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

namespace ShoesApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            Update();

        }
        public void Update(int ID)
        {
            CapaDatos cd = new CapaDatos();
            AddProdET addEt = new AddProdET();


            addEt.Id = int.Parse(textBoxID.Text);
            addEt.Nombre = textBoxAdd.Text;
            addEt.Description = textBoxDesc.Text;
            addEt.Title = textBoxTitle.Text;
            addEt.Observations = textBoxObservacion.Text;
            addEt.PriceClient = decimal.Parse(textBoxPriceClient.Text);
            addEt.PriceMember = decimal.Parse(textBoxPriceMember.Text);
            addEt.IsEnabled = true;

            if (cd.Update(addEt))
            {
                label2.Text = "Se modifico el producto";
            }
            else
            {
                label2.Text = "No se pudo modificar";
            }
        }
        
    }
}
