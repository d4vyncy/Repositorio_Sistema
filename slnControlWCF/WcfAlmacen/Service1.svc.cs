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
#region _tblRolUsuario
public cls_tblRolUsuario Obtiene_tblRolUsuario(int Id_tblRolUsuario)
{
cls_tblRolUsuario o_tblRolUsuario = new cls_tblRolUsuario();
o_tblRolUsuario.Id_tblRolUsuario = Id_tblRolUsuario;
return o_tblRolUsuario.cls_tblRolUsuarioPorId_tblRolUsuario();
}

public int Agrega_tblRolUsuario(cls_tblRolUsuario o_tblRolUsuario)
{return o_tblRolUsuario.Agrega_tblRolUsuario();}

public int Modifica_tblRolUsuario(cls_tblRolUsuario o_tblRolUsuario)
{return o_tblRolUsuario.Modifica_tblRolUsuario();}

public int Elimina_tblRolUsuario(int Id_tblRolUsuario)
{
cls_tblRolUsuario o_tblRolUsuario = new cls_tblRolUsuario();
o_tblRolUsuario.Id_tblRolUsuario = Id_tblRolUsuario;
return o_tblRolUsuario.Elimina_tblRolUsuario();}

//seleccion con parametros
public DataSet Obtienepav_tblRolUsuario1(string Campo, string Valor)
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
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Obtienepav_tblRolUsuario(pParametros);
}
public DataSet Obtienepav_tblRolUsuario2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Obtienepav_tblRolUsuario(pParametros);
}
public DataSet Obtienepav_tblRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Obtienepav_tblRolUsuario(pParametros);
}
public DataSet Obtienepav_tblRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Obtienepav_tblRolUsuario(pParametros);
}
public DataSet Obtienepav_tblRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblRolUsuarioDA ad = new cls_tblRolUsuarioDA();
return ad.Obtienepav_tblRolUsuario(pParametros);
}
#endregion 
#region _tblPersona
public cls_tblPersona Obtiene_tblPersona(int Id_tblPersona)
{
cls_tblPersona o_tblPersona = new cls_tblPersona();
o_tblPersona.Id_tblPersona = Id_tblPersona;
return o_tblPersona.cls_tblPersonaPorId_tblPersona();
}

public int Agrega_tblPersona(cls_tblPersona o_tblPersona)
{return o_tblPersona.Agrega_tblPersona();}

public int Modifica_tblPersona(cls_tblPersona o_tblPersona)
{return o_tblPersona.Modifica_tblPersona();}

public int Elimina_tblPersona(int Id_tblPersona)
{
cls_tblPersona o_tblPersona = new cls_tblPersona();
o_tblPersona.Id_tblPersona = Id_tblPersona;
return o_tblPersona.Elimina_tblPersona();}

//seleccion con parametros
public DataSet Obtienepav_tblPersona1(string Campo, string Valor)
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
cls_tblPersonaDA ad = new cls_tblPersonaDA();
return ad.Obtienepav_tblPersona(pParametros);
}
public DataSet Obtienepav_tblPersona2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblPersonaDA ad = new cls_tblPersonaDA();
return ad.Obtienepav_tblPersona(pParametros);
}
public DataSet Obtienepav_tblPersona3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblPersonaDA ad = new cls_tblPersonaDA();
return ad.Obtienepav_tblPersona(pParametros);
}
public DataSet Obtienepav_tblPersona4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblPersonaDA ad = new cls_tblPersonaDA();
return ad.Obtienepav_tblPersona(pParametros);
}
public DataSet Obtienepav_tblPersona5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblPersonaDA ad = new cls_tblPersonaDA();
return ad.Obtienepav_tblPersona(pParametros);
}
#endregion 
#region _tblInstitucion
public cls_tblInstitucion Obtiene_tblInstitucion(int Id_tblInstitucion)
{
cls_tblInstitucion o_tblInstitucion = new cls_tblInstitucion();
o_tblInstitucion.Id_tblInstitucion = Id_tblInstitucion;
return o_tblInstitucion.cls_tblInstitucionPorId_tblInstitucion();
}

public int Agrega_tblInstitucion(cls_tblInstitucion o_tblInstitucion)
{return o_tblInstitucion.Agrega_tblInstitucion();}

public int Modifica_tblInstitucion(cls_tblInstitucion o_tblInstitucion)
{return o_tblInstitucion.Modifica_tblInstitucion();}

public int Elimina_tblInstitucion(int Id_tblInstitucion)
{
cls_tblInstitucion o_tblInstitucion = new cls_tblInstitucion();
o_tblInstitucion.Id_tblInstitucion = Id_tblInstitucion;
return o_tblInstitucion.Elimina_tblInstitucion();}

