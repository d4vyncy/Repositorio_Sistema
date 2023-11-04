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

public class clsIngreso : clsIngresoDA
{
public clsIngreso()
{
this.IdIngreso = 0;
this.NumeroIngreso = 0;
this.FechaReal = DateTime.Now;
this.FechaIngreso = DateTime.Now;
this.ComprobantePago = string.Empty;
this.NumeroFactura = string.Empty;
this.NumeroPreventivo = string.Empty;
this.Observacion = string.Empty;
this.SubTotal = 0;
this.Total = 0;
this.Descuento = 0;
this.IdGrupoArticulo = 0;
this.IdProveedor = 0;
this.IdGestion = 0;
this.IdEntidad = 0;
this.IdUsuarioIngreso = 0;
this.IdAlmacen = 0;
this.IdEstadoIngreso = 0;
this.IdTipoDocumentoEntrega = 0;
}

public clsIngreso(int IdIngreso)
{
}


public clsIngreso clsIngresoPorIdIngreso()
{
using (IDataReader dr = ObtieneIngreso(this))
{
if (dr.Read())
{
this.IdIngreso = Convert.ToInt32(dr["IdIngreso"]);
this.NumeroIngreso = Convert.ToInt32(dr["NumeroIngreso"]);
this.FechaReal = Convert.ToDateTime(dr["FechaReal"]);
this.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
this.ComprobantePago = Convert.ToString(dr["ComprobantePago"]);
this.NumeroFactura = Convert.ToString(dr["NumeroFactura"]);
this.NumeroPreventivo = Convert.ToString(dr["NumeroPreventivo"]);
this.Observacion = Convert.ToString(dr["Observacion"]);
this.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
this.Total = Convert.ToDecimal(dr["Total"]);
this.Descuento = Convert.ToDecimal(dr["Descuento"]);
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
this.IdGestion = Convert.ToInt32(dr["IdGestion"]);
this.IdEntidad = Convert.ToInt32(dr["IdEntidad"]);
this.IdUsuarioIngreso = Convert.ToInt32(dr["IdUsuarioIngreso"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.IdEstadoIngreso = Convert.ToInt32(dr["IdEstadoIngreso"]);
this.IdTipoDocumentoEntrega = Convert.ToInt32(dr["IdTipoDocumentoEntrega"]);
}
}
return this;
}

public int AgregaIngreso()
{
clsIngresoDA ad = new clsIngresoDA();
return ad.AgregaIngreso(this);
}

public int ModificaIngreso()
{
clsIngresoDA ad = new clsIngresoDA();
return ad.ModificaIngreso(this);
}

public int EliminaIngreso()
{
clsIngresoDA ad = new clsIngresoDA();
return ad.EliminaIngreso(this);
}

}
}
