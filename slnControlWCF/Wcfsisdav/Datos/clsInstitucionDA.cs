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
public class clsInstitucionDA : clsInstitucionBE
{

Database db = null;
//DataSet dtoInstitucion;

public clsInstitucionDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader ObtieneInstitucion(clsInstitucionBE pInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pagInstitucion",2, pInstitucion.IdInstitucion, pInstitucion.IdInstitucionPadre, pInstitucion.NombreInstitucion, pInstitucion.IdTipoInstitucion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaInstitucion(clsInstitucionBE pInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pagInstitucion",1, pInstitucion.IdInstitucion, pInstitucion.IdInstitucionPadre, pInstitucion.NombreInstitucion, pInstitucion.IdTipoInstitucion);
int nIdInstitucion = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdInstitucion = Convert.ToInt32(dr["IdInstitucion"]);
}
}
return nIdInstitucion;
}

public int ModificaInstitucion(clsInstitucionBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagInstitucion",3, pPaq.IdInstitucion, pPaq.IdInstitucionPadre, pPaq.NombreInstitucion, pPaq.IdTipoInstitucion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaInstitucion(clsInstitucionBE pInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pagInstitucion",4, pInstitucion.IdInstitucion, pInstitucion.IdInstitucionPadre, pInstitucion.NombreInstitucion, pInstitucion.IdTipoInstitucion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavInstitucion(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavInstitucion" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
