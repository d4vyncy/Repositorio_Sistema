using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsReporteBE
{
public int IdReporte { get; set; }
public string NombreReporte { get; set; }
public string NombreFormulario { get; set; }
public int NumeroDeOrden { get; set; }
public int IdSistema { get; set; }
public int IdReportePadre { get; set; }
}
}