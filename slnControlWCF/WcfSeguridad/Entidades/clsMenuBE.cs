using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsMenuBE
{
public int IdMenu { get; set; }
public string NombreMenu { get; set; }
public string NombreFormulario { get; set; }
public int NumeroDeOrden { get; set; }
public int IdSistema { get; set; }
public int IdMenuPadre { get; set; }
}
}