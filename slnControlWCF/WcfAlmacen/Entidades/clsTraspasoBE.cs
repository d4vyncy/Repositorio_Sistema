using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsTraspasoBE
{
public int IdTraspaso { get; set; }
public int NumeroTraspaso { get; set; }
public DateTime FechaReal { get; set; }
public DateTime FechaTraspaso { get; set; }
public string Observaciones { get; set; }
public decimal Total { get; set; }
public int IdGrupoArticulo { get; set; }
public int IdUnidadTraspaso { get; set; }
public int IdGestion { get; set; }
public int IdUsuarioTraspaso { get; set; }
public int IdAlmacenOrigen { get; set; }
public int IdAlmacenDestino { get; set; }
}
}