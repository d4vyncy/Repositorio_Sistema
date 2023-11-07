//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using Wcfsisdav.Negocios;
using Wcfsisdav.Datos;

namespace Wcfsisdav
{
public class Service1 : IService1
{
// con n parametros
public DataSet ProcedureConParametro(string Procedimiento,object[] pParametros)
{
clspsisdav ad = new clspsisdav();
return ad.ProcedureParametro(Procedimiento,pParametros);
}
// con 8 parametros
public DataSet ProcedureParametro(string Procedimiento, string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7)
{
object[] pParametros = new object[] {"","","","","","","","","","","","","","","",""};
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clspsisdav ad = new clspsisdav();
return ad.ProcedureParametro(Procedimiento,pParametros);
}
public int EjecutaConsulta(string Consulta)
{
clspsisdav ad = new clspsisdav();
return ad.EjecutaConsulta(Consulta);
}
#region RolUsuario
public clsRolUsuario ObtieneRolUsuario(int IdRolUsuario)
{
clsRolUsuario oRolUsuario = new clsRolUsuario();
oRolUsuario.IdRolUsuario = IdRolUsuario;
return oRolUsuario.clsRolUsuarioPorIdRolUsuario();
}

public int AgregaRolUsuario(clsRolUsuario oRolUsuario)
{return oRolUsuario.AgregaRolUsuario();}

public int ModificaRolUsuario(clsRolUsuario oRolUsuario)
{return oRolUsuario.ModificaRolUsuario();}

public int EliminaRolUsuario(int IdRolUsuario)
{
clsRolUsuario oRolUsuario = new clsRolUsuario();
oRolUsuario.IdRolUsuario = IdRolUsuario;
return oRolUsuario.EliminaRolUsuario();}

//seleccion con parametros
public DataSet ObtienepavRolUsuario1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.ObtienepavRolUsuario(pParametros);
}
public DataSet ObtienepavRolUsuario2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.ObtienepavRolUsuario(pParametros);
}
public DataSet ObtienepavRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.ObtienepavRolUsuario(pParametros);
}
public DataSet ObtienepavRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.ObtienepavRolUsuario(pParametros);
}
public DataSet ObtienepavRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsRolUsuarioDA ad = new clsRolUsuarioDA();
return ad.ObtienepavRolUsuario(pParametros);
}
#endregion 
#region Persona
public clsPersona ObtienePersona(int IdPersona)
{
clsPersona oPersona = new clsPersona();
oPersona.IdPersona = IdPersona;
return oPersona.clsPersonaPorIdPersona();
}

public int AgregaPersona(clsPersona oPersona)
{return oPersona.AgregaPersona();}

public int ModificaPersona(clsPersona oPersona)
{return oPersona.ModificaPersona();}

public int EliminaPersona(int IdPersona)
{
clsPersona oPersona = new clsPersona();
oPersona.IdPersona = IdPersona;
return oPersona.EliminaPersona();}

//seleccion con parametros
public DataSet ObtienepavPersona1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsPersonaDA ad = new clsPersonaDA();
return ad.ObtienepavPersona(pParametros);
}
public DataSet ObtienepavPersona2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsPersonaDA ad = new clsPersonaDA();
return ad.ObtienepavPersona(pParametros);
}
public DataSet ObtienepavPersona3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsPersonaDA ad = new clsPersonaDA();
return ad.ObtienepavPersona(pParametros);
}
public DataSet ObtienepavPersona4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsPersonaDA ad = new clsPersonaDA();
return ad.ObtienepavPersona(pParametros);
}
public DataSet ObtienepavPersona5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsPersonaDA ad = new clsPersonaDA();
return ad.ObtienepavPersona(pParametros);
}
#endregion 
#region Institucion
public clsInstitucion ObtieneInstitucion(int IdInstitucion)
{
clsInstitucion oInstitucion = new clsInstitucion();
oInstitucion.IdInstitucion = IdInstitucion;
return oInstitucion.clsInstitucionPorIdInstitucion();
}

public int AgregaInstitucion(clsInstitucion oInstitucion)
{return oInstitucion.AgregaInstitucion();}

public int ModificaInstitucion(clsInstitucion oInstitucion)
{return oInstitucion.ModificaInstitucion();}

public int EliminaInstitucion(int IdInstitucion)
{
clsInstitucion oInstitucion = new clsInstitucion();
oInstitucion.IdInstitucion = IdInstitucion;
return oInstitucion.EliminaInstitucion();}

