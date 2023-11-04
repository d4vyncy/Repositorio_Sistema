//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using WcfAlmacen.Negocios;
using WcfAlmacen.Datos;

namespace WcfAlmacen
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
#region EstadoEgreso
[OperationContract]
clsEstadoEgreso ObtieneEstadoEgreso(int IdEstadoEgreso);

[OperationContract]
int AgregaEstadoEgreso(clsEstadoEgreso oEstadoEgreso);

[OperationContract]
int ModificaEstadoEgreso(clsEstadoEgreso oEstadoEgreso);

[OperationContract]
int EliminaEstadoEgreso(int IdEstadoEgreso);

[OperationContract]
DataSet ObtienepavEstadoEgreso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoEgreso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoEgreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoEgreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoEgreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Marca
[OperationContract]
clsMarca ObtieneMarca(int IdMarca);

[OperationContract]
int AgregaMarca(clsMarca oMarca);

[OperationContract]
int ModificaMarca(clsMarca oMarca);

[OperationContract]
int EliminaMarca(int IdMarca);

[OperationContract]
DataSet ObtienepavMarca1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavMarca2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavMarca3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavMarca4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavMarca5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region AreaTrabajo
[OperationContract]
clsAreaTrabajo ObtieneAreaTrabajo(int IdAreaTrabajo);

[OperationContract]
int AgregaAreaTrabajo(clsAreaTrabajo oAreaTrabajo);

[OperationContract]
int ModificaAreaTrabajo(clsAreaTrabajo oAreaTrabajo);

[OperationContract]
int EliminaAreaTrabajo(int IdAreaTrabajo);

[OperationContract]
DataSet ObtienepavAreaTrabajo1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavAreaTrabajo2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavAreaTrabajo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavAreaTrabajo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavAreaTrabajo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Traspaso
[OperationContract]
clsTraspaso ObtieneTraspaso(int IdTraspaso);

[OperationContract]
int AgregaTraspaso(clsTraspaso oTraspaso);

[OperationContract]
int ModificaTraspaso(clsTraspaso oTraspaso);

[OperationContract]
int EliminaTraspaso(int IdTraspaso);

[OperationContract]
DataSet ObtienepavTraspaso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavTraspaso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavTraspaso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavTraspaso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavTraspaso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Ingreso
[OperationContract]
clsIngreso ObtieneIngreso(int IdIngreso);

[OperationContract]
int AgregaIngreso(clsIngreso oIngreso);

[OperationContract]
int ModificaIngreso(clsIngreso oIngreso);

[OperationContract]
int EliminaIngreso(int IdIngreso);

[OperationContract]
DataSet ObtienepavIngreso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavIngreso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavIngreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavIngreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavIngreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Bitacora
[OperationContract]
clsBitacora ObtieneBitacora(int IdBitacora);

[OperationContract]
int AgregaBitacora(clsBitacora oBitacora);

[OperationContract]
int ModificaBitacora(clsBitacora oBitacora);

[OperationContract]
int EliminaBitacora(int IdBitacora);

[OperationContract]
DataSet ObtienepavBitacora1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavBitacora2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavBitacora3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavBitacora4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavBitacora5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region MovimientoAlmacenDetalle
[OperationContract]
clsMovimientoAlmacenDetalle ObtieneMovimientoAlmacenDetalle(int IdMovimientoAlmacenDetalle);

[OperationContract]
int AgregaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalle oMovimientoAlmacenDetalle);

[OperationContract]
int ModificaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalle oMovimientoAlmacenDetalle);

[OperationContract]
int EliminaMovimientoAlmacenDetalle(int IdMovimientoAlmacenDetalle);

[OperationContract]
DataSet ObtienepavMovimientoAlmacenDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavMovimientoAlmacenDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavMovimientoAlmacenDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavMovimientoAlmacenDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavMovimientoAlmacenDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EstadoAsignado
[OperationContract]
clsEstadoAsignado ObtieneEstadoAsignado(int IdEstadoAsignado);

