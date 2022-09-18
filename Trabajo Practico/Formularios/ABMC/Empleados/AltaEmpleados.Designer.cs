namespace Trabajo_Practico.Formularios.ABMC.Empleados
{
    partial class AltaEmpleados
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
            this.comboCargable1 = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.comboCargable2 = new Trabajo_Practico.ControlesPropios.ComboCargable();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // comboCargable1
            // 
            this.comboCargable1.Location = new System.Drawing.Point(214, 105);
            this.comboCargable1.Name = "comboCargable1";
            this.comboCargable1.Size = new System.Drawing.Size(226, 36);
            this.comboCargable1.TabIndex = 2;
            // 
            // comboCargable2
            // 
            this.comboCargable2.Location = new System.Drawing.Point(214, 147);
            this.comboCargable2.Name = "comboCargable2";
            this.comboCargable2.Size = new System.Drawing.Size(226, 36);
            this.comboCargable2.TabIndex = 3;
            // 
            // AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboCargable2);
            this.Controls.Add(this.comboCargable1);
            this.Name = "AltaEmpleados";
            this.Text = "AltaEmpleados";
            this.Load += new System.EventHandler(this.AltaEmpleados_Load);
            this.Controls.SetChildIndex(this.btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.comboCargable1, 0);
            this.Controls.SetChildIndex(this.comboCargable2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.ComboCargable comboCargable1;
        private ControlesPropios.ComboCargable comboCargable2;
    }
}