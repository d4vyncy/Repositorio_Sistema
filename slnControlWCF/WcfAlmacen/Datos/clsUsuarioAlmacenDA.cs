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
public class clsUsuarioAlmacenDA : clsUsuarioAlmacenBE
{

Database db = null;
//DataSet dtoUsuarioAlmacen;

public clsUsuarioAlmacenDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneUsuarioAlmacen(clsUsuarioAlmacenBE pUsuarioAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioAlmacen",2, pUsuarioAlmacen.IdUsuarioAlmacen, pUsuarioAlmacen.IdUsuario, pUsuarioAlmacen.IdAlmacen, pUsuarioAlmacen.IdEstadoAsignado);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaUsuarioAlmacen(clsUsuarioAlmacenBE pUsuarioAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioAlmacen",1, pUsuarioAlmacen.IdUsuarioAlmacen, pUsuarioAlmacen.IdUsuario, pUsuarioAlmacen.IdAlmacen, pUsuarioAlmacen.IdEstadoAsignado);
int nIdUsuarioAlmacen = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdUsuarioAlmacen = Convert.ToInt32(dr["IdUsuarioAlmacen"]);
}
}
return nIdUsuarioAlmacen;
}

public int ModificaUsuarioAlmacen(clsUsuarioAlmacenBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioAlmacen",3, pPaq.IdUsuarioAlmacen, pPaq.IdUsuario, pPaq.IdAlmacen, pPaq.IdEstadoAsignado);
return db.ExecuteNonQuery(cmd);
}

public int EliminaUsuarioAlmacen(clsUsuarioAlmacenBE pUsuarioAlmacen)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuarioAlmacen",4, pUsuarioAlmacen.IdUsuarioAlmacen, pUsuarioAlmacen.IdUsuario, pUsuarioAlmacen.IdAlmacen, pUsuarioAlmacen.IdEstadoAsignado);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavUsuarioAlmacen(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavUsuarioAlmacen" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
