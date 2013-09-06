using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexion;

namespace Servicio_al_Ciente
{
    public partial class RecuperaUsuario : Form
    {
        public RecuperaUsuario()
        {
            InitializeComponent();
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            Log frm = new Log();
            frm.Show();
            this.Hide();
        }

        private void button_recuperar_Click(object sender, EventArgs e)
        {
            string opcion = combobox_opcion.SelectedItem.ToString();
            string campo = text_informacion.Text;

            conexion con = new conexion();

            try
            {
                con.Conectar();
                con.Correo(opcion, campo);
                con.Desconectar();
                MessageBox.Show("Sus datos se enviaron correctamente");
            }
            catch {
                MessageBox.Show("Error al envaier correo electronico");
            }
            
        }

        
    }
}
