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
public class clsSolicitudDetalleInexistenciaDA : clsSolicitudDetalleInexistenciaBE
{

Database db = null;
//DataSet dtoSolicitudDetalleInexistencia;

public clsSolicitudDetalleInexistenciaDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneSolicitudDetalleInexistencia(clsSolicitudDetalleInexistenciaBE pSolicitudDetalleInexistencia)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalleInexistencia",2, pSolicitudDetalleInexistencia.IdSolicitudDetalleInexistencia, pSolicitudDetalleInexistencia.IdInsumo, pSolicitudDetalleInexistencia.IdSolicitudDetalle, pSolicitudDetalleInexistencia.Cantidad, pSolicitudDetalleInexistencia.PrecioUnitario, pSolicitudDetalleInexistencia.Subtotal);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistenciaBE pSolicitudDetalleInexistencia)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalleInexistencia",1, pSolicitudDetalleInexistencia.IdSolicitudDetalleInexistencia, pSolicitudDetalleInexistencia.IdInsumo, pSolicitudDetalleInexistencia.IdSolicitudDetalle, pSolicitudDetalleInexistencia.Cantidad, pSolicitudDetalleInexistencia.PrecioUnitario, pSolicitudDetalleInexistencia.Subtotal);
int nIdSolicitudDetalleInexistencia = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdSolicitudDetalleInexistencia = Convert.ToInt32(dr["IdSolicitudDetalleInexistencia"]);
}
}
return nIdSolicitudDetalleInexistencia;
}

public int ModificaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistenciaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalleInexistencia",3, pPaq.IdSolicitudDetalleInexistencia, pPaq.IdInsumo, pPaq.IdSolicitudDetalle, pPaq.Cantidad, pPaq.PrecioUnitario, pPaq.Subtotal);
return db.ExecuteNonQuery(cmd);
}

public int EliminaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistenciaBE pSolicitudDetalleInexistencia)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalleInexistencia",4, pSolicitudDetalleInexistencia.IdSolicitudDetalleInexistencia, pSolicitudDetalleInexistencia.IdInsumo, pSolicitudDetalleInexistencia.IdSolicitudDetalle, pSolicitudDetalleInexistencia.Cantidad, pSolicitudDetalleInexistencia.PrecioUnitario, pSolicitudDetalleInexistencia.Subtotal);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavSolicitudDetalleInexistencia(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavSolicitudDetalleInexistencia" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
