using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexion;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;


namespace Servicio_al_Ciente
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

   

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;");
            MySqlDataAdapter sql = new MySqlDataAdapter("select nom_puesto from tblpuestoempleado;",conn);

            DataTable dt = new DataTable();
            sql.Fill(dt);

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i]["nom_puesto"]);
                }
            }
            catch (MySqlException erro)
            {
                throw erro;
            }
            finally {
                conn.Close();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados puest = new Empleados();
            puest.Show();
            this.Hide();
           
        }
    }
}
