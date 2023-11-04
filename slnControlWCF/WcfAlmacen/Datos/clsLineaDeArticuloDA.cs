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
public class clsLineaDeArticuloDA : clsLineaDeArticuloBE
{

Database db = null;
//DataSet dtoLineaDeArticulo;

public clsLineaDeArticuloDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneLineaDeArticulo(clsLineaDeArticuloBE pLineaDeArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagLineaDeArticulo",2, pLineaDeArticulo.IdLineaDeArticulo, pLineaDeArticulo.NombreLineaDeArticulo);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaLineaDeArticulo(clsLineaDeArticuloBE pLineaDeArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagLineaDeArticulo",1, pLineaDeArticulo.IdLineaDeArticulo, pLineaDeArticulo.NombreLineaDeArticulo);
int nIdLineaDeArticulo = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdLineaDeArticulo = Convert.ToInt32(dr["IdLineaDeArticulo"]);
}
}
return nIdLineaDeArticulo;
}

public int ModificaLineaDeArticulo(clsLineaDeArticuloBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagLineaDeArticulo",3, pPaq.IdLineaDeArticulo, pPaq.NombreLineaDeArticulo);
return db.ExecuteNonQuery(cmd);
}

public int EliminaLineaDeArticulo(clsLineaDeArticuloBE pLineaDeArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagLineaDeArticulo",4, pLineaDeArticulo.IdLineaDeArticulo, pLineaDeArticulo.NombreLineaDeArticulo);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavLineaDeArticulo(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavLineaDeArticulo" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
