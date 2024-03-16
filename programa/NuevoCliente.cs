using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using dominio;
using negocio;

namespace programa
{
    public partial class nuevoCliente : Form
    {
        formClientes ventanaVieja;

        public nuevoCliente(formClientes pantallaVieja)
        {
            ventanaVieja = pantallaVieja;
            InitializeComponent();

        }

        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string razonSocial, email, domicilio;
            int telefono;

            Cliente cli= new Cliente();
            clienteNegocio negocio = new clienteNegocio();
            
            try
            {
                razonSocial = textboxRazonSocial.Text.ToUpper();
                telefono = int.Parse(textBoxTelefono.Text);
                string telefonoString = telefono.ToString();
                email = textBoxEmail.Text.ToUpper();
                domicilio = textBoxDomicilio.Text.ToUpper();
                Vendedor vendedor = new Vendedor();
                vendedor.id = (int)comboBoxVendedor.SelectedValue;



                cli.razonsocial = razonSocial;
                cli.telefono = telefonoString;
                cli.email = email;
                cli.domicilio = domicilio;
                cli.vendedor = vendedor;
                

                negocio.agregarCliente(cli);
                ventanaVieja.cargarTabla();

                textboxRazonSocial.Clear();
                textBoxTelefono.Clear();
                textBoxEmail.Clear();
                textBoxDomicilio.Clear();
                   
                MessageBox.Show("Cliente ingresado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
                textboxRazonSocial.Focus(); 


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese numeros por favor", "-                       TELEFONO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
                textBoxTelefono.Focus();   
                   
            }
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {
            clienteNegocio clienteNegocio = new clienteNegocio();

            try
            {
                comboBoxVendedor.DataSource = clienteNegocio.listarVendedor();
                comboBoxVendedor.DisplayMember = "vendedor";
                comboBoxVendedor.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
