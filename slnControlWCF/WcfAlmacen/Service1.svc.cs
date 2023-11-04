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
public class Service1 : IService1
{
// con n parametros
public DataSet ProcedureConParametro(string Procedimiento,object[] pParametros)
{
clspAlmacen ad = new clspAlmacen();
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
clspAlmacen ad = new clspAlmacen();
return ad.ProcedureParametro(Procedimiento,pParametros);
}
public int EjecutaConsulta(string Consulta)
{
clspAlmacen ad = new clspAlmacen();
return ad.EjecutaConsulta(Consulta);
}
#region EstadoEgreso
public clsEstadoEgreso ObtieneEstadoEgreso(int IdEstadoEgreso)
{
clsEstadoEgreso oEstadoEgreso = new clsEstadoEgreso();
oEstadoEgreso.IdEstadoEgreso = IdEstadoEgreso;
return oEstadoEgreso.clsEstadoEgresoPorIdEstadoEgreso();
}

public int AgregaEstadoEgreso(clsEstadoEgreso oEstadoEgreso)
{return oEstadoEgreso.AgregaEstadoEgreso();}

public int ModificaEstadoEgreso(clsEstadoEgreso oEstadoEgreso)
{return oEstadoEgreso.ModificaEstadoEgreso();}

public int EliminaEstadoEgreso(int IdEstadoEgreso)
{
clsEstadoEgreso oEstadoEgreso = new clsEstadoEgreso();
oEstadoEgreso.IdEstadoEgreso = IdEstadoEgreso;
return oEstadoEgreso.EliminaEstadoEgreso();}

//seleccion con parametros
public DataSet ObtienepavEstadoEgreso1(string Campo, string Valor)
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
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.ObtienepavEstadoEgreso(pParametros);
}
public DataSet ObtienepavEstadoEgreso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.ObtienepavEstadoEgreso(pParametros);
}
public DataSet ObtienepavEstadoEgreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.ObtienepavEstadoEgreso(pParametros);
}
public DataSet ObtienepavEstadoEgreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.ObtienepavEstadoEgreso(pParametros);
}
public DataSet ObtienepavEstadoEgreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.ObtienepavEstadoEgreso(pParametros);
}
#endregion 
#region Marca
public clsMarca ObtieneMarca(int IdMarca)
{
clsMarca oMarca = new clsMarca();
oMarca.IdMarca = IdMarca;
return oMarca.clsMarcaPorIdMarca();
}

public int AgregaMarca(clsMarca oMarca)
{return oMarca.AgregaMarca();}

public int ModificaMarca(clsMarca oMarca)
{return oMarca.ModificaMarca();}

public int EliminaMarca(int IdMarca)
{
clsMarca oMarca = new clsMarca();
oMarca.IdMarca = IdMarca;
return oMarca.EliminaMarca();}

//seleccion con parametros
public DataSet ObtienepavMarca1(string Campo, string Valor)
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
clsMarcaDA ad = new clsMarcaDA();
return ad.ObtienepavMarca(pParametros);
}
public DataSet ObtienepavMarca2(string Campo, string Valor,string Campo1, string Valor1)
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
clsMarcaDA ad = new clsMarcaDA();
return ad.ObtienepavMarca(pParametros);
}
public DataSet ObtienepavMarca3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsMarcaDA ad = new clsMarcaDA();
return ad.ObtienepavMarca(pParametros);
}
public DataSet ObtienepavMarca4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsMarcaDA ad = new clsMarcaDA();
return ad.ObtienepavMarca(pParametros);
}
public DataSet ObtienepavMarca5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsMarcaDA ad = new clsMarcaDA();
return ad.ObtienepavMarca(pParametros);
}
#endregion 
#region AreaTrabajo
public clsAreaTrabajo ObtieneAreaTrabajo(int IdAreaTrabajo)
{
clsAreaTrabajo oAreaTrabajo = new clsAreaTrabajo();
oAreaTrabajo.IdAreaTrabajo = IdAreaTrabajo;
return oAreaTrabajo.clsAreaTrabajoPorIdAreaTrabajo();
}

public int AgregaAreaTrabajo(clsAreaTrabajo oAreaTrabajo)
{return oAreaTrabajo.AgregaAreaTrabajo();}

public int ModificaAreaTrabajo(clsAreaTrabajo oAreaTrabajo)
{return oAreaTrabajo.ModificaAreaTrabajo();}

public int EliminaAreaTrabajo(int IdAreaTrabajo)
{
clsAreaTrabajo oAreaTrabajo = new clsAreaTrabajo();
oAreaTrabajo.IdAreaTrabajo = IdAreaTrabajo;
return oAreaTrabajo.EliminaAreaTrabajo();}

//seleccion con parametros
public DataSet ObtienepavAreaTrabajo1(string Campo, string Valor)
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
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.ObtienepavAreaTrabajo(pParametros);
}
public DataSet ObtienepavAreaTrabajo2(string Campo, string Valor,string Campo1, string Valor1)
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
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.ObtienepavAreaTrabajo(pParametros);
}
public DataSet ObtienepavAreaTrabajo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.ObtienepavAreaTrabajo(pParametros);
}
public DataSet ObtienepavAreaTrabajo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.ObtienepavAreaTrabajo(pParametros);
}
public DataSet ObtienepavAreaTrabajo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.ObtienepavAreaTrabajo(pParametros);
}
#endregion 
#region Traspaso
public clsTraspaso ObtieneTraspaso(int IdTraspaso)
{
clsTraspaso oTraspaso = new clsTraspaso();
oTraspaso.IdTraspaso = IdTraspaso;
return oTraspaso.clsTraspasoPorIdTraspaso();
}

public int AgregaTraspaso(clsTraspaso oTraspaso)
{return oTraspaso.AgregaTraspaso();}

public int ModificaTraspaso(clsTraspaso oTraspaso)
{return oTraspaso.ModificaTraspaso();}

public int EliminaTraspaso(int IdTraspaso)
{
clsTraspaso oTraspaso = new clsTraspaso();
oTraspaso.IdTraspaso = IdTraspaso;
return oTraspaso.EliminaTraspaso();}

//seleccion con parametros
public DataSet ObtienepavTraspaso1(string Campo, string Valor)
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
clsTraspasoDA ad = new clsTraspasoDA();
return ad.ObtienepavTraspaso(pParametros);
}
public DataSet ObtienepavTraspaso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsTraspasoDA ad = new clsTraspasoDA();
return ad.ObtienepavTraspaso(pParametros);
}
public DataSet ObtienepavTraspaso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsTraspasoDA ad = new clsTraspasoDA();
return ad.ObtienepavTraspaso(pParametros);
}
public DataSet ObtienepavTraspaso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsTraspasoDA ad = new clsTraspasoDA();
return ad.ObtienepavTraspaso(pParametros);
}
public DataSet ObtienepavTraspaso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsTraspasoDA ad = new clsTraspasoDA();
return ad.ObtienepavTraspaso(pParametros);
}
#endregion 
#region Ingreso
public clsIngreso ObtieneIngreso(int IdIngreso)
{
clsIngreso oIngreso = new clsIngreso();
oIngreso.IdIngreso = IdIngreso;
return oIngreso.clsIngresoPorIdIngreso();
}

public int AgregaIngreso(clsIngreso oIngreso)
{return oIngreso.AgregaIngreso();}

public int ModificaIngreso(clsIngreso oIngreso)
{return oIngreso.ModificaIngreso();}

