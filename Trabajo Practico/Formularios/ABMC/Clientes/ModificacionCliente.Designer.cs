namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    partial class ModificacionCliente
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
            this.lbl_Barrio = new System.Windows.Forms.Label();
            this.cmbCargable_Barrio = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.mTxt_NroCalle = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_Calle = new System.Windows.Forms.MaskedTextBox();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.mTxt_FechaNac = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.mTxt_Apellido = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mTxt_Nombre = new System.Windows.Forms.MaskedTextBox();
            this.mTxt_NroDocu = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tipoDocumento = new System.Windows.Forms.Label();
            this.cmbCargable_TipoDoc = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // lbl_Barrio
            // 
            this.lbl_Barrio.AutoSize = true;
            this.lbl_Barrio.Location = new System.Drawing.Point(453, 165);
            this.lbl_Barrio.Name = "lbl_Barrio";
            this.lbl_Barrio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Barrio.TabIndex = 48;
            this.lbl_Barrio.Text = "Barrio:";
            // 
            // cmbCargable_Barrio
            // 
            this.cmbCargable_Barrio.Location = new System.Drawing.Point(510, 165);
            this.cmbCargable_Barrio.Name = "cmbCargable_Barrio";
            this.cmbCargable_Barrio.Size = new System.Drawing.Size(128, 28);
            this.cmbCargable_Barrio.TabIndex = 47;
            // 
            // mTxt_NroCalle
            // 
            this.mTxt_NroCalle.Location = new System.Drawing.Point(523, 134);
            this.mTxt_NroCalle.Mask = "9999";
            this.mTxt_NroCalle.Name = "mTxt_NroCalle";
            this.mTxt_NroCalle.Size = new System.Drawing.Size(100, 20);
            this.mTxt_NroCalle.TabIndex = 46;
            this.mTxt_NroCalle.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Calle:";
            // 
            // mtxt_Calle
            // 
            this.mtxt_Calle.Location = new System.Drawing.Point(523, 99);
            this.mtxt_Calle.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.mtxt_Calle.Name = "mtxt_Calle";
            this.mtxt_Calle.Size = new System.Drawing.Size(100, 20);
            this.mtxt_Calle.TabIndex = 43;
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(119, 227);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lbl_FechaNacimiento.TabIndex = 42;
            this.lbl_FechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // mTxt_FechaNac
            // 
            this.mTxt_FechaNac.Location = new System.Drawing.Point(242, 220);
            this.mTxt_FechaNac.Mask = "00/00/0000";
            this.mTxt_FechaNac.Name = "mTxt_FechaNac";
            this.mTxt_FechaNac.Size = new System.Drawing.Size(100, 20);
            this.mTxt_FechaNac.TabIndex = 41;
            this.mTxt_FechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(183, 199);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_Apellido.TabIndex = 40;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // mTxt_Apellido
            // 
            this.mTxt_Apellido.Location = new System.Drawing.Point(242, 193);
            this.mTxt_Apellido.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.mTxt_Apellido.Name = "mTxt_Apellido";
            this.mTxt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.mTxt_Apellido.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre:";
            // 
            // mTxt_Nombre
            // 
            this.mTxt_Nombre.Location = new System.Drawing.Point(242, 158);
            this.mTxt_Nombre.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.mTxt_Nombre.Name = "mTxt_Nombre";
            this.mTxt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.mTxt_Nombre.TabIndex = 37;
            // 
            // mTxt_NroDocu
            // 
            this.mTxt_NroDocu.Location = new System.Drawing.Point(242, 131);
            this.mTxt_NroDocu.Mask = "99999999";
            this.mTxt_NroDocu.Name = "mTxt_NroDocu";
            this.mTxt_NroDocu.Size = new System.Drawing.Size(100, 20);
            this.mTxt_NroDocu.TabIndex = 36;
            this.mTxt_NroDocu.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Numero de Documento:";
            // 
            // lbl_tipoDocumento
            // 
            this.lbl_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tipoDocumento.AutoSize = true;
            this.lbl_tipoDocumento.Location = new System.Drawing.Point(119, 99);
            this.lbl_tipoDocumento.Name = "lbl_tipoDocumento";
            this.lbl_tipoDocumento.Size = new System.Drawing.Size(104, 13);
            this.lbl_tipoDocumento.TabIndex = 34;
            this.lbl_tipoDocumento.Text = "Tipo de Documento:";
            // 
            // cmbCargable_TipoDoc
            // 
            this.cmbCargable_TipoDoc.Location = new System.Drawing.Point(242, 99);
            this.cmbCargable_TipoDoc.Name = "cmbCargable_TipoDoc";
            this.cmbCargable_TipoDoc.Size = new System.Drawing.Size(128, 28);
            this.cmbCargable_TipoDoc.TabIndex = 33;
            // 
            // ModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Barrio);
            this.Controls.Add(this.cmbCargable_Barrio);
            this.Controls.Add(this.mTxt_NroCalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxt_Calle);
            this.Controls.Add(this.lbl_FechaNacimiento);
            this.Controls.Add(this.mTxt_FechaNac);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.mTxt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mTxt_Nombre);
            this.Controls.Add(this.mTxt_NroDocu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tipoDocumento);
            this.Controls.Add(this.cmbCargable_TipoDoc);
            this.Name = "ModificacionCliente";
            this.Text = "ModificacionCliente";
            this.Load += new System.EventHandler(this.ModificacionCliente_Load);
            this.Controls.SetChildIndex(this.cmbCargable_TipoDoc, 0);
            this.Controls.SetChildIndex(this.lbl_tipoDocumento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.mTxt_NroDocu, 0);
            this.Controls.SetChildIndex(this.mTxt_Nombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.mTxt_Apellido, 0);
            this.Controls.SetChildIndex(this.lbl_Apellido, 0);
            this.Controls.SetChildIndex(this.mTxt_FechaNac, 0);
            this.Controls.SetChildIndex(this.lbl_FechaNacimiento, 0);
            this.Controls.SetChildIndex(this.mtxt_Calle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.mTxt_NroCalle, 0);
            this.Controls.SetChildIndex(this.cmbCargable_Barrio, 0);
            this.Controls.SetChildIndex(this.lbl_Barrio, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Barrio;
        private ControlesPropios.ComboCargable cmbCargable_Barrio;
        private System.Windows.Forms.MaskedTextBox mTxt_NroCalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_Calle;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.MaskedTextBox mTxt_FechaNac;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.MaskedTextBox mTxt_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTxt_Nombre;
        private System.Windows.Forms.MaskedTextBox mTxt_NroDocu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tipoDocumento;
        private ControlesPropios.ComboCargable cmbCargable_TipoDoc;
    }
}