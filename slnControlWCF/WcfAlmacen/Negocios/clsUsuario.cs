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

public class clsUsuario : clsUsuarioDA
{
public clsUsuario()
{
this.IdUsuario = 0;
this.IdPersona = 0;
this.NombreUsuario = string.Empty;
this.Clave = string.Empty;
this.Salt = string.Empty;
this.Pin = 0;
this.IdEstadoUsuario = 0;
this.IdTipoUsuario = 0;
this.Estilo = string.Empty;
}

public clsUsuario(int IdUsuario)
{
}


public clsUsuario clsUsuarioPorIdUsuario()
{
using (IDataReader dr = ObtieneUsuario(this))
{
if (dr.Read())
{
this.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
this.IdPersona = Convert.ToInt32(dr["IdPersona"]);
this.NombreUsuario = Convert.ToString(dr["NombreUsuario"]);
this.Clave = Convert.ToString(dr["Clave"]);
this.Salt = Convert.ToString(dr["Salt"]);
this.Pin = Convert.ToInt32(dr["Pin"]);
this.IdEstadoUsuario = Convert.ToInt32(dr["IdEstadoUsuario"]);
this.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
this.Estilo = Convert.ToString(dr["Estilo"]);
}
}
return this;
}

public int AgregaUsuario()
{
clsUsuarioDA ad = new clsUsuarioDA();
return ad.AgregaUsuario(this);
}

public int ModificaUsuario()
{
clsUsuarioDA ad = new clsUsuarioDA();
return ad.ModificaUsuario(this);
}

public int EliminaUsuario()
{
clsUsuarioDA ad = new clsUsuarioDA();
return ad.EliminaUsuario(this);
}

}
}
