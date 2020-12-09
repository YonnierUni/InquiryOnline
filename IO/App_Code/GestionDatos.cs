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

        public bool agregarPersona(Usuario unUsuario)
        {
            bool agrega = false;
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion;

            comando.CommandText = "insert into usuario(NombreUsuario, Correo, Contraseña, Rol_idRol) values (@NombreUsuario,@Correo,@Contraseña, @Rol_idRol)";
            comando.Parameters.AddWithValue("@NombreUsuario", unUsuario.NombreUsuario);
            comando.Parameters.AddWithValue("@Correo", unUsuario.Correo);
            comando.Parameters.AddWithValue("@Contraseña", unUsuario.Contrasena);
            comando.Parameters.AddWithValue("@Rol_idRol",1);
            try
            {
                comando.ExecuteNonQuery();
                enviarCorreo(unUsuario);
                agrega = true;
            }
            catch (MySqlException ex)
            {
                this.error = ex.Message;
            }
            return agrega;
        }

        public void enviarCorreo(Usuario unUsuario)
        {

            string body = "<h1>Hola</h1><br>" + "Felicitaciones por el registro<br>" + "Usuario:" + unUsuario.NombreUsuario + "<br>Contraseña:" + unUsuario.Contrasena;

            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Credentials = new NetworkCredential("andres.skyred@gmail.com", "skap.m.2001");//Cuenta de correo
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("andres.skyred@gmail.com", "Inquiry Online");//Correo de salida
            correo.To.Add(new MailAddress(unUsuario.Correo)); //Correo destino?
            correo.Subject = "Bienvenido a Inquiry Online"; //Asunto
            correo.Body = body;
            correo.IsBodyHtml = true;

            smtp.Send(correo);
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