using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfAlmacen.Entidades;
using WcfAlmacen.Datos;

namespace WcfAlmacen.Negocios 
{

public class clsUsuarioAlmacen : clsUsuarioAlmacenDA
{
public clsUsuarioAlmacen()
{
this.IdUsuarioAlmacen = 0;
this.IdUsuario = 0;
this.IdAlmacen = 0;
this.IdEstadoAsignado = 0;
}

public clsUsuarioAlmacen(int IdUsuarioAlmacen)
{
}


public clsUsuarioAlmacen clsUsuarioAlmacenPorIdUsuarioAlmacen()
{
using (IDataReader dr = ObtieneUsuarioAlmacen(this))
{
if (dr.Read())
{
this.IdUsuarioAlmacen = Convert.ToInt32(dr["IdUsuarioAlmacen"]);
this.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.IdEstadoAsignado = Convert.ToInt32(dr["IdEstadoAsignado"]);
}
}
return this;
}

public int AgregaUsuarioAlmacen()
{
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.AgregaUsuarioAlmacen(this);
}

public int ModificaUsuarioAlmacen()
{
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.ModificaUsuarioAlmacen(this);
}

public int EliminaUsuarioAlmacen()
{
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.EliminaUsuarioAlmacen(this);
}

}
}