public int EliminaIngreso(int IdIngreso)
{
clsIngreso oIngreso = new clsIngreso();
oIngreso.IdIngreso = IdIngreso;
return oIngreso.EliminaIngreso();}

//seleccion con parametros
public DataSet ObtienepavIngreso1(string Campo, string Valor)
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
clsIngresoDA ad = new clsIngresoDA();
return ad.ObtienepavIngreso(pParametros);
}
public DataSet ObtienepavIngreso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsIngresoDA ad = new clsIngresoDA();
return ad.ObtienepavIngreso(pParametros);
}
public DataSet ObtienepavIngreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsIngresoDA ad = new clsIngresoDA();
return ad.ObtienepavIngreso(pParametros);
}
public DataSet ObtienepavIngreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsIngresoDA ad = new clsIngresoDA();
return ad.ObtienepavIngreso(pParametros);
}
public DataSet ObtienepavIngreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsIngresoDA ad = new clsIngresoDA();
return ad.ObtienepavIngreso(pParametros);
}
#endregion 
#region Bitacora
public clsBitacora ObtieneBitacora(int IdBitacora)
{
clsBitacora oBitacora = new clsBitacora();
oBitacora.IdBitacora = IdBitacora;
return oBitacora.clsBitacoraPorIdBitacora();
}

public int AgregaBitacora(clsBitacora oBitacora)
{return oBitacora.AgregaBitacora();}

public int ModificaBitacora(clsBitacora oBitacora)
{return oBitacora.ModificaBitacora();}

public int EliminaBitacora(int IdBitacora)
{
clsBitacora oBitacora = new clsBitacora();
oBitacora.IdBitacora = IdBitacora;
return oBitacora.EliminaBitacora();}

//seleccion con parametros
public DataSet ObtienepavBitacora1(string Campo, string Valor)
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
clsBitacoraDA ad = new clsBitacoraDA();
return ad.ObtienepavBitacora(pParametros);
}
public DataSet ObtienepavBitacora2(string Campo, string Valor,string Campo1, string Valor1)
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
clsBitacoraDA ad = new clsBitacoraDA();
return ad.ObtienepavBitacora(pParametros);
}
public DataSet ObtienepavBitacora3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsBitacoraDA ad = new clsBitacoraDA();
return ad.ObtienepavBitacora(pParametros);
}
public DataSet ObtienepavBitacora4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsBitacoraDA ad = new clsBitacoraDA();
return ad.ObtienepavBitacora(pParametros);
}
public DataSet ObtienepavBitacora5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsBitacoraDA ad = new clsBitacoraDA();
return ad.ObtienepavBitacora(pParametros);
}
#endregion 
#region MovimientoAlmacenDetalle
public clsMovimientoAlmacenDetalle ObtieneMovimientoAlmacenDetalle(int IdMovimientoAlmacenDetalle)
{
clsMovimientoAlmacenDetalle oMovimientoAlmacenDetalle = new clsMovimientoAlmacenDetalle();
oMovimientoAlmacenDetalle.IdMovimientoAlmacenDetalle = IdMovimientoAlmacenDetalle;
return oMovimientoAlmacenDetalle.clsMovimientoAlmacenDetallePorIdMovimientoAlmacenDetalle();
}

public int AgregaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalle oMovimientoAlmacenDetalle)
{return oMovimientoAlmacenDetalle.AgregaMovimientoAlmacenDetalle();}

public int ModificaMovimientoAlmacenDetalle(clsMovimientoAlmacenDetalle oMovimientoAlmacenDetalle)
{return oMovimientoAlmacenDetalle.ModificaMovimientoAlmacenDetalle();}

public int EliminaMovimientoAlmacenDetalle(int IdMovimientoAlmacenDetalle)
{
clsMovimientoAlmacenDetalle oMovimientoAlmacenDetalle = new clsMovimientoAlmacenDetalle();
oMovimientoAlmacenDetalle.IdMovimientoAlmacenDetalle = IdMovimientoAlmacenDetalle;
return oMovimientoAlmacenDetalle.EliminaMovimientoAlmacenDetalle();}

//seleccion con parametros
public DataSet ObtienepavMovimientoAlmacenDetalle1(string Campo, string Valor)
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
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.ObtienepavMovimientoAlmacenDetalle(pParametros);
}
public DataSet ObtienepavMovimientoAlmacenDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.ObtienepavMovimientoAlmacenDetalle(pParametros);
}
public DataSet ObtienepavMovimientoAlmacenDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.ObtienepavMovimientoAlmacenDetalle(pParametros);
}
public DataSet ObtienepavMovimientoAlmacenDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.ObtienepavMovimientoAlmacenDetalle(pParametros);
}
public DataSet ObtienepavMovimientoAlmacenDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsMovimientoAlmacenDetalleDA ad = new clsMovimientoAlmacenDetalleDA();
return ad.ObtienepavMovimientoAlmacenDetalle(pParametros);
}
#endregion 
#region EstadoAsignado
public clsEstadoAsignado ObtieneEstadoAsignado(int IdEstadoAsignado)
{
clsEstadoAsignado oEstadoAsignado = new clsEstadoAsignado();
oEstadoAsignado.IdEstadoAsignado = IdEstadoAsignado;
return oEstadoAsignado.clsEstadoAsignadoPorIdEstadoAsignado();
}

public int AgregaEstadoAsignado(clsEstadoAsignado oEstadoAsignado)
{return oEstadoAsignado.AgregaEstadoAsignado();}

public int ModificaEstadoAsignado(clsEstadoAsignado oEstadoAsignado)
{return oEstadoAsignado.ModificaEstadoAsignado();}

public int EliminaEstadoAsignado(int IdEstadoAsignado)
{
clsEstadoAsignado oEstadoAsignado = new clsEstadoAsignado();
oEstadoAsignado.IdEstadoAsignado = IdEstadoAsignado;
return oEstadoAsignado.EliminaEstadoAsignado();}

//seleccion con parametros
public DataSet ObtienepavEstadoAsignado1(string Campo, string Valor)
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
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.ObtienepavEstadoAsignado(pParametros);
}
public DataSet ObtienepavEstadoAsignado2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.ObtienepavEstadoAsignado(pParametros);
}
public DataSet ObtienepavEstadoAsignado3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.ObtienepavEstadoAsignado(pParametros);
}
public DataSet ObtienepavEstadoAsignado4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.ObtienepavEstadoAsignado(pParametros);
}
public DataSet ObtienepavEstadoAsignado5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.ObtienepavEstadoAsignado(pParametros);
}
#endregion 
#region MovimientoAlmacen
public clsMovimientoAlmacen ObtieneMovimientoAlmacen(int IdMovimientoAlmacen)
{
clsMovimientoAlmacen oMovimientoAlmacen = new clsMovimientoAlmacen();
oMovimientoAlmacen.IdMovimientoAlmacen = IdMovimientoAlmacen;
return oMovimientoAlmacen.clsMovimientoAlmacenPorIdMovimientoAlmacen();
}

public int AgregaMovimientoAlmacen(clsMovimientoAlmacen oMovimientoAlmacen)
{return oMovimientoAlmacen.AgregaMovimientoAlmacen();}

public int ModificaMovimientoAlmacen(clsMovimientoAlmacen oMovimientoAlmacen)
{return oMovimientoAlmacen.ModificaMovimientoAlmacen();}

public int EliminaMovimientoAlmacen(int IdMovimientoAlmacen)
{
clsMovimientoAlmacen oMovimientoAlmacen = new clsMovimientoAlmacen();
oMovimientoAlmacen.IdMovimientoAlmacen = IdMovimientoAlmacen;
return oMovimientoAlmacen.EliminaMovimientoAlmacen();}

