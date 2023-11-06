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
public class cls_tblRolDA : cls_tblRolBE
{

Database db = null;
//DataSet dto_tblRol;

public cls_tblRolDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblRol(cls_tblRolBE p_tblRol)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRol",2, p_tblRol.IdRol, p_tblRol.NombreRol, p_tblRol.IdSistema);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblRol(cls_tblRolBE p_tblRol)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRol",1, p_tblRol.IdRol, p_tblRol.NombreRol, p_tblRol.IdSistema);
int nId_tblRol = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblRol = Convert.ToInt32(dr["Id_tblRol"]);
}
}
return nId_tblRol;
}

public int Modifica_tblRol(cls_tblRolBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRol",3, pPaq.IdRol, pPaq.NombreRol, pPaq.IdSistema);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblRol(cls_tblRolBE p_tblRol)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblRol",4, p_tblRol.IdRol, p_tblRol.NombreRol, p_tblRol.IdSistema);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblRol(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblRol" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
