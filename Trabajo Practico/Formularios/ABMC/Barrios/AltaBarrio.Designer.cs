namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    partial class AltaBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaBarrio));
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txtNombreNuevoBarrio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Aceptar.Location = new System.Drawing.Point(133, 182);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(151, 49);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txtNombreNuevoBarrio
            // 
            this.txtNombreNuevoBarrio.Location = new System.Drawing.Point(332, 108);
            this.txtNombreNuevoBarrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreNuevoBarrio.Name = "txtNombreNuevoBarrio";
            this.txtNombreNuevoBarrio.Size = new System.Drawing.Size(251, 22);
            this.txtNombreNuevoBarrio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre nuevo barrio:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.Location = new System.Drawing.Point(292, 182);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(151, 49);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(451, 182);
            this.btn_LimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(151, 49);
            this.btn_LimpiarCampos.TabIndex = 3;
            this.btn_LimpiarCampos.Text = "Limpiar Campos";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = false;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.btn_LimpiarCampos_Click);
            // 
            // AltaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 348);
            this.Controls.Add(this.btn_LimpiarCampos);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreNuevoBarrio);
            this.Controls.Add(this.btn_Aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AltaBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaBarrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txtNombreNuevoBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_LimpiarCampos;
    }
}