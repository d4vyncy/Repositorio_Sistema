using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsMovimientoAlmacenBE
{
public int IdMovimientoAlmacen { get; set; }
public int IdMovimientoAlmacenPadre { get; set; }
public string NombreMovimientoAlmacen { get; set; }
public DateTime FechaSaldoInicial { get; set; }
public DateTime FechaInicial { get; set; }
public DateTime FechaFinal { get; set; }
public int NumeroIngreso { get; set; }
public DateTime FechaReal { get; set; }
public string Observacion { get; set; }
public decimal SubTotal { get; set; }
public decimal Total { get; set; }
public int IdGestion { get; set; }
public int IdEntidad { get; set; }
public int IdUsuario { get; set; }
public int IdAlmacen { get; set; }
public int IdEstadoIngreso { get; set; }
}
}