using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de Persona
/// </summary>
/// 
namespace IO.App_Code
{
    public class Persona
    {
        private int idUsuario;
        private string usuario;
        private string email;
        private string contrasena;
       

        public Persona()
        {

        }

        public Persona(string usuario, string email, string contrasena)
        {

            this.usuario = usuario;
            this.email = email;
            this.contrasena = contrasena;

        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }


    }
}