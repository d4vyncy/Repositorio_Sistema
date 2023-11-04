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
public class clsTipoDocumentoEntregaDA : clsTipoDocumentoEntregaBE
{

Database db = null;
//DataSet dtoTipoDocumentoEntrega;

public clsTipoDocumentoEntregaDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneTipoDocumentoEntrega(clsTipoDocumentoEntregaBE pTipoDocumentoEntrega)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoDocumentoEntrega",2, pTipoDocumentoEntrega.IdTipoDocumentoEntrega, pTipoDocumentoEntrega.NombreTipoDocumentoEntrega);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaTipoDocumentoEntrega(clsTipoDocumentoEntregaBE pTipoDocumentoEntrega)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoDocumentoEntrega",1, pTipoDocumentoEntrega.IdTipoDocumentoEntrega, pTipoDocumentoEntrega.NombreTipoDocumentoEntrega);
int nIdTipoDocumentoEntrega = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdTipoDocumentoEntrega = Convert.ToInt32(dr["IdTipoDocumentoEntrega"]);
}
}
return nIdTipoDocumentoEntrega;
}

public int ModificaTipoDocumentoEntrega(clsTipoDocumentoEntregaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoDocumentoEntrega",3, pPaq.IdTipoDocumentoEntrega, pPaq.NombreTipoDocumentoEntrega);
return db.ExecuteNonQuery(cmd);
}

public int EliminaTipoDocumentoEntrega(clsTipoDocumentoEntregaBE pTipoDocumentoEntrega)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoDocumentoEntrega",4, pTipoDocumentoEntrega.IdTipoDocumentoEntrega, pTipoDocumentoEntrega.NombreTipoDocumentoEntrega);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavTipoDocumentoEntrega(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavTipoDocumentoEntrega" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
