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
using Wcfsisdav.Entidades;

namespace Wcfsisdav.Datos 
{
public class clsUnidadDA : clsUnidadBE
{

Database db = null;
//DataSet dtoUnidad;

public clsUnidadDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader ObtieneUnidad(clsUnidadBE pUnidad)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidad",2, pUnidad.IdUnidad, pUnidad.NombreUnidad, pUnidad.CodigoUnidad, pUnidad.IdPadreUnidad, pUnidad.Orden, pUnidad.IdEntidad);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaUnidad(clsUnidadBE pUnidad)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidad",1, pUnidad.IdUnidad, pUnidad.NombreUnidad, pUnidad.CodigoUnidad, pUnidad.IdPadreUnidad, pUnidad.Orden, pUnidad.IdEntidad);
int nIdUnidad = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdUnidad = Convert.ToInt32(dr["IdUnidad"]);
}
}
return nIdUnidad;
}

public int ModificaUnidad(clsUnidadBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidad",3, pPaq.IdUnidad, pPaq.NombreUnidad, pPaq.CodigoUnidad, pPaq.IdPadreUnidad, pPaq.Orden, pPaq.IdEntidad);
return db.ExecuteNonQuery(cmd);
}

public int EliminaUnidad(clsUnidadBE pUnidad)
{
DbCommand cmd = db.GetStoredProcCommand("pagUnidad",4, pUnidad.IdUnidad, pUnidad.NombreUnidad, pUnidad.CodigoUnidad, pUnidad.IdPadreUnidad, pUnidad.Orden, pUnidad.IdEntidad);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavUnidad(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavUnidad" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
