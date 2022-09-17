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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.cmb_Cargable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(15, 12);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(77, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "NombreCombo";
            // 
            // cmb_Cargable
            // 
            this.cmb_Cargable.FormattingEnabled = true;
            this.cmb_Cargable.Location = new System.Drawing.Point(98, 9);
            this.cmb_Cargable.Name = "cmb_Cargable";
            this.cmb_Cargable.Size = new System.Drawing.Size(121, 21);
            this.cmb_Cargable.TabIndex = 1;
            // 
            // ComboCargable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Cargable);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "ComboCargable";
            this.Size = new System.Drawing.Size(226, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.ComboBox cmb_Cargable;
    }
}
