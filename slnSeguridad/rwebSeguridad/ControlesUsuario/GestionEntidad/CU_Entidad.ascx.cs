using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srPersonal;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;

namespace rwebSeguridad.ControlesUsuario.GestionEntidad
{
    public partial class CU_Entidad : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                 clsEntidad oEntidad = new clsEntidad();
                //clsSistema oSistema = new clsSistema();
                Session["oEntidad"] = oEntidad;
            }
        }
    
      void cargarListaEntidad()
        {

            srPersonal.Service1Client oService = new srPersonal.Service1Client();  
          //srSeguridad.srPersonal.ServiceClient oservice = new rwebSeguridad.srPersonal.Service1Client();
            RGVEntidad.DataSource = oService.ObtienepavEntidad1("T", "");


        }

        protected void RGVEntidad_InsertCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            clsEntidad oEntidad = new clsEntidad();
            srPersonal.Service1Client oServicio = new srPersonal.Service1Client();
            GridEditableItem editedItem = e.Item as GridEditableItem;
            //oSistema.IdSistema = 7000001;
            //oRolUsuario.IdRol = Convert.ToInt32((userControl.FindControl("rddlIRol") as RadComboBox).SelectedValue);
            //oRolUsuario.IdUsuario = Convert.ToInt32((userControl.FindControl("rddlUsuario") as RadComboBox).SelectedValue);
            //oRolUsuario.IdEstadoRolUsuario = 1;
            oEntidad.IdEntidadPadre = Convert.ToInt32((userControl.FindControl("rddlEntidadReferente") as RadComboBox).SelectedValue);
            oEntidad.IdDepartamento = Convert.ToInt32((userControl.FindControl("rddlDepartamento") as RadComboBox).SelectedValue);
            oEntidad.NombreEntidad= (userControl.FindControl("rtxtNombreEntidad") as RadTextBox).Text;
            oEntidad.IdTipoEntidad = Convert.ToInt32((userControl.FindControl("rddlTipoEntidad") as RadComboBox).SelectedValue);
            oEntidad.Imagen= (byte[])(Session["sImagenEntidad"]);
           

            oServicio.AgregaEntidad(oEntidad);
        }

        protected void RGVEntidad_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            cargarListaEntidad();
        }

        protected void RGVEntidad_PreRender(object sender, EventArgs e)
        {

        }

        protected void RGVEntidad_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdEntidad"].ToString());
            srPersonal.Service1Client service = new srPersonal.Service1Client();
            clsEntidad oEntidad = service.ObtieneEntidad(Id);            
            oEntidad.IdEntidadPadre = Convert.ToInt32((userControl.FindControl("rddlEntidadReferente") as RadComboBox).SelectedValue);
            oEntidad.IdDepartamento = Convert.ToInt32((userControl.FindControl("rddlDepartamento") as RadComboBox).SelectedValue);
            oEntidad.NombreEntidad = (userControl.FindControl("rtxtNombreEntidad") as RadTextBox).Text;
            oEntidad.IdTipoEntidad = Convert.ToInt32((userControl.FindControl("rddlTipoEntidad") as RadComboBox).SelectedValue);
            oEntidad.Imagen = (byte[])(Session["sImagenEntidad"]);

            service.ModificaEntidad(oEntidad);
        }
    }
}
