namespace Trabajo_Practico.ControlesPropios
{
    partial class ComboCargable
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Cargable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_Cargable
            // 
            this.cmb_Cargable.FormattingEnabled = true;
            this.cmb_Cargable.Location = new System.Drawing.Point(3, 3);
            this.cmb_Cargable.Name = "cmb_Cargable";
            this.cmb_Cargable.Size = new System.Drawing.Size(121, 21);
            this.cmb_Cargable.TabIndex = 1;
            // 
            // ComboCargable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Cargable);
            this.Name = "ComboCargable";
            this.Size = new System.Drawing.Size(226, 36);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_Cargable;
    }
}
