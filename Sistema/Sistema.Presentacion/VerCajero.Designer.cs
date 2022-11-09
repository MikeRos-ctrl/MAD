namespace Sistema.Presentacion
{
    partial class VerCajero
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
            this.Dgv_rCajero = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registered_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomina_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contra_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CURP = new System.Windows.Forms.TextBox();
            this.nNomina = new System.Windows.Forms.TextBox();
            this.NomCompleto = new System.Windows.Forms.TextBox();
            this.ClaveUsu = new System.Windows.Forms.TextBox();
            this.fNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.Adminnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_VerModCajero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_rCajero
            // 
            this.Dgv_rCajero.AllowUserToAddRows = false;
            this.Dgv_rCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rCajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Registered_by,
            this.Nombre,
            this.Curp_,
            this.Fecha_Nacimiento,
            this.Nomina_,
            this.Correo_,
            this.Contra_});
            this.Dgv_rCajero.Location = new System.Drawing.Point(238, 85);
            this.Dgv_rCajero.Name = "Dgv_rCajero";
            this.Dgv_rCajero.Size = new System.Drawing.Size(945, 391);
            this.Dgv_rCajero.TabIndex = 18;
            this.Dgv_rCajero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rCajero_CellClick);
            this.Dgv_rCajero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rCajero_CellContentClick);
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Registered_by
            // 
            this.Registered_by.DataPropertyName = "registered_by";
            this.Registered_by.HeaderText = "Registered_by";
            this.Registered_by.Name = "Registered_by";
            this.Registered_by.ReadOnly = true;
            this.Registered_by.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Curp_
            // 
            this.Curp_.DataPropertyName = "curp";
            this.Curp_.HeaderText = "Curp_";
            this.Curp_.Name = "Curp_";
            this.Curp_.ReadOnly = true;
            this.Curp_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.HeaderText = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.ReadOnly = true;
            this.Fecha_Nacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nomina_
            // 
            this.Nomina_.DataPropertyName = "nomina";
            this.Nomina_.HeaderText = "Nomina_";
            this.Nomina_.Name = "Nomina_";
            this.Nomina_.ReadOnly = true;
            this.Nomina_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Correo_
            // 
            this.Correo_.DataPropertyName = "correo";
            this.Correo_.HeaderText = "Correo_";
            this.Correo_.Name = "Correo_";
            this.Correo_.ReadOnly = true;
            this.Correo_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Contra_
            // 
            this.Contra_.DataPropertyName = "contra";
            this.Contra_.HeaderText = "Contra_";
            this.Contra_.Name = "Contra_";
            this.Contra_.ReadOnly = true;
            this.Contra_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ver Cajeros";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(1135, 508);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(23, 453);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(137, 453);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numero de nómina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Clave de Usuario";
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(23, 204);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(167, 20);
            this.CURP.TabIndex = 23;
            // 
            // nNomina
            // 
            this.nNomina.Location = new System.Drawing.Point(23, 254);
            this.nNomina.Name = "nNomina";
            this.nNomina.Size = new System.Drawing.Size(167, 20);
            this.nNomina.TabIndex = 24;
            // 
            // NomCompleto
            // 
            this.NomCompleto.Location = new System.Drawing.Point(23, 155);
            this.NomCompleto.Name = "NomCompleto";
            this.NomCompleto.Size = new System.Drawing.Size(167, 20);
            this.NomCompleto.TabIndex = 25;
            // 
            // ClaveUsu
            // 
            this.ClaveUsu.Location = new System.Drawing.Point(23, 109);
            this.ClaveUsu.Name = "ClaveUsu";
            this.ClaveUsu.ReadOnly = true;
            this.ClaveUsu.Size = new System.Drawing.Size(167, 20);
            this.ClaveUsu.TabIndex = 26;
            // 
            // fNacimiento
            // 
            this.fNacimiento.Location = new System.Drawing.Point(20, 411);
            this.fNacimiento.Name = "fNacimiento";
            this.fNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fNacimiento.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Contraseña";
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(24, 359);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(167, 20);
            this.Correo.TabIndex = 31;
            // 
            // Contrasena
            // 
            this.Contrasena.Location = new System.Drawing.Point(24, 310);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(167, 20);
            this.Contrasena.TabIndex = 32;
            // 
            // Adminnom
            // 
            this.Adminnom.Location = new System.Drawing.Point(110, 517);
            this.Adminnom.Name = "Adminnom";
            this.Adminnom.ReadOnly = true;
            this.Adminnom.Size = new System.Drawing.Size(167, 20);
            this.Adminnom.TabIndex = 25;
            this.Adminnom.TextChanged += new System.EventHandler(this.Adminnom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quien lo Registra:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_VerModCajero
            // 
            this.btn_VerModCajero.Location = new System.Drawing.Point(1054, 46);
            this.btn_VerModCajero.Name = "btn_VerModCajero";
            this.btn_VerModCajero.Size = new System.Drawing.Size(129, 23);
            this.btn_VerModCajero.TabIndex = 20;
            this.btn_VerModCajero.Text = "Ver Modificaciones";
            this.btn_VerModCajero.UseVisualStyleBackColor = true;
            this.btn_VerModCajero.Click += new System.EventHandler(this.btn_VerModCajero_Click);
            // 
            // VerCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 543);
            this.Controls.Add(this.fNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CURP);
            this.Controls.Add(this.nNomina);
            this.Controls.Add(this.Adminnom);
            this.Controls.Add(this.NomCompleto);
            this.Controls.Add(this.ClaveUsu);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_VerModCajero);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_rCajero);
            this.Name = "VerCajero";
            this.Text = "VerCajero";
            this.Load += new System.EventHandler(this.VerCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rCajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_rCajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CURP;
        private System.Windows.Forms.TextBox nNomina;
        private System.Windows.Forms.TextBox NomCompleto;
        private System.Windows.Forms.TextBox ClaveUsu;
        private System.Windows.Forms.DateTimePicker fNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox Adminnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_VerModCajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registered_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomina_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contra_;
    }
}