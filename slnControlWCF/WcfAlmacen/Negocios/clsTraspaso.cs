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

public class clsTraspaso : clsTraspasoDA
{
public clsTraspaso()
{
this.IdTraspaso = 0;
this.NumeroTraspaso = 0;
this.FechaReal = DateTime.Now;
this.FechaTraspaso = DateTime.Now;
this.Observaciones = string.Empty;
this.Total = 0;
this.IdGrupoArticulo = 0;
this.IdUnidadTraspaso = 0;
this.IdGestion = 0;
this.IdUsuarioTraspaso = 0;
this.IdAlmacenOrigen = 0;
this.IdAlmacenDestino = 0;
}

public clsTraspaso(int IdTraspaso)
{
}


public clsTraspaso clsTraspasoPorIdTraspaso()
{
using (IDataReader dr = ObtieneTraspaso(this))
{
if (dr.Read())
{
this.IdTraspaso = Convert.ToInt32(dr["IdTraspaso"]);
this.NumeroTraspaso = Convert.ToInt32(dr["NumeroTraspaso"]);
this.FechaReal = Convert.ToDateTime(dr["FechaReal"]);
this.FechaTraspaso = Convert.ToDateTime(dr["FechaTraspaso"]);
this.Observaciones = Convert.ToString(dr["Observaciones"]);
this.Total = Convert.ToDecimal(dr["Total"]);
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.IdUnidadTraspaso = Convert.ToInt32(dr["IdUnidadTraspaso"]);
this.IdGestion = Convert.ToInt32(dr["IdGestion"]);
this.IdUsuarioTraspaso = Convert.ToInt32(dr["IdUsuarioTraspaso"]);
this.IdAlmacenOrigen = Convert.ToInt32(dr["IdAlmacenOrigen"]);
this.IdAlmacenDestino = Convert.ToInt32(dr["IdAlmacenDestino"]);
}
}
return this;
}

public int AgregaTraspaso()
{
clsTraspasoDA ad = new clsTraspasoDA();
return ad.AgregaTraspaso(this);
}

public int ModificaTraspaso()
{
clsTraspasoDA ad = new clsTraspasoDA();
return ad.ModificaTraspaso(this);
}

public int EliminaTraspaso()
{
clsTraspasoDA ad = new clsTraspasoDA();
return ad.EliminaTraspaso(this);
}

}
}