[OperationContract]
int AgregaEstadoAsignado(clsEstadoAsignado oEstadoAsignado);

[OperationContract]
int ModificaEstadoAsignado(clsEstadoAsignado oEstadoAsignado);

[OperationContract]
int EliminaEstadoAsignado(int IdEstadoAsignado);

[OperationContract]
DataSet ObtienepavEstadoAsignado1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoAsignado2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoAsignado3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoAsignado4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoAsignado5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region MovimientoAlmacen
[OperationContract]
clsMovimientoAlmacen ObtieneMovimientoAlmacen(int IdMovimientoAlmacen);

[OperationContract]
int AgregaMovimientoAlmacen(clsMovimientoAlmacen oMovimientoAlmacen);

[OperationContract]
int ModificaMovimientoAlmacen(clsMovimientoAlmacen oMovimientoAlmacen);

[OperationContract]
int EliminaMovimientoAlmacen(int IdMovimientoAlmacen);

[OperationContract]
DataSet ObtienepavMovimientoAlmacen1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavMovimientoAlmacen2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavMovimientoAlmacen3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavMovimientoAlmacen4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavMovimientoAlmacen5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region IngresoDetalle
[OperationContract]
clsIngresoDetalle ObtieneIngresoDetalle(int IdIngresoDetalle);

[OperationContract]
int AgregaIngresoDetalle(clsIngresoDetalle oIngresoDetalle);

[OperationContract]
int ModificaIngresoDetalle(clsIngresoDetalle oIngresoDetalle);

[OperationContract]
int EliminaIngresoDetalle(int IdIngresoDetalle);

[OperationContract]
DataSet ObtienepavIngresoDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavIngresoDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavIngresoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavIngresoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavIngresoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Stock
[OperationContract]
clsStock ObtieneStock(int IdStock);

[OperationContract]
int AgregaStock(clsStock oStock);

[OperationContract]
int ModificaStock(clsStock oStock);

[OperationContract]
int EliminaStock(int IdStock);

[OperationContract]
DataSet ObtienepavStock1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavStock2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavStock3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavStock4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavStock5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region SolicitudDetalle
[OperationContract]
clsSolicitudDetalle ObtieneSolicitudDetalle(int IdSolicitudDetalle);

[OperationContract]
int AgregaSolicitudDetalle(clsSolicitudDetalle oSolicitudDetalle);

[OperationContract]
int ModificaSolicitudDetalle(clsSolicitudDetalle oSolicitudDetalle);

[OperationContract]
int EliminaSolicitudDetalle(int IdSolicitudDetalle);

[OperationContract]
DataSet ObtienepavSolicitudDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavSolicitudDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavSolicitudDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavSolicitudDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavSolicitudDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region SolicitudDetalleInexistencia
[OperationContract]
clsSolicitudDetalleInexistencia ObtieneSolicitudDetalleInexistencia(int IdSolicitudDetalleInexistencia);

[OperationContract]
int AgregaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistencia oSolicitudDetalleInexistencia);

[OperationContract]
int ModificaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistencia oSolicitudDetalleInexistencia);

[OperationContract]
int EliminaSolicitudDetalleInexistencia(int IdSolicitudDetalleInexistencia);

[OperationContract]
DataSet ObtienepavSolicitudDetalleInexistencia1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavSolicitudDetalleInexistencia2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavSolicitudDetalleInexistencia3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavSolicitudDetalleInexistencia4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavSolicitudDetalleInexistencia5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EgresoDetalle
[OperationContract]
clsEgresoDetalle ObtieneEgresoDetalle(int IdEgresoDetalle);

[OperationContract]
int AgregaEgresoDetalle(clsEgresoDetalle oEgresoDetalle);

[OperationContract]
int ModificaEgresoDetalle(clsEgresoDetalle oEgresoDetalle);

[OperationContract]
int EliminaEgresoDetalle(int IdEgresoDetalle);

