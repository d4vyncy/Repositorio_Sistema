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

public class clsTipoRolUsuario : clsTipoRolUsuarioDA
{
public clsTipoRolUsuario()
{
this.IdTipoRolUsuario = 0;
this.NombreTipoRolUsuario = string.Empty;
this.Detalle = string.Empty;
}

public clsTipoRolUsuario(int IdTipoRolUsuario)
{
}


public clsTipoRolUsuario clsTipoRolUsuarioPorIdTipoRolUsuario()
{
using (IDataReader dr = ObtieneTipoRolUsuario(this))
{
if (dr.Read())
{
this.IdTipoRolUsuario = Convert.ToInt32(dr["IdTipoRolUsuario"]);
this.NombreTipoRolUsuario = Convert.ToString(dr["NombreTipoRolUsuario"]);
this.Detalle = Convert.ToString(dr["Detalle"]);
}
}
return this;
}

public int AgregaTipoRolUsuario()
{
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.AgregaTipoRolUsuario(this);
}

public int ModificaTipoRolUsuario()
{
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.ModificaTipoRolUsuario(this);
}

public int EliminaTipoRolUsuario()
{
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.EliminaTipoRolUsuario(this);
}

}
}
