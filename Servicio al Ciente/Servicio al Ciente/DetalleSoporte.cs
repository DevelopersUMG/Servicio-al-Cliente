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
    public partial class DetalleSoporte : Form
    {
        public DetalleSoporte()
        {
            InitializeComponent();
        }

        private void btinsertar_Click(object sender, EventArgs e)
        {
            string puesto = cmbpuesto.SelectedValue.ToString();
            string soporte = cmbsoporte.SelectedValue.ToString();


            conexion con = new conexion();


            con.Conectar();

            con.inserta_detalle(puesto, soporte);
            con.Desconectar();
            cmbpuesto.Text = "";
            cmbsoporte.Text = "";
        }

        private void DetalleSoporte_Load(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "select nom_puesto, id_puestoemp from tblpuestoempleado;";
            da.SelectCommand = new MySqlCommand(sql, myConnection);
            da.Fill(ds);
            cmbpuesto.DataSource = ds.Tables[0];
            cmbpuesto.DisplayMember = "nom_puesto";
            cmbpuesto.ValueMember = "id_puestoemp";
            myConnection.Close();

            MySqlConnection myConnectionn = new MySqlConnection();
            myConnectionn.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnectionn.Open();
            MySqlDataAdapter daa = new MySqlDataAdapter();
            DataSet dss = new DataSet();
            string sqll = "select id_caso from tblcaso;";
            daa.SelectCommand = new MySqlCommand(sqll, myConnection);
            daa.Fill(dss);
            cmbsoporte.DataSource = dss.Tables[0];
            cmbsoporte.DisplayMember = "id_caso";
            cmbsoporte.ValueMember = "id_caso";
        }
    }
}
