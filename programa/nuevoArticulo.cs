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
            string codigo, nombre, descripcion, urlImagen;
            decimal precio;
            int idmarca, idcategoria;

            articuloNegocio negocio = new articuloNegocio();    
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();  
                }
                codigo = textBoxCodigo.Text.ToUpper();
                nombre = textBoxNombre.Text.ToUpper();
                descripcion = textBoxDescripcion.Text.ToUpper();
                idmarca = (int)comboBoxMarca.SelectedValue;
                idcategoria = (int)comboBoxCategoria.SelectedValue;
                urlImagen = textBoxImagenUrl.Text;
                precio = decimal.Parse(textPrecio.Text.ToUpper());
                //articulo.idmarca = (int)comboBoxMarca.SelectedValue;
                //articulo.idcategoria = (int)comboBoxCategoria.SelectedValue;
                //articulo.idmarca = (int)comboBoxMarca.SelectedValue;
                //articulo.idcategoria = (int)comboBoxCategoria.SelectedValue;

                articulo.codigo = codigo;
                articulo.nombre = nombre;
                articulo.descripcion = descripcion;
                articulo.precio = precio;
                articulo.imagenurl = urlImagen;
                articulo.idmarca = idmarca;
                articulo.idcategoria = idcategoria;

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
                
                if(archivo != null && (textBoxImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                }


                textBoxCodigo.Clear();
                textBoxNombre.Clear();
                textBoxDescripcion.Clear();
                textPrecio.Clear();
                textBoxImagenUrl.Clear();
                textBoxCodigo.Focus();  
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese numeros por favor", "-                           PRECIO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textPrecio.Focus();
            }





        }


        
        private void textBoxURLimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxImagenUrl.Text);
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
            Articulo articulo = new Articulo();
            articuloNegocio articuloNegocio = new articuloNegocio();

            try
            {
                if(articulo != null)
                {
                    textBoxCodigo.Text = articulo.codigo;
                    textBoxNombre.Text = articulo.nombre;
                    textBoxDescripcion.Text = articulo.descripcion;
                    textPrecio.Text = articulo.precio.ToString();
                    textBoxImagenUrl.Text = articulo.imagenurl;
                    comboBoxMarca.DataSource = articuloNegocio.ListarMarca();
                    comboBoxMarca.DisplayMember = "marca";
                    comboBoxMarca.ValueMember = "id";
                    comboBoxCategoria.DataSource = articuloNegocio.ListarCategorias();
                    comboBoxCategoria.DisplayMember = "categoria";
                    comboBoxCategoria.ValueMember = "id";
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
                textBoxImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
    }
}
