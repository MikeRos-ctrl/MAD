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
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_usurio = new System.Windows.Forms.Button();
            this.btn_devoluciones = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_rVentas = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_rCajero = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_producto
            // 
            this.btn_producto.Location = new System.Drawing.Point(25, 101);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(111, 27);
            this.btn_producto.TabIndex = 0;
            this.btn_producto.Text = "Agregar Producto";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(25, 148);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(111, 27);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.Text = "Editar Producto";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_usurio
            // 
            this.btn_usurio.Location = new System.Drawing.Point(25, 32);
            this.btn_usurio.Name = "btn_usurio";
            this.btn_usurio.Size = new System.Drawing.Size(111, 27);
            this.btn_usurio.TabIndex = 0;
            this.btn_usurio.Text = "Ver Usuario";
            this.btn_usurio.UseVisualStyleBackColor = true;
            this.btn_usurio.Click += new System.EventHandler(this.btn_usurio_Click);
            // 
            // btn_devoluciones
            // 
            this.btn_devoluciones.Location = new System.Drawing.Point(25, 197);
            this.btn_devoluciones.Name = "btn_devoluciones";
            this.btn_devoluciones.Size = new System.Drawing.Size(111, 27);
            this.btn_devoluciones.TabIndex = 0;
            this.btn_devoluciones.Text = "Devoluciones";
            this.btn_devoluciones.UseVisualStyleBackColor = true;
            this.btn_devoluciones.Click += new System.EventHandler(this.btn_devoluciones_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(13, 278);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(139, 27);
            this.btn_consulta.TabIndex = 0;
            this.btn_consulta.Text = "Consulta de Recibos";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // btn_rVentas
            // 
            this.btn_rVentas.Location = new System.Drawing.Point(13, 323);
            this.btn_rVentas.Name = "btn_rVentas";
            this.btn_rVentas.Size = new System.Drawing.Size(139, 27);
            this.btn_rVentas.TabIndex = 0;
            this.btn_rVentas.Text = "Reporte de ventas";
            this.btn_rVentas.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(666, 411);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 27);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_devoluciones_Click);
            // 
            // btn_rCajero
            // 
            this.btn_rCajero.Location = new System.Drawing.Point(13, 368);
            this.btn_rCajero.Name = "btn_rCajero";
            this.btn_rCajero.Size = new System.Drawing.Size(139, 27);
            this.btn_rCajero.TabIndex = 0;
            this.btn_rCajero.Text = "Reporte de cajero";
            this.btn_rCajero.UseVisualStyleBackColor = true;
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(24, 237);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(111, 27);
            this.btn_inventario.TabIndex = 0;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_devoluciones_Click);
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rCajero);
            this.Controls.Add(this.btn_rVentas);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.btn_devoluciones);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_usurio);
            this.Controls.Add(this.btn_producto);
            this.Name = "InicioAdmin";
            this.Text = "InicioAdmin";
            this.Load += new System.EventHandler(this.InicioAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_usurio;
        private System.Windows.Forms.Button btn_devoluciones;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_rVentas;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_rCajero;
        private System.Windows.Forms.Button btn_inventario;
    }
}