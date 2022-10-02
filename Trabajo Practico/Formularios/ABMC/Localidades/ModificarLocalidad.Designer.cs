namespace Trabajo_Practico.Formularios.ABMC.Localidades
{
    partial class ModificarLocalidad
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
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(347, 152);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(173, 20);
            this.txtNombreLocalidad.TabIndex = 20;
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(203, 155);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(138, 17);
            this.lblNombreLocalidad.TabIndex = 21;
            this.lblNombreLocalidad.Text = "Nombre de localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(285, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Modificar Localidad";
            // 
            // ModificarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Name = "ModificarLocalidad";
            this.Text = "ModificarLocalidad";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.lblNombreLocalidad, 0);
            this.Controls.SetChildIndex(this.txtNombreLocalidad, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        public System.Windows.Forms.Label label8;
    }
}