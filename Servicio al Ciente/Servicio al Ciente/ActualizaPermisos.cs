using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexion;
using MySql.Data.MySqlClient;


namespace Servicio_al_Ciente
{
    public partial class ActualizaPermisos : Form
    {
        public ActualizaPermisos()
        {
            InitializeComponent();
        }

        public void actualizatabla() { 
                    
    

            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnection.Open();


            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "select id_user, nom_user from tblusuario;";
            da.SelectCommand = new MySqlCommand(sql, myConnection);
            da.Fill(ds);
            cmbuser.DataSource = ds.Tables[0];
            cmbuser.DisplayMember = "nom_user";
            cmbuser.ValueMember = "id_user";


            string query1 = "select id_user as ID, concat(nom_user, ' ', ape_user) as Nombre, user_user as Usuario, id_tipo as Permisos from tblusuario where id_tipo=1;";
            DataTable dtDatos1 = new DataTable();
            MySqlDataAdapter mdaDatos1 = new MySqlDataAdapter(query1, myConnection);
            mdaDatos1.Fill(dtDatos1);
            dataGridView1.DataSource = dtDatos1;


            string query2 = "select id_user as ID, concat(nom_user, ' ', ape_user) as Nombre, user_user as Usuario, id_tipo as Permisos from tblusuario where id_tipo=2 ;";
            DataTable dtDatos2 = new DataTable();
            MySqlDataAdapter mdaDatos2 = new MySqlDataAdapter(query2, myConnection);
            mdaDatos2.Fill(dtDatos2);
            dataGridView2.DataSource = dtDatos2;
        
        
        }

        private void ActualizaPermisos_Load(object sender, EventArgs e)
        {
            actualizatabla();
        }

        private void butact_Click(object sender, EventArgs e)
        {

            string iduser = cmbuser.SelectedValue.ToString();
            string estado = "";

            conexion con = new conexion();
            con.Conectar();

            if (chkadmin.Checked == true && chkuser.Checked == false)
            {
                estado = "1";
                con.actualiza_rol(estado, iduser);
                con.Desconectar();
                actualizatabla();
                chkadmin.Checked = false;
                MessageBox.Show("Se actualizo correctamente", "Mensaje");
               

            }
            if (chkuser.Checked == true && chkadmin.Checked == false)
            {
                estado = "2";
                con.actualiza_rol(estado, iduser);
                con.Desconectar();
                actualizatabla();
                chkuser.Checked = false;
                MessageBox.Show("Se actualizo correctamente", "Mensaje");
            }

            if (chkuser.Checked == true && chkadmin.Checked == true)
            {
                chkadmin.Checked = false;
                chkuser.Checked = false;
                MessageBox.Show("Solo debe escojer una opcion", "Error");
            }
        }
    }
}
