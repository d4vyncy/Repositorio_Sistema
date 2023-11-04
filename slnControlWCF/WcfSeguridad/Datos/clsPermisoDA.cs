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
public class clsPermisoDA : clsPermisoBE
{

Database db = null;
//DataSet dtoPermiso;

public clsPermisoDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtienePermiso(clsPermisoBE pPermiso)
{
DbCommand cmd = db.GetStoredProcCommand("pagPermiso",2, pPermiso.IdPermiso, pPermiso.NombrePermiso, pPermiso.IdTipoPermiso, pPermiso.IdMenu, pPermiso.IdRol);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaPermiso(clsPermisoBE pPermiso)
{
DbCommand cmd = db.GetStoredProcCommand("pagPermiso",1, pPermiso.IdPermiso, pPermiso.NombrePermiso, pPermiso.IdTipoPermiso, pPermiso.IdMenu, pPermiso.IdRol);
int nIdPermiso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdPermiso = Convert.ToInt32(dr["IdPermiso"]);
}
}
return nIdPermiso;
}

public int ModificaPermiso(clsPermisoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagPermiso",3, pPaq.IdPermiso, pPaq.NombrePermiso, pPaq.IdTipoPermiso, pPaq.IdMenu, pPaq.IdRol);
return db.ExecuteNonQuery(cmd);
}

public int EliminaPermiso(clsPermisoBE pPermiso)
{
DbCommand cmd = db.GetStoredProcCommand("pagPermiso",4, pPermiso.IdPermiso, pPermiso.NombrePermiso, pPermiso.IdTipoPermiso, pPermiso.IdMenu, pPermiso.IdRol);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavPermiso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavPermiso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
