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
            this.components = new System.ComponentModel.Container();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_devoluciones = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_rCajero = new System.Windows.Forms.Button();
            this.btn_rVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.CodigoV = new System.Windows.Forms.TextBox();
            this.Caja = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.FechaActual = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.TextBox();
            this.Dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nProducto = new System.Windows.Forms.TextBox();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Cajero = new System.Windows.Forms.TextBox();
            this.btn_anadir = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_mostrar_total = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dgv_VCarrito = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.ClaveCa = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_VCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(33, 147);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(139, 27);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consulta de Recibos";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(33, 110);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(139, 27);
            this.btn_inventario.TabIndex = 2;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_devoluciones
            // 
            this.btn_devoluciones.Location = new System.Drawing.Point(33, 71);
            this.btn_devoluciones.Name = "btn_devoluciones";
            this.btn_devoluciones.Size = new System.Drawing.Size(139, 27);
            this.btn_devoluciones.TabIndex = 3;
            this.btn_devoluciones.Text = "Devoluciones";
            this.btn_devoluciones.UseVisualStyleBackColor = true;
            this.btn_devoluciones.Click += new System.EventHandler(this.btn_devoluciones_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(15, 631);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(111, 27);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_rCajero
            // 
            this.btn_rCajero.Location = new System.Drawing.Point(33, 219);
            this.btn_rCajero.Name = "btn_rCajero";
            this.btn_rCajero.Size = new System.Drawing.Size(139, 27);
            this.btn_rCajero.TabIndex = 5;
            this.btn_rCajero.Text = "Reporte de cajero";
            this.btn_rCajero.UseVisualStyleBackColor = true;
            this.btn_rCajero.Click += new System.EventHandler(this.btn_rCajero_Click);
            // 
            // btn_rVentas
            // 
            this.btn_rVentas.Location = new System.Drawing.Point(33, 181);
            this.btn_rVentas.Name = "btn_rVentas";
            this.btn_rVentas.Size = new System.Drawing.Size(139, 27);
            this.btn_rVentas.TabIndex = 6;
            this.btn_rVentas.Text = "Reporte de ventas";
            this.btn_rVentas.UseVisualStyleBackColor = true;
            this.btn_rVentas.Click += new System.EventHandler(this.btn_rVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cajero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Caja:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 510);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 28;
            this.label.Text = "Fecha:";
            // 
            // CodigoV
            // 
            this.CodigoV.Location = new System.Drawing.Point(485, 281);
            this.CodigoV.Name = "CodigoV";
            this.CodigoV.ReadOnly = true;
            this.CodigoV.Size = new System.Drawing.Size(305, 20);
            this.CodigoV.TabIndex = 29;
            // 
            // Caja
            // 
            this.Caja.Location = new System.Drawing.Point(56, 448);
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            this.Caja.Size = new System.Drawing.Size(94, 20);
            this.Caja.TabIndex = 29;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(56, 507);
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Size = new System.Drawing.Size(172, 20);
            this.Fecha.TabIndex = 29;
            // 
            // FechaActual
            // 
            this.FechaActual.Enabled = true;
            this.FechaActual.Tick += new System.EventHandler(this.FechaActual_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hora:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(56, 478);
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Size = new System.Drawing.Size(116, 20);
            this.Hora.TabIndex = 29;
            this.Hora.TextChanged += new System.EventHandler(this.Hora_TextChanged);
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.AllowUserToAddRows = false;
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ventas.Location = new System.Drawing.Point(194, 50);
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.Size = new System.Drawing.Size(988, 217);
            this.Dgv_Ventas.TabIndex = 30;
            this.Dgv_Ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Ventas_CellClick);
            this.Dgv_Ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Ventas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Producto:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // nProducto
            // 
            this.nProducto.Location = new System.Drawing.Point(616, 307);
            this.nProducto.Name = "nProducto";
            this.nProducto.ReadOnly = true;
            this.nProducto.Size = new System.Drawing.Size(174, 20);
            this.nProducto.TabIndex = 29;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(359, 281);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(53, 20);
            this.nud_Cantidad.TabIndex = 31;
            // 
            // Cajero
            // 
            this.Cajero.Location = new System.Drawing.Point(56, 415);
            this.Cajero.Name = "Cajero";
            this.Cajero.ReadOnly = true;
            this.Cajero.Size = new System.Drawing.Size(134, 20);
            this.Cajero.TabIndex = 29;
            // 
            // btn_anadir
            // 
            this.btn_anadir.Location = new System.Drawing.Point(204, 276);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(81, 27);
            this.btn_anadir.TabIndex = 4;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = true;
            this.btn_anadir.Click += new System.EventHandler(this.btn_anadir_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.Location = new System.Drawing.Point(322, 594);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(120, 27);
            this.btn_vender.TabIndex = 4;
            this.btn_vender.Text = "Confirmar";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(900, 282);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(277, 20);
            this.Busqueda.TabIndex = 29;
            this.Busqueda.TextChanged += new System.EventHandler(this.Busqueda_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Codigo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(851, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Buscar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(922, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "(Busqueda por numero de codigo del producto)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(342, 380);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Id.TabIndex = 33;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Numero de compra";
            this.label11.Click += new System.EventHandler(this.label5_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(985, 632);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 163;
            this.label20.Text = "Super Total:";
            // 
            // txt_mostrar_total
            // 
            this.txt_mostrar_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mostrar_total.Location = new System.Drawing.Point(1057, 629);
            this.txt_mostrar_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mostrar_total.Name = "txt_mostrar_total";
            this.txt_mostrar_total.ReadOnly = true;
            this.txt_mostrar_total.Size = new System.Drawing.Size(119, 20);
            this.txt_mostrar_total.TabIndex = 162;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 485);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 164;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Forma de pago:";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // Dgv_VCarrito
            // 
            this.Dgv_VCarrito.AllowUserToAddRows = false;
            this.Dgv_VCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_VCarrito.Location = new System.Drawing.Point(448, 364);
            this.Dgv_VCarrito.Name = "Dgv_VCarrito";
            this.Dgv_VCarrito.Size = new System.Drawing.Size(734, 257);
            this.Dgv_VCarrito.TabIndex = 30;
            this.Dgv_VCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_VCarrito_CellClick);
            this.Dgv_VCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_VCarrito_CellContentClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(204, 310);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(81, 27);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // ClaveCa
            // 
            this.ClaveCa.AutoSize = true;
            this.ClaveCa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClaveCa.Location = new System.Drawing.Point(53, 399);
            this.ClaveCa.Name = "ClaveCa";
            this.ClaveCa.Size = new System.Drawing.Size(64, 13);
            this.ClaveCa.TabIndex = 165;
            this.ClaveCa.Text = "ClaveCajero";
            this.ClaveCa.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(443, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "Comprar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // InicioCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 666);
            this.Controls.Add(this.ClaveCa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_mostrar_total);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.Dgv_VCarrito);
            this.Controls.Add(this.Dgv_Ventas);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.nProducto);
            this.Controls.Add(this.Cajero);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.CodigoV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rCajero);
            this.Controls.Add(this.btn_rVentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_anadir);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.btn_devoluciones);
            this.Name = "InicioCajero";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.InicioCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_VCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_devoluciones;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_rCajero;
        private System.Windows.Forms.Button btn_rVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox CodigoV;
        private System.Windows.Forms.TextBox Fecha;
        public System.Windows.Forms.TextBox Caja;
        private System.Windows.Forms.Timer FechaActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Hora;
        private System.Windows.Forms.DataGridView Dgv_Ventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nProducto;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.TextBox Cajero;
        private System.Windows.Forms.Button btn_anadir;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.TextBox Busqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txt_mostrar_total;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_VCarrito;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label ClaveCa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}