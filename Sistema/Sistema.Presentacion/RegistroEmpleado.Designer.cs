﻿namespace Sistema.Presentacion
{
    partial class RegistroEmpleado
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
            this.ClaveUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.NomCompleto = new System.Windows.Forms.TextBox();
            this.CURP = new System.Windows.Forms.TextBox();
            this.nNomina = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.RadioButton();
            this.cajero = new System.Windows.Forms.RadioButton();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.fNacimiento = new System.Windows.Forms.DateTimePicker();
            this.fIngreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añade Un Empleado";
            // 
            // ClaveUsu
            // 
            this.ClaveUsu.Location = new System.Drawing.Point(59, 101);
            this.ClaveUsu.Name = "ClaveUsu";
            this.ClaveUsu.Size = new System.Drawing.Size(167, 20);
            this.ClaveUsu.TabIndex = 1;
            this.ClaveUsu.TextChanged += new System.EventHandler(this.ClaveUsu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CURP";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha de Nacimiento";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numero de nómina";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Correo";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha de ingreso a la empresa";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // Contrasena
            // 
            this.Contrasena.Location = new System.Drawing.Point(59, 147);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(167, 20);
            this.Contrasena.TabIndex = 1;
            this.Contrasena.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // NomCompleto
            // 
            this.NomCompleto.Location = new System.Drawing.Point(59, 197);
            this.NomCompleto.Name = "NomCompleto";
            this.NomCompleto.Size = new System.Drawing.Size(167, 20);
            this.NomCompleto.TabIndex = 1;
            this.NomCompleto.TextChanged += new System.EventHandler(this.NomCompleto_TextChanged);
            // 
            // CURP
            // 
            this.CURP.Location = new System.Drawing.Point(59, 246);
            this.CURP.Name = "CURP";
            this.CURP.Size = new System.Drawing.Size(167, 20);
            this.CURP.TabIndex = 1;
            this.CURP.TextChanged += new System.EventHandler(this.CURP_TextChanged);
            // 
            // nNomina
            // 
            this.nNomina.Location = new System.Drawing.Point(358, 101);
            this.nNomina.Name = "nNomina";
            this.nNomina.Size = new System.Drawing.Size(167, 20);
            this.nNomina.TabIndex = 1;
            this.nNomina.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(358, 147);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(167, 20);
            this.Correo.TabIndex = 1;
            this.Correo.TextChanged += new System.EventHandler(this.NomCompleto_TextChanged);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(589, 127);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(88, 17);
            this.admin.TabIndex = 3;
            this.admin.TabStop = true;
            this.admin.Text = "Administrador";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // cajero
            // 
            this.cajero.AutoSize = true;
            this.cajero.Location = new System.Drawing.Point(589, 150);
            this.cajero.Name = "cajero";
            this.cajero.Size = new System.Drawing.Size(55, 17);
            this.cajero.TabIndex = 3;
            this.cajero.TabStop = true;
            this.cajero.Text = "Cajero";
            this.cajero.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(224, 322);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Crear";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(322, 322);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // fNacimiento
            // 
            this.fNacimiento.Location = new System.Drawing.Point(358, 197);
            this.fNacimiento.Name = "fNacimiento";
            this.fNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fNacimiento.TabIndex = 5;
            this.fNacimiento.ValueChanged += new System.EventHandler(this.fNacimiento_ValueChanged);
            // 
            // fIngreso
            // 
            this.fIngreso.Location = new System.Drawing.Point(358, 246);
            this.fIngreso.Name = "fIngreso";
            this.fIngreso.Size = new System.Drawing.Size(200, 20);
            this.fIngreso.TabIndex = 5;
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 389);
            this.Controls.Add(this.fIngreso);
            this.Controls.Add(this.fNacimiento);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cajero);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.CURP);
            this.Controls.Add(this.nNomina);
            this.Controls.Add(this.NomCompleto);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.ClaveUsu);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEmpleado";
            this.Text = "RegistroEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ClaveUsu;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.TextBox NomCompleto;
        private System.Windows.Forms.TextBox CURP;
        private System.Windows.Forms.TextBox nNomina;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton cajero;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DateTimePicker fNacimiento;
        private System.Windows.Forms.DateTimePicker fIngreso;
    }
}