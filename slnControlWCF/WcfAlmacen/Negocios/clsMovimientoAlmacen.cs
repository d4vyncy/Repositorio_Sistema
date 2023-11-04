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

public class clsMovimientoAlmacen : clsMovimientoAlmacenDA
{
public clsMovimientoAlmacen()
{
this.IdMovimientoAlmacen = 0;
this.IdMovimientoAlmacenPadre = 0;
this.NombreMovimientoAlmacen = string.Empty;
this.FechaSaldoInicial = DateTime.Now;
this.FechaInicial = DateTime.Now;
this.FechaFinal = DateTime.Now;
this.NumeroIngreso = 0;
this.FechaReal = DateTime.Now;
this.Observacion = string.Empty;
this.SubTotal = 0;
this.Total = 0;
this.IdGestion = 0;
this.IdEntidad = 0;
this.IdUsuario = 0;
this.IdAlmacen = 0;
this.IdEstadoIngreso = 0;
}

public clsMovimientoAlmacen(int IdMovimientoAlmacen)
{
}


public clsMovimientoAlmacen clsMovimientoAlmacenPorIdMovimientoAlmacen()
{
using (IDataReader dr = ObtieneMovimientoAlmacen(this))
{
if (dr.Read())
{
this.IdMovimientoAlmacen = Convert.ToInt32(dr["IdMovimientoAlmacen"]);
this.IdMovimientoAlmacenPadre = Convert.ToInt32(dr["IdMovimientoAlmacenPadre"]);
this.NombreMovimientoAlmacen = Convert.ToString(dr["NombreMovimientoAlmacen"]);
this.FechaSaldoInicial = Convert.ToDateTime(dr["FechaSaldoInicial"]);
this.FechaInicial = Convert.ToDateTime(dr["FechaInicial"]);
this.FechaFinal = Convert.ToDateTime(dr["FechaFinal"]);
this.NumeroIngreso = Convert.ToInt32(dr["NumeroIngreso"]);
this.FechaReal = Convert.ToDateTime(dr["FechaReal"]);
this.Observacion = Convert.ToString(dr["Observacion"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
this.Total = Convert.ToDecimal(dr["Total"]);
this.IdGestion = Convert.ToInt32(dr["IdGestion"]);
this.IdEntidad = Convert.ToInt32(dr["IdEntidad"]);
this.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.IdEstadoIngreso = Convert.ToInt32(dr["IdEstadoIngreso"]);
}
}
return this;
}

public int AgregaMovimientoAlmacen()
{
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.AgregaMovimientoAlmacen(this);
}

public int ModificaMovimientoAlmacen()
{
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.ModificaMovimientoAlmacen(this);
}

public int EliminaMovimientoAlmacen()
{
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.EliminaMovimientoAlmacen(this);
}

}
}
