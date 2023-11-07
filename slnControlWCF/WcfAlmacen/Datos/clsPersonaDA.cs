//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
//using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using Wcfsisdav.Entidades;

namespace Wcfsisdav.Datos 
{
public class clsPersonaDA : clsPersonaBE
{

Database db = null;
//DataSet dtoPersona;

public clsPersonaDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader ObtienePersona(clsPersonaBE pPersona)
{
DbCommand cmd = db.GetStoredProcCommand("pagPersona",2, pPersona.IdPersona, pPersona.Paterno, pPersona.Materno, pPersona.ApEsposo, pPersona.Nombres, pPersona.DocIdentidad, pPersona.LugarExpedicion, pPersona.IdEstadoCivil, pPersona.Codigo, pPersona.FechaNacimiento, pPersona.IdDepartamento, pPersona.IdPaisNacionalidad, pPersona.Direccion, pPersona.Telefono, pPersona.Fax, pPersona.Celular, pPersona.TipoTelefono, pPersona.OperadorMovil, pPersona.CasillaPostal, pPersona.CorreoElectronico, pPersona.LibretaDeServicioMilitar, pPersona.IdIdenticacion, pPersona.IdTipoPersona, pPersona.IdItemInstitucion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaPersona(clsPersonaBE pPersona)
{
DbCommand cmd = db.GetStoredProcCommand("pagPersona",1, pPersona.IdPersona, pPersona.Paterno, pPersona.Materno, pPersona.ApEsposo, pPersona.Nombres, pPersona.DocIdentidad, pPersona.LugarExpedicion, pPersona.IdEstadoCivil, pPersona.Codigo, pPersona.FechaNacimiento, pPersona.IdDepartamento, pPersona.IdPaisNacionalidad, pPersona.Direccion, pPersona.Telefono, pPersona.Fax, pPersona.Celular, pPersona.TipoTelefono, pPersona.OperadorMovil, pPersona.CasillaPostal, pPersona.CorreoElectronico, pPersona.LibretaDeServicioMilitar, pPersona.IdIdenticacion, pPersona.IdTipoPersona, pPersona.IdItemInstitucion);
int nIdPersona = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdPersona = Convert.ToInt32(dr["IdPersona"]);
}
}
return nIdPersona;
}

public int ModificaPersona(clsPersonaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagPersona",3, pPaq.IdPersona, pPaq.Paterno, pPaq.Materno, pPaq.ApEsposo, pPaq.Nombres, pPaq.DocIdentidad, pPaq.LugarExpedicion, pPaq.IdEstadoCivil, pPaq.Codigo, pPaq.FechaNacimiento, pPaq.IdDepartamento, pPaq.IdPaisNacionalidad, pPaq.Direccion, pPaq.Telefono, pPaq.Fax, pPaq.Celular, pPaq.TipoTelefono, pPaq.OperadorMovil, pPaq.CasillaPostal, pPaq.CorreoElectronico, pPaq.LibretaDeServicioMilitar, pPaq.IdIdenticacion, pPaq.IdTipoPersona, pPaq.IdItemInstitucion);
return db.ExecuteNonQuery(cmd);
}

public int EliminaPersona(clsPersonaBE pPersona)
{
DbCommand cmd = db.GetStoredProcCommand("pagPersona",4, pPersona.IdPersona, pPersona.Paterno, pPersona.Materno, pPersona.ApEsposo, pPersona.Nombres, pPersona.DocIdentidad, pPersona.LugarExpedicion, pPersona.IdEstadoCivil, pPersona.Codigo, pPersona.FechaNacimiento, pPersona.IdDepartamento, pPersona.IdPaisNacionalidad, pPersona.Direccion, pPersona.Telefono, pPersona.Fax, pPersona.Celular, pPersona.TipoTelefono, pPersona.OperadorMovil, pPersona.CasillaPostal, pPersona.CorreoElectronico, pPersona.LibretaDeServicioMilitar, pPersona.IdIdenticacion, pPersona.IdTipoPersona, pPersona.IdItemInstitucion);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavPersona(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavPersona" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
