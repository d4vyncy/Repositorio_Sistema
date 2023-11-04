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

public class clsTipoPermiso : clsTipoPermisoDA
{
public clsTipoPermiso()
{
this.IdTipoPermiso = 0;
this.NombreTipoPermiso = string.Empty;
this.DetalleTipoPermiso = string.Empty;
}

public clsTipoPermiso(int IdTipoPermiso)
{
}


public clsTipoPermiso clsTipoPermisoPorIdTipoPermiso()
{
using (IDataReader dr = ObtieneTipoPermiso(this))
{
if (dr.Read())
{
this.IdTipoPermiso = Convert.ToInt32(dr["IdTipoPermiso"]);
this.NombreTipoPermiso = Convert.ToString(dr["NombreTipoPermiso"]);
this.DetalleTipoPermiso = Convert.ToString(dr["DetalleTipoPermiso"]);
}
}
return this;
}

public int AgregaTipoPermiso()
{
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.AgregaTipoPermiso(this);
}

public int ModificaTipoPermiso()
{
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.ModificaTipoPermiso(this);
}

public int EliminaTipoPermiso()
{
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.EliminaTipoPermiso(this);
}

}
}
