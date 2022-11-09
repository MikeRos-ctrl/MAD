namespace Sistema.Presentacion
{
    partial class VerModCajero
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.Dgv_ModCajero = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ModCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(878, 415);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Dgv_ModCajero
            // 
            this.Dgv_ModCajero.AllowUserToAddRows = false;
            this.Dgv_ModCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ModCajero.Location = new System.Drawing.Point(12, 102);
            this.Dgv_ModCajero.Name = "Dgv_ModCajero";
            this.Dgv_ModCajero.Size = new System.Drawing.Size(945, 271);
            this.Dgv_ModCajero.TabIndex = 22;
            this.Dgv_ModCajero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ModCajero_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Modificaciones de Cajeros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VerModCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_ModCajero);
            this.Controls.Add(this.btn_cancelar);
            this.Name = "VerModCajero";
            this.Text = "VerModCajero";
            this.Load += new System.EventHandler(this.VerModCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ModCajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView Dgv_ModCajero;
        private System.Windows.Forms.Label label1;
    }
}