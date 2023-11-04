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

public class clsTipoUsuario : clsTipoUsuarioDA
{
public clsTipoUsuario()
{
this.IdTipoUsuario = 0;
this.NombreTipoUsuario = string.Empty;
this.Detalle = string.Empty;
}

public clsTipoUsuario(int IdTipoUsuario)
{
}


public clsTipoUsuario clsTipoUsuarioPorIdTipoUsuario()
{
using (IDataReader dr = ObtieneTipoUsuario(this))
{
if (dr.Read())
{
this.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
this.NombreTipoUsuario = Convert.ToString(dr["NombreTipoUsuario"]);
this.Detalle = Convert.ToString(dr["Detalle"]);
}
}
return this;
}

public int AgregaTipoUsuario()
{
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.AgregaTipoUsuario(this);
}

public int ModificaTipoUsuario()
{
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.ModificaTipoUsuario(this);
}

public int EliminaTipoUsuario()
{
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.EliminaTipoUsuario(this);
}

}
}
