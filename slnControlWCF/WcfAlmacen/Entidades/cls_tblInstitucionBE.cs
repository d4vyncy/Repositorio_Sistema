using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wcfsisdav.Entidades 
{

public class cls_tblInstitucionBE
{
public int IdInstitucion { get; set; }
public int IdInstitucionPadre { get; set; }
public string NombreInstitucion { get; set; }
public int IdTipoInstitucion { get; set; }
}
}