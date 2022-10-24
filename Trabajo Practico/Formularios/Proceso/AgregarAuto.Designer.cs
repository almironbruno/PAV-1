namespace Trabajo_Practico.Formularios.Proceso
{
    partial class AgregarAuto
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
            this.cmb_marca = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmb_nombreComercial = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Condicion = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.cmb_gama = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_gama = new System.Windows.Forms.Label();
            this.dgr_autos = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmbBoxAño = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_autos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(247, 457);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(451, 457);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(656, 457);
            this.btn_LimpiarCampos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // cmb_marca
            // 
            this.cmb_marca.Location = new System.Drawing.Point(261, 34);
            this.cmb_marca.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(161, 26);
            this.cmb_marca.TabIndex = 19;
            // 
            // cmb_nombreComercial
            // 
            this.cmb_nombreComercial.Location = new System.Drawing.Point(261, 82);
            this.cmb_nombreComercial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmb_nombreComercial.Name = "cmb_nombreComercial";
            this.cmb_nombreComercial.Size = new System.Drawing.Size(161, 26);
            this.cmb_nombreComercial.TabIndex = 20;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(175, 34);
            this.lbl_marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(48, 16);
            this.lbl_marca.TabIndex = 21;
            this.lbl_marca.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Comercial:";
            // 
            // cmb_Condicion
            // 
            this.cmb_Condicion.Location = new System.Drawing.Point(261, 134);
            this.cmb_Condicion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmb_Condicion.Name = "cmb_Condicion";
            this.cmb_Condicion.Size = new System.Drawing.Size(161, 26);
            this.cmb_Condicion.TabIndex = 23;
            // 
            // cmb_gama
            // 
            this.cmb_gama.Location = new System.Drawing.Point(619, 82);
            this.cmb_gama.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmb_gama.Name = "cmb_gama";
            this.cmb_gama.Size = new System.Drawing.Size(161, 26);
            this.cmb_gama.TabIndex = 25;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(157, 143);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 16);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "Condicion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Año:";
            // 
            // lbl_gama
            // 
            this.lbl_gama.AutoSize = true;
            this.lbl_gama.Location = new System.Drawing.Point(555, 92);
            this.lbl_gama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gama.Name = "lbl_gama";
            this.lbl_gama.Size = new System.Drawing.Size(44, 16);
            this.lbl_gama.TabIndex = 28;
            this.lbl_gama.Text = "Gama";
            // 
            // dgr_autos
            // 
            this.dgr_autos.AllowUserToAddRows = false;
            this.dgr_autos.AllowUserToDeleteRows = false;
            this.dgr_autos.AllowUserToResizeColumns = false;
            this.dgr_autos.AllowUserToResizeRows = false;
            this.dgr_autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_autos.Location = new System.Drawing.Point(247, 222);
            this.dgr_autos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgr_autos.Name = "dgr_autos";
            this.dgr_autos.ReadOnly = true;
            this.dgr_autos.RowHeadersVisible = false;
            this.dgr_autos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_autos.Size = new System.Drawing.Size(655, 190);
            this.dgr_autos.TabIndex = 29;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(572, 154);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 28);
            this.btn_agregar.TabIndex = 30;
            this.btn_agregar.Text = "Buscar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmbBoxAño
            // 
            this.cmbBoxAño.FormattingEnabled = true;
            this.cmbBoxAño.Location = new System.Drawing.Point(619, 25);
            this.cmbBoxAño.Name = "cmbBoxAño";
            this.cmbBoxAño.Size = new System.Drawing.Size(161, 24);
            this.cmbBoxAño.TabIndex = 31;
            // 
            // AgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbBoxAño);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dgr_autos);
            this.Controls.Add(this.lbl_gama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cmb_gama);
            this.Controls.Add(this.cmb_Condicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.cmb_nombreComercial);
            this.Controls.Add(this.cmb_marca);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AgregarAuto";
            this.Text = "AgregarAuto";
            this.Load += new System.EventHandler(this.AgregarAuto_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.cmb_marca, 0);
            this.Controls.SetChildIndex(this.cmb_nombreComercial, 0);
            this.Controls.SetChildIndex(this.lbl_marca, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmb_Condicion, 0);
            this.Controls.SetChildIndex(this.cmb_gama, 0);
            this.Controls.SetChildIndex(this.lbl, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbl_gama, 0);
            this.Controls.SetChildIndex(this.dgr_autos, 0);
            this.Controls.SetChildIndex(this.btn_agregar, 0);
            this.Controls.SetChildIndex(this.cmbBoxAño, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_autos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlesPropios.ComboCargable cmb_marca;
        private ControlesPropios.ComboCargable cmb_nombreComercial;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label label1;
        private ControlesPropios.ComboCargable cmb_Condicion;
        private ControlesPropios.ComboCargable cmb_gama;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_gama;
        private System.Windows.Forms.DataGridView dgr_autos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmbBoxAño;
    }
}