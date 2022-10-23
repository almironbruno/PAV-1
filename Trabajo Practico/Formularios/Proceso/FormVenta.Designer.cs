namespace Trabajo_Practico.Formularios.Proceso
{
    partial class FormVenta
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
            this.drg_autos = new System.Windows.Forms.DataGridView();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drg_autos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(167, 427);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(331, 427);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(482, 427);
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
            this.buscador1.Size = new System.Drawing.Size(248, 38);
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
            // drg_autos
            // 
            this.drg_autos.AllowUserToAddRows = false;
            this.drg_autos.AllowUserToDeleteRows = false;
            this.drg_autos.AllowUserToResizeColumns = false;
            this.drg_autos.AllowUserToResizeRows = false;
            this.drg_autos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drg_autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drg_autos.Location = new System.Drawing.Point(156, 228);
            this.drg_autos.Name = "drg_autos";
            this.drg_autos.ReadOnly = true;
            this.drg_autos.RowHeadersVisible = false;
            this.drg_autos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drg_autos.Size = new System.Drawing.Size(474, 177);
            this.drg_autos.TabIndex = 24;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Location = new System.Drawing.Point(87, 193);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(54, 13);
            this.lbl_empleado.TabIndex = 25;
            this.lbl_empleado.Text = "Empleado";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(568, 151);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(82, 34);
            this.btn_Agregar.TabIndex = 26;
            this.btn_Agregar.Text = "Agregar Auto";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 490);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.drg_autos);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_nroFactura);
            this.Controls.Add(this.txt_nroFactura);
            this.Controls.Add(this.buscador1);
            this.Controls.Add(this.lbl_venta);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.lbl_venta, 0);
            this.Controls.SetChildIndex(this.buscador1, 0);
            this.Controls.SetChildIndex(this.txt_nroFactura, 0);
            this.Controls.SetChildIndex(this.lbl_nroFactura, 0);
            this.Controls.SetChildIndex(this.lbl_cliente, 0);
            this.Controls.SetChildIndex(this.txt_fecha, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.drg_autos, 0);
            this.Controls.SetChildIndex(this.lbl_empleado, 0);
            this.Controls.SetChildIndex(this.btn_Agregar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drg_autos)).EndInit();
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
        private System.Windows.Forms.DataGridView drg_autos;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Button btn_Agregar;
    }
}