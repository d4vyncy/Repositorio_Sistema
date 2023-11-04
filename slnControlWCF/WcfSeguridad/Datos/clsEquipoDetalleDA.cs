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
public class clsEquipoDetalleDA : clsEquipoDetalleBE
{

Database db = null;
//DataSet dtoEquipoDetalle;

public clsEquipoDetalleDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneEquipoDetalle(clsEquipoDetalleBE pEquipoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipoDetalle",2, pEquipoDetalle.IdEquipoDetalle, pEquipoDetalle.IdEquipo, pEquipoDetalle.Descripcion, pEquipoDetalle.FechaConsulta, pEquipoDetalle.Respuesta);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaEquipoDetalle(clsEquipoDetalleBE pEquipoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipoDetalle",1, pEquipoDetalle.IdEquipoDetalle, pEquipoDetalle.IdEquipo, pEquipoDetalle.Descripcion, pEquipoDetalle.FechaConsulta, pEquipoDetalle.Respuesta);
int nIdEquipoDetalle = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdEquipoDetalle = Convert.ToInt32(dr["IdEquipoDetalle"]);
}
}
return nIdEquipoDetalle;
}

public int ModificaEquipoDetalle(clsEquipoDetalleBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipoDetalle",3, pPaq.IdEquipoDetalle, pPaq.IdEquipo, pPaq.Descripcion, pPaq.FechaConsulta, pPaq.Respuesta);
return db.ExecuteNonQuery(cmd);
}

public int EliminaEquipoDetalle(clsEquipoDetalleBE pEquipoDetalle)
{
DbCommand cmd = db.GetStoredProcCommand("pagEquipoDetalle",4, pEquipoDetalle.IdEquipoDetalle, pEquipoDetalle.IdEquipo, pEquipoDetalle.Descripcion, pEquipoDetalle.FechaConsulta, pEquipoDetalle.Respuesta);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavEquipoDetalle(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavEquipoDetalle" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