//seleccion con parametros
public DataSet ObtienepavMovimientoAlmacen1(string Campo, string Valor)
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
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.ObtienepavMovimientoAlmacen(pParametros);
}
public DataSet ObtienepavMovimientoAlmacen2(string Campo, string Valor,string Campo1, string Valor1)
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
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.ObtienepavMovimientoAlmacen(pParametros);
}
public DataSet ObtienepavMovimientoAlmacen3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.ObtienepavMovimientoAlmacen(pParametros);
}
public DataSet ObtienepavMovimientoAlmacen4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.ObtienepavMovimientoAlmacen(pParametros);
}
public DataSet ObtienepavMovimientoAlmacen5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsMovimientoAlmacenDA ad = new clsMovimientoAlmacenDA();
return ad.ObtienepavMovimientoAlmacen(pParametros);
}
#endregion 
#region IngresoDetalle
public clsIngresoDetalle ObtieneIngresoDetalle(int IdIngresoDetalle)
{
clsIngresoDetalle oIngresoDetalle = new clsIngresoDetalle();
oIngresoDetalle.IdIngresoDetalle = IdIngresoDetalle;
return oIngresoDetalle.clsIngresoDetallePorIdIngresoDetalle();
}

public int AgregaIngresoDetalle(clsIngresoDetalle oIngresoDetalle)
{return oIngresoDetalle.AgregaIngresoDetalle();}

public int ModificaIngresoDetalle(clsIngresoDetalle oIngresoDetalle)
{return oIngresoDetalle.ModificaIngresoDetalle();}

public int EliminaIngresoDetalle(int IdIngresoDetalle)
{
clsIngresoDetalle oIngresoDetalle = new clsIngresoDetalle();
oIngresoDetalle.IdIngresoDetalle = IdIngresoDetalle;
return oIngresoDetalle.EliminaIngresoDetalle();}

//seleccion con parametros
public DataSet ObtienepavIngresoDetalle1(string Campo, string Valor)
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
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.ObtienepavIngresoDetalle(pParametros);
}
public DataSet ObtienepavIngresoDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.ObtienepavIngresoDetalle(pParametros);
}
public DataSet ObtienepavIngresoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.ObtienepavIngresoDetalle(pParametros);
}
public DataSet ObtienepavIngresoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.ObtienepavIngresoDetalle(pParametros);
}
public DataSet ObtienepavIngresoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsIngresoDetalleDA ad = new clsIngresoDetalleDA();
return ad.ObtienepavIngresoDetalle(pParametros);
}
#endregion 
#region Stock
public clsStock ObtieneStock(int IdStock)
{
clsStock oStock = new clsStock();
oStock.IdStock = IdStock;
return oStock.clsStockPorIdStock();
}

public int AgregaStock(clsStock oStock)
{return oStock.AgregaStock();}

public int ModificaStock(clsStock oStock)
{return oStock.ModificaStock();}

public int EliminaStock(int IdStock)
{
clsStock oStock = new clsStock();
oStock.IdStock = IdStock;
return oStock.EliminaStock();}

//seleccion con parametros
public DataSet ObtienepavStock1(string Campo, string Valor)
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
clsStockDA ad = new clsStockDA();
return ad.ObtienepavStock(pParametros);
}
public DataSet ObtienepavStock2(string Campo, string Valor,string Campo1, string Valor1)
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
clsStockDA ad = new clsStockDA();
return ad.ObtienepavStock(pParametros);
}
public DataSet ObtienepavStock3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsStockDA ad = new clsStockDA();
return ad.ObtienepavStock(pParametros);
}
public DataSet ObtienepavStock4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsStockDA ad = new clsStockDA();
return ad.ObtienepavStock(pParametros);
}
public DataSet ObtienepavStock5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsStockDA ad = new clsStockDA();
return ad.ObtienepavStock(pParametros);
}
#endregion 
#region SolicitudDetalle
public clsSolicitudDetalle ObtieneSolicitudDetalle(int IdSolicitudDetalle)
{
clsSolicitudDetalle oSolicitudDetalle = new clsSolicitudDetalle();
oSolicitudDetalle.IdSolicitudDetalle = IdSolicitudDetalle;
return oSolicitudDetalle.clsSolicitudDetallePorIdSolicitudDetalle();
}

public int AgregaSolicitudDetalle(clsSolicitudDetalle oSolicitudDetalle)
{return oSolicitudDetalle.AgregaSolicitudDetalle();}

public int ModificaSolicitudDetalle(clsSolicitudDetalle oSolicitudDetalle)
{return oSolicitudDetalle.ModificaSolicitudDetalle();}

public int EliminaSolicitudDetalle(int IdSolicitudDetalle)
{
clsSolicitudDetalle oSolicitudDetalle = new clsSolicitudDetalle();
oSolicitudDetalle.IdSolicitudDetalle = IdSolicitudDetalle;
return oSolicitudDetalle.EliminaSolicitudDetalle();}

//seleccion con parametros
public DataSet ObtienepavSolicitudDetalle1(string Campo, string Valor)
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
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.ObtienepavSolicitudDetalle(pParametros);
}
public DataSet ObtienepavSolicitudDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.ObtienepavSolicitudDetalle(pParametros);
}
public DataSet ObtienepavSolicitudDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.ObtienepavSolicitudDetalle(pParametros);
}
public DataSet ObtienepavSolicitudDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.ObtienepavSolicitudDetalle(pParametros);
}
public DataSet ObtienepavSolicitudDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsSolicitudDetalleDA ad = new clsSolicitudDetalleDA();
return ad.ObtienepavSolicitudDetalle(pParametros);
}
#endregion 
#region SolicitudDetalleInexistencia
public clsSolicitudDetalleInexistencia ObtieneSolicitudDetalleInexistencia(int IdSolicitudDetalleInexistencia)
{
clsSolicitudDetalleInexistencia oSolicitudDetalleInexistencia = new clsSolicitudDetalleInexistencia();
oSolicitudDetalleInexistencia.IdSolicitudDetalleInexistencia = IdSolicitudDetalleInexistencia;
return oSolicitudDetalleInexistencia.clsSolicitudDetalleInexistenciaPorIdSolicitudDetalleInexistencia();
}

public int AgregaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistencia oSolicitudDetalleInexistencia)
{return oSolicitudDetalleInexistencia.AgregaSolicitudDetalleInexistencia();}

public int ModificaSolicitudDetalleInexistencia(clsSolicitudDetalleInexistencia oSolicitudDetalleInexistencia)
{return oSolicitudDetalleInexistencia.ModificaSolicitudDetalleInexistencia();}

public int EliminaSolicitudDetalleInexistencia(int IdSolicitudDetalleInexistencia)
{
clsSolicitudDetalleInexistencia oSolicitudDetalleInexistencia = new clsSolicitudDetalleInexistencia();
oSolicitudDetalleInexistencia.IdSolicitudDetalleInexistencia = IdSolicitudDetalleInexistencia;
return oSolicitudDetalleInexistencia.EliminaSolicitudDetalleInexistencia();}

