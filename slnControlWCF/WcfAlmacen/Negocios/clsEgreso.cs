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

public class clsEgreso : clsEgresoDA
{
public clsEgreso()
{
this.IdEgreso = 0;
this.NumeroEgreso = 0;
this.FechaReal = DateTime.Now;
this.FechaEgreso = DateTime.Now;
this.Observaciones = string.Empty;
this.Total = 0;
this.IdGrupoArticulo = 0;
this.IdUnidadSolicitante = 0;
this.IdGestion = 0;
this.IdUsuarioEgreso = 0;
this.IdAlmacen = 0;
this.IdEstadoEgreso = 0;
this.IdSolicitud = 0;
}

public clsEgreso(int IdEgreso)
{
}


public clsEgreso clsEgresoPorIdEgreso()
{
using (IDataReader dr = ObtieneEgreso(this))
{
if (dr.Read())
{
this.IdEgreso = Convert.ToInt32(dr["IdEgreso"]);
this.NumeroEgreso = Convert.ToInt32(dr["NumeroEgreso"]);
this.FechaReal = Convert.ToDateTime(dr["FechaReal"]);
this.FechaEgreso = Convert.ToDateTime(dr["FechaEgreso"]);
this.Observaciones = Convert.ToString(dr["Observaciones"]);
this.Total = Convert.ToDecimal(dr["Total"]);
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.IdUnidadSolicitante = Convert.ToInt32(dr["IdUnidadSolicitante"]);
this.IdGestion = Convert.ToInt32(dr["IdGestion"]);
this.IdUsuarioEgreso = Convert.ToInt32(dr["IdUsuarioEgreso"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.IdEstadoEgreso = Convert.ToInt32(dr["IdEstadoEgreso"]);
this.IdSolicitud = Convert.ToInt32(dr["IdSolicitud"]);
}
}
return this;
}

public int AgregaEgreso()
{
clsEgresoDA ad = new clsEgresoDA();
return ad.AgregaEgreso(this);
}

public int ModificaEgreso()
{
clsEgresoDA ad = new clsEgresoDA();
return ad.ModificaEgreso(this);
}

public int EliminaEgreso()
{
clsEgresoDA ad = new clsEgresoDA();
return ad.EliminaEgreso(this);
}

}
}
