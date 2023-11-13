using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wcfsisdav.Entidades 
{

public class clsPersonaBE
{
public int IdPersona { get; set; }
public string Paterno { get; set; }
public string Materno { get; set; }
public string ApEsposo { get; set; }
public string Nombres { get; set; }
public string DocIdentidad { get; set; }
public string LugarExpedicion { get; set; }
public int IdEstadoCivil { get; set; }
public string Codigo { get; set; }
public DateTime FechaNacimiento { get; set; }
public int IdDepartamento { get; set; }
public int IdPaisNacionalidad { get; set; }
public string Direccion { get; set; }
public string Telefono { get; set; }
public string Fax { get; set; }
public string Celular { get; set; }
public string TipoTelefono { get; set; }
public string OperadorMovil { get; set; }
public string CasillaPostal { get; set; }
public string CorreoElectronico { get; set; }
public string LibretaDeServicioMilitar { get; set; }
public int IdIdenticacion { get; set; }
public int IdTipoPersona { get; set; }
public int IdItemInstitucion { get; set; }
}
}