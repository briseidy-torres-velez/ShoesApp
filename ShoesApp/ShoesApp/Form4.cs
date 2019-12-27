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
using System.Xml.Serialization;
using Common;

namespace ShoesApp
{
    public partial class Form4 : Form
    {
        CapaDatos cd = new CapaDatos();
        DataProductsEntities11 DTE = new DataProductsEntities11();
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataProductsEntities11 DET = new DataProductsEntities11();
            CapaDatos cd = new CapaDatos();
            //timer1.Stop();
            //dataGridView1.DataSource = cd.NewProduct();
            //timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = cd.NewProduct();
         
            List<BRTV_InsertChanges_Result> list = new List<BRTV_InsertChanges_Result>();

            if (File.Exists(@"C:/Users/Curso/Documents/ShoesAppXML/NewProduct.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:/Users/Curso/Documents/ShoesAppXML/NewProduct.xml");
                list.AddRange(DeserializeFromXml<List<BRTV_InsertChanges_Result>>(Doc.OuterXml));
            }

            SerializeToXml<List<BRTV_InsertChanges_Result>>(DTE.BRTV_InsertChanges().ToList(), @"C:/Users/Curso/Documents/ShoesAppXML/NewProduct.xml");
            MessageBox.Show("Se creo XML");

            CargarListBox();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarListBox();
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:/Users/Curso/Documents/ShoesAppXML");
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;

            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;

        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} eliminado a las: {1}", e.Name, DateTime.Now.ToLocalTime());
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} creado a las: {1}", e.Name, DateTime.Now.ToLocalTime());
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: {0} actualizado a las: {1}", e.Name, DateTime.Now.ToLocalTime());
        }

        public void CargarListBox()
        {
            listBox1.Items.Clear();
            string rutaDirectorio = @"C:/Users/Curso/Documents/ShoesAppXML";
            DirectoryInfo di = new DirectoryInfo(rutaDirectorio);
            foreach (var item in di.GetFiles())
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }
        public void SerializeToXml<T>(T obj, string fileName)

        {

            XmlSerializer ser = new XmlSerializer(typeof(T));

            //Create a FileStream object connected to the target file 

            FileStream fileStream = new FileStream(fileName, FileMode.Create);

            ser.Serialize(fileStream, obj);

            fileStream.Close();

        }

        public T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cd.Changes();

            List<BRTV_UpdateChanges_Result> list = new List<BRTV_UpdateChanges_Result>();

            if (File.Exists(@"C:/Users/Curso/Documents/ShoesAppXML/Changes.xml"))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"C:/Users/Curso/Documents/ShoesAppXML/Changes.xml");
                list.AddRange(DeserializeFromXml<List<BRTV_UpdateChanges_Result>>(Doc.OuterXml));
            }

            SerializeToXml<List<BRTV_UpdateChanges_Result>>(DTE.BRTV_UpdateChanges().ToList(), @"C:/Users/Curso/Documents/ShoesAppXML/Changes.xml");
            MessageBox.Show("Se creo XML");
            CargarListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @"C:/Users/Curso/Documents/ShoesAppXML/" + listBox1.SelectedItem.ToString();
            
            File.Delete(rutaArchivo);
            
            MessageBox.Show("Se elimino el archivo");

            CargarListBox();


        }
    }
}
