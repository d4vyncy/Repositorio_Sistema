using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wcfsisdav.Entidades 
{

public class clsInstitucionBE
{
public int IdInstitucion { get; set; }
public int IdInstitucionPadre { get; set; }
public string NombreInstitucion { get; set; }
public int IdTipoInstitucion { get; set; }
}
}