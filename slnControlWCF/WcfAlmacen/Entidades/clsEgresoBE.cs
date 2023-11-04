using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsEgresoBE
{
public int IdEgreso { get; set; }
public int NumeroEgreso { get; set; }
public DateTime FechaReal { get; set; }
public DateTime FechaEgreso { get; set; }
public string Observaciones { get; set; }
public decimal Total { get; set; }
public int IdGrupoArticulo { get; set; }
public int IdUnidadSolicitante { get; set; }
public int IdGestion { get; set; }
public int IdUsuarioEgreso { get; set; }
public int IdAlmacen { get; set; }
public int IdEstadoEgreso { get; set; }
public int IdSolicitud { get; set; }
}
}