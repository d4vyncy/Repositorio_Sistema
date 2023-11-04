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
public class clsUsuarioLogueadoDA : clsUsuarioLogueadoBE
{

Database db = null;
//DataSet dtoUsuarioLogueado;

public clsUsuarioLogueadoDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneUsuarioLogueado(clsUsuarioLogueadoBE pUsuarioLogueado)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioLogueado",2, pUsuarioLogueado.IdUsuarioLogueado, pUsuarioLogueado.IdUsuario, pUsuarioLogueado.IdRolUsuario, pUsuarioLogueado.Llave, pUsuarioLogueado.IdEstadoLlave, pUsuarioLogueado.Fecha, pUsuarioLogueado.DireccionIP, pUsuarioLogueado.DireccionHost, pUsuarioLogueado.DireccionDest);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaUsuarioLogueado(clsUsuarioLogueadoBE pUsuarioLogueado)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioLogueado",1, pUsuarioLogueado.IdUsuarioLogueado, pUsuarioLogueado.IdUsuario, pUsuarioLogueado.IdRolUsuario, pUsuarioLogueado.Llave, pUsuarioLogueado.IdEstadoLlave, pUsuarioLogueado.Fecha, pUsuarioLogueado.DireccionIP, pUsuarioLogueado.DireccionHost, pUsuarioLogueado.DireccionDest);
int nIdUsuarioLogueado = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdUsuarioLogueado = Convert.ToInt32(dr["IdUsuarioLogueado"]);
}
}
return nIdUsuarioLogueado;
}

public int ModificaUsuarioLogueado(clsUsuarioLogueadoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioLogueado",3, pPaq.IdUsuarioLogueado, pPaq.IdUsuario, pPaq.IdRolUsuario, pPaq.Llave, pPaq.IdEstadoLlave, pPaq.Fecha, pPaq.DireccionIP, pPaq.DireccionHost, pPaq.DireccionDest);
return db.ExecuteNonQuery(cmd);
}

public int EliminaUsuarioLogueado(clsUsuarioLogueadoBE pUsuarioLogueado)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioLogueado",4, pUsuarioLogueado.IdUsuarioLogueado, pUsuarioLogueado.IdUsuario, pUsuarioLogueado.IdRolUsuario, pUsuarioLogueado.Llave, pUsuarioLogueado.IdEstadoLlave, pUsuarioLogueado.Fecha, pUsuarioLogueado.DireccionIP, pUsuarioLogueado.DireccionHost, pUsuarioLogueado.DireccionDest);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavUsuarioLogueado(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavUsuarioLogueado" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
