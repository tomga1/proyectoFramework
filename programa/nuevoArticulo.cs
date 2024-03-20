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
using System.IO;
using System.Configuration;


namespace programa
{
    public partial class nuevoArticulo : Form
    {

        private Articulo articulo = null;
        formArticulos ventanaVieja;

        private OpenFileDialog archivo = null;


        public nuevoArticulo(formArticulos pantallaVieja)
        {
            ventanaVieja = pantallaVieja;
            InitializeComponent();
            
        }
        public nuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Editar Articulo";
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string codigo, descripcion, proveedor, urlImagen;
            int stock;

            articuloNegocio negocio = new articuloNegocio();    
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();  
                }
                codigo = textBoxCodigo.Text.ToUpper();
                descripcion = textBoxDescripcion.Text.ToUpper();
                proveedor = textBoxProveedor.Text.ToUpper();
                stock = int.Parse(textBoxStock.Text);
                urlImagen = textBoxURLimagen.Text;

                articulo.codigo = codigo;
                articulo.descripcion = descripcion;
                articulo.proveedor = proveedor;
                articulo.stock = stock;
                articulo.UrlImagen = urlImagen;

                if(articulo.id !=0 )
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo ingresado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ventanaVieja.cargarTabla();

                }
                
                if(archivo != null && (textBoxURLimagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                }


                textBoxCodigo.Clear();
                textBoxDescripcion.Clear();
                textBoxProveedor.Clear();
                textBoxStock.Clear();
                textBoxURLimagen.Clear();
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

        private void nuevoArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                if(articulo != null)
                {
                    textBoxCodigo.Text = articulo.codigo;
                    textBoxDescripcion.Text = articulo.descripcion;
                    textBoxProveedor.Text = articulo.proveedor;
                    textBoxStock.Text = articulo.stock.ToString();
                    textBoxURLimagen.Text = articulo.UrlImagen;
                    
                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    archivo = new OpenFileDialog();

        //    archivo.Filter = "jpg |*.jpg;|png|*.png";
        //    archivo.ShowDialog();   
        //    if(archivo.ShowDialog() == DialogResult.OK)
        //    {
        //        textBoxURLimagen.Text = archivo.FileName;
        //        cargarImagen(archivo.FileName);

        //        //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
        //    }
            

        //}

        private void button1_Click_2(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();

            archivo.Filter = "jpg |*.jpg;|png|*.png";
            archivo.ShowDialog();
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxURLimagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
    }
}
