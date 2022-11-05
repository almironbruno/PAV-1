using System;

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
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cmbModelo = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmbMarca = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCondicion = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmbGama = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbAño = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.dgr_autos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgr_factura = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_autos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(157, 661);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(320, 661);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(472, 661);
            this.btn_LimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(372, 18);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(64, 24);
            this.lbl_venta.TabIndex = 17;
            this.lbl_venta.Text = "Venta";
            // 
            // buscador1
            // 
            this.buscador1.Location = new System.Drawing.Point(350, 28);
            this.buscador1.Margin = new System.Windows.Forms.Padding(4);
            this.buscador1.Name = "buscador1";
            this.buscador1.Size = new System.Drawing.Size(403, 30);
            this.buscador1.TabIndex = 18;
            this.buscador1.Load += new System.EventHandler(this.buscador1_Load);
            // 
            // txt_nroFactura
            // 
            this.txt_nroFactura.Location = new System.Drawing.Point(171, 28);
            this.txt_nroFactura.Name = "txt_nroFactura";
            this.txt_nroFactura.ReadOnly = true;
            this.txt_nroFactura.Size = new System.Drawing.Size(100, 20);
            this.txt_nroFactura.TabIndex = 19;
            // 
            // lbl_nroFactura
            // 
            this.lbl_nroFactura.AutoSize = true;
            this.lbl_nroFactura.Location = new System.Drawing.Point(87, 30);
            this.lbl_nroFactura.Name = "lbl_nroFactura";
            this.lbl_nroFactura.Size = new System.Drawing.Size(69, 13);
            this.lbl_nroFactura.TabIndex = 20;
            this.lbl_nroFactura.Text = "Nro. Factura:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(287, 28);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(42, 13);
            this.lbl_cliente.TabIndex = 21;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(171, 60);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 22;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(101, 62);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Location = new System.Drawing.Point(287, 64);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(57, 13);
            this.lbl_empleado.TabIndex = 25;
            this.lbl_empleado.Text = "Empleado:";
            // 
            // cmbModelo
            // 
            this.cmbModelo.Location = new System.Drawing.Point(217, 215);
            this.cmbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(121, 21);
            this.cmbModelo.TabIndex = 20;
            this.cmbModelo.textChanged += new System.EventHandler(this.cmbModelo_textChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Location = new System.Drawing.Point(217, 176);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 19;
            this.cmbMarca.SelectionChanged += new System.EventHandler(this.cmbMarca_SelectionChanged);
            this.cmbMarca.textChanged += new System.EventHandler(this.cmbMarca_textChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre Comercial:";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.Location = new System.Drawing.Point(217, 258);
            this.cmbCondicion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(121, 21);
            this.cmbCondicion.TabIndex = 23;
            // 
            // cmbGama
            // 
            this.cmbGama.Location = new System.Drawing.Point(527, 215);
            this.cmbGama.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGama.Name = "cmbGama";
            this.cmbGama.Size = new System.Drawing.Size(121, 21);
            this.cmbGama.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Condicion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gama";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(376, 256);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbAño
            // 
            this.cmbAño.Location = new System.Drawing.Point(527, 168);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(121, 21);
            this.cmbAño.TabIndex = 32;
            // 
            // dgr_autos
            // 
            this.dgr_autos.AllowUserToAddRows = false;
            this.dgr_autos.AllowUserToDeleteRows = false;
            this.dgr_autos.AllowUserToResizeColumns = false;
            this.dgr_autos.AllowUserToResizeRows = false;
            this.dgr_autos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_autos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Codigo_Serie,
            this.Año,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Monto});
            this.dgr_autos.Location = new System.Drawing.Point(58, 301);
            this.dgr_autos.Name = "dgr_autos";
            this.dgr_autos.ReadOnly = true;
            this.dgr_autos.RowHeadersVisible = false;
            this.dgr_autos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_autos.Size = new System.Drawing.Size(677, 132);
            this.dgr_autos.TabIndex = 29;
            this.dgr_autos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_autos_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Codigo_Serie
            // 
            this.Codigo_Serie.DataPropertyName = "cod_serie_fabrica";
            this.Codigo_Serie.HeaderText = "Codigo_Serie";
            this.Codigo_Serie.Name = "Codigo_Serie";
            this.Codigo_Serie.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "año_fabricacion";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_comercial";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_condicion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Condicion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre_gama";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gama";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto(USD)";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // dgr_factura
            // 
            this.dgr_factura.AllowUserToAddRows = false;
            this.dgr_factura.AllowUserToDeleteRows = false;
            this.dgr_factura.AllowUserToResizeColumns = false;
            this.dgr_factura.AllowUserToResizeRows = false;
            this.dgr_factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgr_factura.Location = new System.Drawing.Point(58, 462);
            this.dgr_factura.Name = "dgr_factura";
            this.dgr_factura.ReadOnly = true;
            this.dgr_factura.RowHeadersVisible = false;
            this.dgr_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_factura.Size = new System.Drawing.Size(677, 132);
            this.dgr_factura.TabIndex = 33;
            this.dgr_factura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_factura_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cod_serie_fabrica";
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo_Serie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "año_fabricacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Año";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nombre_comercial";
            this.dataGridViewTextBoxColumn8.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nombre_condicion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Condicion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nombre_gama";
            this.dataGridViewTextBoxColumn10.HeaderText = "Gama";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn11.HeaderText = "Monto(USD)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(350, 60);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.ReadOnly = true;
            this.txt_legajo.Size = new System.Drawing.Size(100, 20);
            this.txt_legajo.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Monto Total: ";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(638, 606);
            this.txtMontoTotal.Mask = "999999999999999";
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(97, 20);
            this.txtMontoTotal.TabIndex = 35;
            this.txtMontoTotal.ValidatingType = typeof(int);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(527, 256);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(121, 20);
            this.txtEstado.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Estado: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(823, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Disponibles Sugeridos ";
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.AllowUserToResizeColumns = false;
            this.dgvDisponibles.AllowUserToResizeRows = false;
            this.dgvDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvDisponibles.Location = new System.Drawing.Point(741, 301);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.ReadOnly = true;
            this.dgvDisponibles.RowHeadersVisible = false;
            this.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibles.Size = new System.Drawing.Size(461, 293);
            this.dgvDisponibles.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "año_fabricacion";
            this.dataGridViewTextBoxColumn14.HeaderText = "Año";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "nombre_comercial";
            this.dataGridViewTextBoxColumn15.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "nombre_condicion";
            this.dataGridViewTextBoxColumn16.HeaderText = "Condicion";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "nombre_gama";
            this.dataGridViewTextBoxColumn17.HeaderText = "Gama";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn18.HeaderText = "Monto(USD)";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_legajo);
            this.panel1.Controls.Add(this.lbl_empleado);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.lbl_cliente);
            this.panel1.Controls.Add(this.lbl_nroFactura);
            this.panel1.Controls.Add(this.txt_nroFactura);
            this.panel1.Controls.Add(this.buscador1);
            this.panel1.Location = new System.Drawing.Point(54, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 107);
            this.panel1.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Datos de la factura:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Detalle:";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 737);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgr_factura);
            this.Controls.Add(this.dgr_autos);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGama);
            this.Controls.Add(this.cmbCondicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cmbMarca, 0);
            this.Controls.SetChildIndex(this.cmbModelo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_venta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbCondicion, 0);
            this.Controls.SetChildIndex(this.cmbGama, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.cmbAño, 0);
            this.Controls.SetChildIndex(this.dgr_autos, 0);
            this.Controls.SetChildIndex(this.dgr_factura, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtMontoTotal, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dgvDisponibles, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_autos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lbl_empleado;
        private ControlesPropios.ComboCargable cmbModelo;
        private ControlesPropios.ComboCargable cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ControlesPropios.ComboCargable cmbCondicion;
        private ControlesPropios.ComboCargable cmbGama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private ControlesPropios.ComboCargable cmbAño;
        private System.Windows.Forms.DataGridView dgr_autos;
        private System.Windows.Forms.DataGridView dgr_factura;
        private System.Windows.Forms.TextBox txt_legajo;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}