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
public class clsTraspasoDetalleDA : clsTraspasoDetalleBE
{

Database db = null;
//DataSet dtoTraspasoDetalle;

public clsTraspasoDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneTraspasoDetalle(clsTraspasoDetalleBE pTraspasoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspasoDetalle",2, pTraspasoDetalle.IdTraspasoDetalle, pTraspasoDetalle.IdTraspaso, pTraspasoDetalle.PrecioUnitario, pTraspasoDetalle.SubTotal, pTraspasoDetalle.CantidadOrigen, pTraspasoDetalle.CantidadDestino, pTraspasoDetalle.IdInsumoOrigen, pTraspasoDetalle.IdInsumoDestino, pTraspasoDetalle.IdIngresoDetalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaTraspasoDetalle(clsTraspasoDetalleBE pTraspasoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspasoDetalle",1, pTraspasoDetalle.IdTraspasoDetalle, pTraspasoDetalle.IdTraspaso, pTraspasoDetalle.PrecioUnitario, pTraspasoDetalle.SubTotal, pTraspasoDetalle.CantidadOrigen, pTraspasoDetalle.CantidadDestino, pTraspasoDetalle.IdInsumoOrigen, pTraspasoDetalle.IdInsumoDestino, pTraspasoDetalle.IdIngresoDetalle);
int nIdTraspasoDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdTraspasoDetalle = Convert.ToInt32(dr["IdTraspasoDetalle"]);
}
}
return nIdTraspasoDetalle;
}

public int ModificaTraspasoDetalle(clsTraspasoDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspasoDetalle",3, pPaq.IdTraspasoDetalle, pPaq.IdTraspaso, pPaq.PrecioUnitario, pPaq.SubTotal, pPaq.CantidadOrigen, pPaq.CantidadDestino, pPaq.IdInsumoOrigen, pPaq.IdInsumoDestino, pPaq.IdIngresoDetalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaTraspasoDetalle(clsTraspasoDetalleBE pTraspasoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspasoDetalle",4, pTraspasoDetalle.IdTraspasoDetalle, pTraspasoDetalle.IdTraspaso, pTraspasoDetalle.PrecioUnitario, pTraspasoDetalle.SubTotal, pTraspasoDetalle.CantidadOrigen, pTraspasoDetalle.CantidadDestino, pTraspasoDetalle.IdInsumoOrigen, pTraspasoDetalle.IdInsumoDestino, pTraspasoDetalle.IdIngresoDetalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavTraspasoDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavTraspasoDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