[OperationContract]
DataSet ObtienepavEgresoDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEgresoDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEgresoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEgresoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEgresoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region UsuarioAlmacen
[OperationContract]
clsUsuarioAlmacen ObtieneUsuarioAlmacen(int IdUsuarioAlmacen);

[OperationContract]
int AgregaUsuarioAlmacen(clsUsuarioAlmacen oUsuarioAlmacen);

[OperationContract]
int ModificaUsuarioAlmacen(clsUsuarioAlmacen oUsuarioAlmacen);

[OperationContract]
int EliminaUsuarioAlmacen(int IdUsuarioAlmacen);

[OperationContract]
DataSet ObtienepavUsuarioAlmacen1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavUsuarioAlmacen2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavUsuarioAlmacen3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavUsuarioAlmacen4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavUsuarioAlmacen5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Serializacion
[OperationContract]
clsSerializacion ObtieneSerializacion(int IdSerializacion);

[OperationContract]
int AgregaSerializacion(clsSerializacion oSerializacion);

[OperationContract]
int ModificaSerializacion(clsSerializacion oSerializacion);

[OperationContract]
int EliminaSerializacion(int IdSerializacion);

[OperationContract]
DataSet ObtienepavSerializacion1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavSerializacion2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavSerializacion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavSerializacion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavSerializacion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Insumo
[OperationContract]
clsInsumo ObtieneInsumo(int IdInsumo);

[OperationContract]
int AgregaInsumo(clsInsumo oInsumo);

[OperationContract]
int ModificaInsumo(clsInsumo oInsumo);

[OperationContract]
int EliminaInsumo(int IdInsumo);

[OperationContract]
DataSet ObtienepavInsumo1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavInsumo2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavInsumo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavInsumo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavInsumo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region AlmacenPartida
[OperationContract]
clsAlmacenPartida ObtieneAlmacenPartida(int IdAlmacenPartida);

[OperationContract]
int AgregaAlmacenPartida(clsAlmacenPartida oAlmacenPartida);

[OperationContract]
int ModificaAlmacenPartida(clsAlmacenPartida oAlmacenPartida);

[OperationContract]
int EliminaAlmacenPartida(int IdAlmacenPartida);

[OperationContract]
DataSet ObtienepavAlmacenPartida1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavAlmacenPartida2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavAlmacenPartida3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavAlmacenPartida4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavAlmacenPartida5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region PlanificacionCierre
[OperationContract]
clsPlanificacionCierre ObtienePlanificacionCierre(int IdPlanificacionCierre);

[OperationContract]
int AgregaPlanificacionCierre(clsPlanificacionCierre oPlanificacionCierre);

[OperationContract]
int ModificaPlanificacionCierre(clsPlanificacionCierre oPlanificacionCierre);

[OperationContract]
int EliminaPlanificacionCierre(int IdPlanificacionCierre);

[OperationContract]
DataSet ObtienepavPlanificacionCierre1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavPlanificacionCierre2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavPlanificacionCierre3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavPlanificacionCierre4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavPlanificacionCierre5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region PlanificacionCierreDetalle
[OperationContract]
clsPlanificacionCierreDetalle ObtienePlanificacionCierreDetalle(int IdPlanificacionCierreDetalle);

[OperationContract]
int AgregaPlanificacionCierreDetalle(clsPlanificacionCierreDetalle oPlanificacionCierreDetalle);

[OperationContract]
int ModificaPlanificacionCierreDetalle(clsPlanificacionCierreDetalle oPlanificacionCierreDetalle);

[OperationContract]
int EliminaPlanificacionCierreDetalle(int IdPlanificacionCierreDetalle);

[OperationContract]
DataSet ObtienepavPlanificacionCierreDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavPlanificacionCierreDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavPlanificacionCierreDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavPlanificacionCierreDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavPlanificacionCierreDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region TipoDocumentoEntrega
[OperationContract]
clsTipoDocumentoEntrega ObtieneTipoDocumentoEntrega(int IdTipoDocumentoEntrega);

