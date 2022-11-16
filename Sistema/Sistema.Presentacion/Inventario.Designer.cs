namespace Sistema.Presentacion
{
    partial class Inventario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_inventario = new System.Windows.Forms.DataGridView();
            this.cb_Departamento = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.Agotados = new System.Windows.Forms.CheckBox();
            this.merma = new System.Windows.Forms.CheckBox();
            this.btn_buscartodas = new System.Windows.Forms.Button();
            this.Existencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencia minima";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(354, 72);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 28);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Dgv_inventario
            // 
            this.Dgv_inventario.AllowUserToAddRows = false;
            this.Dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_inventario.Location = new System.Drawing.Point(12, 132);
            this.Dgv_inventario.Name = "Dgv_inventario";
            this.Dgv_inventario.Size = new System.Drawing.Size(776, 259);
            this.Dgv_inventario.TabIndex = 7;
            // 
            // cb_Departamento
            // 
            this.cb_Departamento.FormattingEnabled = true;
            this.cb_Departamento.Location = new System.Drawing.Point(109, 62);
            this.cb_Departamento.Name = "cb_Departamento";
            this.cb_Departamento.Size = new System.Drawing.Size(151, 21);
            this.cb_Departamento.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(354, 409);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Agotados
            // 
            this.Agotados.AutoSize = true;
            this.Agotados.Location = new System.Drawing.Point(644, 102);
            this.Agotados.Name = "Agotados";
            this.Agotados.Size = new System.Drawing.Size(144, 17);
            this.Agotados.TabIndex = 8;
            this.Agotados.Text = "Solo productos agotados";
            this.Agotados.UseVisualStyleBackColor = true;
            // 
            // merma
            // 
            this.merma.AutoSize = true;
            this.merma.Location = new System.Drawing.Point(644, 79);
            this.merma.Name = "merma";
            this.merma.Size = new System.Drawing.Size(79, 17);
            this.merma.TabIndex = 9;
            this.merma.Text = "Con merma";
            this.merma.UseVisualStyleBackColor = true;
            // 
            // btn_buscartodas
            // 
            this.btn_buscartodas.Location = new System.Drawing.Point(344, 103);
            this.btn_buscartodas.Name = "btn_buscartodas";
            this.btn_buscartodas.Size = new System.Drawing.Size(93, 23);
            this.btn_buscartodas.TabIndex = 19;
            this.btn_buscartodas.Text = "Buscar Todas";
            this.btn_buscartodas.UseVisualStyleBackColor = true;
            this.btn_buscartodas.Click += new System.EventHandler(this.btn_buscartodas_Click);
            // 
            // Existencia
            // 
            this.Existencia.Location = new System.Drawing.Point(108, 93);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(58, 20);
            this.Existencia.TabIndex = 20;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.btn_buscartodas);
            this.Controls.Add(this.merma);
            this.Controls.Add(this.Agotados);
            this.Controls.Add(this.Dgv_inventario);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_Departamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_inventario;
        private System.Windows.Forms.ComboBox cb_Departamento;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.CheckBox Agotados;
        private System.Windows.Forms.CheckBox merma;
        private System.Windows.Forms.Button btn_buscartodas;
        private System.Windows.Forms.NumericUpDown Existencia;
    }
}