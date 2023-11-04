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

public class clsInsumo : clsInsumoDA
{
public clsInsumo()
{
this.IdInsumo = 0;
this.Codigo1 = string.Empty;
this.Codigo2 = string.Empty;
this.NombreInsumo = string.Empty;
this.CantidadMinima = 0;
this.CantidadMaxima = 0;
this.PrecioCompra = 0;
this.PrecioVenta = 0;
this.ConFechaVencimiento = true;
this.IdMoneda = 0;
this.IdLineaArticulo = 0;
this.IdGrupoArticulo = 0;
this.IdUnidaMedida = 0;
this.IdSerializacion = 0;
this.IdMarca = 0;
this.IdColor = 0;
this.Estante = string.Empty;
this.Nivel = string.Empty;
}

public clsInsumo(int IdInsumo)
{
}


public clsInsumo clsInsumoPorIdInsumo()
{
using (IDataReader dr = ObtieneInsumo(this))
{
if (dr.Read())
{
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.Codigo1 = Convert.ToString(dr["Codigo1"]);
this.Codigo2 = Convert.ToString(dr["Codigo2"]);
this.NombreInsumo = Convert.ToString(dr["NombreInsumo"]);
this.Imagen = (byte[])dr["Imagen"];
this.CantidadMinima = Convert.ToInt32(dr["CantidadMinima"]);
this.CantidadMaxima = Convert.ToInt32(dr["CantidadMaxima"]);
this.PrecioCompra = Convert.ToInt32(dr["PrecioCompra"]);
this.PrecioVenta = Convert.ToInt32(dr["PrecioVenta"]);
this.ConFechaVencimiento = Convert.ToBoolean(dr["ConFechaVencimiento"]);
this.IdMoneda = Convert.ToInt32(dr["IdMoneda"]);
this.IdLineaArticulo = Convert.ToInt32(dr["IdLineaArticulo"]);
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.IdUnidaMedida = Convert.ToInt32(dr["IdUnidaMedida"]);
this.IdSerializacion = Convert.ToInt32(dr["IdSerializacion"]);
this.IdMarca = Convert.ToInt32(dr["IdMarca"]);
this.IdColor = Convert.ToInt32(dr["IdColor"]);
this.Estante = Convert.ToString(dr["Estante"]);
this.Nivel = Convert.ToString(dr["Nivel"]);
}
}
return this;
}

public int AgregaInsumo()
{
clsInsumoDA ad = new clsInsumoDA();
return ad.AgregaInsumo(this);
}

public int ModificaInsumo()
{
clsInsumoDA ad = new clsInsumoDA();
return ad.ModificaInsumo(this);
}

public int EliminaInsumo()
{
clsInsumoDA ad = new clsInsumoDA();
return ad.EliminaInsumo(this);
}

}
}
