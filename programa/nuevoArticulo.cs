using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace programa
{
    public partial class nuevoArticulo : Form
    {
        formArticulos ventanaVieja;
        public nuevoArticulo(formArticulos pantallaVieja)
        {
            ventanaVieja = pantallaVieja;
            InitializeComponent();
            
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string codigo, descripcion, proveedor;
            codigo = textBoxCodigo.Text;
            descripcion = textBoxDescripcion.Text;
            proveedor = textBoxProveedor.Text;  
            MessageBox.Show(codigo);
            MessageBox.Show(descripcion);
            MessageBox.Show(proveedor);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string codigo, descripcion, proveedor, urlImagen;
            int stock;


            Articulo art = new Articulo();
            articuloNegocio negocio = new articuloNegocio();    
            try
            {
                codigo = textBoxCodigo.Text.ToUpper();
                descripcion = textBoxDescripcion.Text.ToUpper();
                proveedor = textBoxProveedor.Text.ToUpper();
                stock = int.Parse(textBoxStock.Text);
                urlImagen = textBoxURLimagen.Text;

                art.codigo = codigo;
                art.descripcion = descripcion;
                art.proveedor = proveedor;
                art.stock = stock;
                art.UrlImagen = urlImagen;

                negocio.agregar(art);
                ventanaVieja.cargarTabla();


                textBoxCodigo.Clear();
                textBoxDescripcion.Clear();
                textBoxProveedor.Clear();
                textBoxStock.Clear();
                textBoxURLimagen.Clear();
                MessageBox.Show("Articulo ingresado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBoxCodigo.Focus();  
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese numeros por favor", "-                           STOCK", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBoxStock.Focus();
            }





        }

        
        private void textBoxURLimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxURLimagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }

    }
}
