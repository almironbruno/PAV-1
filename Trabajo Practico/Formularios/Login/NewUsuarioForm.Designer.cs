namespace Trabajo_Practico.Formularios
{
    partial class NewUsuarioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomNewUsu = new System.Windows.Forms.TextBox();
            this.txtApeNewUsu = new System.Windows.Forms.TextBox();
            this.txtPassNewUsu = new System.Windows.Forms.TextBox();
            this.txtRepPassNewUsu = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtCorreoNewUsu = new System.Windows.Forms.TextBox();
            this.lblValido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repetir Contraseña";
            // 
            // txtNomNewUsu
            // 
            this.txtNomNewUsu.Location = new System.Drawing.Point(270, 51);
            this.txtNomNewUsu.Name = "txtNomNewUsu";
            this.txtNomNewUsu.Size = new System.Drawing.Size(181, 20);
            this.txtNomNewUsu.TabIndex = 5;
            // 
            // txtApeNewUsu
            // 
            this.txtApeNewUsu.Location = new System.Drawing.Point(270, 86);
            this.txtApeNewUsu.Name = "txtApeNewUsu";
            this.txtApeNewUsu.Size = new System.Drawing.Size(181, 20);
            this.txtApeNewUsu.TabIndex = 6;
            // 
            // txtPassNewUsu
            // 
            this.txtPassNewUsu.Location = new System.Drawing.Point(270, 152);
            this.txtPassNewUsu.Name = "txtPassNewUsu";
            this.txtPassNewUsu.PasswordChar = '*';
            this.txtPassNewUsu.Size = new System.Drawing.Size(181, 20);
            this.txtPassNewUsu.TabIndex = 8;
            // 
            // txtRepPassNewUsu
            // 
            this.txtRepPassNewUsu.Location = new System.Drawing.Point(270, 187);
            this.txtRepPassNewUsu.Name = "txtRepPassNewUsu";
            this.txtRepPassNewUsu.PasswordChar = '*';
            this.txtRepPassNewUsu.Size = new System.Drawing.Size(181, 20);
            this.txtRepPassNewUsu.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(296, 233);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(155, 32);
            this.btnCrearUsuario.TabIndex = 10;
            this.btnCrearUsuario.Text = "Crear Nuevo Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtCorreoNewUsu
            // 
            this.txtCorreoNewUsu.Location = new System.Drawing.Point(270, 118);
            this.txtCorreoNewUsu.Name = "txtCorreoNewUsu";
            this.txtCorreoNewUsu.Size = new System.Drawing.Size(181, 20);
            this.txtCorreoNewUsu.TabIndex = 11;
            // 
            // lblValido
            // 
            this.lblValido.AutoSize = true;
            this.lblValido.Location = new System.Drawing.Point(461, 120);
            this.lblValido.Name = "lblValido";
            this.lblValido.Size = new System.Drawing.Size(94, 13);
            this.lblValido.TabIndex = 12;
            this.lblValido.Text = "Valido o No Valido";
            // 
            // NewUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 398);
            this.Controls.Add(this.lblValido);
            this.Controls.Add(this.txtCorreoNewUsu);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.txtRepPassNewUsu);
            this.Controls.Add(this.txtPassNewUsu);
            this.Controls.Add(this.txtApeNewUsu);
            this.Controls.Add(this.txtNomNewUsu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Nuevo Usuario";
            this.Load += new System.EventHandler(this.NewUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomNewUsu;
        private System.Windows.Forms.TextBox txtApeNewUsu;
        private System.Windows.Forms.TextBox txtPassNewUsu;
        private System.Windows.Forms.TextBox txtRepPassNewUsu;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtCorreoNewUsu;
        private System.Windows.Forms.Label lblValido;
    }
}