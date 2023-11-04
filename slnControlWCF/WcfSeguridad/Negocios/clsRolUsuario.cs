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

public class clsRolUsuario : clsRolUsuarioDA
{
public clsRolUsuario()
{
this.IdRolUsuario = 0;
this.IdRol = 0;
this.IdUsuario = 0;
this.IdEstadoRolUsuario = 0;
this.IdTipoRolUsuario = 0;
this.IdUsuarioCreacion = 0;
this.FechaBaja = DateTime.Now;
}

public clsRolUsuario(int IdRolUsuario)
{
}


public clsRolUsuario clsRolUsuarioPorIdRolUsuario()
{
using (IDataReader dr = ObtieneRolUsuario(this))
{
if (dr.Read())
{
this.IdRolUsuario = Convert.ToInt32(dr["IdRolUsuario"]);
this.IdRol = Convert.ToInt32(dr["IdRol"]);
this.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
this.IdEstadoRolUsuario = Convert.ToInt32(dr["IdEstadoRolUsuario"]);
this.IdTipoRolUsuario = Convert.ToInt32(dr["IdTipoRolUsuario"]);
this.IdUsuarioCreacion = Convert.ToInt32(dr["IdUsuarioCreacion"]);
this.FechaBaja = Convert.ToDateTime(dr["FechaBaja"]);
}
}
return this;
}

public int AgregaRolUsuario()
{
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.AgregaRolUsuario(this);
}

public int ModificaRolUsuario()
{
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.ModificaRolUsuario(this);
}

public int EliminaRolUsuario()
{
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.EliminaRolUsuario(this);
}

}
}
