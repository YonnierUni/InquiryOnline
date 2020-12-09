using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace IO.App_Code
{
    public class Empresa
    {
        private int idEmpresa;
        private string nombreEmpresa;

        public Empresa()
        {

        }
        public Empresa(string nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;
        }
        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
    }
}