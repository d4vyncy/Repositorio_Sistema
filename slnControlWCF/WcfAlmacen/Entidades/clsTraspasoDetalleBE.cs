using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsTraspasoDetalleBE
{
public int IdTraspasoDetalle { get; set; }
public int IdTraspaso { get; set; }
public decimal PrecioUnitario { get; set; }
public decimal SubTotal { get; set; }
public int CantidadOrigen { get; set; }
public int CantidadDestino { get; set; }
public int IdInsumoOrigen { get; set; }
public int IdInsumoDestino { get; set; }
public int IdIngresoDetalle { get; set; }
}
}