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
public class clsMovimientoAlmacenDetalleDA : clsMovimientoAlmacenDetalleBE
{

Database db = null;
//DataSet dtoMovimientoAlmacenDetalle;

public clsMovimientoAlmacenDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalleBE pMovimientoAlmacenDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacenDetalle",2, pMovimientoAlmacenDetalle.IdMovimientoAlmacenDetalle, pMovimientoAlmacenDetalle.IdMovimientoAlmacen, pMovimientoAlmacenDetalle.IdIngresoDetalle, pMovimientoAlmacenDetalle.IdInsumo, pMovimientoAlmacenDetalle.IdIngreso, pMovimientoAlmacenDetalle.Cantidad, pMovimientoAlmacenDetalle.PrecioUnitario, pMovimientoAlmacenDetalle.SubTotal, pMovimientoAlmacenDetalle.Lote, pMovimientoAlmacenDetalle.FechaVencimiento);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalleBE pMovimientoAlmacenDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacenDetalle",1, pMovimientoAlmacenDetalle.IdMovimientoAlmacenDetalle, pMovimientoAlmacenDetalle.IdMovimientoAlmacen, pMovimientoAlmacenDetalle.IdIngresoDetalle, pMovimientoAlmacenDetalle.IdInsumo, pMovimientoAlmacenDetalle.IdIngreso, pMovimientoAlmacenDetalle.Cantidad, pMovimientoAlmacenDetalle.PrecioUnitario, pMovimientoAlmacenDetalle.SubTotal, pMovimientoAlmacenDetalle.Lote, pMovimientoAlmacenDetalle.FechaVencimiento);
int nIdMovimientoAlmacenDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdMovimientoAlmacenDetalle = Convert.ToInt32(dr["IdMovimientoAlmacenDetalle"]);
}
}
return nIdMovimientoAlmacenDetalle;
}

public int ModificaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacenDetalle",3, pPaq.IdMovimientoAlmacenDetalle, pPaq.IdMovimientoAlmacen, pPaq.IdIngresoDetalle, pPaq.IdInsumo, pPaq.IdIngreso, pPaq.Cantidad, pPaq.PrecioUnitario, pPaq.SubTotal, pPaq.Lote, pPaq.FechaVencimiento);
return db.ExecuteNonQuery(cmd);
}

public int EliminaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalleBE pMovimientoAlmacenDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacenDetalle",4, pMovimientoAlmacenDetalle.IdMovimientoAlmacenDetalle, pMovimientoAlmacenDetalle.IdMovimientoAlmacen, pMovimientoAlmacenDetalle.IdIngresoDetalle, pMovimientoAlmacenDetalle.IdInsumo, pMovimientoAlmacenDetalle.IdIngreso, pMovimientoAlmacenDetalle.Cantidad, pMovimientoAlmacenDetalle.PrecioUnitario, pMovimientoAlmacenDetalle.SubTotal, pMovimientoAlmacenDetalle.Lote, pMovimientoAlmacenDetalle.FechaVencimiento);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavMovimientoAlmacenDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavMovimientoAlmacenDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
