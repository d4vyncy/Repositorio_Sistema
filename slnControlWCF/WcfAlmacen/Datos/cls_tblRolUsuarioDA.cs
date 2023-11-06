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
public class cls_tblRolUsuarioDA : cls_tblRolUsuarioBE
{

Database db = null;
//DataSet dto_tblRolUsuario;

public cls_tblRolUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblRolUsuario(cls_tblRolUsuarioBE p_tblRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRolUsuario",2, p_tblRolUsuario.IdRolUsuario, p_tblRolUsuario.IdRol, p_tblRolUsuario.IdUsuario, p_tblRolUsuario.IdEstadoRolUsuario, p_tblRolUsuario.IdTipoRolUsuario, p_tblRolUsuario.IdUsuarioCreacion, p_tblRolUsuario.FechaBaja);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblRolUsuario(cls_tblRolUsuarioBE p_tblRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRolUsuario",1, p_tblRolUsuario.IdRolUsuario, p_tblRolUsuario.IdRol, p_tblRolUsuario.IdUsuario, p_tblRolUsuario.IdEstadoRolUsuario, p_tblRolUsuario.IdTipoRolUsuario, p_tblRolUsuario.IdUsuarioCreacion, p_tblRolUsuario.FechaBaja);
int nId_tblRolUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblRolUsuario = Convert.ToInt32(dr["Id_tblRolUsuario"]);
}
}
return nId_tblRolUsuario;
}

public int Modifica_tblRolUsuario(cls_tblRolUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRolUsuario",3, pPaq.IdRolUsuario, pPaq.IdRol, pPaq.IdUsuario, pPaq.IdEstadoRolUsuario, pPaq.IdTipoRolUsuario, pPaq.IdUsuarioCreacion, pPaq.FechaBaja);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblRolUsuario(cls_tblRolUsuarioBE p_tblRolUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRolUsuario",4, p_tblRolUsuario.IdRolUsuario, p_tblRolUsuario.IdRol, p_tblRolUsuario.IdUsuario, p_tblRolUsuario.IdEstadoRolUsuario, p_tblRolUsuario.IdTipoRolUsuario, p_tblRolUsuario.IdUsuarioCreacion, p_tblRolUsuario.FechaBaja);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblRolUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblRolUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
