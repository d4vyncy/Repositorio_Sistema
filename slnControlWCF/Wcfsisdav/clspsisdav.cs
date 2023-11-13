//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace Wcfsisdav
{
public class clspsisdav
{
Database db = null;
public clspsisdav()
{ db = DatabaseFactory.CreateDatabase("Consisdav"); }
public DataSet ProcedureParametro(string Procedimiento, params object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand(Procedimiento, pParametros);
return db.ExecuteDataSet(cmd);
}
public int EjecutaConsulta(string Consulta)
{
DbCommand cmd = db.GetSqlStringCommand(Consulta);
return db.ExecuteNonQuery(cmd);
}
}
}
