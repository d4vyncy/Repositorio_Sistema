//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
//using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using WcfSeguridad.Entidades;

namespace WcfSeguridad.Datos 
{
public class clsReporteDA : clsReporteBE
{

Database db = null;
//DataSet dtoReporte;

public clsReporteDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneReporte(clsReporteBE pReporte)
{
DbCommand cmd = db.GetStoredProcCommand("pagReporte",2, pReporte.IdReporte, pReporte.NombreReporte, pReporte.NombreFormulario, pReporte.NumeroDeOrden, pReporte.IdSistema, pReporte.IdReportePadre);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaReporte(clsReporteBE pReporte)
{
DbCommand cmd = db.GetStoredProcCommand("pagReporte",1, pReporte.IdReporte, pReporte.NombreReporte, pReporte.NombreFormulario, pReporte.NumeroDeOrden, pReporte.IdSistema, pReporte.IdReportePadre);
int nIdReporte = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdReporte = Convert.ToInt32(dr["IdReporte"]);
}
}
return nIdReporte;
}

public int ModificaReporte(clsReporteBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagReporte",3, pPaq.IdReporte, pPaq.NombreReporte, pPaq.NombreFormulario, pPaq.NumeroDeOrden, pPaq.IdSistema, pPaq.IdReportePadre);
return db.ExecuteNonQuery(cmd);
}

public int EliminaReporte(clsReporteBE pReporte)
{
DbCommand cmd = db.GetStoredProcCommand("pagReporte",4, pReporte.IdReporte, pReporte.NombreReporte, pReporte.NombreFormulario, pReporte.NumeroDeOrden, pReporte.IdSistema, pReporte.IdReportePadre);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavReporte(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavReporte" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