//seleccion con parametros
public DataSet ObtienepavSolicitudDetalleInexistencia1(string Campo, string Valor)
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
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.ObtienepavSolicitudDetalleInexistencia(pParametros);
}
public DataSet ObtienepavSolicitudDetalleInexistencia2(string Campo, string Valor,string Campo1, string Valor1)
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
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.ObtienepavSolicitudDetalleInexistencia(pParametros);
}
public DataSet ObtienepavSolicitudDetalleInexistencia3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.ObtienepavSolicitudDetalleInexistencia(pParametros);
}
public DataSet ObtienepavSolicitudDetalleInexistencia4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.ObtienepavSolicitudDetalleInexistencia(pParametros);
}
public DataSet ObtienepavSolicitudDetalleInexistencia5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsSolicitudDetalleInexistenciaDA ad = new clsSolicitudDetalleInexistenciaDA();
return ad.ObtienepavSolicitudDetalleInexistencia(pParametros);
}
#endregion 
#region EgresoDetalle
public clsEgresoDetalle ObtieneEgresoDetalle(int IdEgresoDetalle)
{
clsEgresoDetalle oEgresoDetalle = new clsEgresoDetalle();
oEgresoDetalle.IdEgresoDetalle = IdEgresoDetalle;
return oEgresoDetalle.clsEgresoDetallePorIdEgresoDetalle();
}

public int AgregaEgresoDetalle(clsEgresoDetalle oEgresoDetalle)
{return oEgresoDetalle.AgregaEgresoDetalle();}

public int ModificaEgresoDetalle(clsEgresoDetalle oEgresoDetalle)
{return oEgresoDetalle.ModificaEgresoDetalle();}

public int EliminaEgresoDetalle(int IdEgresoDetalle)
{
clsEgresoDetalle oEgresoDetalle = new clsEgresoDetalle();
oEgresoDetalle.IdEgresoDetalle = IdEgresoDetalle;
return oEgresoDetalle.EliminaEgresoDetalle();}

//seleccion con parametros
public DataSet ObtienepavEgresoDetalle1(string Campo, string Valor)
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
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.ObtienepavEgresoDetalle(pParametros);
}
public DataSet ObtienepavEgresoDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.ObtienepavEgresoDetalle(pParametros);
}
public DataSet ObtienepavEgresoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.ObtienepavEgresoDetalle(pParametros);
}
public DataSet ObtienepavEgresoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.ObtienepavEgresoDetalle(pParametros);
}
public DataSet ObtienepavEgresoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEgresoDetalleDA ad = new clsEgresoDetalleDA();
return ad.ObtienepavEgresoDetalle(pParametros);
}
#endregion 
#region UsuarioAlmacen
public clsUsuarioAlmacen ObtieneUsuarioAlmacen(int IdUsuarioAlmacen)
{
clsUsuarioAlmacen oUsuarioAlmacen = new clsUsuarioAlmacen();
oUsuarioAlmacen.IdUsuarioAlmacen = IdUsuarioAlmacen;
return oUsuarioAlmacen.clsUsuarioAlmacenPorIdUsuarioAlmacen();
}

public int AgregaUsuarioAlmacen(clsUsuarioAlmacen oUsuarioAlmacen)
{return oUsuarioAlmacen.AgregaUsuarioAlmacen();}

public int ModificaUsuarioAlmacen(clsUsuarioAlmacen oUsuarioAlmacen)
{return oUsuarioAlmacen.ModificaUsuarioAlmacen();}

public int EliminaUsuarioAlmacen(int IdUsuarioAlmacen)
{
clsUsuarioAlmacen oUsuarioAlmacen = new clsUsuarioAlmacen();
oUsuarioAlmacen.IdUsuarioAlmacen = IdUsuarioAlmacen;
return oUsuarioAlmacen.EliminaUsuarioAlmacen();}

//seleccion con parametros
public DataSet ObtienepavUsuarioAlmacen1(string Campo, string Valor)
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
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.ObtienepavUsuarioAlmacen(pParametros);
}
public DataSet ObtienepavUsuarioAlmacen2(string Campo, string Valor,string Campo1, string Valor1)
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
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.ObtienepavUsuarioAlmacen(pParametros);
}
public DataSet ObtienepavUsuarioAlmacen3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.ObtienepavUsuarioAlmacen(pParametros);
}
public DataSet ObtienepavUsuarioAlmacen4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.ObtienepavUsuarioAlmacen(pParametros);
}
public DataSet ObtienepavUsuarioAlmacen5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsUsuarioAlmacenDA ad = new clsUsuarioAlmacenDA();
return ad.ObtienepavUsuarioAlmacen(pParametros);
}
#endregion 
#region Serializacion
public clsSerializacion ObtieneSerializacion(int IdSerializacion)
{
clsSerializacion oSerializacion = new clsSerializacion();
oSerializacion.IdSerializacion = IdSerializacion;
return oSerializacion.clsSerializacionPorIdSerializacion();
}

public int AgregaSerializacion(clsSerializacion oSerializacion)
{return oSerializacion.AgregaSerializacion();}

public int ModificaSerializacion(clsSerializacion oSerializacion)
{return oSerializacion.ModificaSerializacion();}

public int EliminaSerializacion(int IdSerializacion)
{
clsSerializacion oSerializacion = new clsSerializacion();
oSerializacion.IdSerializacion = IdSerializacion;
return oSerializacion.EliminaSerializacion();}

//seleccion con parametros
public DataSet ObtienepavSerializacion1(string Campo, string Valor)
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
clsSerializacionDA ad = new clsSerializacionDA();
return ad.ObtienepavSerializacion(pParametros);
}
public DataSet ObtienepavSerializacion2(string Campo, string Valor,string Campo1, string Valor1)
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
clsSerializacionDA ad = new clsSerializacionDA();
return ad.ObtienepavSerializacion(pParametros);
}
public DataSet ObtienepavSerializacion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsSerializacionDA ad = new clsSerializacionDA();
return ad.ObtienepavSerializacion(pParametros);
}
public DataSet ObtienepavSerializacion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsSerializacionDA ad = new clsSerializacionDA();
return ad.ObtienepavSerializacion(pParametros);
}
public DataSet ObtienepavSerializacion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsSerializacionDA ad = new clsSerializacionDA();
return ad.ObtienepavSerializacion(pParametros);
}
#endregion 
#region Insumo
public clsInsumo ObtieneInsumo(int IdInsumo)
{
clsInsumo oInsumo = new clsInsumo();
oInsumo.IdInsumo = IdInsumo;
return oInsumo.clsInsumoPorIdInsumo();
}

public int AgregaInsumo(clsInsumo oInsumo)
{return oInsumo.AgregaInsumo();}

public int ModificaInsumo(clsInsumo oInsumo)
{return oInsumo.ModificaInsumo();}

public int EliminaInsumo(int IdInsumo)
{
clsInsumo oInsumo = new clsInsumo();
oInsumo.IdInsumo = IdInsumo;
return oInsumo.EliminaInsumo();}

//seleccion con parametros
public DataSet ObtienepavInsumo1(string Campo, string Valor)
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
clsInsumoDA ad = new clsInsumoDA();
return ad.ObtienepavInsumo(pParametros);
}
public DataSet ObtienepavInsumo2(string Campo, string Valor,string Campo1, string Valor1)
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
clsInsumoDA ad = new clsInsumoDA();
return ad.ObtienepavInsumo(pParametros);
}
public DataSet ObtienepavInsumo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsInsumoDA ad = new clsInsumoDA();
return ad.ObtienepavInsumo(pParametros);
}
public DataSet ObtienepavInsumo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsInsumoDA ad = new clsInsumoDA();
return ad.ObtienepavInsumo(pParametros);
}
public DataSet ObtienepavInsumo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsInsumoDA ad = new clsInsumoDA();
return ad.ObtienepavInsumo(pParametros);
}
#endregion 
#region AlmacenPartida
public clsAlmacenPartida ObtieneAlmacenPartida(int IdAlmacenPartida)
{
clsAlmacenPartida oAlmacenPartida = new clsAlmacenPartida();
oAlmacenPartida.IdAlmacenPartida = IdAlmacenPartida;
return oAlmacenPartida.clsAlmacenPartidaPorIdAlmacenPartida();
}

