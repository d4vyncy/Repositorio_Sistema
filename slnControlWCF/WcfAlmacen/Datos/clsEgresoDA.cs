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
using WcfAlmacen.Entidades;

namespace WcfAlmacen.Datos 
{
public class clsEgresoDA : clsEgresoBE
{

Database db = null;
//DataSet dtoEgreso;

public clsEgresoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneEgreso(clsEgresoBE pEgreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgreso",2, pEgreso.IdEgreso, pEgreso.NumeroEgreso, pEgreso.FechaReal, pEgreso.FechaEgreso, pEgreso.Observaciones, pEgreso.Total, pEgreso.IdGrupoArticulo, pEgreso.IdUnidadSolicitante, pEgreso.IdGestion, pEgreso.IdUsuarioEgreso, pEgreso.IdAlmacen, pEgreso.IdEstadoEgreso, pEgreso.IdSolicitud);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEgreso(clsEgresoBE pEgreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgreso",1, pEgreso.IdEgreso, pEgreso.NumeroEgreso, pEgreso.FechaReal, pEgreso.FechaEgreso, pEgreso.Observaciones, pEgreso.Total, pEgreso.IdGrupoArticulo, pEgreso.IdUnidadSolicitante, pEgreso.IdGestion, pEgreso.IdUsuarioEgreso, pEgreso.IdAlmacen, pEgreso.IdEstadoEgreso, pEgreso.IdSolicitud);
int nIdEgreso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEgreso = Convert.ToInt32(dr["IdEgreso"]);
}
}
return nIdEgreso;
}

public int ModificaEgreso(clsEgresoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgreso",3, pPaq.IdEgreso, pPaq.NumeroEgreso, pPaq.FechaReal, pPaq.FechaEgreso, pPaq.Observaciones, pPaq.Total, pPaq.IdGrupoArticulo, pPaq.IdUnidadSolicitante, pPaq.IdGestion, pPaq.IdUsuarioEgreso, pPaq.IdAlmacen, pPaq.IdEstadoEgreso, pPaq.IdSolicitud);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEgreso(clsEgresoBE pEgreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgreso",4, pEgreso.IdEgreso, pEgreso.NumeroEgreso, pEgreso.FechaReal, pEgreso.FechaEgreso, pEgreso.Observaciones, pEgreso.Total, pEgreso.IdGrupoArticulo, pEgreso.IdUnidadSolicitante, pEgreso.IdGestion, pEgreso.IdUsuarioEgreso, pEgreso.IdAlmacen, pEgreso.IdEstadoEgreso, pEgreso.IdSolicitud);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEgreso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEgreso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
