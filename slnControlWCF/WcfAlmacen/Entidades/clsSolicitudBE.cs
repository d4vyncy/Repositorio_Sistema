using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsSolicitudBE
{
public int IdSolicitud { get; set; }
public int NumeroSolicitud { get; set; }
public DateTime FechaReal { get; set; }
public DateTime FechaSolicitud { get; set; }
public string Observaciones { get; set; }
public decimal Total { get; set; }
public int IdGrupoArticulo { get; set; }
public int IdUnidadSolicitante { get; set; }
public int IdGestion { get; set; }
public int IdUsuarioSolicitud { get; set; }
public int IdAlmacen { get; set; }
public int IdEstadoSolicitud { get; set; }
}
}