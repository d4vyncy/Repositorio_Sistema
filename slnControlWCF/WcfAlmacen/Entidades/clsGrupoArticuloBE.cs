using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsGrupoArticuloBE
{
public int IdGrupoArticulo { get; set; }
public string NombreGrupoArticulo { get; set; }
public string Abreviatura { get; set; }
public int IdPadre { get; set; }
public int IdPartida { get; set; }
public int Nivel { get; set; }
public string Sector { get; set; }
}
}