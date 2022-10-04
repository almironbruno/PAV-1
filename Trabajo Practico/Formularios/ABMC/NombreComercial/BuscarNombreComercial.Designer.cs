namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    partial class BuscarNombreComercial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomComBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarcaBuscar = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmbGamaBuscar = new Trabajo_Practico.ControlesPropios.ComboCargable();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre Comercial:";
            // 
            // txtNomComBuscar
            // 
            this.txtNomComBuscar.Location = new System.Drawing.Point(310, 129);
            this.txtNomComBuscar.Name = "txtNomComBuscar";
            this.txtNomComBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtNomComBuscar.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Gama:";
            // 
            // cmbMarcaBuscar
            // 
            this.cmbMarcaBuscar.Location = new System.Drawing.Point(263, 183);
            this.cmbMarcaBuscar.Name = "cmbMarcaBuscar";
            this.cmbMarcaBuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbMarcaBuscar.TabIndex = 21;
            // 
            // cmbGamaBuscar
            // 
            this.cmbGamaBuscar.Location = new System.Drawing.Point(263, 232);
            this.cmbGamaBuscar.Name = "cmbGamaBuscar";
            this.cmbGamaBuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbGamaBuscar.TabIndex = 22;
            // 
            // BuscarNombreComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGamaBuscar);
            this.Controls.Add(this.cmbMarcaBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomComBuscar);
            this.Controls.Add(this.label1);
            this.Name = "BuscarNombreComercial";
            this.Text = "BuscarNombreComercial";
            this.Load += new System.EventHandler(this.BuscarNombreComercial_Load);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNomComBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbMarcaBuscar, 0);
            this.Controls.SetChildIndex(this.cmbGamaBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomComBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ControlesPropios.ComboCargable cmbMarcaBuscar;
        private ControlesPropios.ComboCargable cmbGamaBuscar;
    }
}