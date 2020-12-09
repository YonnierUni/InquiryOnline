using IO.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace IO.Vistas
{
    public partial class Registro : System.Web.UI.Page
    {
        GestionDatos objGestionDatos = new GestionDatos();

        protected void registrarPersona(object sender, EventArgs e)
        {
            Usuario unUsuario = new Usuario();


            unUsuario.NombreUsuario = usuario.Value;
            unUsuario.Correo = email.Value;
            unUsuario.Contrasena = contrasena1.Value;
            
            bool agregado = objGestionDatos.agregarPersona(unUsuario);

            if (agregado)
            {
                Response.Redirect("IniciarSesion.aspx");
            }
            else
            {
                
            }
        }
        
        protected void limpiar()
        {
            usuario.Value = "";
            empresa.Value = "";
            email.Value = "";
        }
    }
}