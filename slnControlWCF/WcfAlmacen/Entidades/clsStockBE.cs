using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsStockBE
{
public int IdStock { get; set; }
public decimal Cantidad { get; set; }
public int IdInsumo { get; set; }
public int IdAlmacen { get; set; }
public int IdIngresoDetalle { get; set; }
}
}