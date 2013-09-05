using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Servicio_al_Ciente
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario reg = new RegistroUsuario();
            reg.MdiParent = this;
            reg.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizaDatos act = new ActualizaDatos();
            act.MdiParent = this;
            act.Show();
        }

        private void recuperacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecuperaUsuario rec = new RecuperaUsuario();
            rec.MdiParent = this;
            rec.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.MdiParent = this;
            emp.Show();
        }

        private void soportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSoporte ts = new TipoSoporte();
            ts.MdiParent = this;
            ts.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto();
            pro.MdiParent = this;
            pro.Show();
        }

    }
}
