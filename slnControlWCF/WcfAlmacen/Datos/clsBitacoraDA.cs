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
public class clsBitacoraDA : clsBitacoraBE
{

Database db = null;
//DataSet dtoBitacora;

public clsBitacoraDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneBitacora(clsBitacoraBE pBitacora)
{
DbCommand cmd = db.GetStoredProcCommand("pagBitacora",2, pBitacora.IdBitacora, pBitacora.Fecha, pBitacora.Detalle, pBitacora.IdUsuario, pBitacora.IdInsumo, pBitacora.Cantidad);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaBitacora(clsBitacoraBE pBitacora)
{
DbCommand cmd = db.GetStoredProcCommand("pagBitacora",1, pBitacora.IdBitacora, pBitacora.Fecha, pBitacora.Detalle, pBitacora.IdUsuario, pBitacora.IdInsumo, pBitacora.Cantidad);
int nIdBitacora = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdBitacora = Convert.ToInt32(dr["IdBitacora"]);
}
}
return nIdBitacora;
}

public int ModificaBitacora(clsBitacoraBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagBitacora",3, pPaq.IdBitacora, pPaq.Fecha, pPaq.Detalle, pPaq.IdUsuario, pPaq.IdInsumo, pPaq.Cantidad);
return db.ExecuteNonQuery(cmd);
}

public int EliminaBitacora(clsBitacoraBE pBitacora)
{
DbCommand cmd = db.GetStoredProcCommand("pagBitacora",4, pBitacora.IdBitacora, pBitacora.Fecha, pBitacora.Detalle, pBitacora.IdUsuario, pBitacora.IdInsumo, pBitacora.Cantidad);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavBitacora(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavBitacora" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
