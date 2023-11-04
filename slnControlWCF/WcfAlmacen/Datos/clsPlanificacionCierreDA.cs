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
public class clsPlanificacionCierreDA : clsPlanificacionCierreBE
{

Database db = null;
//DataSet dtoPlanificacionCierre;

public clsPlanificacionCierreDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtienePlanificacionCierre(clsPlanificacionCierreBE pPlanificacionCierre)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierre",2, pPlanificacionCierre.IdPlanificacionCierre, pPlanificacionCierre.FechaApertura, pPlanificacionCierre.FechaCierre, pPlanificacionCierre.IdTasaCambio, pPlanificacionCierre.IdEstadoPlanificacionCierre, pPlanificacionCierre.IdUsuarioCreacion, pPlanificacionCierre.FechaCreacion, pPlanificacionCierre.IdAlmacen);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaPlanificacionCierre(clsPlanificacionCierreBE pPlanificacionCierre)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierre",1, pPlanificacionCierre.IdPlanificacionCierre, pPlanificacionCierre.FechaApertura, pPlanificacionCierre.FechaCierre, pPlanificacionCierre.IdTasaCambio, pPlanificacionCierre.IdEstadoPlanificacionCierre, pPlanificacionCierre.IdUsuarioCreacion, pPlanificacionCierre.FechaCreacion, pPlanificacionCierre.IdAlmacen);
int nIdPlanificacionCierre = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdPlanificacionCierre = Convert.ToInt32(dr["IdPlanificacionCierre"]);
}
}
return nIdPlanificacionCierre;
}

public int ModificaPlanificacionCierre(clsPlanificacionCierreBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierre",3, pPaq.IdPlanificacionCierre, pPaq.FechaApertura, pPaq.FechaCierre, pPaq.IdTasaCambio, pPaq.IdEstadoPlanificacionCierre, pPaq.IdUsuarioCreacion, pPaq.FechaCreacion, pPaq.IdAlmacen);
return db.ExecuteNonQuery(cmd);
}

public int EliminaPlanificacionCierre(clsPlanificacionCierreBE pPlanificacionCierre)
{
DbCommand cmd = db.GetStoredProcCommand("pagPlanificacionCierre",4, pPlanificacionCierre.IdPlanificacionCierre, pPlanificacionCierre.FechaApertura, pPlanificacionCierre.FechaCierre, pPlanificacionCierre.IdTasaCambio, pPlanificacionCierre.IdEstadoPlanificacionCierre, pPlanificacionCierre.IdUsuarioCreacion, pPlanificacionCierre.FechaCreacion, pPlanificacionCierre.IdAlmacen);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavPlanificacionCierre(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavPlanificacionCierre" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
