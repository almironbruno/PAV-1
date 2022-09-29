namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    partial class ModBarrio
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
            this.txtReemplazoNombreBarrio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reemplace el nombre del Barrio:";
            // 
            // txtReemplazoNombreBarrio
            // 
            this.txtReemplazoNombreBarrio.Location = new System.Drawing.Point(419, 250);
            this.txtReemplazoNombreBarrio.Name = "txtReemplazoNombreBarrio";
            this.txtReemplazoNombreBarrio.Size = new System.Drawing.Size(198, 20);
            this.txtReemplazoNombreBarrio.TabIndex = 18;
            // 
            // ModBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 414);
            this.Controls.Add(this.txtReemplazoNombreBarrio);
            this.Controls.Add(this.label1);
            this.Name = "ModBarrio";
            this.Text = "Modificacion Barrio";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtReemplazoNombreBarrio, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReemplazoNombreBarrio;
    }
}