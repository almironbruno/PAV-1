namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    partial class BajaAutos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CancelarElim = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.txtNroMotr = new Trabajo_Practico.ControlesPropios.TextBoxCargable();
            this.txtNroChas = new Trabajo_Practico.ControlesPropios.TextBoxCargable();
            this.txtPatenteElm = new Trabajo_Practico.ControlesPropios.TextBoxCargable();
            this.txtCodSerie = new Trabajo_Practico.ControlesPropios.TextBoxCargable();
            this.dtgvAutosParaEliminar = new Trabajo_Practico.DataGridViewModificada();
            this.SuspendLayout();
            // 
            // btn_CancelarElim
            // 
            this.btn_CancelarElim.BackColor = System.Drawing.Color.LightCoral;
            this.btn_CancelarElim.Location = new System.Drawing.Point(654, 108);
            this.btn_CancelarElim.Name = "btn_CancelarElim";
            this.btn_CancelarElim.Size = new System.Drawing.Size(110, 38);
            this.btn_CancelarElim.TabIndex = 5;
            this.btn_CancelarElim.Text = "Cancelar";
            this.btn_CancelarElim.UseVisualStyleBackColor = false;
            this.btn_CancelarElim.Click += new System.EventHandler(this.btn_CancelarElim_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Eliminar.Location = new System.Drawing.Point(654, 194);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 38);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Actualizar.Location = new System.Drawing.Point(654, 276);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(110, 38);
            this.btn_Actualizar.TabIndex = 7;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.BackColor = System.Drawing.Color.Silver;
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(654, 367);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(110, 38);
            this.btn_LimpiarCampos.TabIndex = 8;
            this.btn_LimpiarCampos.Text = "Limpiar Campos";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = false;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.btn_LimpiarCampos_Click);
            // 
            // txtNroMotr
            // 
            this.txtNroMotr.Location = new System.Drawing.Point(337, 506);
            this.txtNroMotr.Name = "txtNroMotr";
            this.txtNroMotr.Size = new System.Drawing.Size(182, 44);
            this.txtNroMotr.TabIndex = 4;
            // 
            // txtNroChas
            // 
            this.txtNroChas.Location = new System.Drawing.Point(71, 506);
            this.txtNroChas.Name = "txtNroChas";
            this.txtNroChas.Size = new System.Drawing.Size(182, 44);
            this.txtNroChas.TabIndex = 3;
            // 
            // txtPatenteElm
            // 
            this.txtPatenteElm.Location = new System.Drawing.Point(337, 439);
            this.txtPatenteElm.Name = "txtPatenteElm";
            this.txtPatenteElm.Size = new System.Drawing.Size(182, 44);
            this.txtPatenteElm.TabIndex = 2;
            // 
            // txtCodSerie
            // 
            this.txtCodSerie.Location = new System.Drawing.Point(71, 439);
            this.txtCodSerie.Name = "txtCodSerie";
            this.txtCodSerie.Size = new System.Drawing.Size(182, 44);
            this.txtCodSerie.TabIndex = 1;
            // 
            // dtgvAutosParaEliminar
            // 
            this.dtgvAutosParaEliminar.Location = new System.Drawing.Point(29, 108);
            this.dtgvAutosParaEliminar.Name = "dtgvAutosParaEliminar";
            this.dtgvAutosParaEliminar.Size = new System.Drawing.Size(546, 306);
            this.dtgvAutosParaEliminar.TabIndex = 0;
            this.dtgvAutosParaEliminar.Load += new System.EventHandler(this.dtgvAutosParaEliminar_Load);
            // 
            // BajaAutos
            // 
            this.ClientSize = new System.Drawing.Size(850, 585);
            this.Controls.Add(this.btn_LimpiarCampos);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_CancelarElim);
            this.Controls.Add(this.txtNroMotr);
            this.Controls.Add(this.txtNroChas);
            this.Controls.Add(this.txtPatenteElm);
            this.Controls.Add(this.txtCodSerie);
            this.Controls.Add(this.dtgvAutosParaEliminar);
            this.Name = "BajaAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BajaAutos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ControlesPropios.TextBoxCargable txtCodSerie;
        private ControlesPropios.TextBoxCargable txtPatenteElm;
        private ControlesPropios.TextBoxCargable txtNroChas;
        private ControlesPropios.TextBoxCargable txtNroMotr;
        private System.Windows.Forms.Button btn_CancelarElim;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_LimpiarCampos;
        private DataGridViewModificada dtgvAutosParaEliminar;
    }
}
