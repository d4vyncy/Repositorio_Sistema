using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;

namespace rwebSeguridad.ControlesUsuario.GestionSistema
{
    public partial class CU_Sistema : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsSistema oSistema = new clsSistema();
                Session["oSistema"] = oSistema;
            }
            // cargarSistema();
        }

        void cargarListaSistema()
        {
            srSeguridad.Service1Client oservice = new Service1Client();
            RGVSistema.DataSource = oservice.ObtienepavSistema1("T", "");


        }

        protected void RGVSistema_InsertCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            clsSistema oSistema = new clsSistema();
            srSeguridad.Service1Client oServicio = new Service1Client();
            GridEditableItem editedItem = e.Item as GridEditableItem;
            //oSistema.IdSistema = 7000001;
            oSistema.NombreSistema = (userControl.FindControl("rtxtNombreSistema") as RadTextBox).Text;
            oSistema.IpServer = Convert.ToString((userControl.FindControl("rtxtIpServer") as RadTextBox).Text);
            oSistema.HostNameServer = Convert.ToString((userControl.FindControl("rtxtHostNameServer") as RadTextBox).Text);
            oSistema.Url = (userControl.FindControl("rtxtUrl") as RadTextBox).Text;
            oSistema.Imagen = (byte[])(Session["sImagenSistema"]);
            oSistema.Detalle = (userControl.FindControl("rtxtDetalle") as RadTextBox).Text;

            oServicio.AgregaSistema(oSistema);
        }

        protected void RGVSistema_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            cargarListaSistema();
        }

        protected void RGVSistema_PreRender(object sender, EventArgs e)
        {

        }

        protected void RGVSistema_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdSistema"].ToString());
            srSeguridad.Service1Client service = new Service1Client();
            clsSistema oSistema = new clsSistema();
            oSistema.IdSistema = Id;
            oSistema.NombreSistema = (userControl.FindControl("rtxtNombreSistema") as RadTextBox).Text;
            oSistema.IpServer = (userControl.FindControl("rtxtIpServer") as RadTextBox).Text;
            oSistema.HostNameServer = (userControl.FindControl("rtxtHostNameServer") as RadTextBox).Text;
            oSistema.Detalle = (userControl.FindControl("rtxtDetalle") as RadTextBox).Text;

            service.ModificaSistema(oSistema);
        }
    }
}