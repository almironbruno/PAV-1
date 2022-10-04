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
            this.txtEmailUsu = new System.Windows.Forms.TextBox();
            this.txtContraUsu = new System.Windows.Forms.TextBox();
            this.btnIniciarSS = new System.Windows.Forms.Button();
            this.btnRegUsu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email de Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtEmailUsu
            // 
            this.txtEmailUsu.Location = new System.Drawing.Point(269, 104);
            this.txtEmailUsu.Name = "txtEmailUsu";
            this.txtEmailUsu.Size = new System.Drawing.Size(197, 20);
            this.txtEmailUsu.TabIndex = 2;
            // 
            // txtContraUsu
            // 
            this.txtContraUsu.Location = new System.Drawing.Point(269, 157);
            this.txtContraUsu.Name = "txtContraUsu";
            this.txtContraUsu.PasswordChar = '*';
            this.txtContraUsu.Size = new System.Drawing.Size(197, 20);
            this.txtContraUsu.TabIndex = 3;
            // 
            // btnIniciarSS
            // 
            this.btnIniciarSS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSS.Location = new System.Drawing.Point(269, 190);
            this.btnIniciarSS.Name = "btnIniciarSS";
            this.btnIniciarSS.Size = new System.Drawing.Size(101, 48);
            this.btnIniciarSS.TabIndex = 4;
            this.btnIniciarSS.Text = "Iniciar Sesión ";
            this.btnIniciarSS.UseVisualStyleBackColor = true;
            this.btnIniciarSS.Click += new System.EventHandler(this.btnIniciarSS_Click);
            // 
            // btnRegUsu
            // 
            this.btnRegUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegUsu.Location = new System.Drawing.Point(269, 268);
            this.btnRegUsu.Name = "btnRegUsu";
            this.btnRegUsu.Size = new System.Drawing.Size(101, 48);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Trabajo_Practico.Properties.Resources._7518690_user_avatar_mail_people_plus_icon;
            this.pictureBox2.Location = new System.Drawing.Point(376, 267);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabajo_Practico.Properties.Resources._7623201_arrow_right_login_ui_login_icon_icon;
            this.pictureBox1.Location = new System.Drawing.Point(375, 189);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(266, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Login de Usuarios";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 412);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegUsu);
            this.Controls.Add(this.btnIniciarSS);
            this.Controls.Add(this.txtContraUsu);
            this.Controls.Add(this.txtEmailUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailUsu;
        private System.Windows.Forms.TextBox txtContraUsu;
        private System.Windows.Forms.Button btnIniciarSS;
        private System.Windows.Forms.Button btnRegUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label8;
    }
}