[OperationContract]
int AgregaTipoDocumentoEntrega(clsTipoDocumentoEntrega oTipoDocumentoEntrega);

[OperationContract]
int ModificaTipoDocumentoEntrega(clsTipoDocumentoEntrega oTipoDocumentoEntrega);

[OperationContract]
int EliminaTipoDocumentoEntrega(int IdTipoDocumentoEntrega);

[OperationContract]
DataSet ObtienepavTipoDocumentoEntrega1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavTipoDocumentoEntrega2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavTipoDocumentoEntrega3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavTipoDocumentoEntrega4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavTipoDocumentoEntrega5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Almacen
[OperationContract]
clsAlmacen ObtieneAlmacen(int IdAlmacen);

[OperationContract]
int AgregaAlmacen(clsAlmacen oAlmacen);

[OperationContract]
int ModificaAlmacen(clsAlmacen oAlmacen);

[OperationContract]
int EliminaAlmacen(int IdAlmacen);

[OperationContract]
DataSet ObtienepavAlmacen1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavAlmacen2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavAlmacen3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavAlmacen4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavAlmacen5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region ProveedorGrupoArticulo
[OperationContract]
clsProveedorGrupoArticulo ObtieneProveedorGrupoArticulo(int IdProveedorGrupoArticulo);

[OperationContract]
int AgregaProveedorGrupoArticulo(clsProveedorGrupoArticulo oProveedorGrupoArticulo);

[OperationContract]
int ModificaProveedorGrupoArticulo(clsProveedorGrupoArticulo oProveedorGrupoArticulo);

[OperationContract]
int EliminaProveedorGrupoArticulo(int IdProveedorGrupoArticulo);

[OperationContract]
DataSet ObtienepavProveedorGrupoArticulo1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavProveedorGrupoArticulo2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavProveedorGrupoArticulo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavProveedorGrupoArticulo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavProveedorGrupoArticulo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Proveedor
[OperationContract]
clsProveedor ObtieneProveedor(int IdProveedor);

[OperationContract]
int AgregaProveedor(clsProveedor oProveedor);

[OperationContract]
int ModificaProveedor(clsProveedor oProveedor);

[OperationContract]
int EliminaProveedor(int IdProveedor);

[OperationContract]
DataSet ObtienepavProveedor1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavProveedor2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavProveedor3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavProveedor4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavProveedor5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Moneda
[OperationContract]
clsMoneda ObtieneMoneda(int IdMoneda);

[OperationContract]
int AgregaMoneda(clsMoneda oMoneda);

[OperationContract]
int ModificaMoneda(clsMoneda oMoneda);

[OperationContract]
int EliminaMoneda(int IdMoneda);

[OperationContract]
DataSet ObtienepavMoneda1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavMoneda2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavMoneda3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavMoneda4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavMoneda5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Solicitud
[OperationContract]
clsSolicitud ObtieneSolicitud(int IdSolicitud);

[OperationContract]
int AgregaSolicitud(clsSolicitud oSolicitud);

[OperationContract]
int ModificaSolicitud(clsSolicitud oSolicitud);

[OperationContract]
int EliminaSolicitud(int IdSolicitud);

[OperationContract]
DataSet ObtienepavSolicitud1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavSolicitud2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavSolicitud3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavSolicitud4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavSolicitud5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EstadoSolicitud
[OperationContract]
clsEstadoSolicitud ObtieneEstadoSolicitud(int IdEstadoSolicitud);

[OperationContract]
int AgregaEstadoSolicitud(clsEstadoSolicitud oEstadoSolicitud);

[OperationContract]
int ModificaEstadoSolicitud(clsEstadoSolicitud oEstadoSolicitud);

[OperationContract]
int EliminaEstadoSolicitud(int IdEstadoSolicitud);

[OperationContract]
DataSet ObtienepavEstadoSolicitud1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoSolicitud2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoSolicitud3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoSolicitud4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoSolicitud5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Egreso
[OperationContract]
clsEgreso ObtieneEgreso(int IdEgreso);

