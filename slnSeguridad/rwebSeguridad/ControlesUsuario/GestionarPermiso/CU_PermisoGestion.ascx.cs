using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Data;
using Telerik.Web.UI;
namespace rwebSeguridad.ControlesUsuario.GestionarPermiso
{
    public partial class CU_PermisoGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        void LLenarCombos()
        {
            srSeguridad.Service1Client oService = new Service1Client();
            rddlSistema.DataSource = oService.ObtienepavSistema1("T", "");
            rddlSistema.DataValueField = "IdSistema";
            rddlSistema.DataTextField = "NombreSistema";
            rddlSistema.DataBind();

            rddlRol.DataSource = oService.ObtienepavRol1("NIdSistema", rddlSistema.SelectedValue.ToString());
            rddlRol.DataValueField = "IdRol";
            rddlRol.DataTextField = "NombreRol";
            rddlRol.DataBind();

            RGVPermisos.DataSource = oService.ProcedureParametro("pavpPermiso", "NIdSistema", rddlSistema.SelectedValue.ToString(), "NIdRol", rddlRol.SelectedValue.ToString(), "T", "", "T", "", "T", "", "T", "", "T", "", "T", "").Tables[0];
            RGVPermisos.DataBind();
        }

        override protected void OnInit(EventArgs e)
        {
            if (!IsPostBack)
            {
                LLenarCombos();
                base.OnInit(e);
                this.DataBinding += new System.EventHandler(this.PermisoDetalle_DataBinding);
            }
        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }

        protected void PermisoDetalle_DataBinding(object sender, System.EventArgs e)
        {
            object IdPermiso = DataBinder.Eval(DataItem, "IdPermiso");
            if (!Convert.IsDBNull(IdPermiso))
            {
                srSeguridad.Service1Client service = new Service1Client();
                clsPermiso oPermiso = service.ObtienePermiso(Convert.ToInt32(IdPermiso));
                rddlRol.SelectedValue = oPermiso.IdRol.ToString();
            }
        }

        protected void rddlSistema_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                srSeguridad.Service1Client service = new Service1Client();
                rddlRol.DataSource = service.ObtienepavRol1("NIdSistema", rddlSistema.SelectedValue.ToString());
                rddlRol.DataValueField = "IdRol";
                rddlRol.DataTextField = "NombreRol";
                rddlRol.DataBind();
            }
            catch { }
        }

        protected void rddlRol_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            srSeguridad.Service1Client oService = new Service1Client();
            RGVPermisos.DataSource = oService.ProcedureParametro("pavpPermiso", "NIdSistema", rddlSistema.SelectedValue.ToString(), "NIdRol", rddlRol.SelectedValue.ToString(), "T", "", "T", "", "T", "", "T", "", "T", "", "T", "").Tables[0];
            RGVPermisos.DataBind();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            srSeguridad.Service1Client oService = new Service1Client();
            DataTable dtPermiso = oService.ObtienepavPermiso2("NIdSistema", rddlSistema.SelectedValue.ToString(), "NIdRol", rddlRol.SelectedValue.ToString()).Tables[0];
            if (dtPermiso.Rows.Count > 0)
            {
                for (int i = 0; i < dtPermiso.Rows.Count; i++)
                    oService.EliminaPermiso(Convert.ToInt32(dtPermiso.Rows[i]["IdPermiso"].ToString()));
            }
            clsPermiso oPermiso = new clsPermiso();
            oPermiso.IdPermiso = 7000001;
            oPermiso.IdRol = Convert.ToInt32(rddlRol.SelectedValue.ToString());
            oPermiso.NombrePermiso = "";
            foreach (GridDataItem item in RGVPermisos.MasterTableView.Items)
            {
                oPermiso.IdMenu = Convert.ToInt32(item["IdMenu"].Text);
                bool ControlTotal = (item.FindControl("ControlTotal") as CheckBox).Checked;
                bool Modificacion = (item.FindControl("Modificacion") as CheckBox).Checked;
                bool Consulta = (item.FindControl("Consulta") as CheckBox).Checked;
                if (ControlTotal && Modificacion && Consulta)
                    oPermiso.IdMenu = Convert.ToInt32(item["IdMenu"].Text);
                else
                {
                    if (ControlTotal)
                    {
                        oPermiso.IdTipoPermiso = 1;
                        oService.AgregaPermiso(oPermiso);
                    }
                    else
                    {
                        if (Modificacion)
                        {
                            oPermiso.IdTipoPermiso = 2;
                            oService.AgregaPermiso(oPermiso);
                        }
                        else
                        {
                            if (Consulta)
                            {
                                oPermiso.IdTipoPermiso = 3;
                                oService.AgregaPermiso(oPermiso);
                            }
                        }
                    }
                }
            }
            LMensaje.InnerText = "Se guardaron correctamente los datos";
        }
    }
}