using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

using IO.App_Code;
namespace IO
{
    public partial class IO : System.Web.UI.Page
    {
        GestionDatos objGestionDatos = new GestionDatos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Persona unaPersona = new Persona();
            unaPersona.Usuario = usuario.Value;
            unaPersona.Email = email.Value;
            unaPersona.Contrasena = contrasena.Value;
            bool agregado=false;
           // bool agregado = objGestionDatos.agregarPersona(unaPersona);

            if (agregado)
            {
                lblMensaje.Text = "Persona Agregada a la Base de Datos";

                 limpiar();

            }
            else
            {
                lblMensaje.Text = objGestionDatos.error + " este";
            }
        }
        private void limpiar()
        {
            usuario.Value = "";
            email.Value = "";
            contrasena.Value = "";
          
        }
    }
}