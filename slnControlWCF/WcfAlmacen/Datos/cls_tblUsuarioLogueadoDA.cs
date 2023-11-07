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
public class cls_tblUsuarioLogueadoDA : cls_tblUsuarioLogueadoBE
{

Database db = null;
//DataSet dto_tblUsuarioLogueado;

public cls_tblUsuarioLogueadoDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblUsuarioLogueado(cls_tblUsuarioLogueadoBE p_tblUsuarioLogueado)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuarioLogueado",2, p_tblUsuarioLogueado.IdUsuarioLogueado, p_tblUsuarioLogueado.IdUsuario, p_tblUsuarioLogueado.IdRolUsuario, p_tblUsuarioLogueado.Llave, p_tblUsuarioLogueado.IdEstadoLlave, p_tblUsuarioLogueado.Fecha, p_tblUsuarioLogueado.DireccionIP, p_tblUsuarioLogueado.DireccionHost, p_tblUsuarioLogueado.DireccionDest);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblUsuarioLogueado(cls_tblUsuarioLogueadoBE p_tblUsuarioLogueado)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuarioLogueado",1, p_tblUsuarioLogueado.IdUsuarioLogueado, p_tblUsuarioLogueado.IdUsuario, p_tblUsuarioLogueado.IdRolUsuario, p_tblUsuarioLogueado.Llave, p_tblUsuarioLogueado.IdEstadoLlave, p_tblUsuarioLogueado.Fecha, p_tblUsuarioLogueado.DireccionIP, p_tblUsuarioLogueado.DireccionHost, p_tblUsuarioLogueado.DireccionDest);
int nId_tblUsuarioLogueado = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblUsuarioLogueado = Convert.ToInt32(dr["Id_tblUsuarioLogueado"]);
}
}
return nId_tblUsuarioLogueado;
}

public int Modifica_tblUsuarioLogueado(cls_tblUsuarioLogueadoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuarioLogueado",3, pPaq.IdUsuarioLogueado, pPaq.IdUsuario, pPaq.IdRolUsuario, pPaq.Llave, pPaq.IdEstadoLlave, pPaq.Fecha, pPaq.DireccionIP, pPaq.DireccionHost, pPaq.DireccionDest);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblUsuarioLogueado(cls_tblUsuarioLogueadoBE p_tblUsuarioLogueado)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUsuarioLogueado",4, p_tblUsuarioLogueado.IdUsuarioLogueado, p_tblUsuarioLogueado.IdUsuario, p_tblUsuarioLogueado.IdRolUsuario, p_tblUsuarioLogueado.Llave, p_tblUsuarioLogueado.IdEstadoLlave, p_tblUsuarioLogueado.Fecha, p_tblUsuarioLogueado.DireccionIP, p_tblUsuarioLogueado.DireccionHost, p_tblUsuarioLogueado.DireccionDest);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblUsuarioLogueado(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblUsuarioLogueado" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
