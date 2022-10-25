namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms
{
    partial class BuscarLocalidades
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
            this.txtNombreLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.HidePromptOnLeave = true;
            this.txtNombreLocalidad.Location = new System.Drawing.Point(356, 175);
            this.txtNombreLocalidad.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(173, 20);
            this.txtNombreLocalidad.TabIndex = 22;
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(212, 175);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(138, 17);
            this.lblNombreLocalidad.TabIndex = 23;
            this.lblNombreLocalidad.Text = "Nombre de localidad";
            // 
            // BuscarLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.lblNombreLocalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarLocalidades";
            this.Text = "Buscar Localidad";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.lblNombreLocalidad, 0);
            this.Controls.SetChildIndex(this.txtNombreLocalidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MaskedTextBox txtNombreLocalidad;
        protected System.Windows.Forms.Label lblNombreLocalidad;
    }
}