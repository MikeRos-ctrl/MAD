namespace Sistema.Presentacion
{
    partial class ElegirCaja
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
            this.cmb_Caja = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Rounded Mplus 1c Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elige una Caja";
            // 
            // cmb_Caja
            // 
            this.cmb_Caja.FormattingEnabled = true;
            this.cmb_Caja.Location = new System.Drawing.Point(101, 112);
            this.cmb_Caja.Name = "cmb_Caja";
            this.cmb_Caja.Size = new System.Drawing.Size(121, 21);
            this.cmb_Caja.TabIndex = 3;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(122, 171);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 23;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // ElegirCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_Caja);
            this.Controls.Add(this.label1);
            this.Name = "ElegirCaja";
            this.Text = "ElegirCaja";
            this.Load += new System.EventHandler(this.ElegirCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.ComboBox cmb_Caja;
    }
}