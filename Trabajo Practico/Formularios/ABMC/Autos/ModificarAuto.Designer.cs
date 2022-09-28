namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    partial class ModificarAuto
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
            this.mtxtPatente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtNroMotor = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtNroChasis = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mcmbCondicion = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.mtxtAñoFab = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mcmbNomComr = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.MtxtCodSerieFab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // mtxtPatente
            // 
            this.mtxtPatente.Location = new System.Drawing.Point(604, 188);
            this.mtxtPatente.Name = "mtxtPatente";
            this.mtxtPatente.Size = new System.Drawing.Size(100, 20);
            this.mtxtPatente.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Patente: ";
            // 
            // mtxtNroMotor
            // 
            this.mtxtNroMotor.Location = new System.Drawing.Point(604, 154);
            this.mtxtNroMotor.Mask = "9999";
            this.mtxtNroMotor.Name = "mtxtNroMotor";
            this.mtxtNroMotor.Size = new System.Drawing.Size(31, 20);
            this.mtxtNroMotor.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Numero de Motor: ";
            // 
            // mtxtNroChasis
            // 
            this.mtxtNroChasis.Location = new System.Drawing.Point(604, 107);
            this.mtxtNroChasis.Mask = "9999";
            this.mtxtNroChasis.Name = "mtxtNroChasis";
            this.mtxtNroChasis.Size = new System.Drawing.Size(31, 20);
            this.mtxtNroChasis.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Numero de Chasis: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Condicion: ";
            // 
            // mcmbCondicion
            // 
            this.mcmbCondicion.Location = new System.Drawing.Point(388, 226);
            this.mcmbCondicion.Name = "mcmbCondicion";
            this.mcmbCondicion.Size = new System.Drawing.Size(139, 26);
            this.mcmbCondicion.TabIndex = 26;
            // 
            // mtxtAñoFab
            // 
            this.mtxtAñoFab.Location = new System.Drawing.Point(259, 188);
            this.mtxtAñoFab.Mask = "9999";
            this.mtxtAñoFab.Name = "mtxtAñoFab";
            this.mtxtAñoFab.Size = new System.Drawing.Size(31, 20);
            this.mtxtAñoFab.TabIndex = 20;
            this.mtxtAñoFab.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Año de Fabricacion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre_Comercial: ";
            // 
            // mcmbNomComr
            // 
            this.mcmbNomComr.Location = new System.Drawing.Point(259, 148);
            this.mcmbNomComr.Name = "mcmbNomComr";
            this.mcmbNomComr.Size = new System.Drawing.Size(139, 26);
            this.mcmbNomComr.TabIndex = 18;
            // 
            // MtxtCodSerieFab
            // 
            this.MtxtCodSerieFab.Location = new System.Drawing.Point(259, 108);
            this.MtxtCodSerieFab.Name = "MtxtCodSerieFab";
            this.MtxtCodSerieFab.Size = new System.Drawing.Size(186, 20);
            this.MtxtCodSerieFab.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo de Serie de Fabrica: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(308, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Modificar Autos";
            // 
            // ModificarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtPatente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtNroMotor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtNroChasis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mcmbCondicion);
            this.Controls.Add(this.mtxtAñoFab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcmbNomComr);
            this.Controls.Add(this.MtxtCodSerieFab);
            this.Controls.Add(this.label1);
            this.Name = "ModificarAuto";
            this.Text = "ModificarAuto";
            this.Load += new System.EventHandler(this.ModificarAuto_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.MtxtCodSerieFab, 0);
            this.Controls.SetChildIndex(this.mcmbNomComr, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.mtxtAñoFab, 0);
            this.Controls.SetChildIndex(this.mcmbCondicion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.mtxtNroChasis, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.mtxtNroMotor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.mtxtPatente, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mtxtPatente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtNroMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtNroChasis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ControlesPropios.ComboCargable mcmbCondicion;
        private System.Windows.Forms.MaskedTextBox mtxtAñoFab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ControlesPropios.ComboCargable mcmbNomComr;
        private System.Windows.Forms.TextBox MtxtCodSerieFab;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
    }
}