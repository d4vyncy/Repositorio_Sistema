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

public class clsEgresoDetalle : clsEgresoDetalleDA
{
public clsEgresoDetalle()
{
this.IdEgresoDetalle = 0;
this.IdInsumo = 0;
this.IdEgreso = 0;
this.Cantidad = 0;
this.PrecioUnitario = 0;
this.SubTotal = 0;
this.IdIngresoDetalle = 0;
this.IdSolicitudDetalle = 0;
this.Observaciones = string.Empty;
}

public clsEgresoDetalle(int IdEgresoDetalle)
{
}


public clsEgresoDetalle clsEgresoDetallePorIdEgresoDetalle()
{
using (IDataReader dr = ObtieneEgresoDetalle(this))
{
if (dr.Read())
{
this.IdEgresoDetalle = Convert.ToInt32(dr["IdEgresoDetalle"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.IdEgreso = Convert.ToInt32(dr["IdEgreso"]);
this.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
this.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
this.IdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
this.IdSolicitudDetalle = Convert.ToInt32(dr["IdSolicitudDetalle"]);
this.Observaciones = Convert.ToString(dr["Observaciones"]);
}
}
return this;
}

public int AgregaEgresoDetalle()
{
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.AgregaEgresoDetalle(this);
}

public int ModificaEgresoDetalle()
{
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.ModificaEgresoDetalle(this);
}

public int EliminaEgresoDetalle()
{
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.EliminaEgresoDetalle(this);
}

}
}
