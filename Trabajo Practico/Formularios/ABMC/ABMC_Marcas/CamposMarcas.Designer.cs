namespace Trabajo_Practico.Formularios.ABMC.ABMC_Marcas
{
    partial class CamposMarcas
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
            this.txtMarcaRegs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarcaRegs
            // 
            this.txtMarcaRegs.Location = new System.Drawing.Point(341, 182);
            this.txtMarcaRegs.Name = "txtMarcaRegs";
            this.txtMarcaRegs.Size = new System.Drawing.Size(178, 20);
            this.txtMarcaRegs.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Marca de Vehiculos: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CamposMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMarcaRegs);
            this.Controls.Add(this.label1);
            this.Name = "CamposMarcas";
            this.Text = "CamposMarcas";
            this.Load += new System.EventHandler(this.CamposMarcas_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMarcaRegs, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMarcaRegs;
        public System.Windows.Forms.Label label1;
    }
}