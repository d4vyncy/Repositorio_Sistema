using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsSolicitudDetalleInexistenciaBE
{
public int IdSolicitudDetalleInexistencia { get; set; }
public int IdInsumo { get; set; }
public int IdSolicitudDetalle { get; set; }
public decimal Cantidad { get; set; }
public decimal PrecioUnitario { get; set; }
public decimal Subtotal { get; set; }
}
}