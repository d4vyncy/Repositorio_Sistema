using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsInsumoBE
{
public int IdInsumo { get; set; }
public string Codigo1 { get; set; }
public string Codigo2 { get; set; }
public string NombreInsumo { get; set; }
public Byte[] Imagen { get; set; }
public int CantidadMinima { get; set; }
public int CantidadMaxima { get; set; }
public int PrecioCompra { get; set; }
public int PrecioVenta { get; set; }
public Boolean ConFechaVencimiento { get; set; }
public int IdMoneda { get; set; }
public int IdLineaArticulo { get; set; }
public int IdGrupoArticulo { get; set; }
public int IdUnidaMedida { get; set; }
public int IdSerializacion { get; set; }
public int IdMarca { get; set; }
public int IdColor { get; set; }
public string Estante { get; set; }
public string Nivel { get; set; }
}
}