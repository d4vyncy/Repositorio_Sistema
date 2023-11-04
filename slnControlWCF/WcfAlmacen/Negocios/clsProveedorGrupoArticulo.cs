using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfAlmacen.Entidades;
using WcfAlmacen.Datos;

namespace WcfAlmacen.Negocios 
{

public class clsProveedorGrupoArticulo : clsProveedorGrupoArticuloDA
{
public clsProveedorGrupoArticulo()
{
this.IdProveedorGrupoArticulo = 0;
this.IdProveedor = 0;
this.IdGrupoArticulo = 0;
this.IdUsuarioRegistro = 0;
}

public clsProveedorGrupoArticulo(int IdProveedorGrupoArticulo)
{
}


public clsProveedorGrupoArticulo clsProveedorGrupoArticuloPorIdProveedorGrupoArticulo()
{
using (IDataReader dr = ObtieneProveedorGrupoArticulo(this))
{
if (dr.Read())
{
this.IdProveedorGrupoArticulo = Convert.ToInt32(dr["IdProveedorGrupoArticulo"]);
this.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.IdUsuarioRegistro = Convert.ToInt32(dr["IdUsuarioRegistro"]);
}
}
return this;
}

public int AgregaProveedorGrupoArticulo()
{
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.AgregaProveedorGrupoArticulo(this);
}

public int ModificaProveedorGrupoArticulo()
{
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.ModificaProveedorGrupoArticulo(this);
}

public int EliminaProveedorGrupoArticulo()
{
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.EliminaProveedorGrupoArticulo(this);
}

}
}
