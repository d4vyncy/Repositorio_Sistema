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
public class clsEgresoDetalleDA : clsEgresoDetalleBE
{

Database db = null;
//DataSet dtoEgresoDetalle;

public clsEgresoDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneEgresoDetalle(clsEgresoDetalleBE pEgresoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgresoDetalle",2, pEgresoDetalle.IdEgresoDetalle, pEgresoDetalle.IdInsumo, pEgresoDetalle.IdEgreso, pEgresoDetalle.Cantidad, pEgresoDetalle.PrecioUnitario, pEgresoDetalle.SubTotal, pEgresoDetalle.IdIngresoDetalle, pEgresoDetalle.IdSolicitudDetalle, pEgresoDetalle.Observaciones);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEgresoDetalle(clsEgresoDetalleBE pEgresoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgresoDetalle",1, pEgresoDetalle.IdEgresoDetalle, pEgresoDetalle.IdInsumo, pEgresoDetalle.IdEgreso, pEgresoDetalle.Cantidad, pEgresoDetalle.PrecioUnitario, pEgresoDetalle.SubTotal, pEgresoDetalle.IdIngresoDetalle, pEgresoDetalle.IdSolicitudDetalle, pEgresoDetalle.Observaciones);
int nIdEgresoDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEgresoDetalle = Convert.ToInt32(dr["IdEgresoDetalle"]);
}
}
return nIdEgresoDetalle;
}

public int ModificaEgresoDetalle(clsEgresoDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgresoDetalle",3, pPaq.IdEgresoDetalle, pPaq.IdInsumo, pPaq.IdEgreso, pPaq.Cantidad, pPaq.PrecioUnitario, pPaq.SubTotal, pPaq.IdIngresoDetalle, pPaq.IdSolicitudDetalle, pPaq.Observaciones);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEgresoDetalle(clsEgresoDetalleBE pEgresoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagEgresoDetalle",4, pEgresoDetalle.IdEgresoDetalle, pEgresoDetalle.IdInsumo, pEgresoDetalle.IdEgreso, pEgresoDetalle.Cantidad, pEgresoDetalle.PrecioUnitario, pEgresoDetalle.SubTotal, pEgresoDetalle.IdIngresoDetalle, pEgresoDetalle.IdSolicitudDetalle, pEgresoDetalle.Observaciones);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEgresoDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEgresoDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
