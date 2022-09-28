namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    partial class AltaAutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodSerieFab = new System.Windows.Forms.TextBox();
            this.cmbNomComr = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAñoFab = new System.Windows.Forms.MaskedTextBox();
            this.cmbCondicion = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroChasis = new System.Windows.Forms.MaskedTextBox();
            this.txtNroMotor = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(152, 329);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Serie de Fabrica: ";
            // 
            // txtCodSerieFab
            // 
            this.txtCodSerieFab.Location = new System.Drawing.Point(244, 96);
            this.txtCodSerieFab.Name = "txtCodSerieFab";
            this.txtCodSerieFab.Size = new System.Drawing.Size(186, 20);
            this.txtCodSerieFab.TabIndex = 1;
            // 
            // cmbNomComr
            // 
            this.cmbNomComr.Location = new System.Drawing.Point(244, 136);
            this.cmbNomComr.Name = "cmbNomComr";
            this.cmbNomComr.Size = new System.Drawing.Size(139, 26);
            this.cmbNomComr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre_Comercial: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año de Fabricacion: ";
            // 
            // txtAñoFab
            // 
            this.txtAñoFab.Location = new System.Drawing.Point(244, 176);
            this.txtAñoFab.Mask = "9999";
            this.txtAñoFab.Name = "txtAñoFab";
            this.txtAñoFab.Size = new System.Drawing.Size(31, 20);
            this.txtAñoFab.TabIndex = 3;
            this.txtAñoFab.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.Location = new System.Drawing.Point(373, 214);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(139, 26);
            this.cmbCondicion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Condicion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de Chasis: ";
            // 
            // txtNroChasis
            // 
            this.txtNroChasis.Location = new System.Drawing.Point(589, 95);
            this.txtNroChasis.Mask = "9999";
            this.txtNroChasis.Name = "txtNroChasis";
            this.txtNroChasis.Size = new System.Drawing.Size(31, 20);
            this.txtNroChasis.TabIndex = 4;
            // 
            // txtNroMotor
            // 
            this.txtNroMotor.Location = new System.Drawing.Point(589, 142);
            this.txtNroMotor.Mask = "9999";
            this.txtNroMotor.Name = "txtNroMotor";
            this.txtNroMotor.Size = new System.Drawing.Size(31, 20);
            this.txtNroMotor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numero de Motor: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Patente: ";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(589, 176);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(293, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Registro de Vehiculos";
            // 
            // AltaAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AltaAutos";
            this.Text = "AltaAutos";
            this.Load += new System.EventHandler(this.AltaAutos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodSerieFab, 0);
            this.Controls.SetChildIndex(this.cmbNomComr, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAñoFab, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.cmbCondicion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNroChasis, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNroMotor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPatente, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodSerieFab;
        private ControlesPropios.ComboCargable cmbNomComr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtAñoFab;
        private ControlesPropios.ComboCargable cmbCondicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNroChasis;
        private System.Windows.Forms.MaskedTextBox txtNroMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatente;
        public System.Windows.Forms.Label label8;
        //private System.Windows.Forms.Button btn_LimpiarCampos;
    }
}