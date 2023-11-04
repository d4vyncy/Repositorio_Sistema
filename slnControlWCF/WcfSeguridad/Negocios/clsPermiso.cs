using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfSeguridad.Entidades;
using WcfSeguridad.Datos;

namespace WcfSeguridad.Negocios 
{

public class clsPermiso : clsPermisoDA
{
public clsPermiso()
{
this.IdPermiso = 0;
this.NombrePermiso = string.Empty;
this.IdTipoPermiso = 0;
this.IdMenu = 0;
this.IdRol = 0;
}

public clsPermiso(int IdPermiso)
{
}


public clsPermiso clsPermisoPorIdPermiso()
{
using (IDataReader dr = ObtienePermiso(this))
{
if (dr.Read())
{
this.IdPermiso = Convert.ToInt32(dr["IdPermiso"]);
this.NombrePermiso = Convert.ToString(dr["NombrePermiso"]);
this.IdTipoPermiso = Convert.ToInt32(dr["IdTipoPermiso"]);
this.IdMenu = Convert.ToInt32(dr["IdMenu"]);
this.IdRol = Convert.ToInt32(dr["IdRol"]);
}
}
return this;
}

public int AgregaPermiso()
{
clsPermisoDA ad = new clsPermisoDA();
return ad.AgregaPermiso(this);
}

public int ModificaPermiso()
{
clsPermisoDA ad = new clsPermisoDA();
return ad.ModificaPermiso(this);
}

public int EliminaPermiso()
{
clsPermisoDA ad = new clsPermisoDA();
return ad.EliminaPermiso(this);
}

}
}
