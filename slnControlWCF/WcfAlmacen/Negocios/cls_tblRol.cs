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

public class cls_tblRol : cls_tblRolDA
{
public cls_tblRol()
{
this.IdRol = 0;
this.NombreRol = string.Empty;
this.IdSistema = 0;
}

public cls_tblRol(int Id_tblRol)
{
}


public cls_tblRol cls_tblRolPorId_tblRol()
{
using (IDataReader dr = Obtiene_tblRol(this))
{
if (dr.Read())
{
this.IdRol = Convert.ToInt32(dr["IdRol"]);
this.NombreRol = Convert.ToString(dr["NombreRol"]);
this.IdSistema = Convert.ToInt32(dr["IdSistema"]);
}
}
return this;
}

public int Agrega_tblRol()
{
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Agrega_tblRol(this);
}

public int Modifica_tblRol()
{
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Modifica_tblRol(this);
}

public int Elimina_tblRol()
{
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Elimina_tblRol(this);
}

}
}
