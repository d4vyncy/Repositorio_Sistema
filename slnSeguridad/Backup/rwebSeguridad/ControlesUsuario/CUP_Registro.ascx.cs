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
    public partial class CUP_Registro : System.Web.UI.UserControl
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
                Session.Add("Estilo", oUsuario.Estilo.ToString());
                txtFecha.SelectedDate = DateTime.Now;
                rddlMes.SelectedValue = DateTime.Now.Month.ToString();
            }
            RadFormDecorator1.Skin = Session["Estilo"].ToString();
            RadSkinManager1.Skin = Session["Estilo"].ToString();
        }

        void LlenarMarcajes()
        {
            DateTime Fecha = Convert.ToDateTime("01/01/1900");
            if (txtFecha.SelectedDate != null)
                Fecha = txtFecha.SelectedDate.Value;

            srPersonal.Service1Client oServicepersonal = new rwebSeguridad.srPersonal.Service1Client();
            DataTable dtMar;
            if (chkMes.Checked)
                dtMar = oServicepersonal.ProcedureParametro("pavRegistroDeAsistencia", "NCodigo", txtCodigo.Text, "AFecha", rddlAnio.SelectedValue.ToString(), "MFecha", rddlMes.SelectedValue.ToString(), "OFecha", "asc", "T", "", "T", "", "T", "", "T", "").Tables[0];
            else
                dtMar = oServicepersonal.ProcedureParametro("pavRegistroDeAsistencia", "NCodigo", txtCodigo.Text, "DFecha", Fecha.Month.ToString() + "/" + Fecha.Day.ToString() + "/" + Fecha.Year.ToString(), "OFecha", "asc", "T", "", "T", "", "T", "", "T", "", "T", "").Tables[0];
            gvLecturaReloj.DataSource = dtMar;
            int MinutosAtraso = 0;
            //string cad = "";
            int numT = 1;
            for (int r = 0; r < dtMar.Rows.Count; r++)
            {
                //cad += dtMar.Rows[r]["TotalMinutosAtraso"].ToString();
                if (int.TryParse(dtMar.Rows[r]["TotalMinutosAtraso"].ToString(), out numT))
                    MinutosAtraso += Convert.ToInt32(dtMar.Rows[r]["TotalMinutosAtraso"].ToString());
            }
            lblMinutosAtraso.Text = "TOTAL MINUTOS : " + MinutosAtraso.ToString();
        }
        protected void chkMes_CheckedChanged(object sender, EventArgs e)
        {
            rddlMes.Enabled = chkMes.Checked;
            rddlAnio.Enabled = chkMes.Checked;
            txtFecha.Enabled = !chkMes.Checked;
            LlenarMarcajes();
            gvLecturaReloj.DataBind();
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
                case "Marcas":
                    {
                        rwebSeguridad.srPersonal.Service1Client servicePersonal = new rwebSeguridad.srPersonal.Service1Client();
                        DateTime Fecha = Convert.ToDateTime(dataItem.GetDataKeyValue("Fecha").ToString());
                        gvLecturaReloj.MasterTableView.DetailTables[0].Columns[0].Visible = true;
                        gvLecturaReloj.MasterTableView.DetailTables[0].DataSource = servicePersonal.ObtienepavMarcasBSS2("NCodigo", txtCodigo.Text, "DFecha", Fecha.Month.ToString() + "/" + Fecha.Day.ToString() + "/" + Fecha.Year.ToString()).Tables[0];
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
    }
}