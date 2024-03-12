namespace programa
{
    partial class formArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formArticulos));
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Image = ((System.Drawing.Image)(resources.GetObject("botonVolver.Image")));
            this.botonVolver.Location = new System.Drawing.Point(3, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(120, 77);
            this.botonVolver.TabIndex = 0;
            this.botonVolver.Text = "&Volver";
            this.botonVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("botonAgregar.Image")));
            this.botonAgregar.Location = new System.Drawing.Point(128, 378);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(131, 77);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "&Agregar Nuevo";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEditar.Image = ((System.Drawing.Image)(resources.GetObject("botonEditar.Image")));
            this.botonEditar.Location = new System.Drawing.Point(361, 378);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(131, 77);
            this.botonEditar.TabIndex = 2;
            this.botonEditar.Text = "&Editar";
            this.botonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(591, 378);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(131, 77);
            this.botonEliminar.TabIndex = 3;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(128, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(594, 360);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // formArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 454);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.ListView listView1;
    }
}