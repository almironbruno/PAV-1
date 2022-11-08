namespace Trabajo_Practico.Formularios.Reportes.VentasXCondicion
{
    partial class VentasXCondicion
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
            this.comboCargable1 = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTodas = new System.Windows.Forms.Button();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantCondiciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trabajo_Practico.Formularios.Reportes.VentasXCondicion.ReportVentasXCondicion.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(78, 138);
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // comboCargable1
            // 
            this.comboCargable1.Location = new System.Drawing.Point(211, 48);
            this.comboCargable1.Name = "comboCargable1";
            this.comboCargable1.Size = new System.Drawing.Size(126, 33);
            this.comboCargable1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBuscar.Location = new System.Drawing.Point(355, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte Ventas por Condicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione una Condicion";
            // 
            // btnTodas
            // 
            this.btnTodas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTodas.Location = new System.Drawing.Point(447, 48);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(144, 33);
            this.btnTodas.TabIndex = 5;
            this.btnTodas.Text = "Todas las Condiciones";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(75, 100);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(233, 13);
            this.lblCondicion.TabIndex = 6;
            this.lblCondicion.Text = "Alcance de las ventas de todas las Condiciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // txtCantCondiciones
            // 
            this.txtCantCondiciones.Location = new System.Drawing.Point(560, 106);
            this.txtCantCondiciones.Name = "txtCantCondiciones";
            this.txtCantCondiciones.ReadOnly = true;
            this.txtCantCondiciones.Size = new System.Drawing.Size(30, 20);
            this.txtCantCondiciones.TabIndex = 8;
            // 
            // VentasXCondicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantCondiciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboCargable1);
            this.Name = "VentasXCondicion";
            this.Text = "VentasXCondicion";
            this.Load += new System.EventHandler(this.VentasXCondicion_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.comboCargable1, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnTodas, 0);
            this.Controls.SetChildIndex(this.lblCondicion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCantCondiciones, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPropios.ComboCargable comboCargable1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantCondiciones;
    }
}