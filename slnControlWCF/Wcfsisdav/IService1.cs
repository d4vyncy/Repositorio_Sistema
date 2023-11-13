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
[ServiceContract]
public interface IService1
{
[OperationContract]
DataSet ProcedureConParametro(string Procedimiento,object[] pParametros);
[OperationContract]
DataSet ProcedureParametro(string Procedimiento, string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7);
[OperationContract]
int EjecutaConsulta(string Consulta);
#region RolUsuario
[OperationContract]
clsRolUsuario ObtieneRolUsuario(int IdRolUsuario);

[OperationContract]
int AgregaRolUsuario(clsRolUsuario oRolUsuario);

[OperationContract]
int ModificaRolUsuario(clsRolUsuario oRolUsuario);

[OperationContract]
int EliminaRolUsuario(int IdRolUsuario);

[OperationContract]
DataSet ObtienepavRolUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavRolUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Persona
[OperationContract]
clsPersona ObtienePersona(int IdPersona);

[OperationContract]
int AgregaPersona(clsPersona oPersona);

[OperationContract]
int ModificaPersona(clsPersona oPersona);

[OperationContract]
int EliminaPersona(int IdPersona);

[OperationContract]
DataSet ObtienepavPersona1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavPersona2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavPersona3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavPersona4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavPersona5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Institucion
[OperationContract]
clsInstitucion ObtieneInstitucion(int IdInstitucion);

[OperationContract]
int AgregaInstitucion(clsInstitucion oInstitucion);

[OperationContract]
int ModificaInstitucion(clsInstitucion oInstitucion);

[OperationContract]
int EliminaInstitucion(int IdInstitucion);

[OperationContract]
DataSet ObtienepavInstitucion1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavInstitucion2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region ItemInstitucion
[OperationContract]
clsItemInstitucion ObtieneItemInstitucion(int IdItemInstitucion);

[OperationContract]
int AgregaItemInstitucion(clsItemInstitucion oItemInstitucion);

[OperationContract]
int ModificaItemInstitucion(clsItemInstitucion oItemInstitucion);

[OperationContract]
int EliminaItemInstitucion(int IdItemInstitucion);

[OperationContract]
DataSet ObtienepavItemInstitucion1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavItemInstitucion2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavItemInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavItemInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavItemInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Unidad
[OperationContract]
clsUnidad ObtieneUnidad(int IdUnidad);

[OperationContract]
int AgregaUnidad(clsUnidad oUnidad);

[OperationContract]
int ModificaUnidad(clsUnidad oUnidad);

[OperationContract]
int EliminaUnidad(int IdUnidad);

[OperationContract]
DataSet ObtienepavUnidad1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavUnidad2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavUnidad3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavUnidad4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavUnidad5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Usuario
[OperationContract]
clsUsuario ObtieneUsuario(int IdUsuario);

[OperationContract]
int AgregaUsuario(clsUsuario oUsuario);

[OperationContract]
int ModificaUsuario(clsUsuario oUsuario);

[OperationContract]
int EliminaUsuario(int IdUsuario);

[OperationContract]
DataSet ObtienepavUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region UsuarioLogueado
[OperationContract]
clsUsuarioLogueado ObtieneUsuarioLogueado(int IdUsuarioLogueado);

[OperationContract]
int AgregaUsuarioLogueado(clsUsuarioLogueado oUsuarioLogueado);

[OperationContract]
int ModificaUsuarioLogueado(clsUsuarioLogueado oUsuarioLogueado);

[OperationContract]
int EliminaUsuarioLogueado(int IdUsuarioLogueado);

[OperationContract]
DataSet ObtienepavUsuarioLogueado1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavUsuarioLogueado2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavUsuarioLogueado3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavUsuarioLogueado4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavUsuarioLogueado5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Rol
[OperationContract]
clsRol ObtieneRol(int IdRol);

[OperationContract]
int AgregaRol(clsRol oRol);

[OperationContract]
int ModificaRol(clsRol oRol);

[OperationContract]
int EliminaRol(int IdRol);

[OperationContract]
DataSet ObtienepavRol1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavRol2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavRol3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavRol4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavRol5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
}
}
