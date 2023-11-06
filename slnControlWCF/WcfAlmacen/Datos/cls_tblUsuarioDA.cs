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
public class cls_tblUsuarioDA : cls_tblUsuarioBE
{

Database db = null;
//DataSet dto_tblUsuario;

public cls_tblUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblUsuario(cls_tblUsuarioBE p_tblUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuario",2, p_tblUsuario.IdUsuario, p_tblUsuario.IdPersona, p_tblUsuario.NombreUsuario, p_tblUsuario.Clave, p_tblUsuario.Salt, p_tblUsuario.Pin, p_tblUsuario.IdEstadoUsuario, p_tblUsuario.IdTipoUsuario, p_tblUsuario.Estilo);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblUsuario(cls_tblUsuarioBE p_tblUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuario",1, p_tblUsuario.IdUsuario, p_tblUsuario.IdPersona, p_tblUsuario.NombreUsuario, p_tblUsuario.Clave, p_tblUsuario.Salt, p_tblUsuario.Pin, p_tblUsuario.IdEstadoUsuario, p_tblUsuario.IdTipoUsuario, p_tblUsuario.Estilo);
int nId_tblUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblUsuario = Convert.ToInt32(dr["Id_tblUsuario"]);
}
}
return nId_tblUsuario;
}

public int Modifica_tblUsuario(cls_tblUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuario",3, pPaq.IdUsuario, pPaq.IdPersona, pPaq.NombreUsuario, pPaq.Clave, pPaq.Salt, pPaq.Pin, pPaq.IdEstadoUsuario, pPaq.IdTipoUsuario, pPaq.Estilo);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblUsuario(cls_tblUsuarioBE p_tblUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuario",4, p_tblUsuario.IdUsuario, p_tblUsuario.IdPersona, p_tblUsuario.NombreUsuario, p_tblUsuario.Clave, p_tblUsuario.Salt, p_tblUsuario.Pin, p_tblUsuario.IdEstadoUsuario, p_tblUsuario.IdTipoUsuario, p_tblUsuario.Estilo);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
