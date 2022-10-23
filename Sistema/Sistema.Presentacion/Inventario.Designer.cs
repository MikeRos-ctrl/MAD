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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Existencia = new System.Windows.Forms.TextBox();
            this.cb_pAgotados = new System.Windows.Forms.ComboBox();
            this.cb_merma = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_inventario = new System.Windows.Forms.DataGridView();
            this.cb_Departamento = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_recibo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_inventario)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencia minima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Productos agotados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Con Merma";
            // 
            // Existencia
            // 
            this.Existencia.Location = new System.Drawing.Point(33, 136);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(71, 20);
            this.Existencia.TabIndex = 4;
            // 
            // cb_pAgotados
            // 
            this.cb_pAgotados.FormattingEnabled = true;
            this.cb_pAgotados.Location = new System.Drawing.Point(266, 90);
            this.cb_pAgotados.Name = "cb_pAgotados";
            this.cb_pAgotados.Size = new System.Drawing.Size(58, 21);
            this.cb_pAgotados.TabIndex = 5;
            // 
            // cb_merma
            // 
            this.cb_merma.FormattingEnabled = true;
            this.cb_merma.Location = new System.Drawing.Point(266, 135);
            this.cb_merma.Name = "cb_merma";
            this.cb_merma.Size = new System.Drawing.Size(58, 21);
            this.cb_merma.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(444, 110);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Dgv_inventario
            // 
            this.Dgv_inventario.AllowUserToAddRows = false;
            this.Dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_inventario.Location = new System.Drawing.Point(12, 183);
            this.Dgv_inventario.Name = "Dgv_inventario";
            this.Dgv_inventario.Size = new System.Drawing.Size(776, 208);
            this.Dgv_inventario.TabIndex = 7;
            // 
            // cb_Departamento
            // 
            this.cb_Departamento.FormattingEnabled = true;
            this.cb_Departamento.Location = new System.Drawing.Point(33, 90);
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
            // btn_recibo
            // 
            this.btn_recibo.Location = new System.Drawing.Point(633, 151);
            this.btn_recibo.Name = "btn_recibo";
            this.btn_recibo.Size = new System.Drawing.Size(144, 26);
            this.btn_recibo.TabIndex = 6;
            this.btn_recibo.Text = "Generar recibo";
            this.btn_recibo.UseVisualStyleBackColor = true;
            this.btn_recibo.Click += new System.EventHandler(this.btn_recibo_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_inventario);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_recibo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_merma);
            this.Controls.Add(this.cb_Departamento);
            this.Controls.Add(this.cb_pAgotados);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Existencia;
        private System.Windows.Forms.ComboBox cb_pAgotados;
        private System.Windows.Forms.ComboBox cb_merma;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_inventario;
        private System.Windows.Forms.ComboBox cb_Departamento;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_recibo;
    }
}