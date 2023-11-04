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

public class clsGrupoArticulo : clsGrupoArticuloDA
{
public clsGrupoArticulo()
{
this.IdGrupoArticulo = 0;
this.NombreGrupoArticulo = string.Empty;
this.Abreviatura = string.Empty;
this.IdPadre = 0;
this.IdPartida = 0;
this.Nivel = 0;
this.Sector = string.Empty;
}

public clsGrupoArticulo(int IdGrupoArticulo)
{
}


public clsGrupoArticulo clsGrupoArticuloPorIdGrupoArticulo()
{
using (IDataReader dr = ObtieneGrupoArticulo(this))
{
if (dr.Read())
{
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.NombreGrupoArticulo = Convert.ToString(dr["NombreGrupoArticulo"]);
this.Abreviatura = Convert.ToString(dr["Abreviatura"]);
this.IdPadre = Convert.ToInt32(dr["IdPadre"]);
this.IdPartida = Convert.ToInt32(dr["IdPartida"]);
this.Nivel = Convert.ToInt32(dr["Nivel"]);
this.Sector = Convert.ToString(dr["Sector"]);
}
}
return this;
}

public int AgregaGrupoArticulo()
{
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.AgregaGrupoArticulo(this);
}

public int ModificaGrupoArticulo()
{
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.ModificaGrupoArticulo(this);
}

public int EliminaGrupoArticulo()
{
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.EliminaGrupoArticulo(this);
}

}
}
