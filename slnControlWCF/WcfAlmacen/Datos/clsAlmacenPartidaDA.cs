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
public class clsAlmacenPartidaDA : clsAlmacenPartidaBE
{

Database db = null;
//DataSet dtoAlmacenPartida;

public clsAlmacenPartidaDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneAlmacenPartida(clsAlmacenPartidaBE pAlmacenPartida)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacenPartida",2, pAlmacenPartida.IdAlmacenPartida, pAlmacenPartida.NumeroPartida, pAlmacenPartida.IdAlmacenPartidaPadre, pAlmacenPartida.NombreAlmacenPartida, pAlmacenPartida.Descripcion, pAlmacenPartida.DetallePartida, pAlmacenPartida.Estado);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaAlmacenPartida(clsAlmacenPartidaBE pAlmacenPartida)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacenPartida",1, pAlmacenPartida.IdAlmacenPartida, pAlmacenPartida.NumeroPartida, pAlmacenPartida.IdAlmacenPartidaPadre, pAlmacenPartida.NombreAlmacenPartida, pAlmacenPartida.Descripcion, pAlmacenPartida.DetallePartida, pAlmacenPartida.Estado);
int nIdAlmacenPartida = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdAlmacenPartida = Convert.ToInt32(dr["IdAlmacenPartida"]);
}
}
return nIdAlmacenPartida;
}

public int ModificaAlmacenPartida(clsAlmacenPartidaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacenPartida",3, pPaq.IdAlmacenPartida, pPaq.NumeroPartida, pPaq.IdAlmacenPartidaPadre, pPaq.NombreAlmacenPartida, pPaq.Descripcion, pPaq.DetallePartida, pPaq.Estado);
return db.ExecuteNonQuery(cmd);
}

public int EliminaAlmacenPartida(clsAlmacenPartidaBE pAlmacenPartida)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacenPartida",4, pAlmacenPartida.IdAlmacenPartida, pAlmacenPartida.NumeroPartida, pAlmacenPartida.IdAlmacenPartidaPadre, pAlmacenPartida.NombreAlmacenPartida, pAlmacenPartida.Descripcion, pAlmacenPartida.DetallePartida, pAlmacenPartida.Estado);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavAlmacenPartida(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavAlmacenPartida" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