public int AgregaAlmacenPartida(clsAlmacenPartida oAlmacenPartida)
{return oAlmacenPartida.AgregaAlmacenPartida();}

public int ModificaAlmacenPartida(clsAlmacenPartida oAlmacenPartida)
{return oAlmacenPartida.ModificaAlmacenPartida();}

public int EliminaAlmacenPartida(int IdAlmacenPartida)
{
clsAlmacenPartida oAlmacenPartida = new clsAlmacenPartida();
oAlmacenPartida.IdAlmacenPartida = IdAlmacenPartida;
return oAlmacenPartida.EliminaAlmacenPartida();}

//seleccion con parametros
public DataSet ObtienepavAlmacenPartida1(string Campo, string Valor)
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
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.ObtienepavAlmacenPartida(pParametros);
}
public DataSet ObtienepavAlmacenPartida2(string Campo, string Valor,string Campo1, string Valor1)
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
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.ObtienepavAlmacenPartida(pParametros);
}
public DataSet ObtienepavAlmacenPartida3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.ObtienepavAlmacenPartida(pParametros);
}
public DataSet ObtienepavAlmacenPartida4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.ObtienepavAlmacenPartida(pParametros);
}
public DataSet ObtienepavAlmacenPartida5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.ObtienepavAlmacenPartida(pParametros);
}
#endregion 
#region PlanificacionCierre
public clsPlanificacionCierre ObtienePlanificacionCierre(int IdPlanificacionCierre)
{
clsPlanificacionCierre oPlanificacionCierre = new clsPlanificacionCierre();
oPlanificacionCierre.IdPlanificacionCierre = IdPlanificacionCierre;
return oPlanificacionCierre.clsPlanificacionCierrePorIdPlanificacionCierre();
}

public int AgregaPlanificacionCierre(clsPlanificacionCierre oPlanificacionCierre)
{return oPlanificacionCierre.AgregaPlanificacionCierre();}

public int ModificaPlanificacionCierre(clsPlanificacionCierre oPlanificacionCierre)
{return oPlanificacionCierre.ModificaPlanificacionCierre();}

public int EliminaPlanificacionCierre(int IdPlanificacionCierre)
{
clsPlanificacionCierre oPlanificacionCierre = new clsPlanificacionCierre();
oPlanificacionCierre.IdPlanificacionCierre = IdPlanificacionCierre;
return oPlanificacionCierre.EliminaPlanificacionCierre();}

//seleccion con parametros
public DataSet ObtienepavPlanificacionCierre1(string Campo, string Valor)
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
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.ObtienepavPlanificacionCierre(pParametros);
}
public DataSet ObtienepavPlanificacionCierre2(string Campo, string Valor,string Campo1, string Valor1)
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
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.ObtienepavPlanificacionCierre(pParametros);
}
public DataSet ObtienepavPlanificacionCierre3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.ObtienepavPlanificacionCierre(pParametros);
}
public DataSet ObtienepavPlanificacionCierre4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.ObtienepavPlanificacionCierre(pParametros);
}
public DataSet ObtienepavPlanificacionCierre5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.ObtienepavPlanificacionCierre(pParametros);
}
#endregion 
#region PlanificacionCierreDetalle
public clsPlanificacionCierreDetalle ObtienePlanificacionCierreDetalle(int IdPlanificacionCierreDetalle)
{
clsPlanificacionCierreDetalle oPlanificacionCierreDetalle = new clsPlanificacionCierreDetalle();
oPlanificacionCierreDetalle.IdPlanificacionCierreDetalle = IdPlanificacionCierreDetalle;
return oPlanificacionCierreDetalle.clsPlanificacionCierreDetallePorIdPlanificacionCierreDetalle();
}

public int AgregaPlanificacionCierreDetalle(clsPlanificacionCierreDetalle oPlanificacionCierreDetalle)
{return oPlanificacionCierreDetalle.AgregaPlanificacionCierreDetalle();}

public int ModificaPlanificacionCierreDetalle(clsPlanificacionCierreDetalle oPlanificacionCierreDetalle)
{return oPlanificacionCierreDetalle.ModificaPlanificacionCierreDetalle();}

public int EliminaPlanificacionCierreDetalle(int IdPlanificacionCierreDetalle)
{
clsPlanificacionCierreDetalle oPlanificacionCierreDetalle = new clsPlanificacionCierreDetalle();
oPlanificacionCierreDetalle.IdPlanificacionCierreDetalle = IdPlanificacionCierreDetalle;
return oPlanificacionCierreDetalle.EliminaPlanificacionCierreDetalle();}

//seleccion con parametros
public DataSet ObtienepavPlanificacionCierreDetalle1(string Campo, string Valor)
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
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.ObtienepavPlanificacionCierreDetalle(pParametros);
}
public DataSet ObtienepavPlanificacionCierreDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.ObtienepavPlanificacionCierreDetalle(pParametros);
}
public DataSet ObtienepavPlanificacionCierreDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.ObtienepavPlanificacionCierreDetalle(pParametros);
}
public DataSet ObtienepavPlanificacionCierreDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.ObtienepavPlanificacionCierreDetalle(pParametros);
}
public DataSet ObtienepavPlanificacionCierreDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.ObtienepavPlanificacionCierreDetalle(pParametros);
}
#endregion 
#region TipoDocumentoEntrega
public clsTipoDocumentoEntrega ObtieneTipoDocumentoEntrega(int IdTipoDocumentoEntrega)
{
clsTipoDocumentoEntrega oTipoDocumentoEntrega = new clsTipoDocumentoEntrega();
oTipoDocumentoEntrega.IdTipoDocumentoEntrega = IdTipoDocumentoEntrega;
return oTipoDocumentoEntrega.clsTipoDocumentoEntregaPorIdTipoDocumentoEntrega();
}

public int AgregaTipoDocumentoEntrega(clsTipoDocumentoEntrega oTipoDocumentoEntrega)
{return oTipoDocumentoEntrega.AgregaTipoDocumentoEntrega();}

public int ModificaTipoDocumentoEntrega(clsTipoDocumentoEntrega oTipoDocumentoEntrega)
{return oTipoDocumentoEntrega.ModificaTipoDocumentoEntrega();}

public int EliminaTipoDocumentoEntrega(int IdTipoDocumentoEntrega)
{
clsTipoDocumentoEntrega oTipoDocumentoEntrega = new clsTipoDocumentoEntrega();
oTipoDocumentoEntrega.IdTipoDocumentoEntrega = IdTipoDocumentoEntrega;
return oTipoDocumentoEntrega.EliminaTipoDocumentoEntrega();}

