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
public class clsEstadoRolUsuarioDA : clsEstadoRolUsuarioBE
{

Database db = null;
//DataSet dtoEstadoRolUsuario;

public clsEstadoRolUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneEstadoRolUsuario(clsEstadoRolUsuarioBE pEstadoRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoRolUsuario",2, pEstadoRolUsuario.IdEstadoRolUsuario, pEstadoRolUsuario.NombreEstadoRolUsuario, pEstadoRolUsuario.Detalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoRolUsuario(clsEstadoRolUsuarioBE pEstadoRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoRolUsuario",1, pEstadoRolUsuario.IdEstadoRolUsuario, pEstadoRolUsuario.NombreEstadoRolUsuario, pEstadoRolUsuario.Detalle);
int nIdEstadoRolUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoRolUsuario = Convert.ToInt32(dr["IdEstadoRolUsuario"]);
}
}
return nIdEstadoRolUsuario;
}

public int ModificaEstadoRolUsuario(clsEstadoRolUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoRolUsuario",3, pPaq.IdEstadoRolUsuario, pPaq.NombreEstadoRolUsuario, pPaq.Detalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoRolUsuario(clsEstadoRolUsuarioBE pEstadoRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoRolUsuario",4, pEstadoRolUsuario.IdEstadoRolUsuario, pEstadoRolUsuario.NombreEstadoRolUsuario, pEstadoRolUsuario.Detalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoRolUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoRolUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
