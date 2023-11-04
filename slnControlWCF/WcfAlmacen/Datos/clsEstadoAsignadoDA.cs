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
using WcfAlmacen.Entidades;

namespace WcfAlmacen.Datos 
{
public class clsEstadoAsignadoDA : clsEstadoAsignadoBE
{

Database db = null;
//DataSet dtoEstadoAsignado;

public clsEstadoAsignadoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneEstadoAsignado(clsEstadoAsignadoBE pEstadoAsignado)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoAsignado",2, pEstadoAsignado.IdEstadoAsignado, pEstadoAsignado.NombreEstadoAsignado, pEstadoAsignado.Descripcion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoAsignado(clsEstadoAsignadoBE pEstadoAsignado)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoAsignado",1, pEstadoAsignado.IdEstadoAsignado, pEstadoAsignado.NombreEstadoAsignado, pEstadoAsignado.Descripcion);
int nIdEstadoAsignado = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoAsignado = Convert.ToInt32(dr["IdEstadoAsignado"]);
}
}
return nIdEstadoAsignado;
}

public int ModificaEstadoAsignado(clsEstadoAsignadoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoAsignado",3, pPaq.IdEstadoAsignado, pPaq.NombreEstadoAsignado, pPaq.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoAsignado(clsEstadoAsignadoBE pEstadoAsignado)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoAsignado",4, pEstadoAsignado.IdEstadoAsignado, pEstadoAsignado.NombreEstadoAsignado, pEstadoAsignado.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoAsignado(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoAsignado" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
