using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;


namespace rwebSeguridad.ControlesUsuario.GestionRolUsuario
{
    public partial class CU_RolUsuarioGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void LLenarCombos()
        {
            srSeguridad.Service1Client oService = new srSeguridad.Service1Client();
            rddlSistema.DataSource = oService.ObtienepavSistema1("T", "");
            rddlSistema.DataValueField = "IdSistema";
            rddlSistema.DataTextField = "NombreSistema";
            rddlSistema.DataBind();

            rddlUsuario.DataSource = oService.ObtienepavUsuario1("ONombreUsuario", "asc");
            rddlUsuario.DataValueField = "IdUsuario";
            rddlUsuario.DataTextField = "NombreUsuario";
            rddlUsuario.DataBind();

            rddlEstadoUsuario.DataSource = oService.ObtienepavEstadoRolUsuario1("T", "");
            rddlEstadoUsuario.DataValueField = "IdEstadoRolUsuario";
            rddlEstadoUsuario.DataTextField = "NombreEstadoRolUsuario";
            rddlEstadoUsuario.DataBind();

        }

        protected void rddlSistema_SelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                CargarComboRol();
            }
            catch
            { }
        }
        void CargarComboRol()
        {
            srSeguridad.Service1Client oService = new srSeguridad.Service1Client();
            rddlIRol.DataSource = oService.ObtienepavRol1("NIdSistema", rddlSistema.SelectedValue.ToString());
            rddlIRol.DataValueField = "IdRol";
            rddlIRol.DataTextField = "NombreRol";
            rddlIRol.DataBind();
        }
        override protected void OnInit(EventArgs e)
        {
            LLenarCombos();
            base.OnInit(e);
            this.DataBinding += new System.EventHandler(this.ObjetivoRolUsuario_DataBinding);
        }
        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void ObjetivoRolUsuario_DataBinding(object sender, System.EventArgs e)
        {
            object IdRolUsuario = DataBinder.Eval(DataItem, "IdRolUsuario");
            if (!Convert.IsDBNull(IdRolUsuario))
            {
                srSeguridad.Service1Client oService = new srSeguridad.Service1Client();
                clsRolUsuario oRolUsuario = oService.ObtieneRolUsuario(Convert.ToInt32(IdRolUsuario));
                clsRol oRol = oService.ObtieneRol(oRolUsuario.IdRol);
                rddlSistema.SelectedValue = oRol.IdSistema.ToString();
                CargarComboRol();
                rddlIRol.SelectedValue = oRolUsuario.IdRol.ToString();
                rddlUsuario.SelectedValue = oRolUsuario.IdUsuario.ToString();
                rddlUsuario.Enabled = false;
                rdtFechaBaja.SelectedDate = oRolUsuario.FechaBaja;
                rddlEstadoUsuario.SelectedValue = oRolUsuario.IdEstadoRolUsuario.ToString();
                //rddlIdObjetivoPadre.SelectedValue = oObjetivo.IdObjetivoPadre.ToString();
            }
        }





    }
}