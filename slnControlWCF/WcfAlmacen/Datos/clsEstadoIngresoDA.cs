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
public class clsEstadoIngresoDA : clsEstadoIngresoBE
{

Database db = null;
//DataSet dtoEstadoIngreso;

public clsEstadoIngresoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneEstadoIngreso(clsEstadoIngresoBE pEstadoIngreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoIngreso",2, pEstadoIngreso.IdEstadoIngreso, pEstadoIngreso.NombreEstadoIngreso, pEstadoIngreso.Descripcion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoIngreso(clsEstadoIngresoBE pEstadoIngreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoIngreso",1, pEstadoIngreso.IdEstadoIngreso, pEstadoIngreso.NombreEstadoIngreso, pEstadoIngreso.Descripcion);
int nIdEstadoIngreso = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoIngreso = Convert.ToInt32(dr["IdEstadoIngreso"]);
}
}
return nIdEstadoIngreso;
}

public int ModificaEstadoIngreso(clsEstadoIngresoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoIngreso",3, pPaq.IdEstadoIngreso, pPaq.NombreEstadoIngreso, pPaq.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoIngreso(clsEstadoIngresoBE pEstadoIngreso)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoIngreso",4, pEstadoIngreso.IdEstadoIngreso, pEstadoIngreso.NombreEstadoIngreso, pEstadoIngreso.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoIngreso(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoIngreso" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