//seleccion con parametros
public DataSet ObtienepavInstitucion1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsInstitucionDA ad = new clsInstitucionDA();
return ad.ObtienepavInstitucion(pParametros);
}
public DataSet ObtienepavInstitucion2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsInstitucionDA ad = new clsInstitucionDA();
return ad.ObtienepavInstitucion(pParametros);
}
public DataSet ObtienepavInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsInstitucionDA ad = new clsInstitucionDA();
return ad.ObtienepavInstitucion(pParametros);
}
public DataSet ObtienepavInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsInstitucionDA ad = new clsInstitucionDA();
return ad.ObtienepavInstitucion(pParametros);
}
public DataSet ObtienepavInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsInstitucionDA ad = new clsInstitucionDA();
return ad.ObtienepavInstitucion(pParametros);
}
#endregion 
#region ItemInstitucion
public clsItemInstitucion ObtieneItemInstitucion(int IdItemInstitucion)
{
clsItemInstitucion oItemInstitucion = new clsItemInstitucion();
oItemInstitucion.IdItemInstitucion = IdItemInstitucion;
return oItemInstitucion.clsItemInstitucionPorIdItemInstitucion();
}

public int AgregaItemInstitucion(clsItemInstitucion oItemInstitucion)
{return oItemInstitucion.AgregaItemInstitucion();}

public int ModificaItemInstitucion(clsItemInstitucion oItemInstitucion)
{return oItemInstitucion.ModificaItemInstitucion();}

public int EliminaItemInstitucion(int IdItemInstitucion)
{
clsItemInstitucion oItemInstitucion = new clsItemInstitucion();
oItemInstitucion.IdItemInstitucion = IdItemInstitucion;
return oItemInstitucion.EliminaItemInstitucion();}

//seleccion con parametros
public DataSet ObtienepavItemInstitucion1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.ObtienepavItemInstitucion(pParametros);
}
public DataSet ObtienepavItemInstitucion2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.ObtienepavItemInstitucion(pParametros);
}
public DataSet ObtienepavItemInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.ObtienepavItemInstitucion(pParametros);
}
public DataSet ObtienepavItemInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.ObtienepavItemInstitucion(pParametros);
}
public DataSet ObtienepavItemInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.ObtienepavItemInstitucion(pParametros);
}
#endregion 
#region Unidad
public clsUnidad ObtieneUnidad(int IdUnidad)
{
clsUnidad oUnidad = new clsUnidad();
oUnidad.IdUnidad = IdUnidad;
return oUnidad.clsUnidadPorIdUnidad();
}

public int AgregaUnidad(clsUnidad oUnidad)
{return oUnidad.AgregaUnidad();}

public int ModificaUnidad(clsUnidad oUnidad)
{return oUnidad.ModificaUnidad();}

public int EliminaUnidad(int IdUnidad)
{
clsUnidad oUnidad = new clsUnidad();
oUnidad.IdUnidad = IdUnidad;
return oUnidad.EliminaUnidad();}

//seleccion con parametros
public DataSet ObtienepavUnidad1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUnidadDA ad = new clsUnidadDA();
return ad.ObtienepavUnidad(pParametros);
}
public DataSet ObtienepavUnidad2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUnidadDA ad = new clsUnidadDA();
return ad.ObtienepavUnidad(pParametros);
}
public DataSet ObtienepavUnidad3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUnidadDA ad = new clsUnidadDA();
return ad.ObtienepavUnidad(pParametros);
}
public DataSet ObtienepavUnidad4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUnidadDA ad = new clsUnidadDA();
return ad.ObtienepavUnidad(pParametros);
}
public DataSet ObtienepavUnidad5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsUnidadDA ad = new clsUnidadDA();
return ad.ObtienepavUnidad(pParametros);
}
#endregion 
#region Usuario
public clsUsuario ObtieneUsuario(int IdUsuario)
{
clsUsuario oUsuario = new clsUsuario();
oUsuario.IdUsuario = IdUsuario;
return oUsuario.clsUsuarioPorIdUsuario();
}

public int AgregaUsuario(clsUsuario oUsuario)
{return oUsuario.AgregaUsuario();}

public int ModificaUsuario(clsUsuario oUsuario)
{return oUsuario.ModificaUsuario();}

public int EliminaUsuario(int IdUsuario)
{
clsUsuario oUsuario = new clsUsuario();
oUsuario.IdUsuario = IdUsuario;
return oUsuario.EliminaUsuario();}

