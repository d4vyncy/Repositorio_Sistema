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
#region _tblRolUsuario
[OperationContract]
cls_tblRolUsuario Obtiene_tblRolUsuario(int Id_tblRolUsuario);

[OperationContract]
int Agrega_tblRolUsuario(cls_tblRolUsuario o_tblRolUsuario);

[OperationContract]
int Modifica_tblRolUsuario(cls_tblRolUsuario o_tblRolUsuario);

[OperationContract]
int Elimina_tblRolUsuario(int Id_tblRolUsuario);

[OperationContract]
DataSet Obtienepav_tblRolUsuario1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblRolUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblPersona
[OperationContract]
cls_tblPersona Obtiene_tblPersona(int Id_tblPersona);

[OperationContract]
int Agrega_tblPersona(cls_tblPersona o_tblPersona);

[OperationContract]
int Modifica_tblPersona(cls_tblPersona o_tblPersona);

[OperationContract]
int Elimina_tblPersona(int Id_tblPersona);

[OperationContract]
DataSet Obtienepav_tblPersona1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblPersona2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblPersona3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblPersona4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblPersona5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblInstitucion
[OperationContract]
cls_tblInstitucion Obtiene_tblInstitucion(int Id_tblInstitucion);

[OperationContract]
int Agrega_tblInstitucion(cls_tblInstitucion o_tblInstitucion);

[OperationContract]
int Modifica_tblInstitucion(cls_tblInstitucion o_tblInstitucion);

[OperationContract]
int Elimina_tblInstitucion(int Id_tblInstitucion);

[OperationContract]
DataSet Obtienepav_tblInstitucion1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblInstitucion2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblItemInstitucion
[OperationContract]
cls_tblItemInstitucion Obtiene_tblItemInstitucion(int Id_tblItemInstitucion);

[OperationContract]
int Agrega_tblItemInstitucion(cls_tblItemInstitucion o_tblItemInstitucion);

[OperationContract]
int Modifica_tblItemInstitucion(cls_tblItemInstitucion o_tblItemInstitucion);

[OperationContract]
int Elimina_tblItemInstitucion(int Id_tblItemInstitucion);

[OperationContract]
DataSet Obtienepav_tblItemInstitucion1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblItemInstitucion2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblItemInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblItemInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblItemInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblUnidad
[OperationContract]
cls_tblUnidad Obtiene_tblUnidad(int Id_tblUnidad);

[OperationContract]
int Agrega_tblUnidad(cls_tblUnidad o_tblUnidad);

[OperationContract]
int Modifica_tblUnidad(cls_tblUnidad o_tblUnidad);

[OperationContract]
int Elimina_tblUnidad(int Id_tblUnidad);

[OperationContract]
DataSet Obtienepav_tblUnidad1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblUnidad2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblUnidad3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblUnidad4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblUnidad5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblUsuario
[OperationContract]
cls_tblUsuario Obtiene_tblUsuario(int Id_tblUsuario);

[OperationContract]
int Agrega_tblUsuario(cls_tblUsuario o_tblUsuario);

[OperationContract]
int Modifica_tblUsuario(cls_tblUsuario o_tblUsuario);

[OperationContract]
int Elimina_tblUsuario(int Id_tblUsuario);

[OperationContract]
DataSet Obtienepav_tblUsuario1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblUsuarioLogueado
[OperationContract]
cls_tblUsuarioLogueado Obtiene_tblUsuarioLogueado(int Id_tblUsuarioLogueado);

[OperationContract]
int Agrega_tblUsuarioLogueado(cls_tblUsuarioLogueado o_tblUsuarioLogueado);

[OperationContract]
int Modifica_tblUsuarioLogueado(cls_tblUsuarioLogueado o_tblUsuarioLogueado);

[OperationContract]
int Elimina_tblUsuarioLogueado(int Id_tblUsuarioLogueado);

[OperationContract]
DataSet Obtienepav_tblUsuarioLogueado1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblUsuarioLogueado2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblUsuarioLogueado3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblUsuarioLogueado4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblUsuarioLogueado5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region _tblRol
[OperationContract]
cls_tblRol Obtiene_tblRol(int Id_tblRol);

[OperationContract]
int Agrega_tblRol(cls_tblRol o_tblRol);

[OperationContract]
int Modifica_tblRol(cls_tblRol o_tblRol);

[OperationContract]
int Elimina_tblRol(int Id_tblRol);

[OperationContract]
DataSet Obtienepav_tblRol1(string Campo, string Valor);

[OperationContract]
DataSet Obtienepav_tblRol2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet Obtienepav_tblRol3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet Obtienepav_tblRol4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet Obtienepav_tblRol5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
}
}
