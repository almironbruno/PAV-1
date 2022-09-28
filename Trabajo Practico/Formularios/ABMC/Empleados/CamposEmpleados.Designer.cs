﻿namespace Trabajo_Practico.Formularios.ABMC.Empleados
{
    partial class CamposEmpleados
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
            this.mTxt_Nombre = new System.Windows.Forms.MaskedTextBox();
            this.mTxt_Apellido = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.cmbCargable_Cargos = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // mTxt_Nombre
            // 
            this.mTxt_Nombre.Location = new System.Drawing.Point(209, 155);
            this.mTxt_Nombre.Mask = "LLLLLLLLLLLLLL";
            this.mTxt_Nombre.Name = "mTxt_Nombre";
            this.mTxt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.mTxt_Nombre.TabIndex = 18;
            // 
            // mTxt_Apellido
            // 
            this.mTxt_Apellido.Location = new System.Drawing.Point(209, 193);
            this.mTxt_Apellido.Mask = "LLLLLLLLLLLLLLL";
            this.mTxt_Apellido.Name = "mTxt_Apellido";
            this.mTxt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.mTxt_Apellido.TabIndex = 19;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(146, 161);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 20;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(154, 193);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 21;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // cmbCargable_Cargos
            // 
            this.cmbCargable_Cargos.Location = new System.Drawing.Point(448, 147);
            this.cmbCargable_Cargos.Name = "cmbCargable_Cargos";
            this.cmbCargable_Cargos.Size = new System.Drawing.Size(200, 28);
            this.cmbCargable_Cargos.TabIndex = 22;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(209, 117);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 23;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.Location = new System.Drawing.Point(146, 120);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Legajo.TabIndex = 24;
            this.lbl_Legajo.Text = "Legajo:";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Location = new System.Drawing.Point(404, 155);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(38, 13);
            this.lbl_Cargo.TabIndex = 25;
            this.lbl_Cargo.Text = "Cargo:";
            // 
            // CamposEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Cargo);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cmbCargable_Cargos);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.mTxt_Apellido);
            this.Controls.Add(this.mTxt_Nombre);
            this.Name = "CamposEmpleados";
            this.Text = "CamposEmpleados";
            this.Controls.SetChildIndex(this.mTxt_Nombre, 0);
            this.Controls.SetChildIndex(this.mTxt_Apellido, 0);
            this.Controls.SetChildIndex(this.lbl_Nombre, 0);
            this.Controls.SetChildIndex(this.lbl_Apellido, 0);
            this.Controls.SetChildIndex(this.cmbCargable_Cargos, 0);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.Controls.SetChildIndex(this.lbl_Legajo, 0);
            this.Controls.SetChildIndex(this.lbl_Cargo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mTxt_Nombre;
        private System.Windows.Forms.MaskedTextBox mTxt_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        protected ControlesPropios.ComboCargable cmbCargable_Cargos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lbl_Legajo;
        private System.Windows.Forms.Label lbl_Cargo;
    }
}