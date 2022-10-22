namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    partial class ConsultaTelefono
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCargableTipoDoc = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.txtNumDocCliente = new System.Windows.Forms.TextBox();
            this.txtNumTelCliente = new System.Windows.Forms.TextBox();
            this.cmbCargableCarac = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Doc Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Doc Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Caracteristica:";
            // 
            // cmbCargableTipoDoc
            // 
            this.cmbCargableTipoDoc.Location = new System.Drawing.Point(293, 206);
            this.cmbCargableTipoDoc.Name = "cmbCargableTipoDoc";
            this.cmbCargableTipoDoc.Size = new System.Drawing.Size(151, 28);
            this.cmbCargableTipoDoc.TabIndex = 4;
            // 
            // txtNumDocCliente
            // 
            this.txtNumDocCliente.Location = new System.Drawing.Point(293, 173);
            this.txtNumDocCliente.Name = "txtNumDocCliente";
            this.txtNumDocCliente.Size = new System.Drawing.Size(151, 20);
            this.txtNumDocCliente.TabIndex = 5;
            // 
            // txtNumTelCliente
            // 
            this.txtNumTelCliente.Location = new System.Drawing.Point(293, 100);
            this.txtNumTelCliente.Name = "txtNumTelCliente";
            this.txtNumTelCliente.Size = new System.Drawing.Size(151, 20);
            this.txtNumTelCliente.TabIndex = 7;
            // 
            // cmbCargableCarac
            // 
            this.cmbCargableCarac.Location = new System.Drawing.Point(294, 136);
            this.cmbCargableCarac.Name = "cmbCargableCarac";
            this.cmbCargableCarac.Size = new System.Drawing.Size(150, 28);
            this.cmbCargableCarac.TabIndex = 17;
            // 
            // ConsultaTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCargableCarac);
            this.Controls.Add(this.txtNumTelCliente);
            this.Controls.Add(this.txtNumDocCliente);
            this.Controls.Add(this.cmbCargableTipoDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaTelefono";
            this.Text = "ConsultaTelefono";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbCargableTipoDoc, 0);
            this.Controls.SetChildIndex(this.txtNumDocCliente, 0);
            this.Controls.SetChildIndex(this.txtNumTelCliente, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.cmbCargableCarac, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ControlesPropios.ComboCargable cmbCargableTipoDoc;
        private System.Windows.Forms.TextBox txtNumDocCliente;
        private System.Windows.Forms.TextBox txtNumTelCliente;
        private ControlesPropios.ComboCargable cmbCargableCarac;
    }
}