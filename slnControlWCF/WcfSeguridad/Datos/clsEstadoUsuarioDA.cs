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
public class clsEstadoUsuarioDA : clsEstadoUsuarioBE
{

Database db = null;
//DataSet dtoEstadoUsuario;

public clsEstadoUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneEstadoUsuario(clsEstadoUsuarioBE pEstadoUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoUsuario",2, pEstadoUsuario.IdEstadoUsuario, pEstadoUsuario.NombreEstadoUsuario, pEstadoUsuario.Detalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoUsuario(clsEstadoUsuarioBE pEstadoUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoUsuario",1, pEstadoUsuario.IdEstadoUsuario, pEstadoUsuario.NombreEstadoUsuario, pEstadoUsuario.Detalle);
int nIdEstadoUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoUsuario = Convert.ToInt32(dr["IdEstadoUsuario"]);
}
}
return nIdEstadoUsuario;
}

public int ModificaEstadoUsuario(clsEstadoUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoUsuario",3, pPaq.IdEstadoUsuario, pPaq.NombreEstadoUsuario, pPaq.Detalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoUsuario(clsEstadoUsuarioBE pEstadoUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoUsuario",4, pEstadoUsuario.IdEstadoUsuario, pEstadoUsuario.NombreEstadoUsuario, pEstadoUsuario.Detalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
