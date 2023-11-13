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
public class clsRolUsuarioDA : clsRolUsuarioBE
{

Database db = null;
//DataSet dtoRolUsuario;

public clsRolUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader ObtieneRolUsuario(clsRolUsuarioBE pRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagRolUsuario",2, pRolUsuario.IdRolUsuario, pRolUsuario.IdRol, pRolUsuario.IdUsuario, pRolUsuario.IdEstadoRolUsuario, pRolUsuario.IdTipoRolUsuario, pRolUsuario.IdUsuarioCreacion, pRolUsuario.FechaBaja);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaRolUsuario(clsRolUsuarioBE pRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagRolUsuario",1, pRolUsuario.IdRolUsuario, pRolUsuario.IdRol, pRolUsuario.IdUsuario, pRolUsuario.IdEstadoRolUsuario, pRolUsuario.IdTipoRolUsuario, pRolUsuario.IdUsuarioCreacion, pRolUsuario.FechaBaja);
int nIdRolUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdRolUsuario = Convert.ToInt32(dr["IdRolUsuario"]);
}
}
return nIdRolUsuario;
}

public int ModificaRolUsuario(clsRolUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagRolUsuario",3, pPaq.IdRolUsuario, pPaq.IdRol, pPaq.IdUsuario, pPaq.IdEstadoRolUsuario, pPaq.IdTipoRolUsuario, pPaq.IdUsuarioCreacion, pPaq.FechaBaja);
return db.ExecuteNonQuery(cmd);
}

public int EliminaRolUsuario(clsRolUsuarioBE pRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagRolUsuario",4, pRolUsuario.IdRolUsuario, pRolUsuario.IdRol, pRolUsuario.IdUsuario, pRolUsuario.IdEstadoRolUsuario, pRolUsuario.IdTipoRolUsuario, pRolUsuario.IdUsuarioCreacion, pRolUsuario.FechaBaja);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavRolUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavRolUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
