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

public class clsEstadoUsuario : clsEstadoUsuarioDA
{
public clsEstadoUsuario()
{
this.IdEstadoUsuario = 0;
this.NombreEstadoUsuario = string.Empty;
this.Detalle = string.Empty;
}

public clsEstadoUsuario(int IdEstadoUsuario)
{
}


public clsEstadoUsuario clsEstadoUsuarioPorIdEstadoUsuario()
{
using (IDataReader dr = ObtieneEstadoUsuario(this))
{
if (dr.Read())
{
this.IdEstadoUsuario = Convert.ToInt32(dr["IdEstadoUsuario"]);
this.NombreEstadoUsuario = Convert.ToString(dr["NombreEstadoUsuario"]);
this.Detalle = Convert.ToString(dr["Detalle"]);
}
}
return this;
}

public int AgregaEstadoUsuario()
{
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.AgregaEstadoUsuario(this);
}

public int ModificaEstadoUsuario()
{
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.ModificaEstadoUsuario(this);
}

public int EliminaEstadoUsuario()
{
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.EliminaEstadoUsuario(this);
}

}
}
