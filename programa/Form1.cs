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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(formArticulos))
                {
                    MessageBox.Show("Ya existe una venta abierta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
            }

            formArticulos ventana = new formArticulos();
            ventana.MdiParent = this;
            ventana.Show();   
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(formClientes))
                {
                    MessageBox.Show("Ya existe una venta abierta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            formClientes ventana = new formClientes();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
