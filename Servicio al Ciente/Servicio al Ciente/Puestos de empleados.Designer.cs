namespace Servicio_al_Ciente
{
    partial class Puestos_de_empleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_permisos = new System.Windows.Forms.TextBox();
            this.textbox_salario = new System.Windows.Forms.TextBox();
            this.textbox_puesto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textbox_permisos);
            this.groupBox1.Controls.Add(this.textbox_salario);
            this.groupBox1.Controls.Add(this.textbox_puesto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de ingreso de puesto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(102, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textbox_permisos
            // 
            this.textbox_permisos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_permisos.Location = new System.Drawing.Point(284, 234);
            this.textbox_permisos.Name = "textbox_permisos";
            this.textbox_permisos.Size = new System.Drawing.Size(100, 29);
            this.textbox_permisos.TabIndex = 6;
            // 
            // textbox_salario
            // 
            this.textbox_salario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_salario.Location = new System.Drawing.Point(284, 148);
            this.textbox_salario.Name = "textbox_salario";
            this.textbox_salario.Size = new System.Drawing.Size(100, 29);
            this.textbox_salario.TabIndex = 5;
            // 
            // textbox_puesto
            // 
            this.textbox_puesto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_puesto.Location = new System.Drawing.Point(284, 76);
            this.textbox_puesto.Name = "textbox_puesto";
            this.textbox_puesto.Size = new System.Drawing.Size(100, 29);
            this.textbox_puesto.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(297, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(99, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(99, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(99, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del puesto";
            // 
            // Puestos_de_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.ClientSize = new System.Drawing.Size(580, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "Puestos_de_empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puestos de empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_permisos;
        private System.Windows.Forms.TextBox textbox_salario;
        private System.Windows.Forms.TextBox textbox_puesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}