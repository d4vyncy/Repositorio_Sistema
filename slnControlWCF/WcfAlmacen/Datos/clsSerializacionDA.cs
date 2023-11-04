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
public class clsSerializacionDA : clsSerializacionBE
{

Database db = null;
//DataSet dtoSerializacion;

public clsSerializacionDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneSerializacion(clsSerializacionBE pSerializacion)
{
DbCommand cmd = db.GetStoredProcCommand("pagSerializacion",2, pSerializacion.IdSerializacion, pSerializacion.EstadoSerializacion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaSerializacion(clsSerializacionBE pSerializacion)
{
DbCommand cmd = db.GetStoredProcCommand("pagSerializacion",1, pSerializacion.IdSerializacion, pSerializacion.EstadoSerializacion);
int nIdSerializacion = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdSerializacion = Convert.ToInt32(dr["IdSerializacion"]);
}
}
return nIdSerializacion;
}

public int ModificaSerializacion(clsSerializacionBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagSerializacion",3, pPaq.IdSerializacion, pPaq.EstadoSerializacion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaSerializacion(clsSerializacionBE pSerializacion)
{
DbCommand cmd = db.GetStoredProcCommand("pagSerializacion",4, pSerializacion.IdSerializacion, pSerializacion.EstadoSerializacion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavSerializacion(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavSerializacion" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
