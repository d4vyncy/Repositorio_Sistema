using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsSolicitudDetalleBE
{
public int IdSolicitudDetalle { get; set; }
public int IdInsumo { get; set; }
public int IdSolicitud { get; set; }
public int IdStock { get; set; }
public decimal Cantidad { get; set; }
public decimal PrecioUnitario { get; set; }
public decimal SubTotal { get; set; }
}
}