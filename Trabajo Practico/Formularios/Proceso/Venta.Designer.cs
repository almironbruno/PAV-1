namespace Trabajo_Practico.Formularios.Proceso
{
    partial class Venta
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
            this.lbl_venta = new System.Windows.Forms.Label();
            this.buscador1 = new Trabajo_Practico.ControlesPropios.Buscador();
            this.txt_nroFactura = new System.Windows.Forms.TextBox();
            this.lbl_nroFactura = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LimpiarCampos
            // 
            
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(327, 29);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(64, 24);
            this.lbl_venta.TabIndex = 17;
            this.lbl_venta.Text = "Venta";
            // 
            // buscador1
            // 
            this.buscador1.Location = new System.Drawing.Point(156, 111);
            this.buscador1.Name = "buscador1";
            this.buscador1.Size = new System.Drawing.Size(422, 83);
            this.buscador1.TabIndex = 18;
            // 
            // txt_nroFactura
            // 
            this.txt_nroFactura.Location = new System.Drawing.Point(156, 85);
            this.txt_nroFactura.Name = "txt_nroFactura";
            this.txt_nroFactura.ReadOnly = true;
            this.txt_nroFactura.Size = new System.Drawing.Size(100, 20);
            this.txt_nroFactura.TabIndex = 19;
            // 
            // lbl_nroFactura
            // 
            this.lbl_nroFactura.AutoSize = true;
            this.lbl_nroFactura.Location = new System.Drawing.Point(73, 88);
            this.lbl_nroFactura.Name = "lbl_nroFactura";
            this.lbl_nroFactura.Size = new System.Drawing.Size(69, 13);
            this.lbl_nroFactura.TabIndex = 20;
            this.lbl_nroFactura.Text = "Nro. Factura:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(84, 121);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(42, 13);
            this.lbl_cliente.TabIndex = 21;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(156, 155);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 22;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(86, 158);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_nroFactura);
            this.Controls.Add(this.txt_nroFactura);
            this.Controls.Add(this.buscador1);
            this.Controls.Add(this.lbl_venta);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.lbl_venta, 0);
            this.Controls.SetChildIndex(this.buscador1, 0);
            this.Controls.SetChildIndex(this.txt_nroFactura, 0);
            this.Controls.SetChildIndex(this.lbl_nroFactura, 0);
            this.Controls.SetChildIndex(this.lbl_cliente, 0);
            this.Controls.SetChildIndex(this.txt_fecha, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_venta;
        private ControlesPropios.Buscador buscador1;
        private System.Windows.Forms.TextBox txt_nroFactura;
        private System.Windows.Forms.Label lbl_nroFactura;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_fecha;
    }
}