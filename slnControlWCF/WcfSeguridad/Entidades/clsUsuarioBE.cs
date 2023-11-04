using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsUsuarioBE
{
public int IdUsuario { get; set; }
public int IdPersona { get; set; }
public string NombreUsuario { get; set; }
public string Clave { get; set; }
public string Salt { get; set; }
public int Pin { get; set; }
public int IdEstadoUsuario { get; set; }
public int IdTipoUsuario { get; set; }
public string Estilo { get; set; }
}
}