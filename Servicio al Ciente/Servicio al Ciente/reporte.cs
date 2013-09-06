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

namespace Servicio_al_Ciente
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
          
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_ingresar_Click(object sender, EventArgs e)
        {
             conexion con = new conexion();

            int iduser = Convert.ToInt32(Conexion.conexion.iduser);

            string sop = cmb_sop.SelectedValue.ToString();
            string fech = dt_fech.Text;
            string prod = cmb_prod.SelectedValue.ToString();
            string descr = text_descr.Text;


            try
            {
            
            con.Conectar();
            con.inserta_caso(sop,fech,prod,descr,iduser);
            con.Desconectar();

            cmb_sop.Text = "";
            dt_fech.Text = "";
            cmb_prod.Text = "";
            text_descr.Text = "";
            MessageBox.Show("Registro exitoso");

            }
  catch
  {
      MessageBox.Show("Error de registro de datos");
  }     
        }



        private void Reporte_Load(object sender, EventArgs e)
        {
           
            

            int iduser = Convert.ToInt32(Conexion.conexion.iduser);
           // MessageBox.Show(iduser.ToString());

            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnection.Open();


          

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "select  id_tiposop, tipo_sop from tbltiposoporte;";
            da.SelectCommand = new MySqlCommand(sql, myConnection);
            da.Fill(ds);
            cmb_sop.DataSource = ds.Tables[0];
            cmb_sop.DisplayMember = "tipo_sop";
            cmb_sop.ValueMember = "id_tiposop";
            myConnection.Close();

          
            MySqlDataAdapter daa = new MySqlDataAdapter();
            DataSet dss = new DataSet();
            string sqll = "select id_prod, nom_prod from tblproducto;";
            daa.SelectCommand = new MySqlCommand(sqll, myConnection);
            daa.Fill(dss);
            cmb_prod.DataSource = dss.Tables[0];
            cmb_prod.DisplayMember = "nom_prod";
            cmb_prod.ValueMember = "id_prod";


            string query1 = "select id_caso as 'ID Caso',fecha as Fecha,descripcion as Descripcion, estado as Estado from tblcaso where id_user="+iduser+";";
            DataTable dtDatos1 = new DataTable();
            MySqlDataAdapter mdaDatos1 = new MySqlDataAdapter(query1, myConnection);
            mdaDatos1.Fill(dtDatos1);
            dataGridView1.DataSource = dtDatos1;

            string query2 = "select id_caso as 'ID Caso',fecha as Fecha,descripcion as Descripcion, estado as Estado from tblcaso where id_user="+iduser+" and estado ='Pendiente';";
            DataTable dtDatos2 = new DataTable();
            MySqlDataAdapter mdaDatos2 = new MySqlDataAdapter(query2, myConnection);
            mdaDatos2.Fill(dtDatos2);
            dataGridView2.DataSource = dtDatos2;

            string query3 = "select id_caso as 'ID Caso',fecha as Fecha,descripcion as Descripcion, estado as Estado from tblcaso where id_user="+iduser+" and estado ='Resuelto';";
            DataTable dtDatos3 = new DataTable();
            MySqlDataAdapter mdaDatos3 = new MySqlDataAdapter(query3, myConnection);
            mdaDatos3.Fill(dtDatos3);
            dataGridView3.DataSource = dtDatos3;





            
        }

      

       

    

     
        }
    
}
