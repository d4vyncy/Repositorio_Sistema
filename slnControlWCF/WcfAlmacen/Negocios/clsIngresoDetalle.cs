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

public class clsIngresoDetalle : clsIngresoDetalleDA
{
public clsIngresoDetalle()
{
this.IdIngresoDetalle = 0;
this.IdInsumo = 0;
this.IdIngreso = 0;
this.Cantidad = 0;
this.PrecioUnitario = 0;
this.SubTotal = 0;
this.Lote = string.Empty;
this.FechaVencimiento = DateTime.Now;
}

public clsIngresoDetalle(int IdIngresoDetalle)
{
}


public clsIngresoDetalle clsIngresoDetallePorIdIngresoDetalle()
{
using (IDataReader dr = ObtieneIngresoDetalle(this))
{
if (dr.Read())
{
this.IdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.IdIngreso = Convert.ToInt32(dr["IdIngreso"]);
this.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
this.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
this.Lote = Convert.ToString(dr["Lote"]);
this.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);
}
}
return this;
}

public int AgregaIngresoDetalle()
{
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.AgregaIngresoDetalle(this);
}

public int ModificaIngresoDetalle()
{
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.ModificaIngresoDetalle(this);
}

public int EliminaIngresoDetalle()
{
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.EliminaIngresoDetalle(this);
}

}
}
