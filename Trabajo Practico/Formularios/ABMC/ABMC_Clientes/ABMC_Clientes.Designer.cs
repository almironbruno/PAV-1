namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    partial class ABMC_Clientes
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click_1);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click_1);
            // 
            // ABMC_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMC_Clientes";
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.ABMC_Clientes_Activated);
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}