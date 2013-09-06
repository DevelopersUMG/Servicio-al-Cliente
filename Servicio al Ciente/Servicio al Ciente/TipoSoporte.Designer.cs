namespace Servicio_al_Ciente
{
    partial class TipoSoporte
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_cost = new System.Windows.Forms.TextBox();
            this.text_area = new System.Windows.Forms.TextBox();
            this.text_tipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.text_cost);
            this.groupBox1.Controls.Add(this.text_area);
            this.groupBox1.Controls.Add(this.text_tipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de tipos de soporte";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_cost
            // 
            this.text_cost.Location = new System.Drawing.Point(248, 224);
            this.text_cost.Name = "text_cost";
            this.text_cost.Size = new System.Drawing.Size(191, 29);
            this.text_cost.TabIndex = 5;
            // 
            // text_area
            // 
            this.text_area.Location = new System.Drawing.Point(248, 136);
            this.text_area.Name = "text_area";
            this.text_area.Size = new System.Drawing.Size(191, 29);
            this.text_area.TabIndex = 4;
            // 
            // text_tipo
            // 
            this.text_tipo.Location = new System.Drawing.Point(248, 64);
            this.text_tipo.Name = "text_tipo";
            this.text_tipo.Size = new System.Drawing.Size(191, 29);
            this.text_tipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(91, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo de soporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(96, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area de soporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(97, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de soporte";
            // 
            // TipoSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.ClientSize = new System.Drawing.Size(629, 470);
            this.Controls.Add(this.groupBox1);
            this.Name = "TipoSoporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoSoporte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_area;
        private System.Windows.Forms.TextBox text_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_cost;
    }
}