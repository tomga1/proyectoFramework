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
    public partial class nuevoArticulo : Form
    {
        public nuevoArticulo()
        {
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
            string codigo, descripcion, proveedor, codigoMayus, descripcionMayus, proveedorMayus;
            codigo = textBoxCodigo.Text;
            descripcion = textBoxDescripcion.Text;
            proveedor = textBoxProveedor.Text;

            codigoMayus = codigo.ToUpper();
            descripcionMayus = descripcion.ToUpper();
            proveedorMayus = proveedor.ToUpper();   

            //MessageBox.Show(codigoMayus);
            //MessageBox.Show(descripcionMayus);
            //MessageBox.Show(proveedorMayus);

            textBoxCodigo.Clear();
            textBoxDescripcion.Clear();
            textBoxProveedor.Clear();
            textBoxStock.Clear();   
            MessageBox.Show("Articulo ingresado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
            textBoxCodigo.Focus();  

        }

       
    }
}
