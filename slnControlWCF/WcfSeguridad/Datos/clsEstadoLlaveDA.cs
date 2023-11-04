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
using WcfSeguridad.Entidades;

namespace WcfSeguridad.Datos 
{
public class clsEstadoLlaveDA : clsEstadoLlaveBE
{

Database db = null;
//DataSet dtoEstadoLlave;

public clsEstadoLlaveDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneEstadoLlave(clsEstadoLlaveBE pEstadoLlave)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoLlave",2, pEstadoLlave.IdEstadoLlave, pEstadoLlave.NombreEstadoLlave, pEstadoLlave.Detalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEstadoLlave(clsEstadoLlaveBE pEstadoLlave)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoLlave",1, pEstadoLlave.IdEstadoLlave, pEstadoLlave.NombreEstadoLlave, pEstadoLlave.Detalle);
int nIdEstadoLlave = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEstadoLlave = Convert.ToInt32(dr["IdEstadoLlave"]);
}
}
return nIdEstadoLlave;
}

public int ModificaEstadoLlave(clsEstadoLlaveBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoLlave",3, pPaq.IdEstadoLlave, pPaq.NombreEstadoLlave, pPaq.Detalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEstadoLlave(clsEstadoLlaveBE pEstadoLlave)
{
DbCommand cmd = db.GetStoredProcCommand("pagEstadoLlave",4, pEstadoLlave.IdEstadoLlave, pEstadoLlave.NombreEstadoLlave, pEstadoLlave.Detalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEstadoLlave(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEstadoLlave" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
