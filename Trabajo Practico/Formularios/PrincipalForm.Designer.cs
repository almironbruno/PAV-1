namespace Trabajo_Practico.Formularios
{
    partial class PrincipalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreComercialToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorCondicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorGamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreComercialToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gamasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorMarcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrMisDetalles = new System.Windows.Forms.DataGridView();
            this.Nro_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Serie_Fabrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrMisVentas = new System.Windows.Forms.DataGridView();
            this.Num_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Doc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Doc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshVentas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMisDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMisVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.estadisticasToolStripMenuItem1,
            this.reportesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.registrosToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._8559859_settings_options_configuration_setting_system_icon;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.registrosToolStripMenuItem.Text = "Sistema";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._3994382_access_close_exit_logout_sign_out_icon;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barriosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.autosToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.telefonosToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.encargosToolStripMenuItem1});
            this.reportesToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._9044874_query_queue_icon;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.reportesToolStripMenuItem.Text = "Altas - Bajas - Modificaciones - Consultas";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._9162463_sign_map_location_placeholder_street_icon;
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.barriosToolStripMenuItem.Text = "Barrios";
            this.barriosToolStripMenuItem.Click += new System.EventHandler(this.barriosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._4308153_chart_data_employee_graph_manager_icon;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._4308184_client_costs_employee_finance_money_icon;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._352315_car_directions_icon;
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.autosToolStripMenuItem.Text = "Autos";
            this.autosToolStripMenuItem.Click += new System.EventHandler(this.autosToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._7422513_ford_cars_logo_motors_icon;
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.marcaToolStripMenuItem.Text = "Marcas";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // telefonosToolStripMenuItem
            // 
            this.telefonosToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._211830_telephone_icon;
            this.telefonosToolStripMenuItem.Name = "telefonosToolStripMenuItem";
            this.telefonosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.telefonosToolStripMenuItem.Text = "Telefonos";
            this.telefonosToolStripMenuItem.Click += new System.EventHandler(this.telefonosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources.Location;
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // encargosToolStripMenuItem1
            // 
            this.encargosToolStripMenuItem1.Image = global::Trabajo_Practico.Properties.Resources._326700_cart_shopping_icon;
            this.encargosToolStripMenuItem1.Name = "encargosToolStripMenuItem1";
            this.encargosToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.encargosToolStripMenuItem1.Text = "Encargos";
            this.encargosToolStripMenuItem1.Click += new System.EventHandler(this.encargosToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.informesToolStripMenuItem.Text = "Procesos";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Image = global::Trabajo_Practico.Properties.Resources._4192087_address_billing_delivery_invoice_location_icon;
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem1
            // 
            this.estadisticasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem2,
            this.autosToolStripMenuItem2,
            this.nombreComercialToolStripMenuItem2,
            this.ventasPorMarcaToolStripMenuItem,
            this.ventasPorCondicionToolStripMenuItem,
            this.ventasPorGamaToolStripMenuItem});
            this.estadisticasToolStripMenuItem1.Name = "estadisticasToolStripMenuItem1";
            this.estadisticasToolStripMenuItem1.Size = new System.Drawing.Size(79, 24);
            this.estadisticasToolStripMenuItem1.Text = "Estadisticas";
            // 
            // empleadosToolStripMenuItem2
            // 
            this.empleadosToolStripMenuItem2.Name = "empleadosToolStripMenuItem2";
            this.empleadosToolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.empleadosToolStripMenuItem2.Text = "Ventas por Empleado";
            this.empleadosToolStripMenuItem2.Click += new System.EventHandler(this.empleadosToolStripMenuItem2_Click);
            // 
            // autosToolStripMenuItem2
            // 
            this.autosToolStripMenuItem2.Name = "autosToolStripMenuItem2";
            this.autosToolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.autosToolStripMenuItem2.Text = "Autos por Marca";
            this.autosToolStripMenuItem2.Click += new System.EventHandler(this.autosToolStripMenuItem2_Click);
            // 
            // nombreComercialToolStripMenuItem2
            // 
            this.nombreComercialToolStripMenuItem2.Name = "nombreComercialToolStripMenuItem2";
            this.nombreComercialToolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.nombreComercialToolStripMenuItem2.Text = "Ventas Por Modelo";
            this.nombreComercialToolStripMenuItem2.Click += new System.EventHandler(this.nombreComercialToolStripMenuItem2_Click);
            // 
            // ventasPorMarcaToolStripMenuItem
            // 
            this.ventasPorMarcaToolStripMenuItem.Name = "ventasPorMarcaToolStripMenuItem";
            this.ventasPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ventasPorMarcaToolStripMenuItem.Text = "Ventas por Marca ";
            this.ventasPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.ventasPorMarcaToolStripMenuItem_Click);
            // 
            // ventasPorCondicionToolStripMenuItem
            // 
            this.ventasPorCondicionToolStripMenuItem.Name = "ventasPorCondicionToolStripMenuItem";
            this.ventasPorCondicionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ventasPorCondicionToolStripMenuItem.Text = "Ventas por Condicion";
            this.ventasPorCondicionToolStripMenuItem.Click += new System.EventHandler(this.ventasPorCondicionToolStripMenuItem_Click);
            // 
            // ventasPorGamaToolStripMenuItem
            // 
            this.ventasPorGamaToolStripMenuItem.Name = "ventasPorGamaToolStripMenuItem";
            this.ventasPorGamaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ventasPorGamaToolStripMenuItem.Text = "Ventas por Gama";
            this.ventasPorGamaToolStripMenuItem.Click += new System.EventHandler(this.ventasPorGamaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem3,
            this.autosToolStripMenuItem3,
            this.nombreComercialToolStripMenuItem3,
            this.gamasToolStripMenuItem,
            this.condicionToolStripMenuItem,
            this.ventasPorMarcaToolStripMenuItem1});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // clientesToolStripMenuItem3
            // 
            this.clientesToolStripMenuItem3.Name = "clientesToolStripMenuItem3";
            this.clientesToolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.clientesToolStripMenuItem3.Text = "Ventas por Cliente";
            this.clientesToolStripMenuItem3.Click += new System.EventHandler(this.clientesToolStripMenuItem3_Click);
            // 
            // autosToolStripMenuItem3
            // 
            this.autosToolStripMenuItem3.Name = "autosToolStripMenuItem3";
            this.autosToolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.autosToolStripMenuItem3.Text = "Autos por Cliente";
            this.autosToolStripMenuItem3.Click += new System.EventHandler(this.autosToolStripMenuItem3_Click);
            // 
            // nombreComercialToolStripMenuItem3
            // 
            this.nombreComercialToolStripMenuItem3.Name = "nombreComercialToolStripMenuItem3";
            this.nombreComercialToolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.nombreComercialToolStripMenuItem3.Text = "Ventas por Modelo";
            this.nombreComercialToolStripMenuItem3.Click += new System.EventHandler(this.nombreComercialToolStripMenuItem3_Click);
            // 
            // gamasToolStripMenuItem
            // 
            this.gamasToolStripMenuItem.Name = "gamasToolStripMenuItem";
            this.gamasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gamasToolStripMenuItem.Text = "Ventas por Gama";
            this.gamasToolStripMenuItem.Click += new System.EventHandler(this.gamasToolStripMenuItem_Click);
            // 
            // condicionToolStripMenuItem
            // 
            this.condicionToolStripMenuItem.Name = "condicionToolStripMenuItem";
            this.condicionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.condicionToolStripMenuItem.Text = "Ventas por Condicion";
            this.condicionToolStripMenuItem.Click += new System.EventHandler(this.condicionToolStripMenuItem_Click);
            // 
            // ventasPorMarcaToolStripMenuItem1
            // 
            this.ventasPorMarcaToolStripMenuItem1.Name = "ventasPorMarcaToolStripMenuItem1";
            this.ventasPorMarcaToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.ventasPorMarcaToolStripMenuItem1.Text = "Ventas por Marca";
            this.ventasPorMarcaToolStripMenuItem1.Click += new System.EventHandler(this.ventasPorMarcaToolStripMenuItem1_Click);
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.Location = new System.Drawing.Point(12, 39);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(42, 13);
            this.lbl_legajo.TabIndex = 1;
            this.lbl_legajo.Text = "Legajo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(245, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mis Ventas";
            // 
            // dgrMisDetalles
            // 
            this.dgrMisDetalles.AllowUserToAddRows = false;
            this.dgrMisDetalles.AllowUserToDeleteRows = false;
            this.dgrMisDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrMisDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMisDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Factura,
            this.Cod_Serie_Fabrica,
            this.Monto});
            this.dgrMisDetalles.Location = new System.Drawing.Point(601, 144);
            this.dgrMisDetalles.Name = "dgrMisDetalles";
            this.dgrMisDetalles.ReadOnly = true;
            this.dgrMisDetalles.RowHeadersVisible = false;
            this.dgrMisDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrMisDetalles.Size = new System.Drawing.Size(346, 306);
            this.dgrMisDetalles.TabIndex = 5;
            this.dgrMisDetalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMisDetalles_CellDoubleClick);
            // 
            // Nro_Factura
            // 
            this.Nro_Factura.DataPropertyName = "nro_factura";
            this.Nro_Factura.HeaderText = "Nro_Factura";
            this.Nro_Factura.Name = "Nro_Factura";
            this.Nro_Factura.ReadOnly = true;
            // 
            // Cod_Serie_Fabrica
            // 
            this.Cod_Serie_Fabrica.DataPropertyName = "cod_serie_fabrica";
            this.Cod_Serie_Fabrica.HeaderText = "Cod_Serie_Fabrica";
            this.Cod_Serie_Fabrica.Name = "Cod_Serie_Fabrica";
            this.Cod_Serie_Fabrica.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(612, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detalle de Venta Seleccionada";
            // 
            // dgrMisVentas
            // 
            this.dgrMisVentas.AllowUserToAddRows = false;
            this.dgrMisVentas.AllowUserToDeleteRows = false;
            this.dgrMisVentas.AllowUserToResizeColumns = false;
            this.dgrMisVentas.AllowUserToResizeRows = false;
            this.dgrMisVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrMisVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMisVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Factura,
            this.Tipo_Doc_Cliente,
            this.Nro_Doc_Cliente,
            this.Fecha});
            this.dgrMisVentas.Location = new System.Drawing.Point(72, 144);
            this.dgrMisVentas.Name = "dgrMisVentas";
            this.dgrMisVentas.ReadOnly = true;
            this.dgrMisVentas.RowHeadersVisible = false;
            this.dgrMisVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrMisVentas.Size = new System.Drawing.Size(447, 306);
            this.dgrMisVentas.TabIndex = 7;
            this.dgrMisVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMisVentas_CellDoubleClick);
            // 
            // Num_Factura
            // 
            this.Num_Factura.DataPropertyName = "nro_factura";
            this.Num_Factura.HeaderText = "Num_Factura";
            this.Num_Factura.Name = "Num_Factura";
            this.Num_Factura.ReadOnly = true;
            // 
            // Tipo_Doc_Cliente
            // 
            this.Tipo_Doc_Cliente.DataPropertyName = "tipo_doc_cliente";
            this.Tipo_Doc_Cliente.HeaderText = "Tipo_Doc_Cliente";
            this.Tipo_Doc_Cliente.Name = "Tipo_Doc_Cliente";
            this.Tipo_Doc_Cliente.ReadOnly = true;
            // 
            // Nro_Doc_Cliente
            // 
            this.Nro_Doc_Cliente.DataPropertyName = "nro_doc_cliente";
            this.Nro_Doc_Cliente.HeaderText = "Nro_Doc_Cliente";
            this.Nro_Doc_Cliente.Name = "Nro_Doc_Cliente";
            this.Nro_Doc_Cliente.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btnRefreshVentas
            // 
            this.btnRefreshVentas.Location = new System.Drawing.Point(246, 456);
            this.btnRefreshVentas.Name = "btnRefreshVentas";
            this.btnRefreshVentas.Size = new System.Drawing.Size(118, 39);
            this.btnRefreshVentas.TabIndex = 8;
            this.btnRefreshVentas.Text = "Actualizar ";
            this.btnRefreshVentas.UseVisualStyleBackColor = true;
            this.btnRefreshVentas.Click += new System.EventHandler(this.btnRefreshVentas_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 558);
            this.Controls.Add(this.btnRefreshVentas);
            this.Controls.Add(this.dgrMisVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrMisDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_legajo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion Consecionario";
            this.Activated += new System.EventHandler(this.PrincipalForm_Activated);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.Shown += new System.EventHandler(this.PrincipalForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMisDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMisVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nombreComercialToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem nombreComercialToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem telefonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encargosToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrMisDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Serie_Fabrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrMisVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Doc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Doc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnRefreshVentas;
        private System.Windows.Forms.ToolStripMenuItem gamasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorMarcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasPorCondicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorGamaToolStripMenuItem;
    }
}

