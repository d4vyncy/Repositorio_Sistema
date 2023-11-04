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
public class clsMarcaDA : clsMarcaBE
{

Database db = null;
//DataSet dtoMarca;

public clsMarcaDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneMarca(clsMarcaBE pMarca)
{
DbCommand cmd = db.GetStoredProcCommand("pagMarca",2, pMarca.IdMarca, pMarca.NombreMarca);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaMarca(clsMarcaBE pMarca)
{
DbCommand cmd = db.GetStoredProcCommand("pagMarca",1, pMarca.IdMarca, pMarca.NombreMarca);
int nIdMarca = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdMarca = Convert.ToInt32(dr["IdMarca"]);
}
}
return nIdMarca;
}

public int ModificaMarca(clsMarcaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagMarca",3, pPaq.IdMarca, pPaq.NombreMarca);
return db.ExecuteNonQuery(cmd);
}

public int EliminaMarca(clsMarcaBE pMarca)
{
DbCommand cmd = db.GetStoredProcCommand("pagMarca",4, pMarca.IdMarca, pMarca.NombreMarca);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavMarca(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavMarca" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
