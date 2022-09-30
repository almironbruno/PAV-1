namespace Trabajo_Practico.Formularios.ABMC.Marcas
{
    partial class BuscarMarca
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
            this.txtMarcBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // txtMarcBuscar
            // 
            this.txtMarcBuscar.Location = new System.Drawing.Point(484, 205);
            this.txtMarcBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcBuscar.Name = "txtMarcBuscar";
            this.txtMarcBuscar.Size = new System.Drawing.Size(221, 22);
            this.txtMarcBuscar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de Marca automotriz: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id de la Marca a Buscar: ";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(484, 251);
            this.txtIdMarca.Mask = "99";
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(22, 22);
            this.txtIdMarca.TabIndex = 22;
            // 
            // BuscarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 543);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarcBuscar);
            this.Controls.Add(this.label1);
            this.Name = "BuscarMarca";
            this.Text = "BuscarMarca";
            this.Load += new System.EventHandler(this.BuscarMarca_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMarcBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtIdMarca, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarcBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtIdMarca;
    }
}