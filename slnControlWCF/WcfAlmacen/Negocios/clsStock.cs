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

public class clsStock : clsStockDA
{
public clsStock()
{
this.IdStock = 0;
this.Cantidad = 0;
this.IdInsumo = 0;
this.IdAlmacen = 0;
this.IdIngresoDetalle = 0;
}

public clsStock(int IdStock)
{
}


public clsStock clsStockPorIdStock()
{
using (IDataReader dr = ObtieneStock(this))
{
if (dr.Read())
{
this.IdStock = Convert.ToInt32(dr["IdStock"]);
this.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.IdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
}
}
return this;
}

public int AgregaStock()
{
clsStockDA ad = new clsStockDA();
return ad.AgregaStock(this);
}

public int ModificaStock()
{
clsStockDA ad = new clsStockDA();
return ad.ModificaStock(this);
}

public int EliminaStock()
{
clsStockDA ad = new clsStockDA();
return ad.EliminaStock(this);
}

}
}
