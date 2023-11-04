using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsEquipoDetalleBE
{
public int IdEquipoDetalle { get; set; }
public int IdEquipo { get; set; }
public string Descripcion { get; set; }
public DateTime FechaConsulta { get; set; }
public Boolean Respuesta { get; set; }
}
}