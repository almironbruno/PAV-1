namespace Trabajo_Practico.ControlesPropios
{
    partial class TextBoxCargable
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_cargable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 16);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(45, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "nombre:";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // txt_cargable
            // 
            this.txt_cargable.Location = new System.Drawing.Point(63, 13);
            this.txt_cargable.Name = "txt_cargable";
            this.txt_cargable.ReadOnly = true;
            this.txt_cargable.Size = new System.Drawing.Size(100, 20);
            this.txt_cargable.TabIndex = 1;
            // 
            // TextBoxCargable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_cargable);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "TextBoxCargable";
            this.Size = new System.Drawing.Size(182, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.TextBox txt_cargable;
    }
}
