namespace programa
{
    partial class nuevoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoCliente));
            this.textboxRazonSocial = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxRazonSocial
            // 
            this.textboxRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxRazonSocial.Location = new System.Drawing.Point(107, 12);
            this.textboxRazonSocial.Name = "textboxRazonSocial";
            this.textboxRazonSocial.Size = new System.Drawing.Size(168, 20);
            this.textboxRazonSocial.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(107, 64);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(168, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTelefono.Location = new System.Drawing.Point(107, 38);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(168, 20);
            this.textBoxTelefono.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "RAZON SOCIAL :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "TELEFONO : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "EMAIL : ";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(172, 173);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(131, 77);
            this.botonEliminar.TabIndex = 5;
            this.botonEliminar.Text = "Cancelar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("botonAgregar.Image")));
            this.botonAgregar.Location = new System.Drawing.Point(12, 173);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(131, 77);
            this.botonAgregar.TabIndex = 4;
            this.botonAgregar.Text = "&Agregar Nuevo";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DOMICILIO : ";
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDomicilio.Location = new System.Drawing.Point(107, 90);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(168, 20);
            this.textBoxDomicilio.TabIndex = 3;
            // 
            // nuevoCliente
            // 
            this.AcceptButton = this.botonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 253);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textboxRazonSocial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxRazonSocial;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDomicilio;
    }
}