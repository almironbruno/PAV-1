﻿namespace Trabajo_Practico.Formularios.Reportes.VentasXCliente
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
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trabajo_Practico.Formularios.Reportes.VentasXCliente.VentasXCliente.rdlc";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // VentasXClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "VentasXClientes";
            this.Text = "VentasXClientes";
            this.Load += new System.EventHandler(this.VentasXClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}