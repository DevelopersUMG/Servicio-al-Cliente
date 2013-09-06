namespace Servicio_al_Ciente
{
    partial class SeguimientoCasos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkpend = new System.Windows.Forms.CheckBox();
            this.chkresu = new System.Windows.Forms.CheckBox();
            this.txt_act = new System.Windows.Forms.Label();
            this.butact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(728, 44);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(87, 28);
            this.cmbid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butact);
            this.groupBox1.Controls.Add(this.txt_act);
            this.groupBox1.Controls.Add(this.chkresu);
            this.groupBox1.Controls.Add(this.chkpend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmbid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizacion de estados de casos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID de caso";
            // 
            // chkpend
            // 
            this.chkpend.AutoSize = true;
            this.chkpend.Location = new System.Drawing.Point(626, 134);
            this.chkpend.Name = "chkpend";
            this.chkpend.Size = new System.Drawing.Size(100, 24);
            this.chkpend.TabIndex = 5;
            this.chkpend.Text = "Pendiente";
            this.chkpend.UseVisualStyleBackColor = true;
            // 
            // chkresu
            // 
            this.chkresu.AutoSize = true;
            this.chkresu.Location = new System.Drawing.Point(626, 199);
            this.chkresu.Name = "chkresu";
            this.chkresu.Size = new System.Drawing.Size(92, 24);
            this.chkresu.TabIndex = 6;
            this.chkresu.Text = "Resuelto";
            this.chkresu.UseVisualStyleBackColor = true;
            // 
            // txt_act
            // 
            this.txt_act.AutoSize = true;
            this.txt_act.Location = new System.Drawing.Point(690, 333);
            this.txt_act.Name = "txt_act";
            this.txt_act.Size = new System.Drawing.Size(79, 20);
            this.txt_act.TabIndex = 7;
            this.txt_act.Text = "Actualizar";
            // 
            // butact
            // 
            this.butact.BackColor = System.Drawing.Color.DimGray;
            this.butact.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.Sync;
            this.butact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butact.Location = new System.Drawing.Point(694, 258);
            this.butact.Name = "butact";
            this.butact.Size = new System.Drawing.Size(75, 72);
            this.butact.TabIndex = 8;
            this.butact.UseVisualStyleBackColor = false;
            this.butact.Click += new System.EventHandler(this.butact_Click);
            // 
            // SeguimientoCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 474);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeguimientoCasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion de casos";
            this.Load += new System.EventHandler(this.SeguimientoCasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkresu;
        private System.Windows.Forms.CheckBox chkpend;
        private System.Windows.Forms.Button butact;
        private System.Windows.Forms.Label txt_act;
    }
}