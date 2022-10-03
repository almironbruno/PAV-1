namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    partial class AltaTelefono
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
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCargableCaracteristica = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmbCargableNumDoc = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmbCargableTipoDoc = new Trabajo_Practico.ControlesPropios.ComboCargable();
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
            this.label1.Location = new System.Drawing.Point(144, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero de Telefono:";
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(292, 85);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(146, 20);
            this.txtNumTelefono.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Numero de Caracteristica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo Doc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Numero de Documento:";
            // 
            // cmbCargableCaracteristica
            // 
            this.cmbCargableCaracteristica.Location = new System.Drawing.Point(292, 128);
            this.cmbCargableCaracteristica.Name = "cmbCargableCaracteristica";
            this.cmbCargableCaracteristica.Size = new System.Drawing.Size(128, 28);
            this.cmbCargableCaracteristica.TabIndex = 26;
            // 
            // cmbCargableNumDoc
            // 
            this.cmbCargableNumDoc.Location = new System.Drawing.Point(292, 215);
            this.cmbCargableNumDoc.Name = "cmbCargableNumDoc";
            this.cmbCargableNumDoc.Size = new System.Drawing.Size(128, 28);
            this.cmbCargableNumDoc.TabIndex = 27;
            // 
            // cmbCargableTipoDoc
            // 
            this.cmbCargableTipoDoc.Location = new System.Drawing.Point(292, 168);
            this.cmbCargableTipoDoc.Name = "cmbCargableTipoDoc";
            this.cmbCargableTipoDoc.Size = new System.Drawing.Size(128, 28);
            this.cmbCargableTipoDoc.TabIndex = 28;
            // 
            // AltaTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCargableTipoDoc);
            this.Controls.Add(this.cmbCargableNumDoc);
            this.Controls.Add(this.cmbCargableCaracteristica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumTelefono);
            this.Controls.Add(this.label1);
            this.Name = "AltaTelefono";
            this.Text = "Alta Telefono";
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNumTelefono, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbCargableCaracteristica, 0);
            this.Controls.SetChildIndex(this.cmbCargableNumDoc, 0);
            this.Controls.SetChildIndex(this.cmbCargableTipoDoc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ControlesPropios.ComboCargable cmbCargableCaracteristica;
        private ControlesPropios.ComboCargable cmbCargableNumDoc;
        private ControlesPropios.ComboCargable cmbCargableTipoDoc;
    }
}