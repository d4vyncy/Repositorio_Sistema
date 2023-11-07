using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wcfsisdav.Entidades 
{

public class clsUnidadBE
{
public int IdUnidad { get; set; }
public string NombreUnidad { get; set; }
public string CodigoUnidad { get; set; }
public int IdPadreUnidad { get; set; }
public int Orden { get; set; }
public int IdEntidad { get; set; }
}
}