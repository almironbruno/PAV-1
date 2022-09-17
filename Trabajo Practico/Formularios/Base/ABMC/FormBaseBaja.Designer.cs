namespace Trabajo_Practico.Formularios.Base
{
    partial class FormBaseBaja
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
            this.lbl_EstaSeguro = new System.Windows.Forms.Label();
            this.txt_Ejemplo = new Trabajo_Practico.ControlesPropios.TextBoxCargable();
            this.SuspendLayout();
            // 
            // lbl_EstaSeguro
            // 
            this.lbl_EstaSeguro.AutoSize = true;
            this.lbl_EstaSeguro.Location = new System.Drawing.Point(97, 87);
            this.lbl_EstaSeguro.Name = "lbl_EstaSeguro";
            this.lbl_EstaSeguro.Size = new System.Drawing.Size(91, 13);
            this.lbl_EstaSeguro.TabIndex = 2;
            this.lbl_EstaSeguro.Text = "Esta seguro de eli";
            // 
            // txt_Ejemplo
            // 
            this.txt_Ejemplo.Location = new System.Drawing.Point(223, 149);
            this.txt_Ejemplo.Name = "txt_Ejemplo";
            this.txt_Ejemplo.Size = new System.Drawing.Size(182, 44);
            this.txt_Ejemplo.TabIndex = 3;
            // 
            // FormBaseBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.txt_Ejemplo);
            this.Controls.Add(this.lbl_EstaSeguro);
            this.Name = "FormBaseBaja";
            this.Text = "FormBaseBaja";
            this.Load += new System.EventHandler(this.FormBaseBaja_Load);
            this.Controls.SetChildIndex(this.lbl_EstaSeguro, 0);
            this.Controls.SetChildIndex(this.txt_Ejemplo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EstaSeguro;
        private ControlesPropios.TextBoxCargable txt_Ejemplo;
    }
}