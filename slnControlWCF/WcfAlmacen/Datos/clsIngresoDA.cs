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
public class clsIngresoDA : clsIngresoBE
{

Database db = null;
//DataSet dtoIngreso;

public clsIngresoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneIngreso(clsIngresoBE pIngreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngreso",2, pIngreso.IdIngreso, pIngreso.NumeroIngreso, pIngreso.FechaReal, pIngreso.FechaIngreso, pIngreso.ComprobantePago, pIngreso.NumeroFactura, pIngreso.NumeroPreventivo, pIngreso.Observacion, pIngreso.SubTotal, pIngreso.Total, pIngreso.Descuento, pIngreso.IdGrupoArticulo, pIngreso.IdProveedor, pIngreso.IdGestion, pIngreso.IdEntidad, pIngreso.IdUsuarioIngreso, pIngreso.IdAlmacen, pIngreso.IdEstadoIngreso, pIngreso.IdTipoDocumentoEntrega);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaIngreso(clsIngresoBE pIngreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngreso",1, pIngreso.IdIngreso, pIngreso.NumeroIngreso, pIngreso.FechaReal, pIngreso.FechaIngreso, pIngreso.ComprobantePago, pIngreso.NumeroFactura, pIngreso.NumeroPreventivo, pIngreso.Observacion, pIngreso.SubTotal, pIngreso.Total, pIngreso.Descuento, pIngreso.IdGrupoArticulo, pIngreso.IdProveedor, pIngreso.IdGestion, pIngreso.IdEntidad, pIngreso.IdUsuarioIngreso, pIngreso.IdAlmacen, pIngreso.IdEstadoIngreso, pIngreso.IdTipoDocumentoEntrega);
int nIdIngreso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdIngreso = Convert.ToInt32(dr["IdIngreso"]);
}
}
return nIdIngreso;
}

public int ModificaIngreso(clsIngresoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngreso",3, pPaq.IdIngreso, pPaq.NumeroIngreso, pPaq.FechaReal, pPaq.FechaIngreso, pPaq.ComprobantePago, pPaq.NumeroFactura, pPaq.NumeroPreventivo, pPaq.Observacion, pPaq.SubTotal, pPaq.Total, pPaq.Descuento, pPaq.IdGrupoArticulo, pPaq.IdProveedor, pPaq.IdGestion, pPaq.IdEntidad, pPaq.IdUsuarioIngreso, pPaq.IdAlmacen, pPaq.IdEstadoIngreso, pPaq.IdTipoDocumentoEntrega);
return db.ExecuteNonQuery(cmd);
}

public int EliminaIngreso(clsIngresoBE pIngreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagIngreso",4, pIngreso.IdIngreso, pIngreso.NumeroIngreso, pIngreso.FechaReal, pIngreso.FechaIngreso, pIngreso.ComprobantePago, pIngreso.NumeroFactura, pIngreso.NumeroPreventivo, pIngreso.Observacion, pIngreso.SubTotal, pIngreso.Total, pIngreso.Descuento, pIngreso.IdGrupoArticulo, pIngreso.IdProveedor, pIngreso.IdGestion, pIngreso.IdEntidad, pIngreso.IdUsuarioIngreso, pIngreso.IdAlmacen, pIngreso.IdEstadoIngreso, pIngreso.IdTipoDocumentoEntrega);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavIngreso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavIngreso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
