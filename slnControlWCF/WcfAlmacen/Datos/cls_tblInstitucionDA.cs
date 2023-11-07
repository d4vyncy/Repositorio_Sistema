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
public class cls_tblInstitucionDA : cls_tblInstitucionBE
{

Database db = null;
//DataSet dto_tblInstitucion;

public cls_tblInstitucionDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblInstitucion(cls_tblInstitucionBE p_tblInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblInstitucion",2, p_tblInstitucion.IdInstitucion, p_tblInstitucion.IdInstitucionPadre, p_tblInstitucion.NombreInstitucion, p_tblInstitucion.IdTipoInstitucion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblInstitucion(cls_tblInstitucionBE p_tblInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblInstitucion",1, p_tblInstitucion.IdInstitucion, p_tblInstitucion.IdInstitucionPadre, p_tblInstitucion.NombreInstitucion, p_tblInstitucion.IdTipoInstitucion);
int nId_tblInstitucion = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblInstitucion = Convert.ToInt32(dr["Id_tblInstitucion"]);
}
}
return nId_tblInstitucion;
}

public int Modifica_tblInstitucion(cls_tblInstitucionBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblInstitucion",3, pPaq.IdInstitucion, pPaq.IdInstitucionPadre, pPaq.NombreInstitucion, pPaq.IdTipoInstitucion);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblInstitucion(cls_tblInstitucionBE p_tblInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblInstitucion",4, p_tblInstitucion.IdInstitucion, p_tblInstitucion.IdInstitucionPadre, p_tblInstitucion.NombreInstitucion, p_tblInstitucion.IdTipoInstitucion);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblInstitucion(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblInstitucion" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
