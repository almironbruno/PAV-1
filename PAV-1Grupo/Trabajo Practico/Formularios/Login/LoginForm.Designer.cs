namespace Trabajo_Practico
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreUsu = new System.Windows.Forms.TextBox();
            this.txtContraUsu = new System.Windows.Forms.TextBox();
            this.btnIniciarSS = new System.Windows.Forms.Button();
            this.btnRegUsu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtNombreUsu
            // 
            this.txtNombreUsu.Location = new System.Drawing.Point(222, 113);
            this.txtNombreUsu.Name = "txtNombreUsu";
            this.txtNombreUsu.Size = new System.Drawing.Size(197, 20);
            this.txtNombreUsu.TabIndex = 2;
            // 
            // txtContraUsu
            // 
            this.txtContraUsu.Location = new System.Drawing.Point(222, 166);
            this.txtContraUsu.Name = "txtContraUsu";
            this.txtContraUsu.PasswordChar = '*';
            this.txtContraUsu.Size = new System.Drawing.Size(197, 20);
            this.txtContraUsu.TabIndex = 3;
            // 
            // btnIniciarSS
            // 
            this.btnIniciarSS.Location = new System.Drawing.Point(269, 207);
            this.btnIniciarSS.Name = "btnIniciarSS";
            this.btnIniciarSS.Size = new System.Drawing.Size(101, 25);
            this.btnIniciarSS.TabIndex = 4;
            this.btnIniciarSS.Text = "Iniciar Sesión ";
            this.btnIniciarSS.UseVisualStyleBackColor = true;
            this.btnIniciarSS.Click += new System.EventHandler(this.btnIniciarSS_Click);
            // 
            // btnRegUsu
            // 
            this.btnRegUsu.Location = new System.Drawing.Point(269, 284);
            this.btnRegUsu.Name = "btnRegUsu";
            this.btnRegUsu.Size = new System.Drawing.Size(101, 25);
            this.btnRegUsu.TabIndex = 5;
            this.btnRegUsu.Text = "Registrarse";
            this.btnRegUsu.UseVisualStyleBackColor = true;
            this.btnRegUsu.Click += new System.EventHandler(this.btnRegUsu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿Nuevo Usuario? Regístrese. ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegUsu);
            this.Controls.Add(this.btnIniciarSS);
            this.Controls.Add(this.txtContraUsu);
            this.Controls.Add(this.txtNombreUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsu;
        private System.Windows.Forms.TextBox txtContraUsu;
        private System.Windows.Forms.Button btnIniciarSS;
        private System.Windows.Forms.Button btnRegUsu;
        private System.Windows.Forms.Label label3;
    }
}

