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

public class clsEstadoRolUsuario : clsEstadoRolUsuarioDA
{
public clsEstadoRolUsuario()
{
this.IdEstadoRolUsuario = 0;
this.NombreEstadoRolUsuario = string.Empty;
this.Detalle = string.Empty;
}

public clsEstadoRolUsuario(int IdEstadoRolUsuario)
{
}


public clsEstadoRolUsuario clsEstadoRolUsuarioPorIdEstadoRolUsuario()
{
using (IDataReader dr = ObtieneEstadoRolUsuario(this))
{
if (dr.Read())
{
this.IdEstadoRolUsuario = Convert.ToInt32(dr["IdEstadoRolUsuario"]);
this.NombreEstadoRolUsuario = Convert.ToString(dr["NombreEstadoRolUsuario"]);
this.Detalle = Convert.ToString(dr["Detalle"]);
}
}
return this;
}

public int AgregaEstadoRolUsuario()
{
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.AgregaEstadoRolUsuario(this);
}

public int ModificaEstadoRolUsuario()
{
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.ModificaEstadoRolUsuario(this);
}

public int EliminaEstadoRolUsuario()
{
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.EliminaEstadoRolUsuario(this);
}

}
}
