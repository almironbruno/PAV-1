namespace Trabajo_Practico
{
    partial class DataGridViewModificada
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
            this.dgr_Principal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr_Principal
            // 
            this.dgr_Principal.AllowUserToAddRows = false;
            this.dgr_Principal.AllowUserToResizeColumns = false;
            this.dgr_Principal.AllowUserToResizeRows = false;
            this.dgr_Principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Principal.Location = new System.Drawing.Point(3, 3);
            this.dgr_Principal.Name = "dgr_Principal";
            this.dgr_Principal.ReadOnly = true;
            this.dgr_Principal.RowHeadersVisible = false;
            this.dgr_Principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_Principal.Size = new System.Drawing.Size(540, 298);
            this.dgr_Principal.TabIndex = 0;
            // 
            // DataGridViewModificada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgr_Principal);
            this.Name = "DataGridViewModificada";
            this.Size = new System.Drawing.Size(546, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_Principal;
    }
}