[OperationContract]
int AgregaEgreso(clsEgreso oEgreso);

[OperationContract]
int ModificaEgreso(clsEgreso oEgreso);

[OperationContract]
int EliminaEgreso(int IdEgreso);

[OperationContract]
DataSet ObtienepavEgreso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEgreso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEgreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEgreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEgreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region LineaDeArticulo
[OperationContract]
clsLineaDeArticulo ObtieneLineaDeArticulo(int IdLineaDeArticulo);

[OperationContract]
int AgregaLineaDeArticulo(clsLineaDeArticulo oLineaDeArticulo);

[OperationContract]
int ModificaLineaDeArticulo(clsLineaDeArticulo oLineaDeArticulo);

[OperationContract]
int EliminaLineaDeArticulo(int IdLineaDeArticulo);

[OperationContract]
DataSet ObtienepavLineaDeArticulo1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavLineaDeArticulo2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavLineaDeArticulo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavLineaDeArticulo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavLineaDeArticulo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region GrupoArticulo
[OperationContract]
clsGrupoArticulo ObtieneGrupoArticulo(int IdGrupoArticulo);

[OperationContract]
int AgregaGrupoArticulo(clsGrupoArticulo oGrupoArticulo);

[OperationContract]
int ModificaGrupoArticulo(clsGrupoArticulo oGrupoArticulo);

[OperationContract]
int EliminaGrupoArticulo(int IdGrupoArticulo);

[OperationContract]
DataSet ObtienepavGrupoArticulo1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavGrupoArticulo2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavGrupoArticulo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavGrupoArticulo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavGrupoArticulo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region UnidadDeMedida
[OperationContract]
clsUnidadDeMedida ObtieneUnidadDeMedida(int IdUnidadDeMedida);

[OperationContract]
int AgregaUnidadDeMedida(clsUnidadDeMedida oUnidadDeMedida);

[OperationContract]
int ModificaUnidadDeMedida(clsUnidadDeMedida oUnidadDeMedida);

[OperationContract]
int EliminaUnidadDeMedida(int IdUnidadDeMedida);

[OperationContract]
DataSet ObtienepavUnidadDeMedida1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavUnidadDeMedida2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavUnidadDeMedida3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavUnidadDeMedida4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavUnidadDeMedida5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region TraspasoDetalle
[OperationContract]
clsTraspasoDetalle ObtieneTraspasoDetalle(int IdTraspasoDetalle);

[OperationContract]
int AgregaTraspasoDetalle(clsTraspasoDetalle oTraspasoDetalle);

[OperationContract]
int ModificaTraspasoDetalle(clsTraspasoDetalle oTraspasoDetalle);

[OperationContract]
int EliminaTraspasoDetalle(int IdTraspasoDetalle);

[OperationContract]
DataSet ObtienepavTraspasoDetalle1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavTraspasoDetalle2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavTraspasoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavTraspasoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavTraspasoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region EstadoIngreso
[OperationContract]
clsEstadoIngreso ObtieneEstadoIngreso(int IdEstadoIngreso);

[OperationContract]
int AgregaEstadoIngreso(clsEstadoIngreso oEstadoIngreso);

[OperationContract]
int ModificaEstadoIngreso(clsEstadoIngreso oEstadoIngreso);

[OperationContract]
int EliminaEstadoIngreso(int IdEstadoIngreso);

[OperationContract]
DataSet ObtienepavEstadoIngreso1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavEstadoIngreso2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavEstadoIngreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavEstadoIngreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavEstadoIngreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Color
[OperationContract]
clsColor ObtieneColor(int IdColor);

[OperationContract]
int AgregaColor(clsColor oColor);

[OperationContract]
int ModificaColor(clsColor oColor);

[OperationContract]
int EliminaColor(int IdColor);

[OperationContract]
DataSet ObtienepavColor1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavColor2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavColor3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavColor4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavColor5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
}
}
