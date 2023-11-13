using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;
using System.Data;

namespace rwebSeguridad.ControlesUsuario.GestionarUsuario
{
    public partial class CU_UsuarioGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        void LLenarCombos()
        {
            //IdEstadoUsuario
            srSeguridad.Service1Client oSeguridad = new srSeguridad.Service1Client();

            srPersonal.Service1Client oPersonal = new srPersonal.Service1Client();
            rddlIdPersona.DataSource = oPersonal.ObtienepavPersona1("T", "");
            rddlIdPersona.DataValueField = "IdPersona";
            rddlIdPersona.DataTextField = "NombrePersona";
            rddlIdPersona.DataBind();

            rddlIdEstadoUsuario.DataSource = oSeguridad.ObtienepavEstadoUsuario1("T", "");
            rddlIdEstadoUsuario.DataValueField = "IdEstadoUsuario";
            rddlIdEstadoUsuario.DataTextField = "NombreEstadoUsuario";
            rddlIdEstadoUsuario.DataBind();
            //IdTipoUsuario
            rddlIdTipoUsuario.DataSource = oSeguridad.ObtienepavTipoUsuario1("T", "");
            rddlIdTipoUsuario.DataValueField = "IdTipoUsuario";
            rddlIdTipoUsuario.DataTextField = "NombreTipoUsuario";
            rddlIdTipoUsuario.DataBind();
        }

        override protected void OnInit(EventArgs e)
        {
            LLenarCombos();
            base.OnInit(e);
            this.DataBinding += new System.EventHandler(this.UsuarioDetalle_DataBinding);
        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void UsuarioDetalle_DataBinding(object sender, System.EventArgs e)
        {
            object IdUsuario = DataBinder.Eval(DataItem, "IdUsuario");
            if (!Convert.IsDBNull(IdUsuario))
            {
                srSeguridad.Service1Client oSeguridad = new srSeguridad.Service1Client();
                clsUsuario oUsuario = oSeguridad.ObtieneUsuario(Convert.ToInt32(IdUsuario.ToString()));                
                rddlIdPersona.SelectedValue = oUsuario.IdPersona.ToString();
                rddlIdPersona.Enabled = false;
                rddlIdEstadoUsuario.SelectedValue = oUsuario.IdEstadoUsuario.ToString();
                rddlIdTipoUsuario.SelectedValue = oUsuario.IdTipoUsuario.ToString();
                rlblClave.Visible = false;
                rtxtClave.Visible = false;
            }
        }

        protected void rddlIdPersona_DataBound(object sender, EventArgs e)
        {
            //set the initial footer label
            //   ((Literal)rddlIdPersona.Footer.FindControl("RadComboItemsCount")).Text = Convert.ToString(rddlIdPersona.Items.Count);
        }

        protected void rddlIdPersona_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            //RecuperaCargosBusca();
            //IdPersona
            if (e.Text.Length >= 3)
            {
                srPersonal.Service1Client oPersonal = new srPersonal.Service1Client();
                rddlIdPersona.DataSource = oPersonal.ObtienepavPersona1("CNombrePersona", e.Text).Tables[0];
                rddlIdPersona.DataValueField = "IdPersona";
                rddlIdPersona.DataTextField = "NombrePersona";
                rddlIdPersona.DataBind();
            }
        }


        protected void rddlIdPersona_ItemDataBound(object sender, RadComboBoxItemEventArgs e)
        {
            //set the Text and Value property of every item
            //here you can set any other properties like Enabled, ToolTip, Visible, etc.
            e.Item.Text = ((DataRowView)e.Item.DataItem)["NombrePersona"].ToString();
            e.Item.Value = ((DataRowView)e.Item.DataItem)["IdPersona"].ToString();
        }
    }
}