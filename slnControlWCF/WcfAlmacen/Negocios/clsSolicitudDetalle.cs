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

public class clsSolicitudDetalle : clsSolicitudDetalleDA
{
public clsSolicitudDetalle()
{
this.IdSolicitudDetalle = 0;
this.IdInsumo = 0;
this.IdSolicitud = 0;
this.IdStock = 0;
this.Cantidad = 0;
this.PrecioUnitario = 0;
this.SubTotal = 0;
}

public clsSolicitudDetalle(int IdSolicitudDetalle)
{
}


public clsSolicitudDetalle clsSolicitudDetallePorIdSolicitudDetalle()
{
using (IDataReader dr = ObtieneSolicitudDetalle(this))
{
if (dr.Read())
{
this.IdSolicitudDetalle = Convert.ToInt32(dr["IdSolicitudDetalle"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.IdSolicitud = Convert.ToInt32(dr["IdSolicitud"]);
this.IdStock = Convert.ToInt32(dr["IdStock"]);
this.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
this.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
}
}
return this;
}

public int AgregaSolicitudDetalle()
{
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.AgregaSolicitudDetalle(this);
}

public int ModificaSolicitudDetalle()
{
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.ModificaSolicitudDetalle(this);
}

public int EliminaSolicitudDetalle()
{
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.EliminaSolicitudDetalle(this);
}

}
}
