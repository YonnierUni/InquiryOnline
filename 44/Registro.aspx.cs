using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IO.App_Code;
namespace IO
{
    public partial class Registro : System.Web.UI.Page
    {
        GestionDatos objGestionDatos = new GestionDatos();

        protected void registrarPersona(object sender, EventArgs e)
        {
            Persona unaPersona = new Persona();
            Empresa unaEmpresa = new Empresa();

            unaPersona.Usuario = usuario.Value;
            unaPersona.Email = email.Value;
            unaPersona.Contrasena = contrasena1.Value;
            unaEmpresa.NombreEmpresa = empresa.Value;
            bool agregado = objGestionDatos.agregarPersona(unaPersona,unaEmpresa);

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
        protected void limpiar(){
            usuario.Value = "";
            empresa.Value = "";
            email.Value = "";
        }

       
    }
}