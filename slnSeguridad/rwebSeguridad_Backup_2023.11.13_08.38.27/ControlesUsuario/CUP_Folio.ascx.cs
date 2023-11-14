using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using rwebSeguridad.Reporte;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace rwebSeguridad.ControlesUsuario
{
    public partial class CUP_Folio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            //reporte
            MemoryStream rptStream = new MemoryStream();
            ReportDocument rp = new ReportDocument();
            dtoReporte ds = new dtoReporte(); // .xsd file name
            DataTable dt = ds.dtFolio;
            //dt.TableName = "dtFolio";
            DataRow row;
            for (int i = 0; i < 10; i++)
            {
                row = dt.NewRow();
                row["Numero"] = i;
                row["Posicion"] = rddlIdPagina.SelectedValue.ToString();
                dt.Rows.Add(row);
            }
            rp.Load(Server.MapPath("~") + "./Reporte/CRFolio.rpt");
            ds.dtFolio.Merge(dt);
            //srPersonal.Service1Client oServicePersonal = new srPersonal.Service1Client();
            //DataTable dtInst = oServicePersonal.ObtienepavItemInstitucion1("NIdUnidad", Session["IdUnidad"].ToString()).Tables[0];
            //String IdEntidad = dtInst.Rows[0]["IdEntidad"].ToString();
            //DataTable dtRepEntidad = oServicePersonal.ProcedureParametro("paviReporteEntidad", "NIdEntidad", IdEntidad, "T", "", "T", "", "T", "", "T", "", "T", "", "T", "", "T", "").Tables[0];
            //ds.viReporteEntidad.Merge(dtRepEntidad);
            rp.SetDataSource(ds);
            //Parametro
            rptStream = (System.IO.MemoryStream)rp.ExportToStream(ExportFormatType.PortableDocFormat);// versión para Liberación
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=" + "Registro-" + ".pdf");
            Response.BinaryWrite(rptStream.ToArray());
            rp.Dispose();
            Response.End();
        }
    }
}