using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa
{
    public partial class formArticulos : Form
    {
        public formArticulos()
        {
            InitializeComponent();

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("CODIGO", 80);
            listView1.Columns.Add("DESCRIPCION", 140);
            listView1.Columns.Add("PROVEEDOR", 110);
            listView1.Columns.Add("STOCK", 70);
            listView1.View = View.Details;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nuevoArticulo ventana = new nuevoArticulo();
            ventana.ShowDialog();
        }

        
    }
}
