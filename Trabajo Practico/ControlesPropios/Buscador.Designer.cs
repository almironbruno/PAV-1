namespace Trabajo_Practico.ControlesPropios
{
    partial class Buscador
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
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cmb_buscar = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_deshacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(0, 0);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(151, 21);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // cmb_buscar
            // 
            this.cmb_buscar.FormattingEnabled = true;
            this.cmb_buscar.Location = new System.Drawing.Point(0, 0);
            this.cmb_buscar.Name = "cmb_buscar";
            this.cmb_buscar.Size = new System.Drawing.Size(151, 21);
            this.cmb_buscar.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(157, 0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.Location = new System.Drawing.Point(238, 0);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(75, 23);
            this.btn_deshacer.TabIndex = 3;
            this.btn_deshacer.Text = "Deshacer";
            this.btn_deshacer.UseVisualStyleBackColor = true;
            this.btn_deshacer.Click += new System.EventHandler(this.btn_deshacer_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_deshacer);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.cmb_buscar);
            this.Name = "Buscador";
            this.Size = new System.Drawing.Size(429, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscar;
        public System.Windows.Forms.ComboBox cmb_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_deshacer;
    }
}
