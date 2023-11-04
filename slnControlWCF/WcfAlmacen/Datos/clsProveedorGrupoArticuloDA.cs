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
public class clsProveedorGrupoArticuloDA : clsProveedorGrupoArticuloBE
{

Database db = null;
//DataSet dtoProveedorGrupoArticulo;

public clsProveedorGrupoArticuloDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneProveedorGrupoArticulo(clsProveedorGrupoArticuloBE pProveedorGrupoArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedorGrupoArticulo",2, pProveedorGrupoArticulo.IdProveedorGrupoArticulo, pProveedorGrupoArticulo.IdProveedor, pProveedorGrupoArticulo.IdGrupoArticulo, pProveedorGrupoArticulo.IdUsuarioRegistro);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaProveedorGrupoArticulo(clsProveedorGrupoArticuloBE pProveedorGrupoArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedorGrupoArticulo",1, pProveedorGrupoArticulo.IdProveedorGrupoArticulo, pProveedorGrupoArticulo.IdProveedor, pProveedorGrupoArticulo.IdGrupoArticulo, pProveedorGrupoArticulo.IdUsuarioRegistro);
int nIdProveedorGrupoArticulo = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdProveedorGrupoArticulo = Convert.ToInt32(dr["IdProveedorGrupoArticulo"]);
}
}
return nIdProveedorGrupoArticulo;
}

public int ModificaProveedorGrupoArticulo(clsProveedorGrupoArticuloBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedorGrupoArticulo",3, pPaq.IdProveedorGrupoArticulo, pPaq.IdProveedor, pPaq.IdGrupoArticulo, pPaq.IdUsuarioRegistro);
return db.ExecuteNonQuery(cmd);
}

public int EliminaProveedorGrupoArticulo(clsProveedorGrupoArticuloBE pProveedorGrupoArticulo)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedorGrupoArticulo",4, pProveedorGrupoArticulo.IdProveedorGrupoArticulo, pProveedorGrupoArticulo.IdProveedor, pProveedorGrupoArticulo.IdGrupoArticulo, pProveedorGrupoArticulo.IdUsuarioRegistro);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavProveedorGrupoArticulo(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavProveedorGrupoArticulo" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
