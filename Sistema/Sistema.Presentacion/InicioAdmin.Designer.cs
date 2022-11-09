namespace Sistema.Presentacion
{
    partial class InicioAdmin
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
            this.btn_usurio = new System.Windows.Forms.Button();
            this.btn_rVentas = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_rCajero = new System.Windows.Forms.Button();
            this.btn_verCajero = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_GesDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_usurio
            // 
            this.btn_usurio.Location = new System.Drawing.Point(666, 21);
            this.btn_usurio.Name = "btn_usurio";
            this.btn_usurio.Size = new System.Drawing.Size(111, 27);
            this.btn_usurio.TabIndex = 0;
            this.btn_usurio.Text = "Agregar Cajero";
            this.btn_usurio.UseVisualStyleBackColor = true;
            this.btn_usurio.Click += new System.EventHandler(this.btn_usurio_Click);
            // 
            // btn_rVentas
            // 
            this.btn_rVentas.Location = new System.Drawing.Point(12, 266);
            this.btn_rVentas.Name = "btn_rVentas";
            this.btn_rVentas.Size = new System.Drawing.Size(139, 27);
            this.btn_rVentas.TabIndex = 0;
            this.btn_rVentas.Text = "Reporte de ventas";
            this.btn_rVentas.UseVisualStyleBackColor = true;
            this.btn_rVentas.Click += new System.EventHandler(this.btn_rVentas_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(666, 411);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 27);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_rCajero
            // 
            this.btn_rCajero.Location = new System.Drawing.Point(12, 312);
            this.btn_rCajero.Name = "btn_rCajero";
            this.btn_rCajero.Size = new System.Drawing.Size(139, 27);
            this.btn_rCajero.TabIndex = 0;
            this.btn_rCajero.Text = "Reporte de cajero";
            this.btn_rCajero.UseVisualStyleBackColor = true;
            this.btn_rCajero.Click += new System.EventHandler(this.btn_rCajero_Click);
            // 
            // btn_verCajero
            // 
            this.btn_verCajero.Location = new System.Drawing.Point(21, 21);
            this.btn_verCajero.Name = "btn_verCajero";
            this.btn_verCajero.Size = new System.Drawing.Size(111, 27);
            this.btn_verCajero.TabIndex = 0;
            this.btn_verCajero.Text = "Gestionar Cajeros";
            this.btn_verCajero.UseVisualStyleBackColor = true;
            this.btn_verCajero.Click += new System.EventHandler(this.btn_verCajero_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Location = new System.Drawing.Point(12, 220);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(139, 27);
            this.btn_productos.TabIndex = 0;
            this.btn_productos.Text = "Gestionar Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_GesDep
            // 
            this.btn_GesDep.Location = new System.Drawing.Point(12, 178);
            this.btn_GesDep.Name = "btn_GesDep";
            this.btn_GesDep.Size = new System.Drawing.Size(139, 27);
            this.btn_GesDep.TabIndex = 0;
            this.btn_GesDep.Text = "Gestionar Departamento";
            this.btn_GesDep.UseVisualStyleBackColor = true;
            this.btn_GesDep.Click += new System.EventHandler(this.btn_GesDep_Click);
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rCajero);
            this.Controls.Add(this.btn_rVentas);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_GesDep);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_verCajero);
            this.Controls.Add(this.btn_usurio);
            this.Name = "InicioAdmin";
            this.Text = "InicioAdmin";
            this.Load += new System.EventHandler(this.InicioAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_usurio;
        private System.Windows.Forms.Button btn_rVentas;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_rCajero;
        private System.Windows.Forms.Button btn_verCajero;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_GesDep;
    }
}