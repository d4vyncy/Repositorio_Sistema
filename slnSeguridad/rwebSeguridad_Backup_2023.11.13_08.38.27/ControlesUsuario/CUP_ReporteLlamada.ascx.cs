using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srPersonal;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;
using System.Data;

namespace rwebSeguridad.ControlesUsuario
{
    public partial class CUP_ReporteLlamada : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sContrasenia"] == null)
            {
                srSeguridad.Service1Client oSeguridad = new srSeguridad.Service1Client();
                clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                Response.Redirect(oSistema.Url + "/Default.aspx");
            }
            if (!IsPostBack)
            {
                srSeguridad.Service1Client oService = new srSeguridad.Service1Client();
                srPersonal.Service1Client oServicepersonal = new rwebSeguridad.srPersonal.Service1Client();
                clsUsuario oUsuario = oService.ObtieneUsuario(Convert.ToInt32(Session["tIdUsuario"].ToString()));
                clsPersona oPersona = oServicepersonal.ObtienePersona(oUsuario.IdPersona);
                txtCodigo.Text = oPersona.Codigo;
                DataTable dtTelefono = oServicepersonal.ProcedureParametro("pavTelefonoPersona",
                            "NIdPersona", oPersona.IdPersona.ToString(), "T", "", "T", ""
                            , "T", "", "T", "", "T", "", "T", "", "T", "").Tables[0];
                if (dtTelefono.Rows.Count == 1)
                    txtOrigen.Text = dtTelefono.Rows[0]["IdTelefono"].ToString();
                Session.Add("Estilo", oUsuario.Estilo.ToString());
                rddlMes.SelectedValue = DateTime.Now.Month.ToString();
            }
            RadFormDecorator1.Skin = Session["Estilo"].ToString();
            RadSkinManager1.Skin = Session["Estilo"].ToString();
        }

        void LlenarMarcajes()
        {
            srPersonal.Service1Client oServicepersonal = new rwebSeguridad.srPersonal.Service1Client();
            DataTable dtMar;

            dtMar = oServicepersonal.ObtienepavReporteLlamada4("NCodigo", txtCodigo.Text, "NAnio", rddlAnio.SelectedValue.ToString(), "NMes", rddlMes.SelectedValue.ToString(), "ODestino", "asc").Tables[0];
            gvLecturaReloj.MasterTableView.Columns[0].Visible = true;
            gvLecturaReloj.DataSource = dtMar;
            gvLecturaReloj.MasterTableView.Columns[0].Visible = false;
            int MinutosAtraso = 0;
            //string cad = "";
            int numT = 1;
            for (int r = 0; r < dtMar.Rows.Count; r++)
            {
                //cad += dtMar.Rows[r]["TotalMinutosAtraso"].ToString();
                if (int.TryParse(dtMar.Rows[r]["DuracionSegundos"].ToString(), out numT))
                    MinutosAtraso += Convert.ToInt32(dtMar.Rows[r]["DuracionSegundos"].ToString());
            }
            lblMinutosAtraso.Text = "TOTAL SEGUNDOS : " + MinutosAtraso.ToString() + "     TOTAL MINUTOS : " + (MinutosAtraso / 60).ToString();
        }

        protected void RGVFormulario_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
                LlenarMarcajes();
        }

        protected void btnVer_Click1(object sender, EventArgs e)
        {
            LlenarMarcajes();
            gvLecturaReloj.DataBind();
        }

        protected void btnVolver_Click1(object sender, EventArgs e)
        {
            Server.Transfer("wfAcceder.aspx?IdUsuario=" + Session["tIdUsuario"].ToString());
        }

        protected void gvLecturaReloj_DetailTableDataBind(object sender, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
        {
            GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
            switch (e.DetailTableView.Name)
            {
                case "IdReporteLlamada":
                    {
                        rwebSeguridad.srPersonal.Service1Client servicePersonal = new rwebSeguridad.srPersonal.Service1Client();
                        //DateTime Fecha = Convert.ToDateTime(dataItem.GetDataKeyValue("Fecha").ToString());
                        int IdReporteLlamada =Convert.ToInt32( dataItem.GetDataKeyValue("IdReporteLlamada").ToString());
                        clsReporteLlamada oReporteLlamada = servicePersonal.ObtieneReporteLlamada(IdReporteLlamada);
                        gvLecturaReloj.MasterTableView.DetailTables[0].Columns[0].Visible = true;
                        gvLecturaReloj.MasterTableView.DetailTables[0].DataSource = servicePersonal.ProcedureParametro("pavLlamada",
                            "LDestino", oReporteLlamada.Destino.ToString(), "NAnio", rddlAnio.SelectedValue.ToString(), "NMes", rddlMes.SelectedValue.ToString()
                            , "NOrigen", txtOrigen.Text, "T", "", "T", "", "T", "", "T", "").Tables[0];
                        gvLecturaReloj.MasterTableView.DetailTables[0].Columns[0].Visible = false;
                        break;
                    }
            }
        }

        protected void rddlMes_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            LlenarMarcajes();
            gvLecturaReloj.DataBind();
        }

        protected void gvLecturaReloj_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdReporteLlamada"].ToString());
            srPersonal.Service1Client service = new srPersonal.Service1Client();
            clsReporteLlamada oReporteLlamada = service.ObtieneReporteLlamada(Id);
            oReporteLlamada.Asunto = (userControl.FindControl("rtxtAsunto") as RadTextBox).Text;
            oReporteLlamada.Propiedad = (userControl.FindControl("rtxtPropiedad") as RadTextBox).Text;
            service.ModificaReporteLlamada(oReporteLlamada);
        }
    }
}