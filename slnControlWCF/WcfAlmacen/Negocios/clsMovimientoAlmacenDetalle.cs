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

public class clsMovimientoAlmacenDetalle : clsMovimientoAlmacenDetalleDA
{
public clsMovimientoAlmacenDetalle()
{
this.IdMovimientoAlmacenDetalle = 0;
this.IdMovimientoAlmacen = 0;
this.IdIngresoDetalle = 0;
this.IdInsumo = 0;
this.IdIngreso = 0;
this.Cantidad = 0;
this.PrecioUnitario = 0;
this.SubTotal = 0;
this.Lote = string.Empty;
this.FechaVencimiento = DateTime.Now;
}

public clsMovimientoAlmacenDetalle(int IdMovimientoAlmacenDetalle)
{
}


public clsMovimientoAlmacenDetalle clsMovimientoAlmacenDetallePorIdMovimientoAlmacenDetalle()
{
using (IDataReader dr = ObtieneMovimientoAlmacenDetalle(this))
{
if (dr.Read())
{
this.IdMovimientoAlmacenDetalle = Convert.ToInt32(dr["IdMovimientoAlmacenDetalle"]);
this.IdMovimientoAlmacen = Convert.ToInt32(dr["IdMovimientoAlmacen"]);
this.IdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.IdIngreso = Convert.ToInt32(dr["IdIngreso"]);
this.Cantidad = Convert.ToInt32(dr["Cantidad"]);
this.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
this.Lote = Convert.ToString(dr["Lote"]);
this.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);
}
}
return this;
}

public int AgregaMovimientoAlmacenDetalle()
{
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.AgregaMovimientoAlmacenDetalle(this);
}

public int ModificaMovimientoAlmacenDetalle()
{
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.ModificaMovimientoAlmacenDetalle(this);
}

public int EliminaMovimientoAlmacenDetalle()
{
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.EliminaMovimientoAlmacenDetalle(this);
}

}
}
