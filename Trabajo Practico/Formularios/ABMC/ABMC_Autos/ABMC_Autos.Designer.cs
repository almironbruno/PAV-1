namespace Trabajo_Practico.Formularios
{
    partial class ABMC_Autos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1.SuspendLayout();
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
            // dataGridViewModificada1
            // 
            this.dataGridViewModificada1.Load += new System.EventHandler(this.dataGridViewModificada1_Load);
            // 
            // ABMC_Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1090, 554);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ABMC_Autos";
            this.Text = "Autos";
            this.Activated += new System.EventHandler(this.ABMC_Autos_Activated);
            this.Load += new System.EventHandler(this.Autos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
