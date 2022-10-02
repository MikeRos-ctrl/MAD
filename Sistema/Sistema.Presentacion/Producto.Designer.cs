namespace Sistema.Presentacion
{
    partial class Producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pReorden = new System.Windows.Forms.TextBox();
            this.Exitencia = new System.Windows.Forms.TextBox();
            this.Costo = new System.Windows.Forms.TextBox();
            this.pUnitario = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.cProducto = new System.Windows.Forms.TextBox();
            this.Departamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uMedida = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadir Productos al Inventario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Punto de reorden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unidad de Medida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código";
            // 
            // pReorden
            // 
            this.pReorden.Location = new System.Drawing.Point(341, 259);
            this.pReorden.Name = "pReorden";
            this.pReorden.Size = new System.Drawing.Size(167, 20);
            this.pReorden.TabIndex = 3;
            // 
            // Exitencia
            // 
            this.Exitencia.Location = new System.Drawing.Point(42, 160);
            this.Exitencia.Name = "Exitencia";
            this.Exitencia.Size = new System.Drawing.Size(103, 20);
            this.Exitencia.TabIndex = 4;
            // 
            // Costo
            // 
            this.Costo.Location = new System.Drawing.Point(42, 259);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(103, 20);
            this.Costo.TabIndex = 5;
            // 
            // pUnitario
            // 
            this.pUnitario.Location = new System.Drawing.Point(341, 160);
            this.pUnitario.Name = "pUnitario";
            this.pUnitario.Size = new System.Drawing.Size(167, 20);
            this.pUnitario.TabIndex = 8;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(42, 331);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(512, 20);
            this.Descripcion.TabIndex = 9;
            this.Descripcion.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // cProducto
            // 
            this.cProducto.Location = new System.Drawing.Point(42, 114);
            this.cProducto.Name = "cProducto";
            this.cProducto.Size = new System.Drawing.Size(103, 20);
            this.cProducto.TabIndex = 10;
            // 
            // Departamento
            // 
            this.Departamento.Location = new System.Drawing.Point(341, 209);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(167, 20);
            this.Departamento.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Departamento";
            // 
            // uMedida
            // 
            this.uMedida.FormattingEnabled = true;
            this.uMedida.Location = new System.Drawing.Point(42, 209);
            this.uMedida.Name = "uMedida";
            this.uMedida.Size = new System.Drawing.Size(121, 21);
            this.uMedida.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(305, 388);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(207, 388);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Crear";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.uMedida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pReorden);
            this.Controls.Add(this.Exitencia);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.pUnitario);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.cProducto);
            this.Controls.Add(this.label1);
            this.Name = "Producto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pReorden;
        private System.Windows.Forms.TextBox Exitencia;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.TextBox pUnitario;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox cProducto;
        private System.Windows.Forms.TextBox Departamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox uMedida;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
    }
}