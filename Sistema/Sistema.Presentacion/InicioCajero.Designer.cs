namespace Sistema.Presentacion
{
    partial class InicioCajero
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_devoluciones = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(12, 263);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(139, 27);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consulta de Recibos";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(26, 209);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(111, 27);
            this.btn_inventario.TabIndex = 2;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_devoluciones
            // 
            this.btn_devoluciones.Location = new System.Drawing.Point(26, 149);
            this.btn_devoluciones.Name = "btn_devoluciones";
            this.btn_devoluciones.Size = new System.Drawing.Size(111, 27);
            this.btn_devoluciones.TabIndex = 3;
            this.btn_devoluciones.Text = "Devoluciones";
            this.btn_devoluciones.UseVisualStyleBackColor = true;
            this.btn_devoluciones.Click += new System.EventHandler(this.btn_devoluciones_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(650, 409);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 27);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // InicioCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 448);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.btn_devoluciones);
            this.Name = "InicioCajero";
            this.Text = "InicioCajero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_devoluciones;
        private System.Windows.Forms.Button btn_cerrar;
    }
}