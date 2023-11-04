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
public class clsTraspasoDA : clsTraspasoBE
{

Database db = null;
//DataSet dtoTraspaso;

public clsTraspasoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneTraspaso(clsTraspasoBE pTraspaso)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspaso",2, pTraspaso.IdTraspaso, pTraspaso.NumeroTraspaso, pTraspaso.FechaReal, pTraspaso.FechaTraspaso, pTraspaso.Observaciones, pTraspaso.Total, pTraspaso.IdGrupoArticulo, pTraspaso.IdUnidadTraspaso, pTraspaso.IdGestion, pTraspaso.IdUsuarioTraspaso, pTraspaso.IdAlmacenOrigen, pTraspaso.IdAlmacenDestino);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaTraspaso(clsTraspasoBE pTraspaso)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspaso",1, pTraspaso.IdTraspaso, pTraspaso.NumeroTraspaso, pTraspaso.FechaReal, pTraspaso.FechaTraspaso, pTraspaso.Observaciones, pTraspaso.Total, pTraspaso.IdGrupoArticulo, pTraspaso.IdUnidadTraspaso, pTraspaso.IdGestion, pTraspaso.IdUsuarioTraspaso, pTraspaso.IdAlmacenOrigen, pTraspaso.IdAlmacenDestino);
int nIdTraspaso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdTraspaso = Convert.ToInt32(dr["IdTraspaso"]);
}
}
return nIdTraspaso;
}

public int ModificaTraspaso(clsTraspasoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspaso",3, pPaq.IdTraspaso, pPaq.NumeroTraspaso, pPaq.FechaReal, pPaq.FechaTraspaso, pPaq.Observaciones, pPaq.Total, pPaq.IdGrupoArticulo, pPaq.IdUnidadTraspaso, pPaq.IdGestion, pPaq.IdUsuarioTraspaso, pPaq.IdAlmacenOrigen, pPaq.IdAlmacenDestino);
return db.ExecuteNonQuery(cmd);
}

public int EliminaTraspaso(clsTraspasoBE pTraspaso)
{
DbCommand cmd = db.GetStoredProcCommand("pagTraspaso",4, pTraspaso.IdTraspaso, pTraspaso.NumeroTraspaso, pTraspaso.FechaReal, pTraspaso.FechaTraspaso, pTraspaso.Observaciones, pTraspaso.Total, pTraspaso.IdGrupoArticulo, pTraspaso.IdUnidadTraspaso, pTraspaso.IdGestion, pTraspaso.IdUsuarioTraspaso, pTraspaso.IdAlmacenOrigen, pTraspaso.IdAlmacenDestino);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavTraspaso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavTraspaso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
