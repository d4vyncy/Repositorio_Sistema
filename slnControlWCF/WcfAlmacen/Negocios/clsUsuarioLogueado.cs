using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Wcfsisdav.Entidades;
using Wcfsisdav.Datos;

namespace Wcfsisdav.Negocios 
{

public class clsUsuarioLogueado : clsUsuarioLogueadoDA
{
public clsUsuarioLogueado()
{
this.IdUsuarioLogueado = 0;
this.IdUsuario = 0;
this.IdRolUsuario = 0;
this.Llave = string.Empty;
this.IdEstadoLlave = 0;
this.Fecha = DateTime.Now;
this.DireccionIP = string.Empty;
this.DireccionHost = string.Empty;
this.DireccionDest = string.Empty;
}

public clsUsuarioLogueado(int IdUsuarioLogueado)
{
}


public clsUsuarioLogueado clsUsuarioLogueadoPorIdUsuarioLogueado()
{
using (IDataReader dr = ObtieneUsuarioLogueado(this))
{
if (dr.Read())
{
this.IdUsuarioLogueado = Convert.ToInt32(dr["IdUsuarioLogueado"]);
this.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
this.IdRolUsuario = Convert.ToInt32(dr["IdRolUsuario"]);
this.Llave = Convert.ToString(dr["Llave"]);
this.IdEstadoLlave = Convert.ToInt32(dr["IdEstadoLlave"]);
this.Fecha = Convert.ToDateTime(dr["Fecha"]);
this.DireccionIP = Convert.ToString(dr["DireccionIP"]);
this.DireccionHost = Convert.ToString(dr["DireccionHost"]);
this.DireccionDest = Convert.ToString(dr["DireccionDest"]);
}
}
return this;
}

public int AgregaUsuarioLogueado()
{
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.AgregaUsuarioLogueado(this);
}

public int ModificaUsuarioLogueado()
{
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.ModificaUsuarioLogueado(this);
}

public int EliminaUsuarioLogueado()
{
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.EliminaUsuarioLogueado(this);
}

}
}
