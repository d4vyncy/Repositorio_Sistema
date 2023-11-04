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
public class clsSistemaDA : clsSistemaBE
{

Database db = null;
//DataSet dtoSistema;

public clsSistemaDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneSistema(clsSistemaBE pSistema)
{
DbCommand cmd = db.GetStoredProcCommand("pagSistema",2, pSistema.IdSistema, pSistema.NombreSistema, pSistema.IpServer, pSistema.HostNameServer, pSistema.Url, pSistema.Imagen, pSistema.Detalle);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaSistema(clsSistemaBE pSistema)
{
DbCommand cmd = db.GetStoredProcCommand("pagSistema",1, pSistema.IdSistema, pSistema.NombreSistema, pSistema.IpServer, pSistema.HostNameServer, pSistema.Url, pSistema.Imagen, pSistema.Detalle);
int nIdSistema = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdSistema = Convert.ToInt32(dr["IdSistema"]);
}
}
return nIdSistema;
}

public int ModificaSistema(clsSistemaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagSistema",3, pPaq.IdSistema, pPaq.NombreSistema, pPaq.IpServer, pPaq.HostNameServer, pPaq.Url, pPaq.Imagen, pPaq.Detalle);
return db.ExecuteNonQuery(cmd);
}

public int EliminaSistema(clsSistemaBE pSistema)
{
DbCommand cmd = db.GetStoredProcCommand("pagSistema",4, pSistema.IdSistema, pSistema.NombreSistema, pSistema.IpServer, pSistema.HostNameServer, pSistema.Url, pSistema.Imagen, pSistema.Detalle);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavSistema(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavSistema" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
