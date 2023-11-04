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
public class clsTipoRolUsuarioDA : clsTipoRolUsuarioBE
{

Database db = null;
//DataSet dtoTipoRolUsuario;

public clsTipoRolUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneTipoRolUsuario(clsTipoRolUsuarioBE pTipoRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoRolUsuario",2, pTipoRolUsuario.IdTipoRolUsuario, pTipoRolUsuario.NombreTipoRolUsuario, pTipoRolUsuario.Detalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaTipoRolUsuario(clsTipoRolUsuarioBE pTipoRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoRolUsuario",1, pTipoRolUsuario.IdTipoRolUsuario, pTipoRolUsuario.NombreTipoRolUsuario, pTipoRolUsuario.Detalle);
int nIdTipoRolUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdTipoRolUsuario = Convert.ToInt32(dr["IdTipoRolUsuario"]);
}
}
return nIdTipoRolUsuario;
}

public int ModificaTipoRolUsuario(clsTipoRolUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoRolUsuario",3, pPaq.IdTipoRolUsuario, pPaq.NombreTipoRolUsuario, pPaq.Detalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaTipoRolUsuario(clsTipoRolUsuarioBE pTipoRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoRolUsuario",4, pTipoRolUsuario.IdTipoRolUsuario, pTipoRolUsuario.NombreTipoRolUsuario, pTipoRolUsuario.Detalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavTipoRolUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavTipoRolUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
