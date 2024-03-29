﻿namespace Trabajo_Practico.Formularios.ABMC.ABMC_Autos
{
    partial class CamposAutos
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
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroMotor = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroChasis = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCondicion = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.txtAñoFab = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNomComr = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.txtCodSerieFab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioAuto = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(613, 193);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Patente: ";
            // 
            // txtNroMotor
            // 
            this.txtNroMotor.HidePromptOnLeave = true;
            this.txtNroMotor.Location = new System.Drawing.Point(613, 159);
            this.txtNroMotor.Mask = "9999";
            this.txtNroMotor.Name = "txtNroMotor";
            this.txtNroMotor.Size = new System.Drawing.Size(31, 20);
            this.txtNroMotor.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Numero de Motor: ";
            // 
            // txtNroChasis
            // 
            this.txtNroChasis.HidePromptOnLeave = true;
            this.txtNroChasis.Location = new System.Drawing.Point(613, 112);
            this.txtNroChasis.Mask = "9999";
            this.txtNroChasis.Name = "txtNroChasis";
            this.txtNroChasis.Size = new System.Drawing.Size(31, 20);
            this.txtNroChasis.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Numero de Chasis: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Condicion: ";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.Location = new System.Drawing.Point(268, 231);
            this.cmbCondicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(139, 26);
            this.cmbCondicion.TabIndex = 26;
            // 
            // txtAñoFab
            // 
            this.txtAñoFab.HidePromptOnLeave = true;
            this.txtAñoFab.Location = new System.Drawing.Point(268, 193);
            this.txtAñoFab.Mask = "9999";
            this.txtAñoFab.Name = "txtAñoFab";
            this.txtAñoFab.Size = new System.Drawing.Size(31, 20);
            this.txtAñoFab.TabIndex = 20;
            this.txtAñoFab.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Año de Fabricacion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre Comercial: ";
            // 
            // cmbNomComr
            // 
            this.cmbNomComr.Location = new System.Drawing.Point(268, 153);
            this.cmbNomComr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNomComr.Name = "cmbNomComr";
            this.cmbNomComr.Size = new System.Drawing.Size(139, 26);
            this.cmbNomComr.TabIndex = 18;
            // 
            // txtCodSerieFab
            // 
            this.txtCodSerieFab.Location = new System.Drawing.Point(268, 113);
            this.txtCodSerieFab.Name = "txtCodSerieFab";
            this.txtCodSerieFab.Size = new System.Drawing.Size(186, 20);
            this.txtCodSerieFab.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo de Serie de Fabrica: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Precio: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPrecioAuto
            // 
            this.txtPrecioAuto.Location = new System.Drawing.Point(613, 224);
            this.txtPrecioAuto.Mask = "99999999999";
            this.txtPrecioAuto.Name = "txtPrecioAuto";
            this.txtPrecioAuto.Size = new System.Drawing.Size(71, 20);
            this.txtPrecioAuto.TabIndex = 32;
            this.txtPrecioAuto.ValidatingType = typeof(int);
            // 
            // CamposAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecioAuto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNroMotor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNroChasis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCondicion);
            this.Controls.Add(this.txtAñoFab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNomComr);
            this.Controls.Add(this.txtCodSerieFab);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CamposAutos";
            this.Text = "CamposAutos";
            this.Load += new System.EventHandler(this.CamposAutos_Load);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_LimpiarCampos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodSerieFab, 0);
            this.Controls.SetChildIndex(this.cmbNomComr, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAñoFab, 0);
            this.Controls.SetChildIndex(this.cmbCondicion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNroChasis, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNroMotor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtPrecioAuto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.MaskedTextBox txtNroMotor;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.MaskedTextBox txtNroChasis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        protected ControlesPropios.ComboCargable cmbCondicion;
        protected System.Windows.Forms.MaskedTextBox txtAñoFab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected ControlesPropios.ComboCargable cmbNomComr;
        protected System.Windows.Forms.TextBox txtCodSerieFab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.MaskedTextBox txtPrecioAuto;
    }
}