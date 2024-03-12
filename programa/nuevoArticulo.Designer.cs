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
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(172, 174);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(131, 77);
            this.botonEliminar.TabIndex = 5;
            this.botonEliminar.Text = "&Cancelar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCodigo.Location = new System.Drawing.Point(100, 12);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(168, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescripcion.Location = new System.Drawing.Point(100, 38);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(168, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxProveedor.Location = new System.Drawing.Point(100, 64);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(168, 20);
            this.textBoxProveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CODIGO : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DESCRIPCION :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "PROVEEDOR : ";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("botonAgregar.Image")));
            this.botonAgregar.Location = new System.Drawing.Point(15, 174);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(131, 77);
            this.botonAgregar.TabIndex = 4;
            this.botonAgregar.Text = "&Aceptar";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "STOCK : ";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStock.Location = new System.Drawing.Point(100, 90);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(168, 20);
            this.textBoxStock.TabIndex = 3;
            // 
            // nuevoArticulo
            // 
            this.AcceptButton = this.botonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 253);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.botonEliminar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStock;
    }
}