using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;
using System.Data;


namespace rwebSeguridad.ControlesUsuario.GestionRolUsuario
{
    public partial class CU_RolUsuario : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsRolUsuario oRolUsuario = new clsRolUsuario();
                Session["oRolUsuario"] = oRolUsuario;
            }
            // cargarSistema();
        }

        void cargarListaRolUsuario()
        {
            srSeguridad.Service1Client oservice = new Service1Client();
            RGVRolUsuario.DataSource = oservice.ObtienepavRolUsuario1("T", "");


        }

        protected void RGVRolUsuario_InsertCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            clsRolUsuario oRolUsuario = new clsRolUsuario();
            srSeguridad.Service1Client oServicio = new Service1Client();
            GridEditableItem editedItem = e.Item as GridEditableItem;
            oRolUsuario.IdRolUsuario = 7000001;
            oRolUsuario.IdRol = Convert.ToInt32((userControl.FindControl("rddlIRol") as RadComboBox).SelectedValue);
            oRolUsuario.IdUsuario = Convert.ToInt32((userControl.FindControl("rddlUsuario") as RadComboBox).SelectedValue);
            oRolUsuario.IdEstadoRolUsuario = Convert.ToInt32((userControl.FindControl("rddlEstadoUsuario") as RadComboBox).SelectedValue);           
            oRolUsuario.IdTipoRolUsuario = 1;
            oRolUsuario.IdUsuarioCreacion = 7000002;
            oRolUsuario.FechaBaja = (userControl.FindControl("rdtFechaBaja") as RadDatePicker).SelectedDate.Value;
            oServicio.AgregaRolUsuario(oRolUsuario);
        }

        protected void RGVRolUsuario_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            cargarListaRolUsuario();
        }

        protected void RGVRolUsuario_PreRender(object sender, EventArgs e)
        {

        }

        protected void RGVRolUsuario_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdRolUsuario"].ToString());
            srSeguridad.Service1Client service = new Service1Client();
            clsRolUsuario oRolUsuario = new clsRolUsuario();
            oRolUsuario.IdRolUsuario = Id;
            oRolUsuario.IdRol = Convert.ToInt32((userControl.FindControl("rddlIRol") as RadComboBox).SelectedValue);
            oRolUsuario.IdUsuario = Convert.ToInt32((userControl.FindControl("rddlUsuario") as RadComboBox).SelectedValue);
            oRolUsuario.IdEstadoRolUsuario = Convert.ToInt32((userControl.FindControl("rddlEstadoUsuario") as RadComboBox).SelectedValue);
            oRolUsuario.IdTipoRolUsuario = 1;
            oRolUsuario.IdUsuarioCreacion = 7000002;
            oRolUsuario.FechaBaja = (userControl.FindControl("rdtFechaBaja") as RadDatePicker).SelectedDate.Value;

            service.ModificaRolUsuario(oRolUsuario);
        }
    }
}