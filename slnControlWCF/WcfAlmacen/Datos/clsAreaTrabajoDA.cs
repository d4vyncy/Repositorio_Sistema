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
public class clsAreaTrabajoDA : clsAreaTrabajoBE
{

Database db = null;
//DataSet dtoAreaTrabajo;

public clsAreaTrabajoDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneAreaTrabajo(clsAreaTrabajoBE pAreaTrabajo)
{
DbCommand cmd = db.GetStoredProcCommand("pagAreaTrabajo",2, pAreaTrabajo.IdAreaTrabajo, pAreaTrabajo.NombreAreaTrabajo);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaAreaTrabajo(clsAreaTrabajoBE pAreaTrabajo)
{
DbCommand cmd = db.GetStoredProcCommand("pagAreaTrabajo",1, pAreaTrabajo.IdAreaTrabajo, pAreaTrabajo.NombreAreaTrabajo);
int nIdAreaTrabajo = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdAreaTrabajo = Convert.ToInt32(dr["IdAreaTrabajo"]);
}
}
return nIdAreaTrabajo;
}

public int ModificaAreaTrabajo(clsAreaTrabajoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagAreaTrabajo",3, pPaq.IdAreaTrabajo, pPaq.NombreAreaTrabajo);
return db.ExecuteNonQuery(cmd);
}

public int EliminaAreaTrabajo(clsAreaTrabajoBE pAreaTrabajo)
{
DbCommand cmd = db.GetStoredProcCommand("pagAreaTrabajo",4, pAreaTrabajo.IdAreaTrabajo, pAreaTrabajo.NombreAreaTrabajo);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavAreaTrabajo(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavAreaTrabajo" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
