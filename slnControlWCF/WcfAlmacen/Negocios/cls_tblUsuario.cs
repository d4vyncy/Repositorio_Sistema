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

public class cls_tblUsuario : cls_tblUsuarioDA
{
public cls_tblUsuario()
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

public cls_tblUsuario(int Id_tblUsuario)
{
}


public cls_tblUsuario cls_tblUsuarioPorId_tblUsuario()
{
using (IDataReader dr = Obtiene_tblUsuario(this))
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

public int Agrega_tblUsuario()
{
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Agrega_tblUsuario(this);
}

public int Modifica_tblUsuario()
{
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Modifica_tblUsuario(this);
}

public int Elimina_tblUsuario()
{
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Elimina_tblUsuario(this);
}

}
}
