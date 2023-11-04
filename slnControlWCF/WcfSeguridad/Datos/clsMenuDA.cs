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
public class clsMenuDA : clsMenuBE
{

Database db = null;
//DataSet dtoMenu;

public clsMenuDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneMenu(clsMenuBE pMenu)
{
DbCommand cmd = db.GetStoredProcCommand("pagMenu",2, pMenu.IdMenu, pMenu.NombreMenu, pMenu.NombreFormulario, pMenu.NumeroDeOrden, pMenu.IdSistema, pMenu.IdMenuPadre);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaMenu(clsMenuBE pMenu)
{
DbCommand cmd = db.GetStoredProcCommand("pagMenu",1, pMenu.IdMenu, pMenu.NombreMenu, pMenu.NombreFormulario, pMenu.NumeroDeOrden, pMenu.IdSistema, pMenu.IdMenuPadre);
int nIdMenu = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdMenu = Convert.ToInt32(dr["IdMenu"]);
}
}
return nIdMenu;
}

public int ModificaMenu(clsMenuBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagMenu",3, pPaq.IdMenu, pPaq.NombreMenu, pPaq.NombreFormulario, pPaq.NumeroDeOrden, pPaq.IdSistema, pPaq.IdMenuPadre);
return db.ExecuteNonQuery(cmd);
}

public int EliminaMenu(clsMenuBE pMenu)
{
DbCommand cmd = db.GetStoredProcCommand("pagMenu",4, pMenu.IdMenu, pMenu.NombreMenu, pMenu.NombreFormulario, pMenu.NumeroDeOrden, pMenu.IdSistema, pMenu.IdMenuPadre);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavMenu(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavMenu" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
