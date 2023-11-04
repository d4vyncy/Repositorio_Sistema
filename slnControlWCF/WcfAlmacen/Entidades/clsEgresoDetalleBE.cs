using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsEgresoDetalleBE
{
public int IdEgresoDetalle { get; set; }
public int IdInsumo { get; set; }
public int IdEgreso { get; set; }
public decimal Cantidad { get; set; }
public decimal PrecioUnitario { get; set; }
public decimal SubTotal { get; set; }
public int IdIngresoDetalle { get; set; }
public int IdSolicitudDetalle { get; set; }
public string Observaciones { get; set; }
}
}