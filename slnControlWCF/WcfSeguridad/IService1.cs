//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using WcfSeguridad.Negocios;
using WcfSeguridad.Datos;

namespace WcfSeguridad
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
#region TipoRolUsuario
[OperationContract]
clsTipoRolUsuario ObtieneTipoRolUsuario(int IdTipoRolUsuario);

[OperationContract]
int AgregaTipoRolUsuario(clsTipoRolUsuario oTipoRolUsuario);

[OperationContract]
int ModificaTipoRolUsuario(clsTipoRolUsuario oTipoRolUsuario);

[OperationContract]
int EliminaTipoRolUsuario(int IdTipoRolUsuario);

[OperationContract]
DataSet ObtienepavTipoRolUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavTipoRolUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavTipoRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavTipoRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavTipoRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region TipoUsuario
[OperationContract]
clsTipoUsuario ObtieneTipoUsuario(int IdTipoUsuario);

[OperationContract]
int AgregaTipoUsuario(clsTipoUsuario oTipoUsuario);

[OperationContract]
int ModificaTipoUsuario(clsTipoUsuario oTipoUsuario);

[OperationContract]
int EliminaTipoUsuario(int IdTipoUsuario);

[OperationContract]
DataSet ObtienepavTipoUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavTipoUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavTipoUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavTipoUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavTipoUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EstadoUsuario
[OperationContract]
clsEstadoUsuario ObtieneEstadoUsuario(int IdEstadoUsuario);

[OperationContract]
int AgregaEstadoUsuario(clsEstadoUsuario oEstadoUsuario);

[OperationContract]
int ModificaEstadoUsuario(clsEstadoUsuario oEstadoUsuario);

[OperationContract]
int EliminaEstadoUsuario(int IdEstadoUsuario);

[OperationContract]
DataSet ObtienepavEstadoUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EstadoRolUsuario
[OperationContract]
clsEstadoRolUsuario ObtieneEstadoRolUsuario(int IdEstadoRolUsuario);

[OperationContract]
int AgregaEstadoRolUsuario(clsEstadoRolUsuario oEstadoRolUsuario);

[OperationContract]
int ModificaEstadoRolUsuario(clsEstadoRolUsuario oEstadoRolUsuario);

[OperationContract]
int EliminaEstadoRolUsuario(int IdEstadoRolUsuario);

[OperationContract]
DataSet ObtienepavEstadoRolUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoRolUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Permiso
[OperationContract]
clsPermiso ObtienePermiso(int IdPermiso);

[OperationContract]
int AgregaPermiso(clsPermiso oPermiso);

[OperationContract]
int ModificaPermiso(clsPermiso oPermiso);

[OperationContract]
int EliminaPermiso(int IdPermiso);

[OperationContract]
DataSet ObtienepavPermiso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavPermiso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavPermiso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavPermiso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavPermiso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region TipoPermiso
[OperationContract]
clsTipoPermiso ObtieneTipoPermiso(int IdTipoPermiso);

[OperationContract]
int AgregaTipoPermiso(clsTipoPermiso oTipoPermiso);

[OperationContract]
int ModificaTipoPermiso(clsTipoPermiso oTipoPermiso);

[OperationContract]
int EliminaTipoPermiso(int IdTipoPermiso);

[OperationContract]
DataSet ObtienepavTipoPermiso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavTipoPermiso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavTipoPermiso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavTipoPermiso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavTipoPermiso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EstadoLlave
[OperationContract]
clsEstadoLlave ObtieneEstadoLlave(int IdEstadoLlave);

[OperationContract]
int AgregaEstadoLlave(clsEstadoLlave oEstadoLlave);

[OperationContract]
int ModificaEstadoLlave(clsEstadoLlave oEstadoLlave);

[OperationContract]
int EliminaEstadoLlave(int IdEstadoLlave);

[OperationContract]
DataSet ObtienepavEstadoLlave1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoLlave2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoLlave3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoLlave4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoLlave5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Sistema
[OperationContract]
clsSistema ObtieneSistema(int IdSistema);

[OperationContract]
int AgregaSistema(clsSistema oSistema);

[OperationContract]
int ModificaSistema(clsSistema oSistema);

[OperationContract]
int EliminaSistema(int IdSistema);

[OperationContract]
DataSet ObtienepavSistema1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavSistema2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavSistema3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavSistema4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavSistema5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Reporte
[OperationContract]
clsReporte ObtieneReporte(int IdReporte);

[OperationContract]
int AgregaReporte(clsReporte oReporte);

[OperationContract]
int ModificaReporte(clsReporte oReporte);

[OperationContract]
int EliminaReporte(int IdReporte);

[OperationContract]
DataSet ObtienepavReporte1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavReporte2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavReporte3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavReporte4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavReporte5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Equipo
[OperationContract]
clsEquipo ObtieneEquipo(int IdEquipo);

[OperationContract]
int AgregaEquipo(clsEquipo oEquipo);

[OperationContract]
int ModificaEquipo(clsEquipo oEquipo);

[OperationContract]
int EliminaEquipo(int IdEquipo);

[OperationContract]
DataSet ObtienepavEquipo1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEquipo2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEquipo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEquipo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEquipo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EquipoDetalle
[OperationContract]
clsEquipoDetalle ObtieneEquipoDetalle(int IdEquipoDetalle);

[OperationContract]
int AgregaEquipoDetalle(clsEquipoDetalle oEquipoDetalle);

[OperationContract]
int ModificaEquipoDetalle(clsEquipoDetalle oEquipoDetalle);

[OperationContract]
int EliminaEquipoDetalle(int IdEquipoDetalle);

[OperationContract]
DataSet ObtienepavEquipoDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEquipoDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEquipoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEquipoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEquipoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Menu
[OperationContract]
clsMenu ObtieneMenu(int IdMenu);

[OperationContract]
int AgregaMenu(clsMenu oMenu);

[OperationContract]
int ModificaMenu(clsMenu oMenu);

[OperationContract]
int EliminaMenu(int IdMenu);

[OperationContract]
DataSet ObtienepavMenu1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavMenu2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavMenu3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavMenu4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavMenu5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

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
}
}
