using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsPermisoBE
{
public int IdPermiso { get; set; }
public string NombrePermiso { get; set; }
public int IdTipoPermiso { get; set; }
public int IdMenu { get; set; }
public int IdRol { get; set; }
}
}