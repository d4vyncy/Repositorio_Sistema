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

public class cls_tblRolUsuario : cls_tblRolUsuarioDA
{
public cls_tblRolUsuario()
{
this.IdRolUsuario = 0;
this.IdRol = 0;
this.IdUsuario = 0;
this.IdEstadoRolUsuario = 0;
this.IdTipoRolUsuario = 0;
this.IdUsuarioCreacion = 0;
this.FechaBaja = DateTime.Now;
}

public cls_tblRolUsuario(int Id_tblRolUsuario)
{
}


public cls_tblRolUsuario cls_tblRolUsuarioPorId_tblRolUsuario()
{
using (IDataReader dr = Obtiene_tblRolUsuario(this))
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

public int Agrega_tblRolUsuario()
{
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Agrega_tblRolUsuario(this);
}

public int Modifica_tblRolUsuario()
{
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Modifica_tblRolUsuario(this);
}

public int Elimina_tblRolUsuario()
{
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Elimina_tblRolUsuario(this);
}

}
}
