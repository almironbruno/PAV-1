namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    partial class BuscarAuto
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
            this.txtCodBuscar = new System.Windows.Forms.TextBox();
            this.txtPatenteBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo de Serie de Fabrica del Vehiculo: ";
            // 
            // txtCodBuscar
            // 
            this.txtCodBuscar.Location = new System.Drawing.Point(541, 191);
            this.txtCodBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodBuscar.Name = "txtCodBuscar";
            this.txtCodBuscar.Size = new System.Drawing.Size(221, 22);
            this.txtCodBuscar.TabIndex = 18;
            // 
            // txtPatenteBuscar
            // 
            this.txtPatenteBuscar.Location = new System.Drawing.Point(541, 237);
            this.txtPatenteBuscar.Name = "txtPatenteBuscar";
            this.txtPatenteBuscar.Size = new System.Drawing.Size(221, 22);
            this.txtPatenteBuscar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Patente del Vehiculo: ";
            // 
            // BuscarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatenteBuscar);
            this.Controls.Add(this.txtCodBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "BuscarAuto";
            this.Text = "BuscarAuto";
            this.Load += new System.EventHandler(this.BuscarAuto_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodBuscar, 0);
            this.Controls.SetChildIndex(this.txtPatenteBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBuscar;
        private System.Windows.Forms.TextBox txtPatenteBuscar;
        private System.Windows.Forms.Label label2;
    }
}