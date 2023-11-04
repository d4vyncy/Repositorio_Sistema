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
public class clsEstadoEgresoDA : clsEstadoEgresoBE
{

Database db = null;
//DataSet dtoEstadoEgreso;

public clsEstadoEgresoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneEstadoEgreso(clsEstadoEgresoBE pEstadoEgreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoEgreso",2, pEstadoEgreso.IdEstadoEgreso, pEstadoEgreso.NombreEstadoEgreso, pEstadoEgreso.Descripcion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoEgreso(clsEstadoEgresoBE pEstadoEgreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoEgreso",1, pEstadoEgreso.IdEstadoEgreso, pEstadoEgreso.NombreEstadoEgreso, pEstadoEgreso.Descripcion);
int nIdEstadoEgreso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoEgreso = Convert.ToInt32(dr["IdEstadoEgreso"]);
}
}
return nIdEstadoEgreso;
}

public int ModificaEstadoEgreso(clsEstadoEgresoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoEgreso",3, pPaq.IdEstadoEgreso, pPaq.NombreEstadoEgreso, pPaq.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoEgreso(clsEstadoEgresoBE pEstadoEgreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoEgreso",4, pEstadoEgreso.IdEstadoEgreso, pEstadoEgreso.NombreEstadoEgreso, pEstadoEgreso.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoEgreso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoEgreso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
