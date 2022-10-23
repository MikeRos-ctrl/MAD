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
            this.Dgv_inventario = new System.Windows.Forms.DataGridView();
            this.btn_recibo = new System.Windows.Forms.Button();
            this.cb_numRecibos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_inventario
            // 
            this.Dgv_inventario.AllowUserToAddRows = false;
            this.Dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_inventario.Location = new System.Drawing.Point(12, 172);
            this.Dgv_inventario.Name = "Dgv_inventario";
            this.Dgv_inventario.Size = new System.Drawing.Size(776, 208);
            this.Dgv_inventario.TabIndex = 11;
            // 
            // btn_recibo
            // 
            this.btn_recibo.Location = new System.Drawing.Point(633, 140);
            this.btn_recibo.Name = "btn_recibo";
            this.btn_recibo.Size = new System.Drawing.Size(144, 26);
            this.btn_recibo.TabIndex = 10;
            this.btn_recibo.Text = "Generar recibo";
            this.btn_recibo.UseVisualStyleBackColor = true;
            // 
            // cb_numRecibos
            // 
            this.cb_numRecibos.FormattingEnabled = true;
            this.cb_numRecibos.Location = new System.Drawing.Point(67, 99);
            this.cb_numRecibos.Name = "cb_numRecibos";
            this.cb_numRecibos.Size = new System.Drawing.Size(151, 21);
            this.cb_numRecibos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de Recibo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(356, 117);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(356, 396);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
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
            // ConsultaRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.Dgv_inventario);
            this.Controls.Add(this.btn_recibo);
            this.Controls.Add(this.cb_numRecibos);
            this.Controls.Add(this.label2);
            this.Name = "ConsultaRecibo";
            this.Text = "ConsultaRecibo";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_inventario;
        private System.Windows.Forms.Button btn_recibo;
        private System.Windows.Forms.ComboBox cb_numRecibos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label1;
    }
}