namespace Trabajo_Practico.Formularios.Base
{
    partial class FormBaseBotones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseBotones));
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.errorProviderBase = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Aceptar.Location = new System.Drawing.Point(252, 406);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(151, 49);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.Location = new System.Drawing.Point(455, 406);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(151, 49);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(656, 406);
            this.btn_LimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(151, 49);
            this.btn_LimpiarCampos.TabIndex = 16;
            this.btn_LimpiarCampos.Text = "LimpiarCampos";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = false;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.btn_LimpiarCampos_Click);
            // 
            // errorProviderBase
            // 
            this.errorProviderBase.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderBase.ContainerControl = this;
            // 
            // FormBaseBotones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_LimpiarCampos);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBaseBotones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaseBotones";
            this.Load += new System.EventHandler(this.FormBaseBotones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btn_Aceptar;
        protected  System.Windows.Forms.Button btn_Cancelar;
        protected  System.Windows.Forms.Button btn_LimpiarCampos;
        protected System.Windows.Forms.ErrorProvider errorProviderBase;
    }
}