//seleccion con parametros
public DataSet ObtienepavTipoDocumentoEntrega1(string Campo, string Valor)
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
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.ObtienepavTipoDocumentoEntrega(pParametros);
}
public DataSet ObtienepavTipoDocumentoEntrega2(string Campo, string Valor,string Campo1, string Valor1)
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
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.ObtienepavTipoDocumentoEntrega(pParametros);
}
public DataSet ObtienepavTipoDocumentoEntrega3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.ObtienepavTipoDocumentoEntrega(pParametros);
}
public DataSet ObtienepavTipoDocumentoEntrega4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.ObtienepavTipoDocumentoEntrega(pParametros);
}
public DataSet ObtienepavTipoDocumentoEntrega5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.ObtienepavTipoDocumentoEntrega(pParametros);
}
#endregion 
#region Almacen
public clsAlmacen ObtieneAlmacen(int IdAlmacen)
{
clsAlmacen oAlmacen = new clsAlmacen();
oAlmacen.IdAlmacen = IdAlmacen;
return oAlmacen.clsAlmacenPorIdAlmacen();
}

public int AgregaAlmacen(clsAlmacen oAlmacen)
{return oAlmacen.AgregaAlmacen();}

public int ModificaAlmacen(clsAlmacen oAlmacen)
{return oAlmacen.ModificaAlmacen();}

public int EliminaAlmacen(int IdAlmacen)
{
clsAlmacen oAlmacen = new clsAlmacen();
oAlmacen.IdAlmacen = IdAlmacen;
return oAlmacen.EliminaAlmacen();}

//seleccion con parametros
public DataSet ObtienepavAlmacen1(string Campo, string Valor)
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
clsAlmacenDA ad = new clsAlmacenDA();
return ad.ObtienepavAlmacen(pParametros);
}
public DataSet ObtienepavAlmacen2(string Campo, string Valor,string Campo1, string Valor1)
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
clsAlmacenDA ad = new clsAlmacenDA();
return ad.ObtienepavAlmacen(pParametros);
}
public DataSet ObtienepavAlmacen3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsAlmacenDA ad = new clsAlmacenDA();
return ad.ObtienepavAlmacen(pParametros);
}
public DataSet ObtienepavAlmacen4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsAlmacenDA ad = new clsAlmacenDA();
return ad.ObtienepavAlmacen(pParametros);
}
public DataSet ObtienepavAlmacen5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsAlmacenDA ad = new clsAlmacenDA();
return ad.ObtienepavAlmacen(pParametros);
}
#endregion 
#region ProveedorGrupoArticulo
public clsProveedorGrupoArticulo ObtieneProveedorGrupoArticulo(int IdProveedorGrupoArticulo)
{
clsProveedorGrupoArticulo oProveedorGrupoArticulo = new clsProveedorGrupoArticulo();
oProveedorGrupoArticulo.IdProveedorGrupoArticulo = IdProveedorGrupoArticulo;
return oProveedorGrupoArticulo.clsProveedorGrupoArticuloPorIdProveedorGrupoArticulo();
}

public int AgregaProveedorGrupoArticulo(clsProveedorGrupoArticulo oProveedorGrupoArticulo)
{return oProveedorGrupoArticulo.AgregaProveedorGrupoArticulo();}

public int ModificaProveedorGrupoArticulo(clsProveedorGrupoArticulo oProveedorGrupoArticulo)
{return oProveedorGrupoArticulo.ModificaProveedorGrupoArticulo();}

public int EliminaProveedorGrupoArticulo(int IdProveedorGrupoArticulo)
{
clsProveedorGrupoArticulo oProveedorGrupoArticulo = new clsProveedorGrupoArticulo();
oProveedorGrupoArticulo.IdProveedorGrupoArticulo = IdProveedorGrupoArticulo;
return oProveedorGrupoArticulo.EliminaProveedorGrupoArticulo();}

//seleccion con parametros
public DataSet ObtienepavProveedorGrupoArticulo1(string Campo, string Valor)
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
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.ObtienepavProveedorGrupoArticulo(pParametros);
}
public DataSet ObtienepavProveedorGrupoArticulo2(string Campo, string Valor,string Campo1, string Valor1)
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
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.ObtienepavProveedorGrupoArticulo(pParametros);
}
public DataSet ObtienepavProveedorGrupoArticulo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.ObtienepavProveedorGrupoArticulo(pParametros);
}
public DataSet ObtienepavProveedorGrupoArticulo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.ObtienepavProveedorGrupoArticulo(pParametros);
}
public DataSet ObtienepavProveedorGrupoArticulo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsProveedorGrupoArticuloDA ad = new clsProveedorGrupoArticuloDA();
return ad.ObtienepavProveedorGrupoArticulo(pParametros);
}
#endregion 
#region Proveedor
public clsProveedor ObtieneProveedor(int IdProveedor)
{
clsProveedor oProveedor = new clsProveedor();
oProveedor.IdProveedor = IdProveedor;
return oProveedor.clsProveedorPorIdProveedor();
}

public int AgregaProveedor(clsProveedor oProveedor)
{return oProveedor.AgregaProveedor();}

public int ModificaProveedor(clsProveedor oProveedor)
{return oProveedor.ModificaProveedor();}

public int EliminaProveedor(int IdProveedor)
{
clsProveedor oProveedor = new clsProveedor();
oProveedor.IdProveedor = IdProveedor;
return oProveedor.EliminaProveedor();}

//seleccion con parametros
public DataSet ObtienepavProveedor1(string Campo, string Valor)
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
clsProveedorDA ad = new clsProveedorDA();
return ad.ObtienepavProveedor(pParametros);
}
public DataSet ObtienepavProveedor2(string Campo, string Valor,string Campo1, string Valor1)
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
clsProveedorDA ad = new clsProveedorDA();
return ad.ObtienepavProveedor(pParametros);
}
public DataSet ObtienepavProveedor3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsProveedorDA ad = new clsProveedorDA();
return ad.ObtienepavProveedor(pParametros);
}
public DataSet ObtienepavProveedor4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsProveedorDA ad = new clsProveedorDA();
return ad.ObtienepavProveedor(pParametros);
}
public DataSet ObtienepavProveedor5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsProveedorDA ad = new clsProveedorDA();
return ad.ObtienepavProveedor(pParametros);
}
#endregion 
#region Moneda
public clsMoneda ObtieneMoneda(int IdMoneda)
{
clsMoneda oMoneda = new clsMoneda();
oMoneda.IdMoneda = IdMoneda;
return oMoneda.clsMonedaPorIdMoneda();
}

public int AgregaMoneda(clsMoneda oMoneda)
{return oMoneda.AgregaMoneda();}

public int ModificaMoneda(clsMoneda oMoneda)
{return oMoneda.ModificaMoneda();}

public int EliminaMoneda(int IdMoneda)
{
clsMoneda oMoneda = new clsMoneda();
oMoneda.IdMoneda = IdMoneda;
return oMoneda.EliminaMoneda();}

//seleccion con parametros
public DataSet ObtienepavMoneda1(string Campo, string Valor)
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
clsMonedaDA ad = new clsMonedaDA();
return ad.ObtienepavMoneda(pParametros);
}
public DataSet ObtienepavMoneda2(string Campo, string Valor,string Campo1, string Valor1)
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
clsMonedaDA ad = new clsMonedaDA();
return ad.ObtienepavMoneda(pParametros);
}
public DataSet ObtienepavMoneda3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsMonedaDA ad = new clsMonedaDA();
return ad.ObtienepavMoneda(pParametros);
}
public DataSet ObtienepavMoneda4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsMonedaDA ad = new clsMonedaDA();
return ad.ObtienepavMoneda(pParametros);
}
public DataSet ObtienepavMoneda5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsMonedaDA ad = new clsMonedaDA();
return ad.ObtienepavMoneda(pParametros);
}
#endregion 
#region Solicitud
public clsSolicitud ObtieneSolicitud(int IdSolicitud)
{
clsSolicitud oSolicitud = new clsSolicitud();
oSolicitud.IdSolicitud = IdSolicitud;
return oSolicitud.clsSolicitudPorIdSolicitud();
}

