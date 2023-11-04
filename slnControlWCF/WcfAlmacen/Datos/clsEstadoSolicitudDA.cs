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
public class clsEstadoSolicitudDA : clsEstadoSolicitudBE
{

Database db = null;
//DataSet dtoEstadoSolicitud;

public clsEstadoSolicitudDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneEstadoSolicitud(clsEstadoSolicitudBE pEstadoSolicitud)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoSolicitud",2, pEstadoSolicitud.IdEstadoSolicitud, pEstadoSolicitud.NombreEstadoSolicitud, pEstadoSolicitud.Descripcion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoSolicitud(clsEstadoSolicitudBE pEstadoSolicitud)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoSolicitud",1, pEstadoSolicitud.IdEstadoSolicitud, pEstadoSolicitud.NombreEstadoSolicitud, pEstadoSolicitud.Descripcion);
int nIdEstadoSolicitud = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoSolicitud = Convert.ToInt32(dr["IdEstadoSolicitud"]);
}
}
return nIdEstadoSolicitud;
}

public int ModificaEstadoSolicitud(clsEstadoSolicitudBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoSolicitud",3, pPaq.IdEstadoSolicitud, pPaq.NombreEstadoSolicitud, pPaq.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoSolicitud(clsEstadoSolicitudBE pEstadoSolicitud)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoSolicitud",4, pEstadoSolicitud.IdEstadoSolicitud, pEstadoSolicitud.NombreEstadoSolicitud, pEstadoSolicitud.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoSolicitud(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoSolicitud" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
