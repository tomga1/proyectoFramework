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
        private Articulo articulo = null;
        public formArticulos()
        {
            InitializeComponent();

        }

        private void formArticulos_Load(object sender, EventArgs e)
        {

            cargarTabla();
            comboBoxCampo.Items.Add("Codigo");
            comboBoxCampo.Items.Add("Descripcion");
            comboBoxCampo.Items.Add("Proveedor");


            try
            {
                if(articulo != null)
                {
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarTabla()
        {
            articuloNegocio negocio = new articuloNegocio();

            try
            {
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nuevoArticulo ventana = new nuevoArticulo(this);
            ventana.ShowDialog();
            cargarTabla();
        }
        
        private void botonEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            nuevoArticulo modificar = new nuevoArticulo(seleccionado);
            modificar.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.imagenurl);
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

       

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo?", "               ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.id);
                    MessageBox.Show("Articulo elimiando con exito ! ", "               ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cargarTabla();
                }
                else { 
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x =>
                    x.descripcion.Contains(filtro.ToUpper()) ||
                    x.codigo.Contains(filtro.ToUpper()) ||
                    x.nombre.Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos; 
            }
  
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();
            if(opcion == "Codigo" || opcion == "Descripcion" || opcion == "Proveedor")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private void botonFiltro_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString(); 
                string filtro = textBoxFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio,filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }


        }

        
    }
}   
