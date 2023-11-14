using rwebSeguridad.srSisdav;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rwebSeguridad.forms
{
    public partial class fwfAutenticar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        public int RecuperaIdUsuario(string pNombreUsuario)
        {
            int nrIdUsuario = 0;

            srSisdav.Service1Client oUsuario = new srSisdav.Service1Client();

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
            if (RecuperaIdUsuario(rtxtUsuario.Value.Trim()) == 0)
            {
                //lblMensajeError.Text = "El usuario no existe";
                rtxtUsuario.Focus();
                return;
            }
            srSisdav.Service1Client oService = new srSisdav.Service1Client();
            clsUsuario oUsuario = oService.ObtieneUsuario(RecuperaIdUsuario(rtxtUsuario.Value.Trim()));
            Session.Add("sContrasenia", "0");
            if (rtxtContrasenia.Value == "Clave123456")
                Session["sContrasenia"] = "1";

            if (oUsuario.IdUsuario != 0)
            {
                cPasswordhash = CreaPasswordHash(rtxtContrasenia.Value, oUsuario.Salt.Trim());
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
                    if (Session["IdSistema"] != null)
                        Server.Transfer("wfAcceder.aspx?IdUsuario=" + oUsuario.IdUsuario.ToString());
                    else
                    {
                        DataTable dtRolUsuario = oService.ObtienepavRolUsuario2("NIdUsuario", oUsuario.IdUsuario.ToString(), "NIdEstadoRolUsuario", "1").Tables[0];
                        if (dtRolUsuario.Rows.Count == 1)
                        {
                            clsUsuarioLogueado oUsuarioL = new clsUsuarioLogueado();
                            oUsuarioL.IdUsuarioLogueado = 70000001;
                            oUsuarioL.IdUsuario = oUsuario.IdUsuario;
                            oUsuarioL.IdRolUsuario = Convert.ToInt32(dtRolUsuario.Rows[0]["IdRolUsuario"].ToString());
                            oUsuarioL.Llave = CreaLlave(DateTime.Now.ToString(), oUsuarioL.IdUsuario.ToString());
                            oUsuarioL.IdEstadoLlave = 1;
                            oUsuarioL.Fecha = DateTime.Now;
                            oUsuarioL.DireccionIP = "Sis Control Notarios";
                            oUsuarioL.DireccionHost = "";
                            oUsuarioL.DireccionDest = "";
                            int IdUsuarioLogueado = oService.AgregaUsuarioLogueado(oUsuarioL);

                            //clsSistema oSistema = oService.ObtieneSistema(Convert.ToInt32(Session["IdSistema"].ToString()));
                            Response.Redirect("/forms/WebForm1.aspx");
                        }
                        //else
                        //    lblMensajeError.Text = "No cuenta con rol asignado para el sistema";
                    }
                }
                else
                {
                    //lblMensajeError.Text = "El usuario y/o contraseña no son validos. Verifique e intente nuevamente";

                    //((clsUsuario)(Session["Usuario"])).IdUsuario = 0;
                }

            }
            rtxtContrasenia.Value = "";
            rtxtContrasenia.Focus();
        }
        public string CreaLlave(string Cadena, string pSalt)
        {
            string cUnion, cPassHashSalt;
            cUnion = string.Concat(Cadena, pSalt);
            cPassHashSalt = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cPassHashSalt;
        }
    }
}