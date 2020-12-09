using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

//para enviar el imeil
using System.Net.Mail;
using System.Configuration;
using System.Web.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
/// <summary>
/// Descripción breve de GestionDatos
/// </summary>
/// 
namespace IO.App_Code
{
    public class GestionDatos
    {
        public MySqlConnection conexion;
        public MySqlTransaction transaccion;
        public string error;
        public GestionDatos()
        {

            this.conexion = Conexion.getConexion();
        }

        public bool agregarPersona(Persona unaPersona, Empresa unaEmpresa)
        {
            bool agrega = false;
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion;

            comando.CommandText = "insert into Usuario values (@idUsuario,@nombreUsuario,@correo,@contraseña)";
            comando.Parameters.AddWithValue("@idUsuario", 0);
            comando.Parameters.AddWithValue("@nombreUsuario", unaPersona.Usuario);
            comando.Parameters.AddWithValue("@correo", unaPersona.Email);
            comando.Parameters.AddWithValue("@contraseña", unaPersona.Contrasena);

            try
            {
                comando.ExecuteNonQuery();
                agregarEmpresa(unaEmpresa);
               // enviarCorreo(unaPersona);
                agrega = true;
            }
            catch (MySqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }
        public bool agregarEmpresa(Empresa unaEmpresa)
        {
            bool agrega = false;
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion;

            comando.CommandText = "insert into Empresa values (@idEmpresa,@nombreEmpresa)";
            comando.Parameters.AddWithValue("@idEmpresa", 0);
            comando.Parameters.AddWithValue("@nombreEmpresa", unaEmpresa.NombreEmpresa);

            try
            {
                comando.ExecuteNonQuery();
                //enviarCorreo(unaPersona);
                agrega = true;
            }
            catch (MySqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }
        public bool enviarCorreo(Persona unaPersona){

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("uniyonnier@gmail.com", "Inquiry Online", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(unaPersona.Email); //Correo destino?
            correo.Subject = "Bienvenido a Inquiry Online"; //Asunto
            correo.Body = "Este es un correo de prueba desde c#"; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential(unaPersona.Email, unaPersona.Contrasena);//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
            return true;
        }
        /*
        public Cliente consultarClientePorCorreo(string correo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from Persona where Correo=@correo";
            comando.Parameters.AddWithValue("@correo", correo);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                Cliente unCliente = new Cliente();
                SqlCommand comando2 = new SqlCommand();
                comando2.Connection = conexion;
                comando2.CommandText = "select * from Cliente where Persona_idPersona=@id";
                comando2.Parameters.AddWithValue("@id", registro.GetInt32(0));
                registro.Close();

                SqlDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();



                unCliente.IdUsuario = registro2.GetInt32(0);
                unCliente.Contrasena = registro2.GetString(1);
                unCliente.Altura = registro2.GetInt32(2);
                unCliente.PesoActual = (float)5.5 ;
                unCliente.FechaRegistro = registro2.GetDateTime(4);
                unCliente.Persona_idPersona = registro2.GetInt32(5);
                unCliente.Rol = registro2.GetInt32(6);

                registro2.Close();
                return unCliente;
            }
            else
            {
                registro.Close();
                return null;
            }
        }
        /*
        public Cliente consultarClientePorCorreo(string Id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from Persona where idPersona=@id";
            comando.Parameters.AddWithValue("@id", Id);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                Cliente unCliente = new Cliente();
                SqlCommand comando2 = new SqlCommand();
                comando2.Connection = conexion;
                comando2.CommandText = "select * from Cliente where Persona_idPersona=@id";
                comando2.Parameters.AddWithValue("@id", Id);
                registro.Close();

                SqlDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();



                unCliente.IdUsuario = registro2.GetInt32(0);
                unCliente.Contrasena = registro2.GetString(1);
                unCliente.Altura = registro2.GetInt32(2);
                unCliente.PesoActual = (float)5.5;
                unCliente.FechaRegistro = registro2.GetDateTime(4);
                unCliente.Persona_idPersona = registro2.GetInt32(5);
                unCliente.Rol = registro2.GetInt32(6);

                registro2.Close();
                return unCliente;
            }
            else
            {
                registro.Close();
                return null;
            }
        }
        /*
        public List<Persona> listarPersonas()
        {
            List<Persona> listaDePersonas = new List<Persona>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from personas";
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                Persona unaPersona = new Persona();
                unaPersona.IdPersona = registro.GetInt32(0);
                unaPersona.Identificacion = registro.GetString(1);
                unaPersona.Nombres = registro.GetString(2);
                unaPersona.Apellidos = registro.GetString(3);
                unaPersona.Genero = registro.GetString(4);
                unaPersona.Correo = registro.GetString(5);
                unaPersona.FechaNacimiento = registro.GetDateTime(6);
                listaDePersonas.Add(unaPersona);
            }
            registro.Close();
            return listaDePersonas;
        }
        */

    }
}