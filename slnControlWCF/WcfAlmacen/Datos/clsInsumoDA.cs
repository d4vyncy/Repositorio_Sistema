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
public class clsInsumoDA : clsInsumoBE
{

Database db = null;
//DataSet dtoInsumo;

public clsInsumoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneInsumo(clsInsumoBE pInsumo)
{
DbCommand cmd = db.GetStoredProcCommand("pagInsumo",2, pInsumo.IdInsumo, pInsumo.Codigo1, pInsumo.Codigo2, pInsumo.NombreInsumo, pInsumo.Imagen, pInsumo.CantidadMinima, pInsumo.CantidadMaxima, pInsumo.PrecioCompra, pInsumo.PrecioVenta, pInsumo.ConFechaVencimiento, pInsumo.IdMoneda, pInsumo.IdLineaArticulo, pInsumo.IdGrupoArticulo, pInsumo.IdUnidaMedida, pInsumo.IdSerializacion, pInsumo.IdMarca, pInsumo.IdColor, pInsumo.Estante, pInsumo.Nivel);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaInsumo(clsInsumoBE pInsumo)
{
DbCommand cmd = db.GetStoredProcCommand("pagInsumo",1, pInsumo.IdInsumo, pInsumo.Codigo1, pInsumo.Codigo2, pInsumo.NombreInsumo, pInsumo.Imagen, pInsumo.CantidadMinima, pInsumo.CantidadMaxima, pInsumo.PrecioCompra, pInsumo.PrecioVenta, pInsumo.ConFechaVencimiento, pInsumo.IdMoneda, pInsumo.IdLineaArticulo, pInsumo.IdGrupoArticulo, pInsumo.IdUnidaMedida, pInsumo.IdSerializacion, pInsumo.IdMarca, pInsumo.IdColor, pInsumo.Estante, pInsumo.Nivel);
int nIdInsumo = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdInsumo = Convert.ToInt32(dr["IdInsumo"]);
}
}
return nIdInsumo;
}

public int ModificaInsumo(clsInsumoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagInsumo",3, pPaq.IdInsumo, pPaq.Codigo1, pPaq.Codigo2, pPaq.NombreInsumo, pPaq.Imagen, pPaq.CantidadMinima, pPaq.CantidadMaxima, pPaq.PrecioCompra, pPaq.PrecioVenta, pPaq.ConFechaVencimiento, pPaq.IdMoneda, pPaq.IdLineaArticulo, pPaq.IdGrupoArticulo, pPaq.IdUnidaMedida, pPaq.IdSerializacion, pPaq.IdMarca, pPaq.IdColor, pPaq.Estante, pPaq.Nivel);
return db.ExecuteNonQuery(cmd);
}

public int EliminaInsumo(clsInsumoBE pInsumo)
{
DbCommand cmd = db.GetStoredProcCommand("pagInsumo",4, pInsumo.IdInsumo, pInsumo.Codigo1, pInsumo.Codigo2, pInsumo.NombreInsumo, pInsumo.Imagen, pInsumo.CantidadMinima, pInsumo.CantidadMaxima, pInsumo.PrecioCompra, pInsumo.PrecioVenta, pInsumo.ConFechaVencimiento, pInsumo.IdMoneda, pInsumo.IdLineaArticulo, pInsumo.IdGrupoArticulo, pInsumo.IdUnidaMedida, pInsumo.IdSerializacion, pInsumo.IdMarca, pInsumo.IdColor, pInsumo.Estante, pInsumo.Nivel);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavInsumo(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavInsumo" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
