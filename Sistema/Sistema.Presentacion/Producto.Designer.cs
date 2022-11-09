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
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.cProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uMedida = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.Dgv_rProducto = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cbox_departamaneto = new System.Windows.Forms.ComboBox();
            this.nud_Costo = new System.Windows.Forms.NumericUpDown();
            this.nud_Existencia = new System.Windows.Forms.NumericUpDown();
            this.nub_PreUni = new System.Windows.Forms.NumericUpDown();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.nub_pReorden = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Adminnom = new System.Windows.Forms.TextBox();
            this.btn_VerModCajero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Existencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_PreUni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_pReorden)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos del Inventario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Punto de reorden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unidad de Medida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(25, 397);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(260, 20);
            this.Descripcion.TabIndex = 9;
            this.Descripcion.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // cProducto
            // 
            this.cProducto.Location = new System.Drawing.Point(26, 449);
            this.cProducto.Name = "cProducto";
            this.cProducto.ReadOnly = true;
            this.cProducto.Size = new System.Drawing.Size(229, 20);
            this.cProducto.TabIndex = 10;
            this.cProducto.TextChanged += new System.EventHandler(this.cProducto_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Departamento";
            // 
            // uMedida
            // 
            this.uMedida.FormattingEnabled = true;
            this.uMedida.Location = new System.Drawing.Point(28, 143);
            this.uMedida.Name = "uMedida";
            this.uMedida.Size = new System.Drawing.Size(56, 21);
            this.uMedida.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(1120, 462);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(1120, 331);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Crear";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Dgv_rProducto
            // 
            this.Dgv_rProducto.AllowUserToAddRows = false;
            this.Dgv_rProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rProducto.Location = new System.Drawing.Point(256, 95);
            this.Dgv_rProducto.Name = "Dgv_rProducto";
            this.Dgv_rProducto.Size = new System.Drawing.Size(939, 217);
            this.Dgv_rProducto.TabIndex = 23;
            this.Dgv_rProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rProducto_CellClick);
            this.Dgv_rProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rProducto_CellContentClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(1120, 428);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 22;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // cbox_departamaneto
            // 
            this.cbox_departamaneto.FormattingEnabled = true;
            this.cbox_departamaneto.Location = new System.Drawing.Point(26, 339);
            this.cbox_departamaneto.Name = "cbox_departamaneto";
            this.cbox_departamaneto.Size = new System.Drawing.Size(167, 21);
            this.cbox_departamaneto.TabIndex = 24;
            this.cbox_departamaneto.SelectedIndexChanged += new System.EventHandler(this.cbox_departamaneto_SelectedIndexChanged);
            // 
            // nud_Costo
            // 
            this.nud_Costo.Location = new System.Drawing.Point(28, 193);
            this.nud_Costo.Name = "nud_Costo";
            this.nud_Costo.Size = new System.Drawing.Size(56, 20);
            this.nud_Costo.TabIndex = 25;
            this.nud_Costo.ValueChanged += new System.EventHandler(this.nud_Costo_ValueChanged);
            // 
            // nud_Existencia
            // 
            this.nud_Existencia.Location = new System.Drawing.Point(28, 94);
            this.nud_Existencia.Name = "nud_Existencia";
            this.nud_Existencia.Size = new System.Drawing.Size(56, 20);
            this.nud_Existencia.TabIndex = 25;
            this.nud_Existencia.ValueChanged += new System.EventHandler(this.nud_Costo_ValueChanged);
            // 
            // nub_PreUni
            // 
            this.nub_PreUni.Location = new System.Drawing.Point(29, 242);
            this.nub_PreUni.Name = "nub_PreUni";
            this.nub_PreUni.Size = new System.Drawing.Size(56, 20);
            this.nub_PreUni.TabIndex = 25;
            this.nub_PreUni.ValueChanged += new System.EventHandler(this.nud_Costo_ValueChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(1120, 396);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(1120, 364);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 32;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // nub_pReorden
            // 
            this.nub_pReorden.Location = new System.Drawing.Point(29, 290);
            this.nub_pReorden.Name = "nub_pReorden";
            this.nub_pReorden.Size = new System.Drawing.Size(56, 20);
            this.nub_pReorden.TabIndex = 25;
            this.nub_pReorden.ValueChanged += new System.EventHandler(this.nud_Costo_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quien lo Registra:";
            // 
            // Adminnom
            // 
            this.Adminnom.Location = new System.Drawing.Point(363, 323);
            this.Adminnom.Name = "Adminnom";
            this.Adminnom.ReadOnly = true;
            this.Adminnom.Size = new System.Drawing.Size(167, 20);
            this.Adminnom.TabIndex = 33;
            // 
            // btn_VerModCajero
            // 
            this.btn_VerModCajero.Location = new System.Drawing.Point(1066, 66);
            this.btn_VerModCajero.Name = "btn_VerModCajero";
            this.btn_VerModCajero.Size = new System.Drawing.Size(129, 23);
            this.btn_VerModCajero.TabIndex = 35;
            this.btn_VerModCajero.Text = "Ver Modificaciones";
            this.btn_VerModCajero.UseVisualStyleBackColor = true;
            this.btn_VerModCajero.Click += new System.EventHandler(this.btn_VerModCajero_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 497);
            this.Controls.Add(this.btn_VerModCajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Adminnom);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.nud_Existencia);
            this.Controls.Add(this.nub_pReorden);
            this.Controls.Add(this.nub_PreUni);
            this.Controls.Add(this.nud_Costo);
            this.Controls.Add(this.cbox_departamaneto);
            this.Controls.Add(this.Dgv_rProducto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_limpiar);
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
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.cProducto);
            this.Controls.Add(this.label1);
            this.Name = "Producto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Existencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_PreUni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nub_pReorden)).EndInit();
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
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox cProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox uMedida;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridView Dgv_rProducto;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.NumericUpDown nud_Costo;
        private System.Windows.Forms.NumericUpDown nud_Existencia;
        private System.Windows.Forms.NumericUpDown nub_PreUni;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.NumericUpDown nub_pReorden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Adminnom;
        public System.Windows.Forms.ComboBox cbox_departamaneto;
        private System.Windows.Forms.Button btn_VerModCajero;
    }
}