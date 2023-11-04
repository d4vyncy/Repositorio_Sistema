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
public class clsIngresoDetalleDA : clsIngresoDetalleBE
{

Database db = null;
//DataSet dtoIngresoDetalle;

public clsIngresoDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneIngresoDetalle(clsIngresoDetalleBE pIngresoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngresoDetalle",2, pIngresoDetalle.IdIngresoDetalle, pIngresoDetalle.IdInsumo, pIngresoDetalle.IdIngreso, pIngresoDetalle.Cantidad, pIngresoDetalle.PrecioUnitario, pIngresoDetalle.SubTotal, pIngresoDetalle.Lote, pIngresoDetalle.FechaVencimiento);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaIngresoDetalle(clsIngresoDetalleBE pIngresoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngresoDetalle",1, pIngresoDetalle.IdIngresoDetalle, pIngresoDetalle.IdInsumo, pIngresoDetalle.IdIngreso, pIngresoDetalle.Cantidad, pIngresoDetalle.PrecioUnitario, pIngresoDetalle.SubTotal, pIngresoDetalle.Lote, pIngresoDetalle.FechaVencimiento);
int nIdIngresoDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
}
}
return nIdIngresoDetalle;
}

public int ModificaIngresoDetalle(clsIngresoDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngresoDetalle",3, pPaq.IdIngresoDetalle, pPaq.IdInsumo, pPaq.IdIngreso, pPaq.Cantidad, pPaq.PrecioUnitario, pPaq.SubTotal, pPaq.Lote, pPaq.FechaVencimiento);
return db.ExecuteNonQuery(cmd);
}

public int EliminaIngresoDetalle(clsIngresoDetalleBE pIngresoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngresoDetalle",4, pIngresoDetalle.IdIngresoDetalle, pIngresoDetalle.IdInsumo, pIngresoDetalle.IdIngreso, pIngresoDetalle.Cantidad, pIngresoDetalle.PrecioUnitario, pIngresoDetalle.SubTotal, pIngresoDetalle.Lote, pIngresoDetalle.FechaVencimiento);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavIngresoDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavIngresoDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
