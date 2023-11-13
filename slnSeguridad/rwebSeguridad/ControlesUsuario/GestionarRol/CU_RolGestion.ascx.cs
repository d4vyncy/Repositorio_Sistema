using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;

namespace rwebSeguridad.ControlesUsuario.GestionarRol
{
    public partial class CU_RolGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void LLenarCombos()
        {
            srSeguridad.Service1Client service = new Service1Client();
            rddlSistema.DataSource = service.ObtienepavSistema1("T", "");
            rddlSistema.DataValueField = "IdSistema";
            rddlSistema.DataTextField = "NombreSistema";
            rddlSistema.DataBind();
        }

        override protected void OnInit(EventArgs e)
        {
            LLenarCombos();
            base.OnInit(e);
            this.DataBinding += new System.EventHandler(this.RolDetalle_DataBinding);
        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void RolDetalle_DataBinding(object sender, System.EventArgs e)
        {
            object IdRol = DataBinder.Eval(DataItem, "IdRol");
            if (!Convert.IsDBNull(IdRol))
            {
                srSeguridad.Service1Client service = new Service1Client();
                rtxtNombreRol.Text = DataBinder.Eval(DataItem, "NombreRol").ToString();
                rddlSistema.SelectedValue = service.ObtienepavRol1("CIdRol", DataBinder.Eval(DataItem, "IdRol").ToString()).Tables[0].Rows[0]["IdSistema"].ToString();
            }
        }  
    }
}