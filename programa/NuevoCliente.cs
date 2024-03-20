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
using System.Runtime.Remoting;

namespace programa
{
    public partial class nuevoCliente : Form
    {
        private Cliente cliente = null; 
        formClientes ventanaVieja;

        public nuevoCliente(formClientes pantallaVieja)
        {
            ventanaVieja = pantallaVieja;
            InitializeComponent();

        }
        public nuevoCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

            

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

            //Cliente cli= new Cliente();
            clienteNegocio negocio = new clienteNegocio();
            
            try
            {
                if(cliente == null)
                {
                    cliente = new Cliente();
                }
                razonSocial = textboxRazonSocial.Text.ToUpper();
                telefono = int.Parse(textBoxTelefono.Text);
                string telefonoString = telefono.ToString();
                email = textBoxEmail.Text.ToUpper();
                domicilio = textBoxDomicilio.Text.ToUpper();
                Vendedor vendedor = new Vendedor();
                vendedor.id = (int)comboBoxVendedor.SelectedValue;



                cliente.razonsocial = razonSocial;
                cliente.telefono = telefonoString;
                cliente.email = email;
                cliente.domicilio = domicilio;
                cliente.vendedor = vendedor;
                

                if(cliente.id != 0)
                {
                    negocio.modificar(cliente);
                    MessageBox.Show("Articulo modificado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    negocio.agregarCliente(cliente);
                    MessageBox.Show("Cliente ingresado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ventanaVieja.cargarTabla();
                }





                negocio.agregarCliente(cliente);
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
                textBoxTelefono.Focus();   
                   
            }
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();    
            clienteNegocio clienteNegocio = new clienteNegocio();

            try
            {
                textboxRazonSocial.Text = cliente.razonsocial;
                textBoxTelefono.Text = cliente.telefono;    
                textBoxEmail.Text = cliente.email;
                textBoxDomicilio.Text = cliente.domicilio;    
                comboBoxVendedor.DataSource = clienteNegocio.listarVendedor();
                comboBoxVendedor.DisplayMember = "vendedor";
                comboBoxVendedor.ValueMember = "id";


                if(cliente != null)
                {
                    textboxRazonSocial.Text = cliente.razonsocial;
                    textBoxTelefono.Text = cliente.telefono;    
                    textBoxEmail.Text = cliente.email;
                    textBoxDomicilio.Text = cliente.domicilio;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }
    }
}
