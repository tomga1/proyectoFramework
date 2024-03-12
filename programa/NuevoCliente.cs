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

namespace programa
{
    public partial class nuevoCliente : Form
    {
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
            string razonSocial, email, domicilio, razonSocialMayus, emailMayus, domicilioMayus;
            int telefono, id;

            try
            {
                razonSocial = textboxRazonSocial.Text;
                razonSocialMayus = razonSocial.ToUpper();   
                telefono = int.Parse(textBoxTelefono.Text);
                string telefonoString = telefono.ToString();
                email = textBoxEmail.Text;
                emailMayus = email.ToUpper();
                domicilio = textBoxDomicilio.Text;
                domicilioMayus = domicilio.ToUpper();

                //MessageBox.Show(razonSocialMayus);
                //MessageBox.Show(telefonoString);
                //MessageBox.Show(emailMayus);
                //MessageBox.Show(domicilioMayus);

                textboxRazonSocial.Clear();
                textBoxTelefono.Clear();
                textBoxEmail.Clear();
                textBoxDomicilio.Clear();
                MessageBox.Show("Cliente ingresado con exito!", "                 EXCELENTE!", MessageBoxButtons.OK, MessageBoxIcon.None);
                textboxRazonSocial.Focus(); 

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese numeros por favor", "-                       TELEFONO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBoxTelefono.Focus();   
                   
            }
        }

        
    }
}
