namespace programa
{
    partial class nuevoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoArticulo));
            this.botonEliminar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textBoxImagenUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(231, 190);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(108, 61);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "&Cancelar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCodigo.Location = new System.Drawing.Point(108, 8);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(168, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNombre.Location = new System.Drawing.Point(108, 34);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(168, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescripcion.Location = new System.Drawing.Point(108, 60);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(168, 20);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CODIGO : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOMBRE : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "DESCRIPCION : ";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("botonAgregar.Image")));
            this.botonAgregar.Location = new System.Drawing.Point(97, 190);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(108, 61);
            this.botonAgregar.TabIndex = 5;
            this.botonAgregar.Text = "&Aceptar";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "PRECIO : ";
            // 
            // textPrecio
            // 
            this.textPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPrecio.Location = new System.Drawing.Point(108, 86);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(168, 20);
            this.textPrecio.TabIndex = 3;
            // 
            // textBoxImagenUrl
            // 
            this.textBoxImagenUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxImagenUrl.Location = new System.Drawing.Point(108, 112);
            this.textBoxImagenUrl.Name = "textBoxImagenUrl";
            this.textBoxImagenUrl.Size = new System.Drawing.Size(128, 20);
            this.textBoxImagenUrl.TabIndex = 4;
            this.textBoxImagenUrl.Leave += new System.EventHandler(this.textBoxURLimagen_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "URL imagen :  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(295, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(242, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 24);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(108, 138);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(128, 21);
            this.comboBoxMarca.TabIndex = 21;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(108, 163);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCategoria.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "MARCA : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "CATEGORIA : ";
            // 
            // nuevoArticulo
            // 
            this.AcceptButton = this.botonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 253);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxImagenUrl);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.botonEliminar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.nuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textBoxImagenUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}