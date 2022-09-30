namespace Trabajo_Practico.Formularios.ABMC.ABMC_Empleados
{
    partial class BajaEmpleado
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
            this.lbl_Pregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Pregunta
            // 
            this.lbl_Pregunta.AutoSize = true;
            this.lbl_Pregunta.Location = new System.Drawing.Point(250, 58);
            this.lbl_Pregunta.Name = "lbl_Pregunta";
            this.lbl_Pregunta.Size = new System.Drawing.Size(167, 13);
            this.lbl_Pregunta.TabIndex = 26;
            this.lbl_Pregunta.Text = "Desea borrar el siguiente registro?";
            // 
            // BajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Pregunta);
            this.Name = "BajaEmpleado";
            this.Text = "BajaEmpleado";
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.mTxt_Nombre, 0);
            this.Controls.SetChildIndex(this.mTxt_Apellido, 0);
            this.Controls.SetChildIndex(this.cmbCargable_Cargos, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.mtxt_Legajo, 0);
            this.Controls.SetChildIndex(this.lbl_Pregunta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Pregunta;
    }
}