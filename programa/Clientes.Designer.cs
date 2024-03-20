namespace programa
{
    partial class formClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClientes));
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonEditarCliente = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltroCliente = new System.Windows.Forms.TextBox();
            this.botonFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("botonAgregar.Image")));
            this.botonAgregar.Location = new System.Drawing.Point(2, 119);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(120, 77);
            this.botonAgregar.TabIndex = 2;
            this.botonAgregar.Text = "&Agregar Nuevo";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonEditarCliente
            // 
            this.botonEditarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("botonEditarCliente.Image")));
            this.botonEditarCliente.Location = new System.Drawing.Point(2, 202);
            this.botonEditarCliente.Name = "botonEditarCliente";
            this.botonEditarCliente.Size = new System.Drawing.Size(120, 77);
            this.botonEditarCliente.TabIndex = 3;
            this.botonEditarCliente.Text = "&Editar";
            this.botonEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEditarCliente.UseVisualStyleBackColor = true;
            this.botonEditarCliente.Click += new System.EventHandler(this.botonEditarCliente_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(2, 285);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(120, 77);
            this.botonEliminar.TabIndex = 4;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Image = ((System.Drawing.Image)(resources.GetObject("botonVolver.Image")));
            this.botonVolver.Location = new System.Drawing.Point(2, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(120, 77);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(128, 35);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(593, 449);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(735, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 185);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtro :";
            // 
            // textBoxFiltroCliente
            // 
            this.textBoxFiltroCliente.Location = new System.Drawing.Point(320, 9);
            this.textBoxFiltroCliente.Name = "textBoxFiltroCliente";
            this.textBoxFiltroCliente.Size = new System.Drawing.Size(203, 20);
            this.textBoxFiltroCliente.TabIndex = 13;
            this.textBoxFiltroCliente.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // botonFiltro
            // 
            this.botonFiltro.Location = new System.Drawing.Point(529, 7);
            this.botonFiltro.Name = "botonFiltro";
            this.botonFiltro.Size = new System.Drawing.Size(88, 23);
            this.botonFiltro.TabIndex = 14;
            this.botonFiltro.Text = "Buscar";
            this.botonFiltro.UseVisualStyleBackColor = true;
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 485);
            this.ControlBox = false;
            this.Controls.Add(this.botonFiltro);
            this.Controls.Add(this.textBoxFiltroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditarCliente);
            this.Controls.Add(this.botonAgregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonEditarCliente;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltroCliente;
        private System.Windows.Forms.Button botonFiltro;
    }
}