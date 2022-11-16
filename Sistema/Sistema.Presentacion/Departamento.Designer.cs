namespace Sistema.Presentacion
{
    partial class Departamento
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
            this.Dgv_rDepartamento = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Depa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.idDepa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Registeredby = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_bajalogica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_rDepartamento
            // 
            this.Dgv_rDepartamento.AllowUserToAddRows = false;
            this.Dgv_rDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_rDepartamento.Location = new System.Drawing.Point(8, 169);
            this.Dgv_rDepartamento.Name = "Dgv_rDepartamento";
            this.Dgv_rDepartamento.Size = new System.Drawing.Size(794, 217);
            this.Dgv_rDepartamento.TabIndex = 24;
            this.Dgv_rDepartamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rDepartamento_CellClick);
            this.Dgv_rDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rDepartamento_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Departamento:";
            // 
            // Depa
            // 
            this.Depa.Location = new System.Drawing.Point(97, 79);
            this.Depa.Name = "Depa";
            this.Depa.Size = new System.Drawing.Size(167, 20);
            this.Depa.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Gestión de Departamentos";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(283, 77);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 28;
            this.btn_aceptar.Text = "Crear";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(298, 403);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 30;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // idDepa
            // 
            this.idDepa.Location = new System.Drawing.Point(97, 116);
            this.idDepa.Name = "idDepa";
            this.idDepa.ReadOnly = true;
            this.idDepa.Size = new System.Drawing.Size(60, 20);
            this.idDepa.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Id:";
            // 
            // Registeredby
            // 
            this.Registeredby.Location = new System.Drawing.Point(678, 143);
            this.Registeredby.Name = "Registeredby";
            this.Registeredby.ReadOnly = true;
            this.Registeredby.Size = new System.Drawing.Size(124, 20);
            this.Registeredby.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quien lo registra:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(724, 403);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Favor de limpiar la información antes de crear uno nuevo";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(189, 116);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 28;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_bajalogica
            // 
            this.btn_bajalogica.Location = new System.Drawing.Point(400, 403);
            this.btn_bajalogica.Name = "btn_bajalogica";
            this.btn_bajalogica.Size = new System.Drawing.Size(73, 23);
            this.btn_bajalogica.TabIndex = 33;
            this.btn_bajalogica.Text = "Eliminar";
            this.btn_bajalogica.UseVisualStyleBackColor = true;
            this.btn_bajalogica.Click += new System.EventHandler(this.btn_bajalogica_Click);
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 444);
            this.Controls.Add(this.btn_bajalogica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Registeredby);
            this.Controls.Add(this.idDepa);
            this.Controls.Add(this.Depa);
            this.Controls.Add(this.Dgv_rDepartamento);
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Depa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox idDepa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Registeredby;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.DataGridView Dgv_rDepartamento;
        private System.Windows.Forms.Button btn_bajalogica;
    }
}