public int AgregaSolicitud(clsSolicitud oSolicitud)
{return oSolicitud.AgregaSolicitud();}

public int ModificaSolicitud(clsSolicitud oSolicitud)
{return oSolicitud.ModificaSolicitud();}

public int EliminaSolicitud(int IdSolicitud)
{
clsSolicitud oSolicitud = new clsSolicitud();
oSolicitud.IdSolicitud = IdSolicitud;
return oSolicitud.EliminaSolicitud();}

//seleccion con parametros
public DataSet ObtienepavSolicitud1(string Campo, string Valor)
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
clsSolicitudDA ad = new clsSolicitudDA();
return ad.ObtienepavSolicitud(pParametros);
}
public DataSet ObtienepavSolicitud2(string Campo, string Valor,string Campo1, string Valor1)
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
clsSolicitudDA ad = new clsSolicitudDA();
return ad.ObtienepavSolicitud(pParametros);
}
public DataSet ObtienepavSolicitud3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsSolicitudDA ad = new clsSolicitudDA();
return ad.ObtienepavSolicitud(pParametros);
}
public DataSet ObtienepavSolicitud4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsSolicitudDA ad = new clsSolicitudDA();
return ad.ObtienepavSolicitud(pParametros);
}
public DataSet ObtienepavSolicitud5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsSolicitudDA ad = new clsSolicitudDA();
return ad.ObtienepavSolicitud(pParametros);
}
#endregion 
#region EstadoSolicitud
public clsEstadoSolicitud ObtieneEstadoSolicitud(int IdEstadoSolicitud)
{
clsEstadoSolicitud oEstadoSolicitud = new clsEstadoSolicitud();
oEstadoSolicitud.IdEstadoSolicitud = IdEstadoSolicitud;
return oEstadoSolicitud.clsEstadoSolicitudPorIdEstadoSolicitud();
}

public int AgregaEstadoSolicitud(clsEstadoSolicitud oEstadoSolicitud)
{return oEstadoSolicitud.AgregaEstadoSolicitud();}

public int ModificaEstadoSolicitud(clsEstadoSolicitud oEstadoSolicitud)
{return oEstadoSolicitud.ModificaEstadoSolicitud();}

public int EliminaEstadoSolicitud(int IdEstadoSolicitud)
{
clsEstadoSolicitud oEstadoSolicitud = new clsEstadoSolicitud();
oEstadoSolicitud.IdEstadoSolicitud = IdEstadoSolicitud;
return oEstadoSolicitud.EliminaEstadoSolicitud();}

//seleccion con parametros
public DataSet ObtienepavEstadoSolicitud1(string Campo, string Valor)
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
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.ObtienepavEstadoSolicitud(pParametros);
}
public DataSet ObtienepavEstadoSolicitud2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.ObtienepavEstadoSolicitud(pParametros);
}
public DataSet ObtienepavEstadoSolicitud3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.ObtienepavEstadoSolicitud(pParametros);
}
public DataSet ObtienepavEstadoSolicitud4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.ObtienepavEstadoSolicitud(pParametros);
}
public DataSet ObtienepavEstadoSolicitud5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.ObtienepavEstadoSolicitud(pParametros);
}
#endregion 
#region Egreso
public clsEgreso ObtieneEgreso(int IdEgreso)
{
clsEgreso oEgreso = new clsEgreso();
oEgreso.IdEgreso = IdEgreso;
return oEgreso.clsEgresoPorIdEgreso();
}

public int AgregaEgreso(clsEgreso oEgreso)
{return oEgreso.AgregaEgreso();}

public int ModificaEgreso(clsEgreso oEgreso)
{return oEgreso.ModificaEgreso();}

public int EliminaEgreso(int IdEgreso)
{
clsEgreso oEgreso = new clsEgreso();
oEgreso.IdEgreso = IdEgreso;
return oEgreso.EliminaEgreso();}

//seleccion con parametros
public DataSet ObtienepavEgreso1(string Campo, string Valor)
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
clsEgresoDA ad = new clsEgresoDA();
return ad.ObtienepavEgreso(pParametros);
}
public DataSet ObtienepavEgreso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEgresoDA ad = new clsEgresoDA();
return ad.ObtienepavEgreso(pParametros);
}
public DataSet ObtienepavEgreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEgresoDA ad = new clsEgresoDA();
return ad.ObtienepavEgreso(pParametros);
}
public DataSet ObtienepavEgreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEgresoDA ad = new clsEgresoDA();
return ad.ObtienepavEgreso(pParametros);
}
public DataSet ObtienepavEgreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEgresoDA ad = new clsEgresoDA();
return ad.ObtienepavEgreso(pParametros);
}
#endregion 
#region LineaDeArticulo
public clsLineaDeArticulo ObtieneLineaDeArticulo(int IdLineaDeArticulo)
{
clsLineaDeArticulo oLineaDeArticulo = new clsLineaDeArticulo();
oLineaDeArticulo.IdLineaDeArticulo = IdLineaDeArticulo;
return oLineaDeArticulo.clsLineaDeArticuloPorIdLineaDeArticulo();
}

public int AgregaLineaDeArticulo(clsLineaDeArticulo oLineaDeArticulo)
{return oLineaDeArticulo.AgregaLineaDeArticulo();}

public int ModificaLineaDeArticulo(clsLineaDeArticulo oLineaDeArticulo)
{return oLineaDeArticulo.ModificaLineaDeArticulo();}

public int EliminaLineaDeArticulo(int IdLineaDeArticulo)
{
clsLineaDeArticulo oLineaDeArticulo = new clsLineaDeArticulo();
oLineaDeArticulo.IdLineaDeArticulo = IdLineaDeArticulo;
return oLineaDeArticulo.EliminaLineaDeArticulo();}

//seleccion con parametros
public DataSet ObtienepavLineaDeArticulo1(string Campo, string Valor)
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
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.ObtienepavLineaDeArticulo(pParametros);
}
public DataSet ObtienepavLineaDeArticulo2(string Campo, string Valor,string Campo1, string Valor1)
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
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.ObtienepavLineaDeArticulo(pParametros);
}
public DataSet ObtienepavLineaDeArticulo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.ObtienepavLineaDeArticulo(pParametros);
}
public DataSet ObtienepavLineaDeArticulo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.ObtienepavLineaDeArticulo(pParametros);
}
public DataSet ObtienepavLineaDeArticulo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.ObtienepavLineaDeArticulo(pParametros);
}
#endregion 
#region GrupoArticulo
public clsGrupoArticulo ObtieneGrupoArticulo(int IdGrupoArticulo)
{
clsGrupoArticulo oGrupoArticulo = new clsGrupoArticulo();
oGrupoArticulo.IdGrupoArticulo = IdGrupoArticulo;
return oGrupoArticulo.clsGrupoArticuloPorIdGrupoArticulo();
}

public int AgregaGrupoArticulo(clsGrupoArticulo oGrupoArticulo)
{return oGrupoArticulo.AgregaGrupoArticulo();}

public int ModificaGrupoArticulo(clsGrupoArticulo oGrupoArticulo)
{return oGrupoArticulo.ModificaGrupoArticulo();}

