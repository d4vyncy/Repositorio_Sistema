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
public class cls_tblItemInstitucionDA : cls_tblItemInstitucionBE
{

Database db = null;
//DataSet dto_tblItemInstitucion;

public cls_tblItemInstitucionDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblItemInstitucion(cls_tblItemInstitucionBE p_tblItemInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblItemInstitucion",2, p_tblItemInstitucion.IdItemInstitucion, p_tblItemInstitucion.NroItem, p_tblItemInstitucion.IdEntidad, p_tblItemInstitucion.IdUnidad, p_tblItemInstitucion.IdPuesto);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblItemInstitucion(cls_tblItemInstitucionBE p_tblItemInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblItemInstitucion",1, p_tblItemInstitucion.IdItemInstitucion, p_tblItemInstitucion.NroItem, p_tblItemInstitucion.IdEntidad, p_tblItemInstitucion.IdUnidad, p_tblItemInstitucion.IdPuesto);
int nId_tblItemInstitucion = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblItemInstitucion = Convert.ToInt32(dr["Id_tblItemInstitucion"]);
}
}
return nId_tblItemInstitucion;
}

public int Modifica_tblItemInstitucion(cls_tblItemInstitucionBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblItemInstitucion",3, pPaq.IdItemInstitucion, pPaq.NroItem, pPaq.IdEntidad, pPaq.IdUnidad, pPaq.IdPuesto);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblItemInstitucion(cls_tblItemInstitucionBE p_tblItemInstitucion)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblItemInstitucion",4, p_tblItemInstitucion.IdItemInstitucion, p_tblItemInstitucion.NroItem, p_tblItemInstitucion.IdEntidad, p_tblItemInstitucion.IdUnidad, p_tblItemInstitucion.IdPuesto);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblItemInstitucion(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblItemInstitucion" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
