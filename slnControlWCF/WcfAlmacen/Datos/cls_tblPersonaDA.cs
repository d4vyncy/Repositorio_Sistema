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
public class cls_tblPersonaDA : cls_tblPersonaBE
{

Database db = null;
//DataSet dto_tblPersona;

public cls_tblPersonaDA()
{
db = DatabaseFactory.CreateDatabase("Consisdav");
}

public IDataReader Obtiene_tblPersona(cls_tblPersonaBE p_tblPersona)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblPersona",2, p_tblPersona.IdPersona, p_tblPersona.Paterno, p_tblPersona.Materno, p_tblPersona.ApEsposo, p_tblPersona.Nombres, p_tblPersona.DocIdentidad, p_tblPersona.LugarExpedicion, p_tblPersona.IdEstadoCivil, p_tblPersona.Codigo, p_tblPersona.FechaNacimiento, p_tblPersona.IdDepartamento, p_tblPersona.IdPaisNacionalidad, p_tblPersona.Direccion, p_tblPersona.Telefono, p_tblPersona.Fax, p_tblPersona.Celular, p_tblPersona.TipoTelefono, p_tblPersona.OperadorMovil, p_tblPersona.CasillaPostal, p_tblPersona.CorreoElectronico, p_tblPersona.LibretaDeServicioMilitar, p_tblPersona.IdIdenticacion, p_tblPersona.IdTipoPersona, p_tblPersona.IdItemInstitucion);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int Agrega_tblPersona(cls_tblPersonaBE p_tblPersona)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblPersona",1, p_tblPersona.IdPersona, p_tblPersona.Paterno, p_tblPersona.Materno, p_tblPersona.ApEsposo, p_tblPersona.Nombres, p_tblPersona.DocIdentidad, p_tblPersona.LugarExpedicion, p_tblPersona.IdEstadoCivil, p_tblPersona.Codigo, p_tblPersona.FechaNacimiento, p_tblPersona.IdDepartamento, p_tblPersona.IdPaisNacionalidad, p_tblPersona.Direccion, p_tblPersona.Telefono, p_tblPersona.Fax, p_tblPersona.Celular, p_tblPersona.TipoTelefono, p_tblPersona.OperadorMovil, p_tblPersona.CasillaPostal, p_tblPersona.CorreoElectronico, p_tblPersona.LibretaDeServicioMilitar, p_tblPersona.IdIdenticacion, p_tblPersona.IdTipoPersona, p_tblPersona.IdItemInstitucion);
int nId_tblPersona = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nId_tblPersona = Convert.ToInt32(dr["Id_tblPersona"]);
}
}
return nId_tblPersona;
}

public int Modifica_tblPersona(cls_tblPersonaBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblPersona",3, pPaq.IdPersona, pPaq.Paterno, pPaq.Materno, pPaq.ApEsposo, pPaq.Nombres, pPaq.DocIdentidad, pPaq.LugarExpedicion, pPaq.IdEstadoCivil, pPaq.Codigo, pPaq.FechaNacimiento, pPaq.IdDepartamento, pPaq.IdPaisNacionalidad, pPaq.Direccion, pPaq.Telefono, pPaq.Fax, pPaq.Celular, pPaq.TipoTelefono, pPaq.OperadorMovil, pPaq.CasillaPostal, pPaq.CorreoElectronico, pPaq.LibretaDeServicioMilitar, pPaq.IdIdenticacion, pPaq.IdTipoPersona, pPaq.IdItemInstitucion);
return db.ExecuteNonQuery(cmd);
}

public int Elimina_tblPersona(cls_tblPersonaBE p_tblPersona)
{
DbCommand cmd = db.GetStoredProcCommand("pag_tblPersona",4, p_tblPersona.IdPersona, p_tblPersona.Paterno, p_tblPersona.Materno, p_tblPersona.ApEsposo, p_tblPersona.Nombres, p_tblPersona.DocIdentidad, p_tblPersona.LugarExpedicion, p_tblPersona.IdEstadoCivil, p_tblPersona.Codigo, p_tblPersona.FechaNacimiento, p_tblPersona.IdDepartamento, p_tblPersona.IdPaisNacionalidad, p_tblPersona.Direccion, p_tblPersona.Telefono, p_tblPersona.Fax, p_tblPersona.Celular, p_tblPersona.TipoTelefono, p_tblPersona.OperadorMovil, p_tblPersona.CasillaPostal, p_tblPersona.CorreoElectronico, p_tblPersona.LibretaDeServicioMilitar, p_tblPersona.IdIdenticacion, p_tblPersona.IdTipoPersona, p_tblPersona.IdItemInstitucion);
return db.ExecuteNonQuery(cmd);
}

public DataSet Obtienepav_tblPersona(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pav_tblPersona" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
