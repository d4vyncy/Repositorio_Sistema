using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
namespace rwebSeguridad.Formularios
{
    public partial class wfAcceder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            srSeguridad.Service1Client oService = new Service1Client();
          //clsUsuario oUsuario = (clsUsuario)Session["Usuario"];
            clsUsuario oUsuario = oService.ObtieneUsuario(Convert.ToInt32(base.Request["IdUsuario"].ToString()));
           
          RadFormDecorator1.Skin = oUsuario.Estilo;
          RadSkinManager1.Skin = oUsuario.Estilo;
        }
    }
}