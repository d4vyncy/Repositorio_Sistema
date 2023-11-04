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
public class clsEquipoDA : clsEquipoBE
{

Database db = null;
//DataSet dtoEquipo;

public clsEquipoDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneEquipo(clsEquipoBE pEquipo)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipo",2, pEquipo.IdEquipo, pEquipo.Hostname, pEquipo.IpEquipo, pEquipo.Descripcion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEquipo(clsEquipoBE pEquipo)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipo",1, pEquipo.IdEquipo, pEquipo.Hostname, pEquipo.IpEquipo, pEquipo.Descripcion);
int nIdEquipo = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEquipo = Convert.ToInt32(dr["IdEquipo"]);
}
}
return nIdEquipo;
}

public int ModificaEquipo(clsEquipoBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipo",3, pPaq.IdEquipo, pPaq.Hostname, pPaq.IpEquipo, pPaq.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEquipo(clsEquipoBE pEquipo)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipo",4, pEquipo.IdEquipo, pEquipo.Hostname, pEquipo.IpEquipo, pEquipo.Descripcion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEquipo(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEquipo" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
