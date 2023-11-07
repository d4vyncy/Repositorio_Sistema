using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Wcfsisdav.Entidades;
using Wcfsisdav.Datos;

namespace Wcfsisdav.Negocios 
{

public class clsPersona : clsPersonaDA
{
public clsPersona()
{
this.IdPersona = 0;
this.Paterno = string.Empty;
this.Materno = string.Empty;
this.ApEsposo = string.Empty;
this.Nombres = string.Empty;
this.DocIdentidad = string.Empty;
this.LugarExpedicion = string.Empty;
this.IdEstadoCivil = 0;
this.Codigo = string.Empty;
this.FechaNacimiento = DateTime.Now;
this.IdDepartamento = 0;
this.IdPaisNacionalidad = 0;
this.Direccion = string.Empty;
this.Telefono = string.Empty;
this.Fax = string.Empty;
this.Celular = string.Empty;
this.TipoTelefono = string.Empty;
this.OperadorMovil = string.Empty;
this.CasillaPostal = string.Empty;
this.CorreoElectronico = string.Empty;
this.LibretaDeServicioMilitar = string.Empty;
this.IdIdenticacion = 0;
this.IdTipoPersona = 0;
this.IdItemInstitucion = 0;
}

public clsPersona(int IdPersona)
{
}


public clsPersona clsPersonaPorIdPersona()
{
using (IDataReader dr = ObtienePersona(this))
{
if (dr.Read())
{
this.IdPersona = Convert.ToInt32(dr["IdPersona"]);
this.Paterno = Convert.ToString(dr["Paterno"]);
this.Materno = Convert.ToString(dr["Materno"]);
this.ApEsposo = Convert.ToString(dr["ApEsposo"]);
this.Nombres = Convert.ToString(dr["Nombres"]);
this.DocIdentidad = Convert.ToString(dr["DocIdentidad"]);
this.LugarExpedicion = Convert.ToString(dr["LugarExpedicion"]);
this.IdEstadoCivil = Convert.ToInt32(dr["IdEstadoCivil"]);
this.Codigo = Convert.ToString(dr["Codigo"]);
this.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
this.IdDepartamento = Convert.ToInt32(dr["IdDepartamento"]);
this.IdPaisNacionalidad = Convert.ToInt32(dr["IdPaisNacionalidad"]);
this.Direccion = Convert.ToString(dr["Direccion"]);
this.Telefono = Convert.ToString(dr["Telefono"]);
this.Fax = Convert.ToString(dr["Fax"]);
this.Celular = Convert.ToString(dr["Celular"]);
this.TipoTelefono = Convert.ToString(dr["TipoTelefono"]);
this.OperadorMovil = Convert.ToString(dr["OperadorMovil"]);
this.CasillaPostal = Convert.ToString(dr["CasillaPostal"]);
this.CorreoElectronico = Convert.ToString(dr["CorreoElectronico"]);
this.LibretaDeServicioMilitar = Convert.ToString(dr["LibretaDeServicioMilitar"]);
this.IdIdenticacion = Convert.ToInt32(dr["IdIdenticacion"]);
this.IdTipoPersona = Convert.ToInt32(dr["IdTipoPersona"]);
this.IdItemInstitucion = Convert.ToInt32(dr["IdItemInstitucion"]);
}
}
return this;
}

public int AgregaPersona()
{
clsPersonaDA ad = new clsPersonaDA();
return ad.AgregaPersona(this);
}

public int ModificaPersona()
{
clsPersonaDA ad = new clsPersonaDA();
return ad.ModificaPersona(this);
}

public int EliminaPersona()
{
clsPersonaDA ad = new clsPersonaDA();
return ad.EliminaPersona(this);
}

}
}