//seleccion con parametros
public DataSet Obtienepav_tblInstitucion1(string Campo, string Valor)
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
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Obtienepav_tblInstitucion(pParametros);
}
public DataSet Obtienepav_tblInstitucion2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Obtienepav_tblInstitucion(pParametros);
}
public DataSet Obtienepav_tblInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Obtienepav_tblInstitucion(pParametros);
}
public DataSet Obtienepav_tblInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Obtienepav_tblInstitucion(pParametros);
}
public DataSet Obtienepav_tblInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Obtienepav_tblInstitucion(pParametros);
}
#endregion 
#region _tblItemInstitucion
public cls_tblItemInstitucion Obtiene_tblItemInstitucion(int Id_tblItemInstitucion)
{
cls_tblItemInstitucion o_tblItemInstitucion = new cls_tblItemInstitucion();
o_tblItemInstitucion.Id_tblItemInstitucion = Id_tblItemInstitucion;
return o_tblItemInstitucion.cls_tblItemInstitucionPorId_tblItemInstitucion();
}

public int Agrega_tblItemInstitucion(cls_tblItemInstitucion o_tblItemInstitucion)
{return o_tblItemInstitucion.Agrega_tblItemInstitucion();}

public int Modifica_tblItemInstitucion(cls_tblItemInstitucion o_tblItemInstitucion)
{return o_tblItemInstitucion.Modifica_tblItemInstitucion();}

public int Elimina_tblItemInstitucion(int Id_tblItemInstitucion)
{
cls_tblItemInstitucion o_tblItemInstitucion = new cls_tblItemInstitucion();
o_tblItemInstitucion.Id_tblItemInstitucion = Id_tblItemInstitucion;
return o_tblItemInstitucion.Elimina_tblItemInstitucion();}

//seleccion con parametros
public DataSet Obtienepav_tblItemInstitucion1(string Campo, string Valor)
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
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Obtienepav_tblItemInstitucion(pParametros);
}
public DataSet Obtienepav_tblItemInstitucion2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Obtienepav_tblItemInstitucion(pParametros);
}
public DataSet Obtienepav_tblItemInstitucion3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Obtienepav_tblItemInstitucion(pParametros);
}
public DataSet Obtienepav_tblItemInstitucion4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Obtienepav_tblItemInstitucion(pParametros);
}
public DataSet Obtienepav_tblItemInstitucion5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Obtienepav_tblItemInstitucion(pParametros);
}
#endregion 
#region _tblUnidad
public cls_tblUnidad Obtiene_tblUnidad(int Id_tblUnidad)
{
cls_tblUnidad o_tblUnidad = new cls_tblUnidad();
o_tblUnidad.Id_tblUnidad = Id_tblUnidad;
return o_tblUnidad.cls_tblUnidadPorId_tblUnidad();
}

public int Agrega_tblUnidad(cls_tblUnidad o_tblUnidad)
{return o_tblUnidad.Agrega_tblUnidad();}

public int Modifica_tblUnidad(cls_tblUnidad o_tblUnidad)
{return o_tblUnidad.Modifica_tblUnidad();}

public int Elimina_tblUnidad(int Id_tblUnidad)
{
cls_tblUnidad o_tblUnidad = new cls_tblUnidad();
o_tblUnidad.Id_tblUnidad = Id_tblUnidad;
return o_tblUnidad.Elimina_tblUnidad();}

//seleccion con parametros
public DataSet Obtienepav_tblUnidad1(string Campo, string Valor)
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
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Obtienepav_tblUnidad(pParametros);
}
public DataSet Obtienepav_tblUnidad2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Obtienepav_tblUnidad(pParametros);
}
public DataSet Obtienepav_tblUnidad3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Obtienepav_tblUnidad(pParametros);
}
public DataSet Obtienepav_tblUnidad4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Obtienepav_tblUnidad(pParametros);
}
public DataSet Obtienepav_tblUnidad5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Obtienepav_tblUnidad(pParametros);
}
#endregion 
#region _tblUsuario
public cls_tblUsuario Obtiene_tblUsuario(int Id_tblUsuario)
{
cls_tblUsuario o_tblUsuario = new cls_tblUsuario();
o_tblUsuario.Id_tblUsuario = Id_tblUsuario;
return o_tblUsuario.cls_tblUsuarioPorId_tblUsuario();
}

public int Agrega_tblUsuario(cls_tblUsuario o_tblUsuario)
{return o_tblUsuario.Agrega_tblUsuario();}

public int Modifica_tblUsuario(cls_tblUsuario o_tblUsuario)
{return o_tblUsuario.Modifica_tblUsuario();}

public int Elimina_tblUsuario(int Id_tblUsuario)
{
cls_tblUsuario o_tblUsuario = new cls_tblUsuario();
o_tblUsuario.Id_tblUsuario = Id_tblUsuario;
return o_tblUsuario.Elimina_tblUsuario();}

