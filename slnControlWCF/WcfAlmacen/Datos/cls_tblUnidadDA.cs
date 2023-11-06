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
public class cls_tblUnidadDA : cls_tblUnidadBE
{

Database db = null;
//DataSet dto_tblUnidad;

public cls_tblUnidadDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblUnidad(cls_tblUnidadBE p_tblUnidad)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUnidad",2, p_tblUnidad.IdUnidad, p_tblUnidad.NombreUnidad, p_tblUnidad.CodigoUnidad, p_tblUnidad.IdPadreUnidad, p_tblUnidad.Orden, p_tblUnidad.IdEntidad);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblUnidad(cls_tblUnidadBE p_tblUnidad)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUnidad",1, p_tblUnidad.IdUnidad, p_tblUnidad.NombreUnidad, p_tblUnidad.CodigoUnidad, p_tblUnidad.IdPadreUnidad, p_tblUnidad.Orden, p_tblUnidad.IdEntidad);
int nId_tblUnidad = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblUnidad = Convert.ToInt32(dr["Id_tblUnidad"]);
}
}
return nId_tblUnidad;
}

public int Modifica_tblUnidad(cls_tblUnidadBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUnidad",3, pPaq.IdUnidad, pPaq.NombreUnidad, pPaq.CodigoUnidad, pPaq.IdPadreUnidad, pPaq.Orden, pPaq.IdEntidad);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblUnidad(cls_tblUnidadBE p_tblUnidad)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblUnidad",4, p_tblUnidad.IdUnidad, p_tblUnidad.NombreUnidad, p_tblUnidad.CodigoUnidad, p_tblUnidad.IdPadreUnidad, p_tblUnidad.Orden, p_tblUnidad.IdEntidad);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblUnidad(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblUnidad" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
