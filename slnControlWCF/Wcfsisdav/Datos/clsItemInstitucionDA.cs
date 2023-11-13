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
public class clsItemInstitucionDA : clsItemInstitucionBE
{

Database db = null;
//DataSet dtoItemInstitucion;

public clsItemInstitucionDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader ObtieneItemInstitucion(clsItemInstitucionBE pItemInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pagItemInstitucion",2, pItemInstitucion.IdItemInstitucion, pItemInstitucion.NroItem, pItemInstitucion.IdEntidad, pItemInstitucion.IdUnidad, pItemInstitucion.IdPuesto);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaItemInstitucion(clsItemInstitucionBE pItemInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pagItemInstitucion",1, pItemInstitucion.IdItemInstitucion, pItemInstitucion.NroItem, pItemInstitucion.IdEntidad, pItemInstitucion.IdUnidad, pItemInstitucion.IdPuesto);
int nIdItemInstitucion = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdItemInstitucion = Convert.ToInt32(dr["IdItemInstitucion"]);
}
}
return nIdItemInstitucion;
}

public int ModificaItemInstitucion(clsItemInstitucionBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagItemInstitucion",3, pPaq.IdItemInstitucion, pPaq.NroItem, pPaq.IdEntidad, pPaq.IdUnidad, pPaq.IdPuesto);
return db.ExecuteNonQuery(cmd);
}

public int EliminaItemInstitucion(clsItemInstitucionBE pItemInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pagItemInstitucion",4, pItemInstitucion.IdItemInstitucion, pItemInstitucion.NroItem, pItemInstitucion.IdEntidad, pItemInstitucion.IdUnidad, pItemInstitucion.IdPuesto);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavItemInstitucion(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavItemInstitucion" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
