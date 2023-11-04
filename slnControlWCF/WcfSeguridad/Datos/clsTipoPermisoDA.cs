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
using WcfSeguridad.Entidades;

namespace WcfSeguridad.Datos 
{
public class clsTipoPermisoDA : clsTipoPermisoBE
{

Database db = null;
//DataSet dtoTipoPermiso;

public clsTipoPermisoDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneTipoPermiso(clsTipoPermisoBE pTipoPermiso)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoPermiso",2, pTipoPermiso.IdTipoPermiso, pTipoPermiso.NombreTipoPermiso, pTipoPermiso.DetalleTipoPermiso);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaTipoPermiso(clsTipoPermisoBE pTipoPermiso)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoPermiso",1, pTipoPermiso.IdTipoPermiso, pTipoPermiso.NombreTipoPermiso, pTipoPermiso.DetalleTipoPermiso);
int nIdTipoPermiso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdTipoPermiso = Convert.ToInt32(dr["IdTipoPermiso"]);
}
}
return nIdTipoPermiso;
}

public int ModificaTipoPermiso(clsTipoPermisoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoPermiso",3, pPaq.IdTipoPermiso, pPaq.NombreTipoPermiso, pPaq.DetalleTipoPermiso);
return db.ExecuteNonQuery(cmd);
}

public int EliminaTipoPermiso(clsTipoPermisoBE pTipoPermiso)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoPermiso",4, pTipoPermiso.IdTipoPermiso, pTipoPermiso.NombreTipoPermiso, pTipoPermiso.DetalleTipoPermiso);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavTipoPermiso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavTipoPermiso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
