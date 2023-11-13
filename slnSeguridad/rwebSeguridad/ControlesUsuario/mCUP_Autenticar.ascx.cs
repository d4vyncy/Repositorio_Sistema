using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Data;
using System.Web.Security;

namespace rwebSeguridad.ControlesUsuario
{
    public partial class mCUP_Autenticar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
        }

        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        public int RecuperaIdUsuario(string pNombreUsuario)
        {
            int nrIdUsuario = 0;

            srSeguridad.Service1Client oUsuario = new Service1Client();

            DataTable dt = oUsuario.ObtienepavUsuario1("LNombreUsuario", pNombreUsuario).Tables[0];  // Revisar cuando tiene mas de dos roles un usuario
            // if (dt.Rows.Count == 1)
            if (dt.Rows.Count > 0)
            {
                nrIdUsuario = Convert.ToInt32(dt.Rows[0]["IdUsuario"]);
            }
            else
            {
                nrIdUsuario = 0;
            }
            return nrIdUsuario;
        }

        public string CreaPasswordHash(string pPassword, string pSalt)
        {
            string cUnion, cPassHashSalt;
            cUnion = string.Concat(pPassword, pSalt);
            cPassHashSalt = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cPassHashSalt;
        }

        public string CreaLLave(string pHostname, string pIp)
        {
            string cUnion, cLLave;
            cUnion = string.Concat(pHostname, pIp);
            cLLave = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cLLave;
        }

        void Autenticar()
        {
            string cPasswordhash = string.Empty;
            if (RecuperaIdUsuario(rtxtUsuario.Text.Trim()) == 0)
            {
                lblMensajeError.Text = "El usuario no existe";
                rtxtUsuario.Focus();
                return;
            }
            srSeguridad.Service1Client oService = new Service1Client();
            clsUsuario oUsuario = oService.ObtieneUsuario(RecuperaIdUsuario(rtxtUsuario.Text.Trim()));
            Session.Add("sContrasenia", "0");
            if (rtxtContrasenia.Text == "Clave123456")
                Session["sContrasenia"] = "1";

            if (oUsuario.IdUsuario != 0)
            {
                cPasswordhash = CreaPasswordHash(rtxtContrasenia.Text, oUsuario.Salt.Trim());
                if (oUsuario.IdUsuario != 0 && cPasswordhash == oUsuario.Clave)//preguntara si existe usuario y si la clave/usuario estan bien
                {
                    DataTable dt = oService.ObtienepavUsuarioLogueado2("NIdUsuario", oUsuario.IdUsuario.ToString(), "NIdEstadoLlave", "1").Tables[0];
                    clsUsuarioLogueado oUsuarioLogueado;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        oUsuarioLogueado = oService.ObtieneUsuarioLogueado(Convert.ToInt32(dt.Rows[i]["IdUsuarioLogueado"].ToString()));
                        oUsuarioLogueado.IdEstadoLlave = 2;
                        oService.ModificaUsuarioLogueado(oUsuarioLogueado);
                    }
                    Server.Transfer("mwfAcceder.aspx?IdUsuario=" + oUsuario.IdUsuario.ToString());
                }
                else
                {
                    lblMensajeError.Text = "El usuario y/o contraseña no son validos. Verifique e intente nuevamente";
                }   
            }
            rtxtContrasenia.Text = "";
            rtxtContrasenia.Focus();
        }

        protected void btnAutenticar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            rtxtUsuario.Text = "";
            rtxtContrasenia.Text = "";
        }
    }
}