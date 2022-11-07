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
            this.ventasBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasxgamaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasXGamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bDreporteVenXGam = new Trabajo_Practico.BDreporteVenXGam();
            this.gamasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamasTableAdapter = new Trabajo_Practico.BDreporteVenXGamTableAdapters.gamasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasxgamaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasXGamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDreporteVenXGam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tablareporteventaporgamas";
            reportDataSource1.Value = this.gamasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trabajo_Practico.Formularios.Reportes.VentasXGama.ReportVenXGama.rdlc";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bDreporteVenXGam
            // 
            this.bDreporteVenXGam.DataSetName = "BDreporteVenXGam";
            this.bDreporteVenXGam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamasBindingSource
            // 
            this.gamasBindingSource.DataMember = "gamas";
            this.gamasBindingSource.DataSource = this.bDreporteVenXGam;
            // 
            // gamasTableAdapter
            // 
            this.gamasTableAdapter.ClearBeforeFill = true;
            // 
            // VentasXGamas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "VentasXGamas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasXGama";
            this.Load += new System.EventHandler(this.VentasXGama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasxgamaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasXGamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDreporteVenXGam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}