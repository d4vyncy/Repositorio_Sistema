using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsIngresoDetalleBE
{
public int IdIngresoDetalle { get; set; }
public int IdInsumo { get; set; }
public int IdIngreso { get; set; }
public decimal Cantidad { get; set; }
public decimal PrecioUnitario { get; set; }
public decimal SubTotal { get; set; }
public string Lote { get; set; }
public DateTime FechaVencimiento { get; set; }
}
}