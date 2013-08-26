namespace Servicio_al_Ciente
{
    partial class Login
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
            this.button_login = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_contraseña = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_pas = new System.Windows.Forms.TextBox();
            this.linkLabel_registrarse = new System.Windows.Forms.LinkLabel();
            this.linkLabel_recuperar = new System.Windows.Forms.LinkLabel();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(279, 140);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 33);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(17, 140);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 33);
            this.button_salir.TabIndex = 1;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(22, 44);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(90, 22);
            this.label_usuario.TabIndex = 2;
            this.label_usuario.Text = "Usuario: ";
            // 
            // label_contraseña
            // 
            this.label_contraseña.AutoSize = true;
            this.label_contraseña.Font = new System.Drawing.Font("Forte", 15.75F);
            this.label_contraseña.Location = new System.Drawing.Point(22, 92);
            this.label_contraseña.Name = "label_contraseña";
            this.label_contraseña.Size = new System.Drawing.Size(124, 22);
            this.label_contraseña.TabIndex = 3;
            this.label_contraseña.Text = "Contraseña: ";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(254, 48);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(100, 24);
            this.text_user.TabIndex = 4;
            // 
            // text_pas
            // 
            this.text_pas.Location = new System.Drawing.Point(254, 92);
            this.text_pas.Name = "text_pas";
            this.text_pas.Size = new System.Drawing.Size(100, 24);
            this.text_pas.TabIndex = 5;
            this.text_pas.UseSystemPasswordChar = true;
            // 
            // linkLabel_registrarse
            // 
            this.linkLabel_registrarse.AutoSize = true;
            this.linkLabel_registrarse.Location = new System.Drawing.Point(120, 241);
            this.linkLabel_registrarse.Name = "linkLabel_registrarse";
            this.linkLabel_registrarse.Size = new System.Drawing.Size(60, 13);
            this.linkLabel_registrarse.TabIndex = 6;
            this.linkLabel_registrarse.TabStop = true;
            this.linkLabel_registrarse.Text = "Registrarse";
            this.linkLabel_registrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_recuperar
            // 
            this.linkLabel_recuperar.AutoSize = true;
            this.linkLabel_recuperar.Location = new System.Drawing.Point(303, 241);
            this.linkLabel_recuperar.Name = "linkLabel_recuperar";
            this.linkLabel_recuperar.Size = new System.Drawing.Size(113, 13);
            this.linkLabel_recuperar.TabIndex = 7;
            this.linkLabel_recuperar.TabStop = true;
            this.linkLabel_recuperar.Text = "Recuperar contraseña";
            this.linkLabel_recuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.label_usuario);
            this.groupBox_login.Controls.Add(this.label_contraseña);
            this.groupBox_login.Controls.Add(this.text_user);
            this.groupBox_login.Controls.Add(this.button_login);
            this.groupBox_login.Controls.Add(this.button_salir);
            this.groupBox_login.Controls.Add(this.text_pas);
            this.groupBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox_login.Location = new System.Drawing.Point(52, 35);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(398, 179);
            this.groupBox_login.TabIndex = 8;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Datos de Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 291);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.linkLabel_recuperar);
            this.Controls.Add(this.linkLabel_registrarse);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_contraseña;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_pas;
        private System.Windows.Forms.LinkLabel linkLabel_registrarse;
        private System.Windows.Forms.LinkLabel linkLabel_recuperar;
        private System.Windows.Forms.GroupBox groupBox_login;
    }
}