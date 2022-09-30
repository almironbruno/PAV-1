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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgr_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_Principal.Location = new System.Drawing.Point(0, 0);
            this.dgr_Principal.MultiSelect = false;
            this.dgr_Principal.Name = "dgr_Principal";
            this.dgr_Principal.ReadOnly = true;
            this.dgr_Principal.RowHeadersVisible = false;
            this.dgr_Principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_Principal.Size = new System.Drawing.Size(540, 306);
            this.dgr_Principal.TabIndex = 0;
            this.dgr_Principal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_Principal_CellDoubleClick);
            // 
            // DataGridViewModificada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgr_Principal);
            this.Name = "DataGridViewModificada";
            this.Size = new System.Drawing.Size(549, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgr_Principal;
    }
}
