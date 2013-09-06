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
    public partial class SeguimientoCasos : Form
    {
        public SeguimientoCasos()
        {
            InitializeComponent();
        }

        public void actualizatabla() {

            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnection.Open();


            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "select id_caso from tblcaso;";
            da.SelectCommand = new MySqlCommand(sql, myConnection);
            da.Fill(ds);
            cmbid.DataSource = ds.Tables[0];
            cmbid.DisplayMember = "id_caso";
            cmbid.ValueMember = "id_caso";



            string query = "select t1.id_caso As 'ID Caso', t2.nom_user as Usuario, t1.fecha as Fecha , t1.descripcion as 'Descripcion del Caso' , t1.estado as 'Estado del Caso'from tblcaso as t1, tblusuario as t2 where  t1.id_user=t2.id_user;";
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(query, myConnection);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;
        }

        private void SeguimientoCasos_Load(object sender, EventArgs e)
        {

            actualizatabla();
         
        }

        private void butact_Click(object sender, EventArgs e)
        {
            string idcaso = cmbid.SelectedValue.ToString();
            string estado="";

            conexion con = new conexion();
            con.Conectar();

            if (chkpend.Checked == true && chkresu.Checked == false)
            { 
                estado="Pendiente";                
                con.actualiza_estado(idcaso, estado);
                con.Desconectar();
                actualizatabla();
                chkpend.Checked = false;
            }
            if (chkresu.Checked == true && chkpend.Checked == false)
            { 
                estado="Resuelto";
                con.actualiza_estado(idcaso, estado);
                con.Desconectar();
                actualizatabla();
                chkresu.Checked = false;
            }

            if (chkresu.Checked == true && chkpend.Checked == true)
            {
                chkpend.Checked = false;
                chkresu.Checked = false;
                MessageBox.Show("Solo debe escojer una opcion","Error");
            }

   
        }




        
      
    }
}
