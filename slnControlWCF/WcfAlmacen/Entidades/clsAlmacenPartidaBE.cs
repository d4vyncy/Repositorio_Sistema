using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsAlmacenPartidaBE
{
public int IdAlmacenPartida { get; set; }
public int NumeroPartida { get; set; }
public int IdAlmacenPartidaPadre { get; set; }
public string NombreAlmacenPartida { get; set; }
public string Descripcion { get; set; }
public string DetallePartida { get; set; }
public string Estado { get; set; }
}
}