public int EliminaGrupoArticulo(int IdGrupoArticulo)
{
clsGrupoArticulo oGrupoArticulo = new clsGrupoArticulo();
oGrupoArticulo.IdGrupoArticulo = IdGrupoArticulo;
return oGrupoArticulo.EliminaGrupoArticulo();}

//seleccion con parametros
public DataSet ObtienepavGrupoArticulo1(string Campo, string Valor)
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
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.ObtienepavGrupoArticulo(pParametros);
}
public DataSet ObtienepavGrupoArticulo2(string Campo, string Valor,string Campo1, string Valor1)
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
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.ObtienepavGrupoArticulo(pParametros);
}
public DataSet ObtienepavGrupoArticulo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.ObtienepavGrupoArticulo(pParametros);
}
public DataSet ObtienepavGrupoArticulo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.ObtienepavGrupoArticulo(pParametros);
}
public DataSet ObtienepavGrupoArticulo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsGrupoArticuloDA ad = new clsGrupoArticuloDA();
return ad.ObtienepavGrupoArticulo(pParametros);
}
#endregion 
#region UnidadDeMedida
public clsUnidadDeMedida ObtieneUnidadDeMedida(int IdUnidadDeMedida)
{
clsUnidadDeMedida oUnidadDeMedida = new clsUnidadDeMedida();
oUnidadDeMedida.IdUnidadDeMedida = IdUnidadDeMedida;
return oUnidadDeMedida.clsUnidadDeMedidaPorIdUnidadDeMedida();
}

public int AgregaUnidadDeMedida(clsUnidadDeMedida oUnidadDeMedida)
{return oUnidadDeMedida.AgregaUnidadDeMedida();}

public int ModificaUnidadDeMedida(clsUnidadDeMedida oUnidadDeMedida)
{return oUnidadDeMedida.ModificaUnidadDeMedida();}

public int EliminaUnidadDeMedida(int IdUnidadDeMedida)
{
clsUnidadDeMedida oUnidadDeMedida = new clsUnidadDeMedida();
oUnidadDeMedida.IdUnidadDeMedida = IdUnidadDeMedida;
return oUnidadDeMedida.EliminaUnidadDeMedida();}

//seleccion con parametros
public DataSet ObtienepavUnidadDeMedida1(string Campo, string Valor)
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
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.ObtienepavUnidadDeMedida(pParametros);
}
public DataSet ObtienepavUnidadDeMedida2(string Campo, string Valor,string Campo1, string Valor1)
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
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.ObtienepavUnidadDeMedida(pParametros);
}
public DataSet ObtienepavUnidadDeMedida3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.ObtienepavUnidadDeMedida(pParametros);
}
public DataSet ObtienepavUnidadDeMedida4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.ObtienepavUnidadDeMedida(pParametros);
}
public DataSet ObtienepavUnidadDeMedida5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.ObtienepavUnidadDeMedida(pParametros);
}
#endregion 
#region TraspasoDetalle
public clsTraspasoDetalle ObtieneTraspasoDetalle(int IdTraspasoDetalle)
{
clsTraspasoDetalle oTraspasoDetalle = new clsTraspasoDetalle();
oTraspasoDetalle.IdTraspasoDetalle = IdTraspasoDetalle;
return oTraspasoDetalle.clsTraspasoDetallePorIdTraspasoDetalle();
}

public int AgregaTraspasoDetalle(clsTraspasoDetalle oTraspasoDetalle)
{return oTraspasoDetalle.AgregaTraspasoDetalle();}

public int ModificaTraspasoDetalle(clsTraspasoDetalle oTraspasoDetalle)
{return oTraspasoDetalle.ModificaTraspasoDetalle();}

public int EliminaTraspasoDetalle(int IdTraspasoDetalle)
{
clsTraspasoDetalle oTraspasoDetalle = new clsTraspasoDetalle();
oTraspasoDetalle.IdTraspasoDetalle = IdTraspasoDetalle;
return oTraspasoDetalle.EliminaTraspasoDetalle();}

//seleccion con parametros
public DataSet ObtienepavTraspasoDetalle1(string Campo, string Valor)
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
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.ObtienepavTraspasoDetalle(pParametros);
}
public DataSet ObtienepavTraspasoDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.ObtienepavTraspasoDetalle(pParametros);
}
public DataSet ObtienepavTraspasoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.ObtienepavTraspasoDetalle(pParametros);
}
public DataSet ObtienepavTraspasoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.ObtienepavTraspasoDetalle(pParametros);
}
public DataSet ObtienepavTraspasoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsTraspasoDetalleDA ad = new clsTraspasoDetalleDA();
return ad.ObtienepavTraspasoDetalle(pParametros);
}
#endregion 
#region EstadoIngreso
public clsEstadoIngreso ObtieneEstadoIngreso(int IdEstadoIngreso)
{
clsEstadoIngreso oEstadoIngreso = new clsEstadoIngreso();
oEstadoIngreso.IdEstadoIngreso = IdEstadoIngreso;
return oEstadoIngreso.clsEstadoIngresoPorIdEstadoIngreso();
}

public int AgregaEstadoIngreso(clsEstadoIngreso oEstadoIngreso)
{return oEstadoIngreso.AgregaEstadoIngreso();}

public int ModificaEstadoIngreso(clsEstadoIngreso oEstadoIngreso)
{return oEstadoIngreso.ModificaEstadoIngreso();}

public int EliminaEstadoIngreso(int IdEstadoIngreso)
{
clsEstadoIngreso oEstadoIngreso = new clsEstadoIngreso();
oEstadoIngreso.IdEstadoIngreso = IdEstadoIngreso;
return oEstadoIngreso.EliminaEstadoIngreso();}

//seleccion con parametros
public DataSet ObtienepavEstadoIngreso1(string Campo, string Valor)
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
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.ObtienepavEstadoIngreso(pParametros);
}
public DataSet ObtienepavEstadoIngreso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.ObtienepavEstadoIngreso(pParametros);
}
public DataSet ObtienepavEstadoIngreso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.ObtienepavEstadoIngreso(pParametros);
}
public DataSet ObtienepavEstadoIngreso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.ObtienepavEstadoIngreso(pParametros);
}
public DataSet ObtienepavEstadoIngreso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.ObtienepavEstadoIngreso(pParametros);
}
#endregion 
#region Color
public clsColor ObtieneColor(int IdColor)
{
clsColor oColor = new clsColor();
oColor.IdColor = IdColor;
return oColor.clsColorPorIdColor();
}

public int AgregaColor(clsColor oColor)
{return oColor.AgregaColor();}

public int ModificaColor(clsColor oColor)
{return oColor.ModificaColor();}

public int EliminaColor(int IdColor)
{
clsColor oColor = new clsColor();
oColor.IdColor = IdColor;
return oColor.EliminaColor();}

//seleccion con parametros
public DataSet ObtienepavColor1(string Campo, string Valor)
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
clsColorDA ad = new clsColorDA();
return ad.ObtienepavColor(pParametros);
}
public DataSet ObtienepavColor2(string Campo, string Valor,string Campo1, string Valor1)
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
clsColorDA ad = new clsColorDA();
return ad.ObtienepavColor(pParametros);
}
public DataSet ObtienepavColor3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsColorDA ad = new clsColorDA();
return ad.ObtienepavColor(pParametros);
}
public DataSet ObtienepavColor4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsColorDA ad = new clsColorDA();
return ad.ObtienepavColor(pParametros);
}
public DataSet ObtienepavColor5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsColorDA ad = new clsColorDA();
return ad.ObtienepavColor(pParametros);
}
#endregion 
}
}
