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
public class clsGrupoArticuloDA : clsGrupoArticuloBE
{

Database db = null;
//DataSet dtoGrupoArticulo;

public clsGrupoArticuloDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneGrupoArticulo(clsGrupoArticuloBE pGrupoArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagGrupoArticulo",2, pGrupoArticulo.IdGrupoArticulo, pGrupoArticulo.NombreGrupoArticulo, pGrupoArticulo.Abreviatura, pGrupoArticulo.IdPadre, pGrupoArticulo.IdPartida, pGrupoArticulo.Nivel, pGrupoArticulo.Sector);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaGrupoArticulo(clsGrupoArticuloBE pGrupoArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagGrupoArticulo",1, pGrupoArticulo.IdGrupoArticulo, pGrupoArticulo.NombreGrupoArticulo, pGrupoArticulo.Abreviatura, pGrupoArticulo.IdPadre, pGrupoArticulo.IdPartida, pGrupoArticulo.Nivel, pGrupoArticulo.Sector);
int nIdGrupoArticulo = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
}
}
return nIdGrupoArticulo;
}

public int ModificaGrupoArticulo(clsGrupoArticuloBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagGrupoArticulo",3, pPaq.IdGrupoArticulo, pPaq.NombreGrupoArticulo, pPaq.Abreviatura, pPaq.IdPadre, pPaq.IdPartida, pPaq.Nivel, pPaq.Sector);
return db.ExecuteNonQuery(cmd);
}

public int EliminaGrupoArticulo(clsGrupoArticuloBE pGrupoArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagGrupoArticulo",4, pGrupoArticulo.IdGrupoArticulo, pGrupoArticulo.NombreGrupoArticulo, pGrupoArticulo.Abreviatura, pGrupoArticulo.IdPadre, pGrupoArticulo.IdPartida, pGrupoArticulo.Nivel, pGrupoArticulo.Sector);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavGrupoArticulo(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavGrupoArticulo" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
