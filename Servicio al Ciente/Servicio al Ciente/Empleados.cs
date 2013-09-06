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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {

            RegistroEmpleado puest = new RegistroEmpleado();
            puest.MdiParent = this.MdiParent;
            puest.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Puestos_de_empleados puest = new Puestos_de_empleados();
            puest.MdiParent = this.MdiParent;
            puest.Show();
            this.Hide();
        }

      
       
    }
}
