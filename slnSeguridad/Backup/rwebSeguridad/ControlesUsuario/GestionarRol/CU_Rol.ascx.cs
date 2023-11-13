using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;
using System.Data;

namespace rwebSeguridad.ControlesUsuario.GestionarRol
{
    public partial class CU_Rol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsRol oRol = new clsRol();
                Session["oRol"] = oRol;
            }
        }

        public void CargarListaRol()
        {
            //clsPersona oPersona = new clsPersona();
            srSeguridad.Service1Client service = new Service1Client();
            RGVRol.DataSource = service.ObtienepavRol1("T", "");
        }

        protected void RGVRol_InsertCommand(object sender, GridCommandEventArgs e)
        {
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);

            clsRol oRol = new clsRol();
            srSeguridad.Service1Client service = new Service1Client();
            DataTable dt = service.ObtienepavRol1("CNombreRol", (userControl.FindControl("rtxtNombreRol") as RadTextBox).Text).Tables[0];
            if (dt.Rows.Count > 0 )
            {
               if(dt.Rows[0]["IdSistema"].ToString() == (userControl.FindControl("rddlSistema") as RadComboBox).SelectedValue.ToString()){
                    return;
               }
            }
            
            GridEditableItem editedItem = e.Item as GridEditableItem;
            oRol.NombreRol = (userControl.FindControl("rtxtNombreRol") as RadTextBox).Text.ToUpper();
            oRol.IdSistema = Convert.ToInt32((userControl.FindControl("rddlSistema") as RadComboBox).SelectedValue);
            oRol.IdRol = 70000001;
            service.AgregaRol(oRol);
                        
        }
        protected void RGVRol_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);


            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdRol"].ToString());
            srSeguridad.Service1Client service = new Service1Client();

            DataTable dt = service.ObtienepavRol1("CNombreRol", (userControl.FindControl("rtxtNombreRol") as RadTextBox).Text).Tables[0];
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["IdSistema"].ToString() == (userControl.FindControl("rddlSistema") as RadComboBox).SelectedValue.ToString())
                {
                    return;
                }
            }

            clsRol oRol = new clsRol();
            oRol.IdRol = Id;
            oRol.NombreRol = (userControl.FindControl("rtxtNombreRol") as RadTextBox).Text;
            oRol.IdSistema = Convert.ToInt32((userControl.FindControl("rddlSistema") as RadComboBox).SelectedValue);
            service.ModificaRol(oRol);
        }
        protected void RGVRol_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            CargarListaRol();
        }
    
        protected void RGVRol_PreRender(object sender, EventArgs e)
        {

        }
    }
}