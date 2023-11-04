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
public class clsStockDA : clsStockBE
{

Database db = null;
//DataSet dtoStock;

public clsStockDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneStock(clsStockBE pStock)
{
DbCommand cmd = db.GetStoredProcCommand("pagStock",2, pStock.IdStock, pStock.Cantidad, pStock.IdInsumo, pStock.IdAlmacen, pStock.IdIngresoDetalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaStock(clsStockBE pStock)
{
DbCommand cmd = db.GetStoredProcCommand("pagStock",1, pStock.IdStock, pStock.Cantidad, pStock.IdInsumo, pStock.IdAlmacen, pStock.IdIngresoDetalle);
int nIdStock = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdStock = Convert.ToInt32(dr["IdStock"]);
}
}
return nIdStock;
}

public int ModificaStock(clsStockBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagStock",3, pPaq.IdStock, pPaq.Cantidad, pPaq.IdInsumo, pPaq.IdAlmacen, pPaq.IdIngresoDetalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaStock(clsStockBE pStock)
{
DbCommand cmd = db.GetStoredProcCommand("pagStock",4, pStock.IdStock, pStock.Cantidad, pStock.IdInsumo, pStock.IdAlmacen, pStock.IdIngresoDetalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavStock(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavStock" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
