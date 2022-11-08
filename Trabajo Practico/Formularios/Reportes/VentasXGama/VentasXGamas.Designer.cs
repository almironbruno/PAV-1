namespace Trabajo_Practico.Formularios.Reportes.VentasXGama
{
    partial class VentasXGamas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gamasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDreporteVenXGam = new Trabajo_Practico.BDreporteVenXGam();
            this.ventasBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasxgamaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasXGamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gamasTableAdapter = new Trabajo_Practico.BDreporteVenXGamTableAdapters.gamasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCargable1 = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.btnTodas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantGamas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDreporteVenXGam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasxgamaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasXGamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tablareporteventaporgamas";
            reportDataSource1.Value = this.gamasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trabajo_Practico.Formularios.Reportes.VentasXGama.ReportVenXGama.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(80, 138);
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // gamasBindingSource
            // 
            this.gamasBindingSource.DataMember = "gamas";
            this.gamasBindingSource.DataSource = this.bDreporteVenXGam;
            // 
            // bDreporteVenXGam
            // 
            this.bDreporteVenXGam.DataSetName = "BDreporteVenXGam";
            this.bDreporteVenXGam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamasTableAdapter
            // 
            this.gamasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte Ventas por Gamas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione una Gama";
            // 
            // comboCargable1
            // 
            this.comboCargable1.Location = new System.Drawing.Point(195, 60);
            this.comboCargable1.Name = "comboCargable1";
            this.comboCargable1.Size = new System.Drawing.Size(137, 26);
            this.comboCargable1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(338, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 26);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(77, 106);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(208, 13);
            this.lblAlcance.TabIndex = 6;
            this.lblAlcance.Text = "Alcance de las ventas de todas las Gamas";
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(435, 60);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(134, 26);
            this.btnTodas.TabIndex = 7;
            this.btnTodas.Text = "Todas las Gamas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad:";
            // 
            // txtCantGamas
            // 
            this.txtCantGamas.Location = new System.Drawing.Point(544, 103);
            this.txtCantGamas.Name = "txtCantGamas";
            this.txtCantGamas.ReadOnly = true;
            this.txtCantGamas.Size = new System.Drawing.Size(27, 20);
            this.txtCantGamas.TabIndex = 9;
            // 
            // VentasXGamas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 523);
            this.Controls.Add(this.txtCantGamas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboCargable1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentasXGamas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasXGama";
            this.Load += new System.EventHandler(this.VentasXGama_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboCargable1, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblAlcance, 0);
            this.Controls.SetChildIndex(this.btnTodas, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCantGamas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDreporteVenXGam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasxgamaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasXGamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ventasXGamaBindingSource;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.BindingSource ventasBindingSource1;
        private System.Windows.Forms.BindingSource ventasBindingSource2;
        private System.Windows.Forms.BindingSource ventasxgamaBindingSource1;
        private System.Windows.Forms.BindingSource ventasBindingSource3;
        private System.Windows.Forms.BindingSource ventasBindingSource4;
        private System.Windows.Forms.BindingSource ventasBindingSource5;
        private System.Windows.Forms.BindingSource ventasBindingSource6;
        private BDreporteVenXGam bDreporteVenXGam;
        private System.Windows.Forms.BindingSource gamasBindingSource;
        private BDreporteVenXGamTableAdapters.gamasTableAdapter gamasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ControlesPropios.ComboCargable comboCargable1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantGamas;
    }
}