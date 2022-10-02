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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCargable_Region = new Trabajo_Practico.ControlesPropios.ComboCargable();
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
            this.label1.Location = new System.Drawing.Point(341, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero:";
            // 
            // txtNumModificado
            // 
            this.txtNumModificado.Location = new System.Drawing.Point(409, 195);
            this.txtNumModificado.Name = "txtNumModificado";
            this.txtNumModificado.Size = new System.Drawing.Size(130, 20);
            this.txtNumModificado.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tipo Doc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numero de Doc:";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(159, 143);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.ReadOnly = true;
            this.txtTipoDoc.Size = new System.Drawing.Size(130, 20);
            this.txtTipoDoc.TabIndex = 23;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(159, 98);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.ReadOnly = true;
            this.txtNumeroDoc.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroDoc.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(39, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "DATOS DEL CLIENTE";
            // 
            // cmbCargable_Region
            // 
            this.cmbCargable_Region.Location = new System.Drawing.Point(409, 238);
            this.cmbCargable_Region.Name = "cmbCargable_Region";
            this.cmbCargable_Region.Size = new System.Drawing.Size(130, 28);
            this.cmbCargable_Region.TabIndex = 26;
            // 
            // ModificacionTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCargable_Region);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumModificado);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionTelefono";
            this.Text = "Modificacion Telefono";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNumModificado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTipoDoc, 0);
            this.Controls.SetChildIndex(this.txtNumeroDoc, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbCargable_Region, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumModificado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label label5;
        private ControlesPropios.ComboCargable cmbCargable_Region;
    }
}