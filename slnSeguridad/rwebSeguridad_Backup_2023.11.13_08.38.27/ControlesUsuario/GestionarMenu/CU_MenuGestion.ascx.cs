using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Data;
using System.Collections;
using Telerik.Web.UI;

namespace rwebSeguridad.ControlesUsuario.GestionarMenu
{
    public partial class CU_MenuGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void LLenarCombosPadres(int sis)
        {
            srSeguridad.Service1Client oService = new Service1Client();
            rddlMenuPadre.DataSource = oService.ObtienepavMenu2("NIdMenuPadre", "0", "NIdSistema", sis.ToString());
            rddlMenuPadre.DataValueField = "IdMenu";
            rddlMenuPadre.DataTextField = "NombreMenu";
            rddlMenuPadre.DataBind();

            if (rddlMenuPadre.Items.Count > 0)
            {
                llenarComboHijo(Convert.ToInt32(rddlMenuPadre.SelectedValue));
            }
        }

        void llenarComboHijo(int n)
        {
            srSeguridad.Service1Client oService = new Service1Client();
            rddlSubMenu.DataSource = oService.ObtienepavMenu1("NIdMenuPadre", n.ToString());
            rddlSubMenu.DataValueField = "IdMenu";
            rddlSubMenu.DataTextField = "NombreMenu";
            rddlSubMenu.DataBind();
        }
        void CargarCombos()
        {
            srSeguridad.Service1Client oService = new Service1Client();
            rddlSistema.DataSource = oService.ObtienepavSistema1("T", "");
            rddlSistema.DataValueField = "IdSistema";
            rddlSistema.DataTextField = "NombreSistema";
            rddlSistema.DataBind();

            if (rddlSistema.Items.Count > 0)
            {
                LLenarCombosPadres(Convert.ToInt32(rddlSistema.SelectedValue));
            }
        }
        override protected void OnInit(EventArgs e)
        {
            CargarCombos();
            base.OnInit(e);
            this.DataBinding += new System.EventHandler(this.PersonaDetalle_DataBinding);
        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }

        protected void PersonaDetalle_DataBinding(object sender, System.EventArgs e)
        {
            //object IdPersona = DataBinder.Eval(DataItem, "IdPersona");
            //if (!Convert.IsDBNull(IdPersona))
            //{
            //    srPersonal.Service1Client oServicio = new srPersonal.Service1Client();
            //    //clsPersona oPersona = new clsPersona(Convert.ToInt32(IdPersona.ToString()));
            //    clsPersona oPersona = oServicio.ObtienePersona(Convert.ToInt32(IdPersona.ToString()));
            //    rddlTipoPersona.SelectedValue = oPersona.IdTipoPersona.ToString();
            //}
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //((clsPersona)(Session["oPersona"])).Nombres = "";
            //srBio.Service1Client oService = new srBio.Service1Client();
            ////Session["oPersona"] = oService.GetPersonaBE(rtxtDocIdentidad.Text);
            //Session["otPersona"] = oService.GetPersonaBE(rtxtDocIdentidad.Text);
            //if (((srBio.clsPersona)(Session["otPersona"])).Nombres != "")
            //{
            //    ((srBio.clsPersona)(Session["otPersona"])).IdPersona = 70000001;
            //    rtxtNombres.Text = ((srBio.clsPersona)(Session["otPersona"])).Nombres;
            //    rtxtPaterno.Text = ((srBio.clsPersona)(Session["otPersona"])).Paterno;
            //    rtxtMaterno.Text = ((srBio.clsPersona)(Session["otPersona"])).Materno;
            //    rtxtApEsposo.Text = ((srBio.clsPersona)(Session["otPersona"])).ApEsposo;
            //    rtxtDocIdentidad.Text = ((srBio.clsPersona)(Session["otPersona"])).DocIdentidad;
            //    ((srBio.clsPersona)(Session["otPersona"])).Codigo = ((srBio.clsPersona)(Session["otPersona"])).DocIdentidad.ToString();
            //    ((clsPersona)(Session["oPersona"])).IdIdenticacion = ((srBio.clsPersona)(Session["otPersona"])).IdPersona;
            //}
            //else
            //    Lcampo.Text = "Verifique el numero de carnet...";
        }

        protected void rddlMenuPadre_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            llenarComboHijo(Convert.ToInt32(rddlMenuPadre.SelectedValue));
        }

        protected void rddlSistema_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            LLenarCombosPadres(Convert.ToInt32(rddlSistema.SelectedValue));
        }

    }
}