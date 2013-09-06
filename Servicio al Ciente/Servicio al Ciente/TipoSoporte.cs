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
    public partial class TipoSoporte : Form
    {
        public TipoSoporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();
            string tipo = text_tipo.Text;
            string area = text_area.Text;

            string costo = text_cost.Text;
            try
            {
                con.Conectar();
                con.inserta_soport(tipo, area, costo);
                con.Desconectar();

                text_tipo.Text = "";
                text_area.Text = "";
                text_cost.Text = "";


                MessageBox.Show("Registro exitoso");

            }
            catch
            {
                MessageBox.Show("Error de registro de datos");
            }
        }
    }
}
