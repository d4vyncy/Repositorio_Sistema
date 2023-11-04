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
public class clsPlanificacionCierreDetalleDA : clsPlanificacionCierreDetalleBE
{

Database db = null;
//DataSet dtoPlanificacionCierreDetalle;

public clsPlanificacionCierreDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtienePlanificacionCierreDetalle(clsPlanificacionCierreDetalleBE pPlanificacionCierreDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierreDetalle",2, pPlanificacionCierreDetalle.IdPlanificacionCierreDetalle, pPlanificacionCierreDetalle.IdPlanificacionCierre, pPlanificacionCierreDetalle.IdIngreso, pPlanificacionCierreDetalle.IdIngresoDetalle, pPlanificacionCierreDetalle.IdEgreso, pPlanificacionCierreDetalle.IdEgresoDetalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaPlanificacionCierreDetalle(clsPlanificacionCierreDetalleBE pPlanificacionCierreDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierreDetalle",1, pPlanificacionCierreDetalle.IdPlanificacionCierreDetalle, pPlanificacionCierreDetalle.IdPlanificacionCierre, pPlanificacionCierreDetalle.IdIngreso, pPlanificacionCierreDetalle.IdIngresoDetalle, pPlanificacionCierreDetalle.IdEgreso, pPlanificacionCierreDetalle.IdEgresoDetalle);
int nIdPlanificacionCierreDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdPlanificacionCierreDetalle = Convert.ToInt32(dr["IdPlanificacionCierreDetalle"]);
}
}
return nIdPlanificacionCierreDetalle;
}

public int ModificaPlanificacionCierreDetalle(clsPlanificacionCierreDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierreDetalle",3, pPaq.IdPlanificacionCierreDetalle, pPaq.IdPlanificacionCierre, pPaq.IdIngreso, pPaq.IdIngresoDetalle, pPaq.IdEgreso, pPaq.IdEgresoDetalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaPlanificacionCierreDetalle(clsPlanificacionCierreDetalleBE pPlanificacionCierreDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierreDetalle",4, pPlanificacionCierreDetalle.IdPlanificacionCierreDetalle, pPlanificacionCierreDetalle.IdPlanificacionCierre, pPlanificacionCierreDetalle.IdIngreso, pPlanificacionCierreDetalle.IdIngresoDetalle, pPlanificacionCierreDetalle.IdEgreso, pPlanificacionCierreDetalle.IdEgresoDetalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavPlanificacionCierreDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavPlanificacionCierreDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
