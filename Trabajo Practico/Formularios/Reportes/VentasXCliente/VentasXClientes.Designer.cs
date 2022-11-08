namespace Trabajo_Practico.Formularios.Reportes.VentasXCliente
{
    partial class VentasXClientes
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
            this.txtCantAutos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.comboCargable1 = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_autos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trabajo_Practico.Formularios.Reportes.VentasXCliente.VentasXCliente.rdlc";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txtCantAutos
            // 
            this.txtCantAutos.Location = new System.Drawing.Point(758, 87);
            this.txtCantAutos.Name = "txtCantAutos";
            this.txtCantAutos.ReadOnly = true;
            this.txtCantAutos.Size = new System.Drawing.Size(27, 20);
            this.txtCantAutos.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad:";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(81, 87);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(106, 13);
            this.lblAlcance.TabIndex = 16;
            this.lblAlcance.Text = "Alcance de los autos";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(337, 54);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 15;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // comboCargable1
            // 
            this.comboCargable1.Location = new System.Drawing.Point(200, 54);
            this.comboCargable1.Name = "comboCargable1";
            this.comboCargable1.Size = new System.Drawing.Size(121, 21);
            this.comboCargable1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione un cliente:";
            // 
            // lbl_autos
            // 
            this.lbl_autos.AutoSize = true;
            this.lbl_autos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_autos.Location = new System.Drawing.Point(293, 9);
            this.lbl_autos.Name = "lbl_autos";
            this.lbl_autos.Size = new System.Drawing.Size(284, 24);
            this.lbl_autos.TabIndex = 19;
            this.lbl_autos.Text = "Reporte de Ventas de un Cliente";
            // 
            // VentasXClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.lbl_autos);
            this.Controls.Add(this.txtCantAutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.comboCargable1);
            this.Controls.Add(this.label1);
            this.Name = "VentasXClientes";
            this.Text = "Ventas por Clientes";
            this.Load += new System.EventHandler(this.VentasXClientes_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboCargable1, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.lblAlcance, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCantAutos, 0);
            this.Controls.SetChildIndex(this.lbl_autos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantAutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Button btn_Buscar;
        private ControlesPropios.ComboCargable comboCargable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_autos;
    }
}