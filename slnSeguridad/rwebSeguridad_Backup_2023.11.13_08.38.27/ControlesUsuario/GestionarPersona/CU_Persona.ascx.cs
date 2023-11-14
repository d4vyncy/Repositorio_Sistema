using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srPersonal;
using Telerik.Web.UI;

namespace rwebSeguridad.ControlesUsuario.GestionarPersona
{
    public partial class CU_Persona : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsPersona oPersona = new clsPersona();
                Session["oPersona"] = oPersona;
            }
        }

        public void CargarListaPersona()
        {
            //clsPersona oPersona = new clsPersona();
            srPersonal.Service1Client oServicio = new Service1Client();
            RGVPersona.DataSource = oServicio.ObtienepavPersona1("T", "");
        }

        protected void RGVPersona_InsertCommand(object sender, GridCommandEventArgs e)
        {
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            clsPersona oPersona = new clsPersona();
            srPersonal.Service1Client oServicio = new Service1Client();
            if (oServicio.ObtienepavPersona1("LDocIdentidad", (userControl.FindControl("rtxtDocIdentidad") as RadTextBox).Text).Tables[0].Rows.Count > 0)
            {

            }
            else
            {
                GridEditableItem editedItem = e.Item as GridEditableItem;

                oPersona.Paterno = (userControl.FindControl("rtxtPaterno") as RadTextBox).Text.Trim();
                oPersona.Materno = (userControl.FindControl("rtxtMaterno") as RadTextBox).Text.Trim();
                oPersona.ApEsposo = (userControl.FindControl("rtxtApEsposo") as RadTextBox).Text.Trim();
                oPersona.Nombres = (userControl.FindControl("rtxtNombres") as RadTextBox).Text.Trim();
                oPersona.DocIdentidad = (userControl.FindControl("rtxtDocIdentidad") as RadTextBox).Text.Trim();
                oPersona.LugarExpedicion = Convert.ToString((userControl.FindControl("rddlLugarExpedicion") as RadComboBox).SelectedValue).Trim();
                oPersona.Celular = (userControl.FindControl("rtxtCelular") as RadTextBox).Text.Trim();
                oPersona.CorreoElectronico = (userControl.FindControl("rtxtCorreoElectronico") as RadTextBox).Text.Trim();
                oPersona.IdIdenticacion = ((clsPersona)(Session["oPersona"])).IdIdenticacion;
                oPersona.IdTipoPersona = Convert.ToInt32((userControl.FindControl("rddlTipoPersona") as RadComboBox).SelectedValue);
                oPersona.IdPersona = 70000001;
                oServicio.AgregaPersona(oPersona);
                //oPersona.AgregaPersona();
            }
        }
        protected void RGVPersona_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdPersona"].ToString());
            srPersonal.Service1Client oServicio = new Service1Client();
            clsPersona oPersona = new clsPersona();
            oPersona.Paterno = (userControl.FindControl("rtxtPaterno") as RadTextBox).Text.Trim();
            oPersona.Materno = (userControl.FindControl("rtxtMaterno") as RadTextBox).Text.Trim();
            oPersona.ApEsposo = (userControl.FindControl("rtxtApEsposo") as RadTextBox).Text.Trim();
            oPersona.Nombres = (userControl.FindControl("rtxtNombres") as RadTextBox).Text.Trim();
            oPersona.DocIdentidad = (userControl.FindControl("rtxtDocIdentidad") as RadTextBox).Text.Trim();
            oPersona.LugarExpedicion = (userControl.FindControl("rddlLugarExpedicion") as RadComboBox).SelectedValue.Trim();
            oPersona.Celular = (userControl.FindControl("rtxtCelular") as RadTextBox).Text.Trim();
            oPersona.CorreoElectronico = (userControl.FindControl("rtxtCorreoElectronico") as RadTextBox).Text.Trim();
            oPersona.IdTipoPersona = Convert.ToInt32((userControl.FindControl("rddlTipoPersona") as RadComboBox).SelectedValue);
            oServicio.ModificaPersona(oPersona);
            //oPersona.ModificaPersona();
        }
        protected void RGVPersona_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            CargarListaPersona();
        }
        protected void RGVPersona_PreRender(object sender, EventArgs e)
        {
        }
    }
}