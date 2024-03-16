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
    public partial class formArticulos : Form
    {
        private List<Articulo> listaArticulos;        
        public formArticulos()
        {
            InitializeComponent();

        }

        private void formArticulos_Load(object sender, EventArgs e)
        {
            cargarTabla();
            //cargarImagen(listaArticulos[0].UrlImagen);
        }

        public void cargarTabla()
        {
            articuloNegocio negocio = new articuloNegocio();

            try
            {
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nuevoArticulo ventana = new nuevoArticulo(this);
            ventana.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                {
                    pictureBoxArticulo.ImageLocation = imagen;
                }
                else
                {
                    // Si la ruta de la imagen está vacía o nula, cargar una imagen predeterminada
                    pictureBoxArticulo.ImageLocation = "https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
