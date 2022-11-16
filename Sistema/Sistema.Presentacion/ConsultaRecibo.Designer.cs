namespace Sistema.Presentacion
{
    partial class ConsultaRecibo
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
            this.Dgv_cRecibos = new System.Windows.Forms.DataGridView();
            this.btn_recibo = new System.Windows.Forms.Button();
            this.cb_numRecibos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_devolvertodo = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.producto = new System.Windows.Forms.TextBox();
            this.caja = new System.Windows.Forms.TextBox();
            this.tipopago = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.motivo = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cb_tienemerma = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.codigopro = new System.Windows.Forms.TextBox();
            this.ClaveCa = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_cRecibos
            // 
            this.Dgv_cRecibos.AllowUserToAddRows = false;
            this.Dgv_cRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cRecibos.Location = new System.Drawing.Point(306, 85);
            this.Dgv_cRecibos.Name = "Dgv_cRecibos";
            this.Dgv_cRecibos.Size = new System.Drawing.Size(675, 208);
            this.Dgv_cRecibos.TabIndex = 11;
            this.Dgv_cRecibos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_cRecibos_CellClick);
            this.Dgv_cRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_cRecibos_CellContentClick);
            // 
            // btn_recibo
            // 
            this.btn_recibo.Location = new System.Drawing.Point(837, 319);
            this.btn_recibo.Name = "btn_recibo";
            this.btn_recibo.Size = new System.Drawing.Size(144, 26);
            this.btn_recibo.TabIndex = 10;
            this.btn_recibo.Text = "Generar recibo";
            this.btn_recibo.UseVisualStyleBackColor = true;
            this.btn_recibo.Click += new System.EventHandler(this.btn_recibo_Click);
            // 
            // cb_numRecibos
            // 
            this.cb_numRecibos.FormattingEnabled = true;
            this.cb_numRecibos.Location = new System.Drawing.Point(306, 319);
            this.cb_numRecibos.Name = "cb_numRecibos";
            this.cb_numRecibos.Size = new System.Drawing.Size(151, 21);
            this.cb_numRecibos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de Recibo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(475, 319);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(906, 380);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Cerrar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Consulta De Recibos";
            // 
            // btn_devolvertodo
            // 
            this.btn_devolvertodo.Location = new System.Drawing.Point(111, 380);
            this.btn_devolvertodo.Name = "btn_devolvertodo";
            this.btn_devolvertodo.Size = new System.Drawing.Size(115, 23);
            this.btn_devolvertodo.TabIndex = 22;
            this.btn_devolvertodo.Text = "Devolver Todo";
            this.btn_devolvertodo.UseVisualStyleBackColor = true;
            this.btn_devolvertodo.Click += new System.EventHandler(this.btn_devolvertodo_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(12, 380);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(75, 23);
            this.btn_devolver.TabIndex = 23;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(22, 78);
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Size = new System.Drawing.Size(107, 20);
            this.codigo.TabIndex = 25;
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(22, 149);
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Size = new System.Drawing.Size(167, 20);
            this.producto.TabIndex = 25;
            // 
            // caja
            // 
            this.caja.Location = new System.Drawing.Point(22, 186);
            this.caja.Name = "caja";
            this.caja.ReadOnly = true;
            this.caja.Size = new System.Drawing.Size(124, 20);
            this.caja.TabIndex = 25;
            // 
            // tipopago
            // 
            this.tipopago.Location = new System.Drawing.Point(22, 225);
            this.tipopago.Name = "tipopago";
            this.tipopago.ReadOnly = true;
            this.tipopago.Size = new System.Drawing.Size(157, 20);
            this.tipopago.TabIndex = 25;
            // 
            // subtotal
            // 
            this.subtotal.Location = new System.Drawing.Point(22, 264);
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Size = new System.Drawing.Size(78, 20);
            this.subtotal.TabIndex = 25;
            this.subtotal.TextChanged += new System.EventHandler(this.subtotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de recibo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Caja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Motivo:";
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(303, 382);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(194, 20);
            this.motivo.TabIndex = 25;
            this.motivo.TextChanged += new System.EventHandler(this.subtotal_TextChanged);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(123, 262);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // cb_tienemerma
            // 
            this.cb_tienemerma.AutoSize = true;
            this.cb_tienemerma.Location = new System.Drawing.Point(22, 317);
            this.cb_tienemerma.Name = "cb_tienemerma";
            this.cb_tienemerma.Size = new System.Drawing.Size(87, 17);
            this.cb_tienemerma.TabIndex = 26;
            this.cb_tienemerma.Text = "Tiene merma";
            this.cb_tienemerma.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(150, 78);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 27;
            this.ID.Text = "ID";
            this.ID.Visible = false;
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Codigo:";
            // 
            // codigopro
            // 
            this.codigopro.Location = new System.Drawing.Point(22, 113);
            this.codigopro.Name = "codigopro";
            this.codigopro.ReadOnly = true;
            this.codigopro.Size = new System.Drawing.Size(195, 20);
            this.codigopro.TabIndex = 25;
            // 
            // ClaveCa
            // 
            this.ClaveCa.AutoSize = true;
            this.ClaveCa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClaveCa.Location = new System.Drawing.Point(300, 30);
            this.ClaveCa.Name = "ClaveCa";
            this.ClaveCa.Size = new System.Drawing.Size(64, 13);
            this.ClaveCa.TabIndex = 167;
            this.ClaveCa.Text = "ClaveCajero";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hora.Location = new System.Drawing.Point(414, 30);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(30, 13);
            this.hora.TabIndex = 167;
            this.hora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConsultaRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 414);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.ClaveCa);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.cb_tienemerma);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.tipopago);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.codigopro);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.btn_devolvertodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.Dgv_cRecibos);
            this.Controls.Add(this.btn_recibo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_numRecibos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ConsultaRecibo";
            this.Text = "ConsultaRecibo";
            this.Load += new System.EventHandler(this.ConsultaRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_cRecibos;
        private System.Windows.Forms.Button btn_recibo;
        private System.Windows.Forms.ComboBox cb_numRecibos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_devolvertodo;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.TextBox caja;
        private System.Windows.Forms.TextBox tipopago;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox motivo;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.CheckBox cb_tienemerma;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codigopro;
        public System.Windows.Forms.Label ClaveCa;
        public System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
    }
}