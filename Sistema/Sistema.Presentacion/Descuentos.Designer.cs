namespace Sistema.Presentacion
{
    partial class Descuentos
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
            this.Dgv_rDescuento = new System.Windows.Forms.DataGridView();
            this.dtp_fFin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idDescu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.nud_Descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_Codigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rDescuento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_rDescuento
            // 
            this.Dgv_rDescuento.AllowUserToAddRows = false;
            this.Dgv_rDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rDescuento.Location = new System.Drawing.Point(10, 194);
            this.Dgv_rDescuento.Name = "Dgv_rDescuento";
            this.Dgv_rDescuento.Size = new System.Drawing.Size(728, 217);
            this.Dgv_rDescuento.TabIndex = 24;
            this.Dgv_rDescuento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rDescuento_CellClick);
            this.Dgv_rDescuento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rDescuento_CellContentClick);
            // 
            // dtp_fFin
            // 
            this.dtp_fFin.Location = new System.Drawing.Point(6, 79);
            this.dtp_fFin.Name = "dtp_fFin";
            this.dtp_fFin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fFin.TabIndex = 6;
            // 
            // dtp_fInicio
            // 
            this.dtp_fInicio.Location = new System.Drawing.Point(6, 40);
            this.dtp_fInicio.Name = "dtp_fInicio";
            this.dtp_fInicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_fInicio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_fFin);
            this.groupBox1.Controls.Add(this.dtp_fInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(519, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 110);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de fechas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Generar un descuento";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(326, 417);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 29;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id:";
            // 
            // idDescu
            // 
            this.idDescu.Location = new System.Drawing.Point(129, 108);
            this.idDescu.Name = "idDescu";
            this.idDescu.ReadOnly = true;
            this.idDescu.Size = new System.Drawing.Size(60, 20);
            this.idDescu.TabIndex = 30;
            this.idDescu.TextChanged += new System.EventHandler(this.idDescu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descuento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(326, 94);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 34;
            this.btn_aceptar.Text = "Crear";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(326, 128);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 35;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // nud_Descuento
            // 
            this.nud_Descuento.Location = new System.Drawing.Point(129, 71);
            this.nud_Descuento.Name = "nud_Descuento";
            this.nud_Descuento.Size = new System.Drawing.Size(93, 20);
            this.nud_Descuento.TabIndex = 30;
            this.nud_Descuento.TextChanged += new System.EventHandler(this.idDescu_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Codigo de Producto:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbox_Codigo
            // 
            this.cbox_Codigo.FormattingEnabled = true;
            this.cbox_Codigo.Location = new System.Drawing.Point(46, 154);
            this.cbox_Codigo.Name = "cbox_Codigo";
            this.cbox_Codigo.Size = new System.Drawing.Size(246, 21);
            this.cbox_Codigo.TabIndex = 37;
            this.cbox_Codigo.SelectedIndexChanged += new System.EventHandler(this.cbox_Codigo_SelectedIndexChanged);
            // 
            // Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 452);
            this.Controls.Add(this.cbox_Codigo);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_Descuento);
            this.Controls.Add(this.idDescu);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgv_rDescuento);
            this.Name = "Descuentos";
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.Descuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rDescuento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_rDescuento;
        private System.Windows.Forms.DateTimePicker dtp_fFin;
        private System.Windows.Forms.DateTimePicker dtp_fInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idDescu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox nud_Descuento;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbox_Codigo;
    }
}