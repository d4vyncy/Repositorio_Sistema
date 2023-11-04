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

public class clsSolicitudDetalleInexistencia : clsSolicitudDetalleInexistenciaDA
{
public clsSolicitudDetalleInexistencia()
{
this.IdSolicitudDetalleInexistencia = 0;
this.IdInsumo = 0;
this.IdSolicitudDetalle = 0;
this.Cantidad = 0;
this.PrecioUnitario = 0;
this.Subtotal = 0;
}

public clsSolicitudDetalleInexistencia(int IdSolicitudDetalleInexistencia)
{
}


public clsSolicitudDetalleInexistencia clsSolicitudDetalleInexistenciaPorIdSolicitudDetalleInexistencia()
{
using (IDataReader dr = ObtieneSolicitudDetalleInexistencia(this))
{
if (dr.Read())
{
this.IdSolicitudDetalleInexistencia = Convert.ToInt32(dr["IdSolicitudDetalleInexistencia"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.IdSolicitudDetalle = Convert.ToInt32(dr["IdSolicitudDetalle"]);
this.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
this.PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]);
this.Subtotal = Convert.ToDecimal(dr["Subtotal"]);
}
}
return this;
}

public int AgregaSolicitudDetalleInexistencia()
{
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.AgregaSolicitudDetalleInexistencia(this);
}

public int ModificaSolicitudDetalleInexistencia()
{
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.ModificaSolicitudDetalleInexistencia(this);
}

public int EliminaSolicitudDetalleInexistencia()
{
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.EliminaSolicitudDetalleInexistencia(this);
}

}
}
