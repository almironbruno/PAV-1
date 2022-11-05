namespace Trabajo_Practico.Formularios.ABMC.ABMC_Autos.Forms
{
    partial class BajaAutos
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
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.ReadOnly = true;
            // 
            // txtNroMotor
            // 
            this.txtNroMotor.ReadOnly = true;
            // 
            // txtNroChasis
            // 
            this.txtNroChasis.ReadOnly = true;
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.Enabled = false;
            // 
            // txtAñoFab
            // 
            this.txtAñoFab.ReadOnly = true;
            // 
            // cmbNomComr
            // 
            this.cmbNomComr.Enabled = false;
            // 
            // txtCodSerieFab
            // 
            this.txtCodSerieFab.ReadOnly = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(263, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Baja de Vehiculos";
            // 
            // BajaAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Name = "BajaAutos";
            this.Text = "BajaAutos";
            this.Load += new System.EventHandler(this.BajaAutos_Load);
            this.Controls.SetChildIndex(this.txtPrecioAuto, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.txtCodSerieFab, 0);
            this.Controls.SetChildIndex(this.cmbNomComr, 0);
            this.Controls.SetChildIndex(this.txtAñoFab, 0);
            this.Controls.SetChildIndex(this.cmbCondicion, 0);
            this.Controls.SetChildIndex(this.txtNroChasis, 0);
            this.Controls.SetChildIndex(this.txtNroMotor, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
    }
}