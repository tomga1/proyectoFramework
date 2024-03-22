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
        private Cliente cliente = null;
        
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
            try
            {
                clienteNegocio negocio = new clienteNegocio();
                listaClientes = negocio.listar();
                dgvClientes.DataSource = listaClientes;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nuevoCliente ventana = new nuevoCliente(this);
            ventana.ShowDialog();
            cargarTabla();
        }

       

        private void botonEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente seleccionado; 
            seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            nuevoCliente modificar = new nuevoCliente(seleccionado);
            modificar.ShowDialog();
        } 
        

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> listaFiltrada;
            string filtro = textBoxFiltroCliente.Text;


            if(filtro != "")
            {
                listaFiltrada = listaClientes.FindAll(x => x.razonsocial.Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaClientes; 
            }
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaFiltrada;

        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            clienteNegocio negocio = new clienteNegocio();
            Cliente seleccionado;
            try
            {
                seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo?", "               ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.id);
                    MessageBox.Show("Articulo elimiando con exito ! ", "               ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cargarTabla();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

}



