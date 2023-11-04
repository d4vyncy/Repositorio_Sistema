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
public class clsTipoUsuarioDA : clsTipoUsuarioBE
{

Database db = null;
//DataSet dtoTipoUsuario;

public clsTipoUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneTipoUsuario(clsTipoUsuarioBE pTipoUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoUsuario",2, pTipoUsuario.IdTipoUsuario, pTipoUsuario.NombreTipoUsuario, pTipoUsuario.Detalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaTipoUsuario(clsTipoUsuarioBE pTipoUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoUsuario",1, pTipoUsuario.IdTipoUsuario, pTipoUsuario.NombreTipoUsuario, pTipoUsuario.Detalle);
int nIdTipoUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
}
}
return nIdTipoUsuario;
}

public int ModificaTipoUsuario(clsTipoUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoUsuario",3, pPaq.IdTipoUsuario, pPaq.NombreTipoUsuario, pPaq.Detalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaTipoUsuario(clsTipoUsuarioBE pTipoUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagTipoUsuario",4, pTipoUsuario.IdTipoUsuario, pTipoUsuario.NombreTipoUsuario, pTipoUsuario.Detalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavTipoUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavTipoUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