//seleccion con parametros
public DataSet Obtienepav_tblUsuario1(string Campo, string Valor)
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
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Obtienepav_tblUsuario(pParametros);
}
public DataSet Obtienepav_tblUsuario2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Obtienepav_tblUsuario(pParametros);
}
public DataSet Obtienepav_tblUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Obtienepav_tblUsuario(pParametros);
}
public DataSet Obtienepav_tblUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Obtienepav_tblUsuario(pParametros);
}
public DataSet Obtienepav_tblUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblUsuarioDA ad = new cls_tblUsuarioDA();
return ad.Obtienepav_tblUsuario(pParametros);
}
#endregion 
#region _tblUsuarioLogueado
public cls_tblUsuarioLogueado Obtiene_tblUsuarioLogueado(int Id_tblUsuarioLogueado)
{
cls_tblUsuarioLogueado o_tblUsuarioLogueado = new cls_tblUsuarioLogueado();
o_tblUsuarioLogueado.Id_tblUsuarioLogueado = Id_tblUsuarioLogueado;
return o_tblUsuarioLogueado.cls_tblUsuarioLogueadoPorId_tblUsuarioLogueado();
}

public int Agrega_tblUsuarioLogueado(cls_tblUsuarioLogueado o_tblUsuarioLogueado)
{return o_tblUsuarioLogueado.Agrega_tblUsuarioLogueado();}

public int Modifica_tblUsuarioLogueado(cls_tblUsuarioLogueado o_tblUsuarioLogueado)
{return o_tblUsuarioLogueado.Modifica_tblUsuarioLogueado();}

public int Elimina_tblUsuarioLogueado(int Id_tblUsuarioLogueado)
{
cls_tblUsuarioLogueado o_tblUsuarioLogueado = new cls_tblUsuarioLogueado();
o_tblUsuarioLogueado.Id_tblUsuarioLogueado = Id_tblUsuarioLogueado;
return o_tblUsuarioLogueado.Elimina_tblUsuarioLogueado();}

//seleccion con parametros
public DataSet Obtienepav_tblUsuarioLogueado1(string Campo, string Valor)
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
cls_tblUsuarioLogueadoDA ad = new cls_tblUsuarioLogueadoDA();
return ad.Obtienepav_tblUsuarioLogueado(pParametros);
}
public DataSet Obtienepav_tblUsuarioLogueado2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblUsuarioLogueadoDA ad = new cls_tblUsuarioLogueadoDA();
return ad.Obtienepav_tblUsuarioLogueado(pParametros);
}
public DataSet Obtienepav_tblUsuarioLogueado3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblUsuarioLogueadoDA ad = new cls_tblUsuarioLogueadoDA();
return ad.Obtienepav_tblUsuarioLogueado(pParametros);
}
public DataSet Obtienepav_tblUsuarioLogueado4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblUsuarioLogueadoDA ad = new cls_tblUsuarioLogueadoDA();
return ad.Obtienepav_tblUsuarioLogueado(pParametros);
}
public DataSet Obtienepav_tblUsuarioLogueado5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblUsuarioLogueadoDA ad = new cls_tblUsuarioLogueadoDA();
return ad.Obtienepav_tblUsuarioLogueado(pParametros);
}
#endregion 
#region _tblRol
public cls_tblRol Obtiene_tblRol(int Id_tblRol)
{
cls_tblRol o_tblRol = new cls_tblRol();
o_tblRol.Id_tblRol = Id_tblRol;
return o_tblRol.cls_tblRolPorId_tblRol();
}

public int Agrega_tblRol(cls_tblRol o_tblRol)
{return o_tblRol.Agrega_tblRol();}

public int Modifica_tblRol(cls_tblRol o_tblRol)
{return o_tblRol.Modifica_tblRol();}

public int Elimina_tblRol(int Id_tblRol)
{
cls_tblRol o_tblRol = new cls_tblRol();
o_tblRol.Id_tblRol = Id_tblRol;
return o_tblRol.Elimina_tblRol();}

//seleccion con parametros
public DataSet Obtienepav_tblRol1(string Campo, string Valor)
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
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Obtienepav_tblRol(pParametros);
}
public DataSet Obtienepav_tblRol2(string Campo, string Valor,string Campo1, string Valor1)
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
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Obtienepav_tblRol(pParametros);
}
public DataSet Obtienepav_tblRol3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Obtienepav_tblRol(pParametros);
}
public DataSet Obtienepav_tblRol4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Obtienepav_tblRol(pParametros);
}
public DataSet Obtienepav_tblRol5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
cls_tblRolDA ad = new cls_tblRolDA();
return ad.Obtienepav_tblRol(pParametros);
}
#endregion 
}
}
