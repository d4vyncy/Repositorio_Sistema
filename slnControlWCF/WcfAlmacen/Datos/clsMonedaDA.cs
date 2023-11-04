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
public class clsMonedaDA : clsMonedaBE
{

Database db = null;
//DataSet dtoMoneda;

public clsMonedaDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneMoneda(clsMonedaBE pMoneda)
{
DbCommand cmd = db.GetStoredProcCommand("pagMoneda",2, pMoneda.IdMoneda, pMoneda.NombreMoneda);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaMoneda(clsMonedaBE pMoneda)
{
DbCommand cmd = db.GetStoredProcCommand("pagMoneda",1, pMoneda.IdMoneda, pMoneda.NombreMoneda);
int nIdMoneda = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdMoneda = Convert.ToInt32(dr["IdMoneda"]);
}
}
return nIdMoneda;
}

public int ModificaMoneda(clsMonedaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagMoneda",3, pPaq.IdMoneda, pPaq.NombreMoneda);
return db.ExecuteNonQuery(cmd);
}

public int EliminaMoneda(clsMonedaBE pMoneda)
{
DbCommand cmd = db.GetStoredProcCommand("pagMoneda",4, pMoneda.IdMoneda, pMoneda.NombreMoneda);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavMoneda(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavMoneda" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
