using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsProveedorBE
{
public int IdProveedor { get; set; }
public int IdPersona { get; set; }
public string Representante { get; set; }
public string NombreProveedor { get; set; }
public string Direccion { get; set; }
public string Telefono { get; set; }
public string NitProveedor { get; set; }
public string ServiciosGenerales { get; set; }
public string Celular { get; set; }
public string Correo { get; set; }
public int IdAreaTrabajo { get; set; }
}
}