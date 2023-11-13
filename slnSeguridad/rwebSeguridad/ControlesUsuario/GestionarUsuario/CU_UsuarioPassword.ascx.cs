using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Web.Security;
using System.Security.Cryptography;


namespace rwebSeguridad.ControlesUsuario.GestionUsuario
{
    public partial class CU_UsuarioPassword : System.Web.UI.UserControl
    {
        

        private object _dataItem = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void ObjetivoGestion_DataBinding(object sender, System.EventArgs e)
        {
            object IdSistema = DataBinder.Eval(DataItem, "IdSistema");
            if (!Convert.IsDBNull(IdSistema))
            {
                srSeguridad.Service1Client oService = new srSeguridad.Service1Client();
                clsSistema oSistema = oService.ObtieneSistema(Convert.ToInt32(IdSistema));
                // rddlTipoObjetivo.SelectedValue = oObjetivo.IdTipoObjetivo.ToString();
                //rddlIdObjetivoPadre.SelectedValue = oObjetivo.IdObjetivoPadre.ToString();
            }
        }

        public string CreaLLave(string pHostname, string pIp)
        {
            string cUnion, cLLave;
            cUnion = string.Concat(pHostname, pIp);
            cLLave = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cLLave;
        }

        public string CreaPasswordHash(string pPassword, string pSalt)
        {
            string cUnion, cPassHashSalt;
            cUnion = string.Concat(pPassword, pSalt);
            cPassHashSalt = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cPassHashSalt;
        }

        private string CreaSalt(int Tamano)
        {
            Byte[] bytSalt = new Byte[5];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytSalt);
            return Convert.ToBase64String(bytSalt);
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string cPasswordhash = string.Empty;
            
            srSeguridad.Service1Client oSrSeguridad = new Service1Client();
            clsUsuario oUsuario =oSrSeguridad.ObtieneUsuario(Convert.ToInt32(Session["tIdUsuario"].ToString()));
            cPasswordhash = CreaPasswordHash(rtxtPasswordActual.Text, oUsuario.Salt.Trim());
            if ( cPasswordhash == oUsuario.Clave  )
            {
                if (rtxtNuevoPassword.Text.Trim().Length > 5)
                {
                    if (rtxtNuevoPassword.Text.Trim() == rtxtNuevoPasswordDuplicado.Text.Trim())
                    {
                        string cSalt = CreaSalt(4);
                        string cClave = CreaPasswordHash(rtxtNuevoPassword.Text, cSalt);

                        oUsuario.Clave = cClave;
                        oUsuario.Salt = cSalt;
                        oSrSeguridad.ModificaUsuario(oUsuario);
                        lblMensaje.Text="CORRECTO";
                        try
                        {
                            Service1Client oService = new Service1Client();
                            Session["Usuario"] = null;
                            Session["UsuarioLogueado"] = null;
                            Session["RolUsuario"] = null;
                            Session["Rol"] = null;
                            srSeguridad.Service1Client oSeguridad = new Service1Client();
                            clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                            Response.Redirect(oSistema.Url + "/Default.aspx");
                        }
                        catch
                        {
                            srSeguridad.Service1Client oSeguridad = new Service1Client();
                            clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                            Response.Redirect(oSistema.Url + "/Default.aspx");
                        }
                    }
                    else
                        lblMensaje.Text="NO COINCIDE EL NUEVO PASSWORDY EL DUPLICADO !!!!!";
                }
                else
                    lblMensaje.Text="LA CLAVE TIENE QUE SER MAS DE 5 DIGITOS !!!!!";
            }
            else
                lblMensaje.Text="PASSWORD  .... INCORRECTO!!!!!!!!!!!!!!!!!!!";
        }
    }
}