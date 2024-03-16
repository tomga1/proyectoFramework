using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace programa
{
    public partial class formClientes : Form
    {

        private List<Cliente> listaClientes;
        public formClientes()
        {
            InitializeComponent();

        }
        private void formClientes_Load(object sender, EventArgs e)
        {
            clienteNegocio negocio = new clienteNegocio();
            dgvClientes.DataSource = negocio.listar();
            //dgvClientes.DataSource = negocio.listarVendedor();
        }

        public void cargarTabla()
        {
            clienteNegocio negocio = new clienteNegocio();
            listaClientes = negocio.listar();
            dgvClientes.DataSource = listaClientes;

        }


        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nuevoCliente ventana = new nuevoCliente(this);
            ventana.ShowDialog();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
