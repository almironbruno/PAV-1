namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    partial class InfoNombreComercial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarca = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmbGama = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDNomCom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre Comercial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID Gama:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.Location = new System.Drawing.Point(246, 180);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 21;
            // 
            // cmbGama
            // 
            this.cmbGama.Location = new System.Drawing.Point(244, 226);
            this.cmbGama.Name = "cmbGama";
            this.cmbGama.Size = new System.Drawing.Size(121, 21);
            this.cmbGama.TabIndex = 22;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(288, 127);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(152, 20);
            this.txtNombreComercial.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Nombre Comercial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIDNomCom
            // 
            this.txtIDNomCom.Location = new System.Drawing.Point(299, 78);
            this.txtIDNomCom.Name = "txtIDNomCom";
            this.txtIDNomCom.Size = new System.Drawing.Size(47, 20);
            this.txtIDNomCom.TabIndex = 26;
            // 
            // InfoNombreComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDNomCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.cmbGama);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "InfoNombreComercial";
            this.Text = "InfoNombreComercial";
            this.Load += new System.EventHandler(this.InfoNombreComercial_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbMarca, 0);
            this.Controls.SetChildIndex(this.cmbGama, 0);
            this.Controls.SetChildIndex(this.txtNombreComercial, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtIDNomCom, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ControlesPropios.ComboCargable cmbMarca;
        private ControlesPropios.ComboCargable cmbGama;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDNomCom;
    }
}