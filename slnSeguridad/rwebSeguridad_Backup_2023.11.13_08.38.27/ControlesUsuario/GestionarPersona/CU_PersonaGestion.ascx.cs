using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srPersonal;


namespace rwebSeguridad.ControlesUsuario.GestionarPersona
{
    public partial class CU_PersonaGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void LLenarCombos()
        {
            //tarea: corregir a tipo persona
            srPersonal.Service1Client oService = new Service1Client();
            rddlTipoPersona.DataSource = oService.ObtienepavTipoServidorPublico1("T", "");
            rddlTipoPersona.DataValueField = "IdTipoServidorPublico";
            rddlTipoPersona.DataTextField = "NombreTipoServidorPublico";
            rddlTipoPersona.DataBind();
        }

        override protected void OnInit(EventArgs e)
        {
            LLenarCombos();
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
            object IdPersona = DataBinder.Eval(DataItem, "IdPersona");
            if (!Convert.IsDBNull(IdPersona))
            {
                srPersonal.Service1Client oServicio = new srPersonal.Service1Client();
                //clsPersona oPersona = new clsPersona(Convert.ToInt32(IdPersona.ToString()));
                clsPersona oPersona = oServicio.ObtienePersona(Convert.ToInt32(IdPersona.ToString()));
                rddlTipoPersona.SelectedValue = oPersona.IdTipoPersona.ToString();
                rddlLugarExpedicion.SelectedValue = oPersona.LugarExpedicion.ToString().Trim();
             
        //                    <telerik:RadComboBoxItem runat="server" Text="LPZ" Value="LPZ" />
        //                    <telerik:RadComboBoxItem runat="server" Text="CHQ" Value="CHQ" />
        //                    <telerik:RadComboBoxItem runat="server" Text="CBA" Value="CBA" />
        //                    <telerik:RadComboBoxItem runat="server" Text="OR" Value="OR" />
        //                    <telerik:RadComboBoxItem runat="server" Text="PTS" Value="PTS" />
        //                    <telerik:RadComboBoxItem runat="server" Text="TJA" Value="TJA" />
        //                    <telerik:RadComboBoxItem runat="server" Text="SCZ" Value="SCZ" />
        //                    <telerik:RadComboBoxItem runat="server" Text="BEN" Value="BEN" />
        //                    <telerik:RadComboBoxItem runat="server" Text="PND" Value="PND" />
 
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ((clsPersona)(Session["oPersona"])).Nombres = "";
            srBio.Service1Client oService = new srBio.Service1Client();
            //Session["oPersona"] = oService.GetPersonaBE(rtxtDocIdentidad.Text);
            Session["otPersona"] = oService.GetPersonaBE(rtxtDocIdentidad.Text);
            if (((srBio.clsPersona)(Session["otPersona"])).Nombres != "")
            {
                ((srBio.clsPersona)(Session["otPersona"])).IdPersona = 70000001;
                rtxtNombres.Text = ((srBio.clsPersona)(Session["otPersona"])).Nombres;
                rtxtPaterno.Text = ((srBio.clsPersona)(Session["otPersona"])).Paterno;
                rtxtMaterno.Text = ((srBio.clsPersona)(Session["otPersona"])).Materno;
                rtxtApEsposo.Text = ((srBio.clsPersona)(Session["otPersona"])).ApEsposo;
                rtxtDocIdentidad.Text = ((srBio.clsPersona)(Session["otPersona"])).DocIdentidad;
                ((srBio.clsPersona)(Session["otPersona"])).Codigo = ((srBio.clsPersona)(Session["otPersona"])).DocIdentidad.ToString();
                ((clsPersona)(Session["oPersona"])).IdIdenticacion = ((srBio.clsPersona)(Session["otPersona"])).IdPersona;
            }
            else
                Lcampo.Text = "Verifique el numero de carnet...";
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}