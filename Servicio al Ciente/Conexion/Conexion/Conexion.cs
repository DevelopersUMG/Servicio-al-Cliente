using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Data;
using System.Collections;



namespace Conexion
{
    public class conexion
    {
        MySqlConnection Connection = new MySqlConnection();
        public String usu;
        public String pas;
        public String id;

        public String CadenaDeConexion = "Server=localhost;"
                                       + "Port=3306;"
                                       + "Database=servicioalcliente;"
                                       + "Uid=root;"
                                       + "Password=toor";
   
 

        static MySqlCommand cmd = new MySqlCommand();
        static MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        //**

       
        // variables de logeo de session
        public Boolean session = false;
        public int estado;


        public void Conectar()
        {
            try
            {
                Connection.ConnectionString = CadenaDeConexion;
                Connection.Open();
            }
            catch (MySqlException)
            {
                //MessageBox.Show("Error al conectar a la base de datos");
                throw;
            }
        }
           


        public void Desconectar() {
            Connection.Close();        
        }


        public void consulta_log(String user, String pass) {

         

            MySqlCommand query = Connection.CreateCommand();

            //query.CommandText = "select user_user,pass_user from tblusuario where user_user='"+user+"' and pass_user='"+pass+"';";

            query.CommandText = "select user_user,pass_user,id_tipo from tblusuario where user_user='"+user+"' and pass_user='"+pass+"';";

            MySqlDataReader reader = query.ExecuteReader();
            
            int id1;
          

            while (reader.Read())
            {
                usu = reader["user_user"].ToString();
                pas = reader["pass_user"].ToString();
                id = reader["id_tipo"].ToString();

                id1 = Convert.ToInt32(id);
            }
           
        }




        public void inserta_user( string nom, string ape, string cor, string user,string pas,string nac,string tel,string sex) {


                string campos = "(nom_user,ape_user,cor_user,user_user,pass_user,nac_user,te_user,sexo_user,id_tipo)";
                string strSQL = "insert into tblusuario"+campos+" values('"+nom+"','"+ape+"','"+cor+"','"+user+"','"+pas+"','"+nac+"','"+tel+"','"+sex+"',2);";
                cmd.CommandText = strSQL;
                cmd.Connection = Connection;
                cmd.ExecuteNonQuery();          
       
        }

        public void inserta_producto(string nompr, string tipo, string cant, string precio)
        {


            string campos = "(nom_prod,tipo_prod,cant_inventario,precio)";
            string strSQL = "insert into tblproducto" + campos + " values('" + nompr + "','" + tipo + "','" + cant + "','" + precio + "');";
            cmd.CommandText = strSQL;
            cmd.Connection = Connection;
            cmd.ExecuteNonQuery();

        }
        
        public void Correo(string opcion, string campo) {

            string id = "";
            string nom = "";
            string ape = "";
            string cor = "";
            string use = "";
            string pas = "";
            string nac = "";
            string tel = "";
            string sex = "";

            MySqlCommand query = Connection.CreateCommand();

            if (opcion == "Correo")
            {
                query.CommandText = "select *from tblusuario where cor_user = '"+campo+"';";
            }
            if (opcion == "Usuario")
            {
                query.CommandText = "select *from tblusuario where user_user = '" + campo + "';";
            }

            

            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                id = reader["id_user"].ToString();
                nom = reader["nom_user"].ToString();
                ape = reader["ape_user"].ToString();
                cor = reader["cor_user"].ToString();
                use = reader["user_user"].ToString();
                pas = reader["pass_user"].ToString();
                nac = reader["nac_user"].ToString();
                tel = reader["te_user"].ToString();
                sex = reader["sexo_user"].ToString();
            }


            string cuerpo = "ID: " + id + "\n"
                         + "Nombre: " + nom + " " + ape + "\n"
                         + "Correo: " + cor + "\n"
                         + "Usuario: " + use + "\n"
                         + "Contraseña: " + pas + "\n"
                         + "Fecha de Nacimiento: " + nac + "\n"
                         + "Telefono: " + tel + "\n"
                         + "Sexo: " + sex + "\n";
            EnviaCorreo(cuerpo,cor);
        }


        public void EnviaCorreo(string cuerpo,string correo) {

            try{
              MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");               
                mail.From = new MailAddress("estandares.adst@gmail.com", "Estandares ADST", Encoding.UTF8);             
                mail.Subject = "Recuperacion de datos";              
                mail.Body = "Se envia datos se recomienda cambiar su contraseña\n\n"+cuerpo;               
                //mail.To.Add("joseph.ajcan@hotmail.com");   
                mail.To.Add(correo); 
                //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));
                                
                SmtpServer.Port = 587;              
                SmtpServer.Credentials = new System.Net.NetworkCredential("estandares.adst@gmail.com", "umg.edu.gt");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                //return true;
            }
            catch (Exception ex)
            {
               // return false;
            }

        }


        
        

        
    }
}