//seleccion con parametros
public DataSet ObtienepavUsuario1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioDA ad = new clsUsuarioDA();
return ad.ObtienepavUsuario(pParametros);
}
public DataSet ObtienepavUsuario2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioDA ad = new clsUsuarioDA();
return ad.ObtienepavUsuario(pParametros);
}
public DataSet ObtienepavUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioDA ad = new clsUsuarioDA();
return ad.ObtienepavUsuario(pParametros);
}
public DataSet ObtienepavUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioDA ad = new clsUsuarioDA();
return ad.ObtienepavUsuario(pParametros);
}
public DataSet ObtienepavUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsUsuarioDA ad = new clsUsuarioDA();
return ad.ObtienepavUsuario(pParametros);
}
#endregion 
#region UsuarioLogueado
public clsUsuarioLogueado ObtieneUsuarioLogueado(int IdUsuarioLogueado)
{
clsUsuarioLogueado oUsuarioLogueado = new clsUsuarioLogueado();
oUsuarioLogueado.IdUsuarioLogueado = IdUsuarioLogueado;
return oUsuarioLogueado.clsUsuarioLogueadoPorIdUsuarioLogueado();
}

public int AgregaUsuarioLogueado(clsUsuarioLogueado oUsuarioLogueado)
{return oUsuarioLogueado.AgregaUsuarioLogueado();}

public int ModificaUsuarioLogueado(clsUsuarioLogueado oUsuarioLogueado)
{return oUsuarioLogueado.ModificaUsuarioLogueado();}

public int EliminaUsuarioLogueado(int IdUsuarioLogueado)
{
clsUsuarioLogueado oUsuarioLogueado = new clsUsuarioLogueado();
oUsuarioLogueado.IdUsuarioLogueado = IdUsuarioLogueado;
return oUsuarioLogueado.EliminaUsuarioLogueado();}

//seleccion con parametros
public DataSet ObtienepavUsuarioLogueado1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.ObtienepavUsuarioLogueado(pParametros);
}
public DataSet ObtienepavUsuarioLogueado2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.ObtienepavUsuarioLogueado(pParametros);
}
public DataSet ObtienepavUsuarioLogueado3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.ObtienepavUsuarioLogueado(pParametros);
}
public DataSet ObtienepavUsuarioLogueado4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.ObtienepavUsuarioLogueado(pParametros);
}
public DataSet ObtienepavUsuarioLogueado5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsUsuarioLogueadoDA ad = new clsUsuarioLogueadoDA();
return ad.ObtienepavUsuarioLogueado(pParametros);
}
#endregion 
#region Rol
public clsRol ObtieneRol(int IdRol)
{
clsRol oRol = new clsRol();
oRol.IdRol = IdRol;
return oRol.clsRolPorIdRol();
}

public int AgregaRol(clsRol oRol)
{return oRol.AgregaRol();}

public int ModificaRol(clsRol oRol)
{return oRol.ModificaRol();}

public int EliminaRol(int IdRol)
{
clsRol oRol = new clsRol();
oRol.IdRol = IdRol;
return oRol.EliminaRol();}

//seleccion con parametros
public DataSet ObtienepavRol1(string Campo, string Valor)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = "T";
pParametros[3] = "";
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolDA ad = new clsRolDA();
return ad.ObtienepavRol(pParametros);
}
public DataSet ObtienepavRol2(string Campo, string Valor,string Campo1, string Valor1)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = "T";
pParametros[5] = "";
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolDA ad = new clsRolDA();
return ad.ObtienepavRol(pParametros);
}
public DataSet ObtienepavRol3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = "T";
pParametros[7] = "";
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolDA ad = new clsRolDA();
return ad.ObtienepavRol(pParametros);
}
public DataSet ObtienepavRol4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = "T";
pParametros[9] = "";
pParametros[10] = "T";
pParametros[11] = "";
pParametros[12] = "T";
pParametros[13] = "";
pParametros[14] = "T";
pParametros[15] = "";
clsRolDA ad = new clsRolDA();
return ad.ObtienepavRol(pParametros);
}
public DataSet ObtienepavRol5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
{
object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
pParametros[0] = Campo;
pParametros[1] = Valor;
pParametros[2] = Campo1;
pParametros[3] = Valor1;
pParametros[4] = Campo2;
pParametros[5] = Valor2;
pParametros[6] = Campo3;
pParametros[7] = Valor3;
pParametros[8] = Campo4;
pParametros[9] = Valor4;
pParametros[10] = Campo5;
pParametros[11] = Valor5;
pParametros[12] = Campo6;
pParametros[13] = Valor6;
pParametros[14] = Campo7;
pParametros[15] = Valor7;
clsRolDA ad = new clsRolDA();
return ad.ObtienepavRol(pParametros);
}
#endregion 
}
}
