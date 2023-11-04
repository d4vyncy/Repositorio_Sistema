using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsUsuarioLogueadoBE
{
public int IdUsuarioLogueado { get; set; }
public int IdUsuario { get; set; }
public int IdRolUsuario { get; set; }
public string Llave { get; set; }
public int IdEstadoLlave { get; set; }
public DateTime Fecha { get; set; }
public string DireccionIP { get; set; }
public string DireccionHost { get; set; }
public string DireccionDest { get; set; }
}
}