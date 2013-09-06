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
    public partial class Solucion : Form
    {
        public Solucion()
        {
            InitializeComponent();
        }

        private void btinsertar_Click(object sender, EventArgs e)
        {
            string detalle = cmbdetalle.SelectedValue.ToString();
            string tipo = txttipo.Text;
            string descripcion = txttipo.Text;


            conexion con = new conexion();


            con.Conectar();

            con.inserta_det(tipo, descripcion, detalle);
            con.Desconectar();
            cmbdetalle.Text = "";
        }

        private void Solucion_Load(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "select id_detaosop from tbldetasoporte;";
            da.SelectCommand = new MySqlCommand(sql, myConnection);
            da.Fill(ds);
            cmbdetalle.DataSource = ds.Tables[0];
            cmbdetalle.DisplayMember = "id_detaosop";
            cmbdetalle.ValueMember = "id_detaosop";
            myConnection.Close();
            
        }
    }
}
