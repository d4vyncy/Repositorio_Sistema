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
public class clsMovimientoAlmacenDA : clsMovimientoAlmacenBE
{

Database db = null;
//DataSet dtoMovimientoAlmacen;

public clsMovimientoAlmacenDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneMovimientoAlmacen(clsMovimientoAlmacenBE pMovimientoAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacen",2, pMovimientoAlmacen.IdMovimientoAlmacen, pMovimientoAlmacen.IdMovimientoAlmacenPadre, pMovimientoAlmacen.NombreMovimientoAlmacen, pMovimientoAlmacen.FechaSaldoInicial, pMovimientoAlmacen.FechaInicial, pMovimientoAlmacen.FechaFinal, pMovimientoAlmacen.NumeroIngreso, pMovimientoAlmacen.FechaReal, pMovimientoAlmacen.Observacion, pMovimientoAlmacen.SubTotal, pMovimientoAlmacen.Total, pMovimientoAlmacen.IdGestion, pMovimientoAlmacen.IdEntidad, pMovimientoAlmacen.IdUsuario, pMovimientoAlmacen.IdAlmacen, pMovimientoAlmacen.IdEstadoIngreso);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaMovimientoAlmacen(clsMovimientoAlmacenBE pMovimientoAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacen",1, pMovimientoAlmacen.IdMovimientoAlmacen, pMovimientoAlmacen.IdMovimientoAlmacenPadre, pMovimientoAlmacen.NombreMovimientoAlmacen, pMovimientoAlmacen.FechaSaldoInicial, pMovimientoAlmacen.FechaInicial, pMovimientoAlmacen.FechaFinal, pMovimientoAlmacen.NumeroIngreso, pMovimientoAlmacen.FechaReal, pMovimientoAlmacen.Observacion, pMovimientoAlmacen.SubTotal, pMovimientoAlmacen.Total, pMovimientoAlmacen.IdGestion, pMovimientoAlmacen.IdEntidad, pMovimientoAlmacen.IdUsuario, pMovimientoAlmacen.IdAlmacen, pMovimientoAlmacen.IdEstadoIngreso);
int nIdMovimientoAlmacen = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdMovimientoAlmacen = Convert.ToInt32(dr["IdMovimientoAlmacen"]);
}
}
return nIdMovimientoAlmacen;
}

public int ModificaMovimientoAlmacen(clsMovimientoAlmacenBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacen",3, pPaq.IdMovimientoAlmacen, pPaq.IdMovimientoAlmacenPadre, pPaq.NombreMovimientoAlmacen, pPaq.FechaSaldoInicial, pPaq.FechaInicial, pPaq.FechaFinal, pPaq.NumeroIngreso, pPaq.FechaReal, pPaq.Observacion, pPaq.SubTotal, pPaq.Total, pPaq.IdGestion, pPaq.IdEntidad, pPaq.IdUsuario, pPaq.IdAlmacen, pPaq.IdEstadoIngreso);
return db.ExecuteNonQuery(cmd);
}

public int EliminaMovimientoAlmacen(clsMovimientoAlmacenBE pMovimientoAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagMovimientoAlmacen",4, pMovimientoAlmacen.IdMovimientoAlmacen, pMovimientoAlmacen.IdMovimientoAlmacenPadre, pMovimientoAlmacen.NombreMovimientoAlmacen, pMovimientoAlmacen.FechaSaldoInicial, pMovimientoAlmacen.FechaInicial, pMovimientoAlmacen.FechaFinal, pMovimientoAlmacen.NumeroIngreso, pMovimientoAlmacen.FechaReal, pMovimientoAlmacen.Observacion, pMovimientoAlmacen.SubTotal, pMovimientoAlmacen.Total, pMovimientoAlmacen.IdGestion, pMovimientoAlmacen.IdEntidad, pMovimientoAlmacen.IdUsuario, pMovimientoAlmacen.IdAlmacen, pMovimientoAlmacen.IdEstadoIngreso);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavMovimientoAlmacen(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavMovimientoAlmacen" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
