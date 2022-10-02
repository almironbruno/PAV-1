namespace Trabajo_Practico.Formularios.ABMC
{
    partial class Barrios
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_advertencia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Agregar.Location = new System.Drawing.Point(20, 23);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(113, 51);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(235, 65);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(231, 29);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Gestion de Barrios";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Actualizar);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Location = new System.Drawing.Point(633, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 306);
            this.panel1.TabIndex = 2;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Actualizar.Location = new System.Drawing.Point(20, 92);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(113, 51);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Khaki;
            this.btn_Buscar.Location = new System.Drawing.Point(20, 159);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(113, 51);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(20, 229);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(113, 51);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.AutoSize = true;
            this.lbl_advertencia.Location = new System.Drawing.Point(85, 351);
            this.lbl_advertencia.Name = "lbl_advertencia";
            this.lbl_advertencia.Size = new System.Drawing.Size(230, 13);
            this.lbl_advertencia.TabIndex = 6;
            this.lbl_advertencia.Text = "Debe seleccionar uno para actualizar o eliminar";
            // 
            // Barrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_advertencia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Barrios";
            this.Text = "Barrios";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_advertencia;
    }
}