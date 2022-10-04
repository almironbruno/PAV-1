namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    partial class InfoTelefonos
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
            this.txtNumTelCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumDocCliente = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.txtTipoDocCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumTelCliente
            // 
            this.txtNumTelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTelCliente.Location = new System.Drawing.Point(341, 90);
            this.txtNumTelCliente.Name = "txtNumTelCliente";
            this.txtNumTelCliente.Size = new System.Drawing.Size(140, 20);
            this.txtNumTelCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefono del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caracteristica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NumDocCliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Documento:";
            // 
            // txtNumDocCliente
            // 
            this.txtNumDocCliente.Location = new System.Drawing.Point(341, 198);
            this.txtNumDocCliente.Name = "txtNumDocCliente";
            this.txtNumDocCliente.Size = new System.Drawing.Size(140, 20);
            this.txtNumDocCliente.TabIndex = 5;
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(341, 144);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(140, 20);
            this.txtCaracteristica.TabIndex = 6;
            // 
            // txtTipoDocCliente
            // 
            this.txtTipoDocCliente.Location = new System.Drawing.Point(341, 247);
            this.txtTipoDocCliente.Name = "txtTipoDocCliente";
            this.txtTipoDocCliente.Size = new System.Drawing.Size(140, 20);
            this.txtTipoDocCliente.TabIndex = 7;
            // 
            // InfoTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTipoDocCliente);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.txtNumDocCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumTelCliente);
            this.Name = "InfoTelefonos";
            this.Text = "Info Telefonos";
            this.Controls.SetChildIndex(this.txtNumTelCliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNumDocCliente, 0);
            this.Controls.SetChildIndex(this.txtCaracteristica, 0);
            this.Controls.SetChildIndex(this.txtTipoDocCliente, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumTelCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumDocCliente;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.TextBox txtTipoDocCliente;
    }
}