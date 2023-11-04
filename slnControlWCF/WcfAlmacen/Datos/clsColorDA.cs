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
public class clsColorDA : clsColorBE
{

Database db = null;
//DataSet dtoColor;

public clsColorDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneColor(clsColorBE pColor)
{
DbCommand cmd = db.GetStoredProcCommand("pagColor",2, pColor.IdColor, pColor.NombreColor);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaColor(clsColorBE pColor)
{
DbCommand cmd = db.GetStoredProcCommand("pagColor",1, pColor.IdColor, pColor.NombreColor);
int nIdColor = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdColor = Convert.ToInt32(dr["IdColor"]);
}
}
return nIdColor;
}

public int ModificaColor(clsColorBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagColor",3, pPaq.IdColor, pPaq.NombreColor);
return db.ExecuteNonQuery(cmd);
}

public int EliminaColor(clsColorBE pColor)
{
DbCommand cmd = db.GetStoredProcCommand("pagColor",4, pColor.IdColor, pColor.NombreColor);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavColor(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavColor" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
