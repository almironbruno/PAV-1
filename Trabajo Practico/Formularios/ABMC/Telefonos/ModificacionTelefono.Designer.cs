namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    partial class ModificacionTelefono
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
            this.txtNumModificado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegionModificada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero:";
            // 
            // txtNumModificado
            // 
            this.txtNumModificado.Location = new System.Drawing.Point(299, 123);
            this.txtNumModificado.Name = "txtNumModificado";
            this.txtNumModificado.Size = new System.Drawing.Size(130, 20);
            this.txtNumModificado.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Region";
            // 
            // txtRegionModificada
            // 
            this.txtRegionModificada.Location = new System.Drawing.Point(299, 165);
            this.txtRegionModificada.Name = "txtRegionModificada";
            this.txtRegionModificada.Size = new System.Drawing.Size(130, 20);
            this.txtRegionModificada.TabIndex = 20;
            // 
            // ModificacionTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegionModificada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumModificado);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionTelefono";
            this.Text = "Modificacion Telefono";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNumModificado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtRegionModificada, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumModificado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegionModificada;
    }
}