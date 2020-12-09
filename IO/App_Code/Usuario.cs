using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO.App_Code
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string correo;
        private string contrasena;

        public Usuario(){}
        public Usuario(string nombreUsuario, string correo, string contrasena)
        {
            this.nombreUsuario = nombreUsuario;
            this.correo = correo;
            this.contrasena = contrasena;
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}