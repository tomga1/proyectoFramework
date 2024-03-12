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
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("RAZON SOCIAL", 140);
            listView1.Columns.Add("TELEFONO", 110);
            listView1.Columns.Add("EMAIL", 70);
            listView1.Columns.Add("DOMICILIO", 90);
            listView1.View = View.Details;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nuevoCliente ventana = new nuevoCliente();
            ventana.ShowDialog();
        }
    }
}
