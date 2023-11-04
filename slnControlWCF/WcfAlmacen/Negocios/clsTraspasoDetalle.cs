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

public class clsTraspasoDetalle : clsTraspasoDetalleDA
{
public clsTraspasoDetalle()
{
this.IdTraspasoDetalle = 0;
this.IdTraspaso = 0;
this.PrecioUnitario = 0;
this.SubTotal = 0;
this.CantidadOrigen = 0;
this.CantidadDestino = 0;
this.IdInsumoOrigen = 0;
this.IdInsumoDestino = 0;
this.IdIngresoDetalle = 0;
}

public clsTraspasoDetalle(int IdTraspasoDetalle)
{
}


public clsTraspasoDetalle clsTraspasoDetallePorIdTraspasoDetalle()
{
using (IDataReader dr = ObtieneTraspasoDetalle(this))
{
if (dr.Read())
{
this.IdTraspasoDetalle = Convert.ToInt32(dr["IdTraspasoDetalle"]);
this.IdTraspaso = Convert.ToInt32(dr["IdTraspaso"]);
this.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
this.CantidadOrigen = Convert.ToInt32(dr["CantidadOrigen"]);
this.CantidadDestino = Convert.ToInt32(dr["CantidadDestino"]);
this.IdInsumoOrigen = Convert.ToInt32(dr["IdInsumoOrigen"]);
this.IdInsumoDestino = Convert.ToInt32(dr["IdInsumoDestino"]);
this.IdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
}
}
return this;
}

public int AgregaTraspasoDetalle()
{
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.AgregaTraspasoDetalle(this);
}

public int ModificaTraspasoDetalle()
{
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.ModificaTraspasoDetalle(this);
}

public int EliminaTraspasoDetalle()
{
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.EliminaTraspasoDetalle(this);
}

}
}
