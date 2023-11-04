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
public class clsProveedorDA : clsProveedorBE
{

Database db = null;
//DataSet dtoProveedor;

public clsProveedorDA()
{
db = DatabaseFactory.CreateDatabase("ConAlmacen");
}

public IDataReader ObtieneProveedor(clsProveedorBE pProveedor)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedor",2, pProveedor.IdProveedor, pProveedor.IdPersona, pProveedor.Representante, pProveedor.NombreProveedor, pProveedor.Direccion, pProveedor.Telefono, pProveedor.NitProveedor, pProveedor.ServiciosGenerales, pProveedor.Celular, pProveedor.Correo, pProveedor.IdAreaTrabajo);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaProveedor(clsProveedorBE pProveedor)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedor",1, pProveedor.IdProveedor, pProveedor.IdPersona, pProveedor.Representante, pProveedor.NombreProveedor, pProveedor.Direccion, pProveedor.Telefono, pProveedor.NitProveedor, pProveedor.ServiciosGenerales, pProveedor.Celular, pProveedor.Correo, pProveedor.IdAreaTrabajo);
int nIdProveedor = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdProveedor = Convert.ToInt32(dr["IdProveedor"]);
}
}
return nIdProveedor;
}

public int ModificaProveedor(clsProveedorBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedor",3, pPaq.IdProveedor, pPaq.IdPersona, pPaq.Representante, pPaq.NombreProveedor, pPaq.Direccion, pPaq.Telefono, pPaq.NitProveedor, pPaq.ServiciosGenerales, pPaq.Celular, pPaq.Correo, pPaq.IdAreaTrabajo);
return db.ExecuteNonQuery(cmd);
}

public int EliminaProveedor(clsProveedorBE pProveedor)
{
DbCommand cmd = db.GetStoredProcCommand("pagProveedor",4, pProveedor.IdProveedor, pProveedor.IdPersona, pProveedor.Representante, pProveedor.NombreProveedor, pProveedor.Direccion, pProveedor.Telefono, pProveedor.NitProveedor, pProveedor.ServiciosGenerales, pProveedor.Celular, pProveedor.Correo, pProveedor.IdAreaTrabajo);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavProveedor(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavProveedor" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
