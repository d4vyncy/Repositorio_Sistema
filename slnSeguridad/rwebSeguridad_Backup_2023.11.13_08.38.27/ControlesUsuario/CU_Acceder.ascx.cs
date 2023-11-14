using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Data;
using System.Web.Security;
using Telerik.Web.UI;
using System.Net;


namespace rwebSeguridad.ControlesUsuario
{
    public partial class CU_Acceder : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //try
                //{
                srSeguridad.Service1Client oService = new Service1Client();
                string IdUsuario = base.Request["IdUsuario"].ToString();
                Session.Add("tIdUsuario", IdUsuario);
                clsUsuario oUsuario = oService.ObtieneUsuario(Convert.ToInt32(IdUsuario));
                RGVAcceder.DataSource = oService.ObtienepavRolUsuario2("NIdUsuario", IdUsuario, "NIdEstadoRolUsuario", "1");
                rddlEstilo.DataSource = Telerik.Web.SkinRegistrar.GetEmbeddedSkinNames(typeof(RadGrid));
                rddlEstilo.SelectedValue = oUsuario.Estilo;
                rddlEstilo.DataBind();
                //direccion

                //string strHostName = Dns.GetHostName();
                lblIP.InnerText = GetIPAddress();
                //lblIP.InnerText = strHostName;                
                try
                {
                    IPHostEntry ipEntry = Dns.GetHostEntry(lblIP.InnerText);
                    lblHostname.InnerText = ipEntry.HostName;
                    IPHostEntry host = Dns.GetHostEntry(lblIP.InnerText.Trim());
                    IPAddress[] ipaddr = host.AddressList;
                    // Loop through the IP Address array and add the IP address to Listbox
                    foreach (IPAddress addr in ipaddr)
                    {
                        lblOtro.InnerText += addr.ToString();
                    }
                }
                catch
                {
                    lblHostname.InnerText = "...";
                    lblOtro.InnerText = "...";
                }
                //}
                //catch
                //{
                //    lblMensaje.Text = lblIP.InnerText;
                //}
            }
            if (Session["sContrasenia"] == null)
            {
                srSeguridad.Service1Client oSeguridad = new Service1Client();
                clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                Response.Redirect(oSistema.Url + "/Default.aspx");
            }
            if (Session["sContrasenia"].ToString() == "1")
            {
                btnInsertar.Enabled = false;
                lblMensaje.Text = "Debe cambiar su contraseña para ingresar al sistema";
            }
        }
        protected string GetIPAddress()
        {
            try
            {
                System.Web.HttpContext context = System.Web.HttpContext.Current;
                string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (!string.IsNullOrEmpty(ipAddress))
                {
                    string[] addresses = ipAddress.Split(',');
                    if (addresses.Length != 0)
                    {
                        return addresses[0];
                    }
                }
                return context.Request.ServerVariables["REMOTE_ADDR"];
            }
            catch { return "error al obtener:IP"; }
        }

        protected void RGVAcceder_ItemCreated(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {

        }

        protected void RGVAcceder_PreRender(object sender, EventArgs e)
        {

        }

        public string CreaLlave(string Cadena, string pSalt)
        {
            string cUnion, cPassHashSalt;
            cUnion = string.Concat(Cadena, pSalt);
            cPassHashSalt = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cPassHashSalt;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            srSeguridad.Service1Client oService = new Service1Client();
            clsUsuario oUsuario = oService.ObtieneUsuario(Convert.ToInt32(base.Request["IdUsuario"].ToString()));

            if (RGVAcceder.SelectedValue != null)
            {

                if (oUsuario.Estilo != rddlEstilo.SelectedValue)
                {
                    oUsuario.Estilo = rddlEstilo.SelectedValue;
                    oService.ModificaUsuario(oUsuario);
                }

                //DataTable dtAcceso = oService.ProcedureParametro("pavAcceder", "NIdUsuario", oUsuario.IdUsuario.ToString(), "NIdRolUsuario", RGVAcceder.SelectedValues["IdRolUsuario"].ToString(), "T", "", "T", "", "T", "", "T", "", "T", "", "T", "").Tables[0];
                DataTable dtAcceso = oService.ObtienepavRolUsuario2("NIdUsuario", oUsuario.IdUsuario.ToString(), "NIdRolUsuario", RGVAcceder.SelectedValues["IdRolUsuario"].ToString()).Tables[0];
                clsUsuarioLogueado oUsuarioL = new clsUsuarioLogueado();

                oUsuarioL.IdUsuarioLogueado = 70000001;
                oUsuarioL.IdUsuario = oUsuario.IdUsuario;
                oUsuarioL.IdRolUsuario = Convert.ToInt32(dtAcceso.Rows[0]["IdRolUsuario"]);
                oUsuarioL.Llave = CreaLlave(DateTime.Now.ToString(), oUsuarioL.IdUsuario.ToString());
                oUsuarioL.IdEstadoLlave = 1;
                oUsuarioL.Fecha = DateTime.Now;
                oUsuarioL.DireccionIP = lblIP.InnerText;
                oUsuarioL.DireccionHost = lblHostname.InnerText;
                oUsuarioL.DireccionDest = lblOtro.InnerText;

                int IdUsuarioLogueado = oService.AgregaUsuarioLogueado(oUsuarioL);

                clsSistema oSistema = oService.ObtieneSistema(Convert.ToInt32(dtAcceso.Rows[0]["IdSistema"]));
                //if (oUsuarioL.DireccionIP.Contains("192.168"))
                //    oSistema.Url = oSistema.Url.Replace("10.71.104.46", "192.168.100.30");
                Response.Redirect(oSistema.Url + "/Formularios/wfPrincipal.aspx" + "?llave=" + oUsuarioL.Llave + "&IdUsuarioLogueado=" + IdUsuarioLogueado.ToString());
            }
            else
            {
                lblMensaje.Text = "Seleccione el rol para ingresar";
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            srSeguridad.Service1Client oSeguridad = new Service1Client();
            clsSistema oSistema = oSeguridad.ObtieneSistema(1);
            Response.Redirect(oSistema.Url + "/Default.aspx");
        }

        protected void rddlEstilo_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            rddlEstilo.Skin = rddlEstilo.SelectedValue;
            RGVAcceder.Skin = rddlEstilo.SelectedValue;
            btnCancelar.Skin = rddlEstilo.SelectedValue;
            btnInsertar.Skin = rddlEstilo.SelectedValue;
        }

        protected void btnVerMarcajes_Click(object sender, EventArgs e)
        {
            Server.Transfer("wfPersonal.aspx");
        }
        protected void btnVerRefrigerio_Click(object sender, EventArgs e)
        {
            Server.Transfer("wfRefrigerio.aspx");
        }

        protected void btnVerLlamadas_Click(object sender, EventArgs e)
        {
            Server.Transfer("wfLlamadas.aspx");
        }

        protected void btnFolio_Click(object sender, EventArgs e)
        {
            Server.Transfer("wfFolio.aspx");
        }

    }
}