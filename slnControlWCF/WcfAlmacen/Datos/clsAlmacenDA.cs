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
public class clsAlmacenDA : clsAlmacenBE
{

Database db = null;
//DataSet dtoAlmacen;

public clsAlmacenDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneAlmacen(clsAlmacenBE pAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacen",2, pAlmacen.IdAlmacen, pAlmacen.NombreAlmacen, pAlmacen.IdEntidad);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaAlmacen(clsAlmacenBE pAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacen",1, pAlmacen.IdAlmacen, pAlmacen.NombreAlmacen, pAlmacen.IdEntidad);
int nIdAlmacen = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
}
}
return nIdAlmacen;
}

public int ModificaAlmacen(clsAlmacenBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacen",3, pPaq.IdAlmacen, pPaq.NombreAlmacen, pPaq.IdEntidad);
return db.ExecuteNonQuery(cmd);
}

public int EliminaAlmacen(clsAlmacenBE pAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagAlmacen",4, pAlmacen.IdAlmacen, pAlmacen.NombreAlmacen, pAlmacen.IdEntidad);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavAlmacen(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavAlmacen" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
