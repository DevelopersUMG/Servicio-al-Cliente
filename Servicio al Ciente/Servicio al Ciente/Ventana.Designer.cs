namespace Servicio_al_Ciente
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_menu_principal = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter_menu = new System.Windows.Forms.Splitter();
            this.button_menu = new System.Windows.Forms.Button();
            this.menuStrip_menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_menu_principal
            // 
            this.menuStrip_menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.menuStrip_menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_menu_principal.Name = "menuStrip_menu_principal";
            this.menuStrip_menu_principal.Size = new System.Drawing.Size(727, 24);
            this.menuStrip_menu_principal.TabIndex = 2;
            this.menuStrip_menu_principal.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.recuperacionToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            this.actualizacionToolStripMenuItem.Click += new System.EventHandler(this.actualizacionToolStripMenuItem_Click);
            // 
            // recuperacionToolStripMenuItem
            // 
            this.recuperacionToolStripMenuItem.Name = "recuperacionToolStripMenuItem";
            this.recuperacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recuperacionToolStripMenuItem.Text = "Recuperacion";
            this.recuperacionToolStripMenuItem.Click += new System.EventHandler(this.recuperacionToolStripMenuItem_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar Session";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // splitter_menu
            // 
            this.splitter_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitter_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_menu.Location = new System.Drawing.Point(0, 24);
            this.splitter_menu.Name = "splitter_menu";
            this.splitter_menu.Size = new System.Drawing.Size(189, 457);
            this.splitter_menu.TabIndex = 4;
            this.splitter_menu.TabStop = false;
            this.splitter_menu.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.button_menu.Location = new System.Drawing.Point(25, 60);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(115, 28);
            this.button_menu.TabIndex = 5;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 481);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.splitter_menu);
            this.Controls.Add(this.menuStrip_menu_principal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_menu_principal;
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio al Cliente (Prototipo)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip_menu_principal.ResumeLayout(false);
            this.menuStrip_menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_menu_principal;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter_menu;
        private System.Windows.Forms.Button button_menu;
    }
}

