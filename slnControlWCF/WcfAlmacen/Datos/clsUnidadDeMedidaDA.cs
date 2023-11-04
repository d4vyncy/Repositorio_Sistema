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
public class clsUnidadDeMedidaDA : clsUnidadDeMedidaBE
{

Database db = null;
//DataSet dtoUnidadDeMedida;

public clsUnidadDeMedidaDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneUnidadDeMedida(clsUnidadDeMedidaBE pUnidadDeMedida)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidadDeMedida",2, pUnidadDeMedida.IdUnidadDeMedida, pUnidadDeMedida.NombreUnidadDeMedida, pUnidadDeMedida.Abreviacion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaUnidadDeMedida(clsUnidadDeMedidaBE pUnidadDeMedida)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidadDeMedida",1, pUnidadDeMedida.IdUnidadDeMedida, pUnidadDeMedida.NombreUnidadDeMedida, pUnidadDeMedida.Abreviacion);
int nIdUnidadDeMedida = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdUnidadDeMedida = Convert.ToInt32(dr["IdUnidadDeMedida"]);
}
}
return nIdUnidadDeMedida;
}

public int ModificaUnidadDeMedida(clsUnidadDeMedidaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidadDeMedida",3, pPaq.IdUnidadDeMedida, pPaq.NombreUnidadDeMedida, pPaq.Abreviacion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaUnidadDeMedida(clsUnidadDeMedidaBE pUnidadDeMedida)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidadDeMedida",4, pUnidadDeMedida.IdUnidadDeMedida, pUnidadDeMedida.NombreUnidadDeMedida, pUnidadDeMedida.Abreviacion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavUnidadDeMedida(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavUnidadDeMedida" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
