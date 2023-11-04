using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsBitacoraBE
{
public int IdBitacora { get; set; }
public DateTime Fecha { get; set; }
public string Detalle { get; set; }
public int IdUsuario { get; set; }
public int IdInsumo { get; set; }
public int Cantidad { get; set; }
}
}