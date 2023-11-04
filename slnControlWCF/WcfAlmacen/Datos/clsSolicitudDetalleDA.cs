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
public class clsSolicitudDetalleDA : clsSolicitudDetalleBE
{

Database db = null;
//DataSet dtoSolicitudDetalle;

public clsSolicitudDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneSolicitudDetalle(clsSolicitudDetalleBE pSolicitudDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalle",2, pSolicitudDetalle.IdSolicitudDetalle, pSolicitudDetalle.IdInsumo, pSolicitudDetalle.IdSolicitud, pSolicitudDetalle.IdStock, pSolicitudDetalle.Cantidad, pSolicitudDetalle.PrecioUnitario, pSolicitudDetalle.SubTotal);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaSolicitudDetalle(clsSolicitudDetalleBE pSolicitudDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalle",1, pSolicitudDetalle.IdSolicitudDetalle, pSolicitudDetalle.IdInsumo, pSolicitudDetalle.IdSolicitud, pSolicitudDetalle.IdStock, pSolicitudDetalle.Cantidad, pSolicitudDetalle.PrecioUnitario, pSolicitudDetalle.SubTotal);
int nIdSolicitudDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdSolicitudDetalle = Convert.ToInt32(dr["IdSolicitudDetalle"]);
}
}
return nIdSolicitudDetalle;
}

public int ModificaSolicitudDetalle(clsSolicitudDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalle",3, pPaq.IdSolicitudDetalle, pPaq.IdInsumo, pPaq.IdSolicitud, pPaq.IdStock, pPaq.Cantidad, pPaq.PrecioUnitario, pPaq.SubTotal);
return db.ExecuteNonQuery(cmd);
}

public int EliminaSolicitudDetalle(clsSolicitudDetalleBE pSolicitudDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagSolicitudDetalle",4, pSolicitudDetalle.IdSolicitudDetalle, pSolicitudDetalle.IdInsumo, pSolicitudDetalle.IdSolicitud, pSolicitudDetalle.IdStock, pSolicitudDetalle.Cantidad, pSolicitudDetalle.PrecioUnitario, pSolicitudDetalle.SubTotal);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavSolicitudDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavSolicitudDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
