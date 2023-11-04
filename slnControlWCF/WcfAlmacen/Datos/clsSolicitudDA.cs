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
public class clsSolicitudDA : clsSolicitudBE
{

Database db = null;
//DataSet dtoSolicitud;

public clsSolicitudDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneSolicitud(clsSolicitudBE pSolicitud)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitud",2, pSolicitud.IdSolicitud, pSolicitud.NumeroSolicitud, pSolicitud.FechaReal, pSolicitud.FechaSolicitud, pSolicitud.Observaciones, pSolicitud.Total, pSolicitud.IdGrupoArticulo, pSolicitud.IdUnidadSolicitante, pSolicitud.IdGestion, pSolicitud.IdUsuarioSolicitud, pSolicitud.IdAlmacen, pSolicitud.IdEstadoSolicitud);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaSolicitud(clsSolicitudBE pSolicitud)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitud",1, pSolicitud.IdSolicitud, pSolicitud.NumeroSolicitud, pSolicitud.FechaReal, pSolicitud.FechaSolicitud, pSolicitud.Observaciones, pSolicitud.Total, pSolicitud.IdGrupoArticulo, pSolicitud.IdUnidadSolicitante, pSolicitud.IdGestion, pSolicitud.IdUsuarioSolicitud, pSolicitud.IdAlmacen, pSolicitud.IdEstadoSolicitud);
int nIdSolicitud = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdSolicitud = Convert.ToInt32(dr["IdSolicitud"]);
}
}
return nIdSolicitud;
}

public int ModificaSolicitud(clsSolicitudBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitud",3, pPaq.IdSolicitud, pPaq.NumeroSolicitud, pPaq.FechaReal, pPaq.FechaSolicitud, pPaq.Observaciones, pPaq.Total, pPaq.IdGrupoArticulo, pPaq.IdUnidadSolicitante, pPaq.IdGestion, pPaq.IdUsuarioSolicitud, pPaq.IdAlmacen, pPaq.IdEstadoSolicitud);
return db.ExecuteNonQuery(cmd);
}

public int EliminaSolicitud(clsSolicitudBE pSolicitud)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitud",4, pSolicitud.IdSolicitud, pSolicitud.NumeroSolicitud, pSolicitud.FechaReal, pSolicitud.FechaSolicitud, pSolicitud.Observaciones, pSolicitud.Total, pSolicitud.IdGrupoArticulo, pSolicitud.IdUnidadSolicitante, pSolicitud.IdGestion, pSolicitud.IdUsuarioSolicitud, pSolicitud.IdAlmacen, pSolicitud.IdEstadoSolicitud);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavSolicitud(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavSolicitud" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
