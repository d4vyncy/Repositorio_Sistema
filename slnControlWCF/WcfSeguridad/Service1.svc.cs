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
public class Service1 : IService1
{
// con n parametros
public DataSet ProcedureConParametro(string Procedimiento,object[] pParametros)
{
clspSeguridad ad = new clspSeguridad();
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
clspSeguridad ad = new clspSeguridad();
return ad.ProcedureParametro(Procedimiento,pParametros);
}
public int EjecutaConsulta(string Consulta)
{
clspSeguridad ad = new clspSeguridad();
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
#region TipoRolUsuario
public clsTipoRolUsuario ObtieneTipoRolUsuario(int IdTipoRolUsuario)
{
clsTipoRolUsuario oTipoRolUsuario = new clsTipoRolUsuario();
oTipoRolUsuario.IdTipoRolUsuario = IdTipoRolUsuario;
return oTipoRolUsuario.clsTipoRolUsuarioPorIdTipoRolUsuario();
}

public int AgregaTipoRolUsuario(clsTipoRolUsuario oTipoRolUsuario)
{return oTipoRolUsuario.AgregaTipoRolUsuario();}

public int ModificaTipoRolUsuario(clsTipoRolUsuario oTipoRolUsuario)
{return oTipoRolUsuario.ModificaTipoRolUsuario();}

public int EliminaTipoRolUsuario(int IdTipoRolUsuario)
{
clsTipoRolUsuario oTipoRolUsuario = new clsTipoRolUsuario();
oTipoRolUsuario.IdTipoRolUsuario = IdTipoRolUsuario;
return oTipoRolUsuario.EliminaTipoRolUsuario();}

//seleccion con parametros
public DataSet ObtienepavTipoRolUsuario1(string Campo, string Valor)
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
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.ObtienepavTipoRolUsuario(pParametros);
}
public DataSet ObtienepavTipoRolUsuario2(string Campo, string Valor,string Campo1, string Valor1)
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
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.ObtienepavTipoRolUsuario(pParametros);
}
public DataSet ObtienepavTipoRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.ObtienepavTipoRolUsuario(pParametros);
}
public DataSet ObtienepavTipoRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.ObtienepavTipoRolUsuario(pParametros);
}
public DataSet ObtienepavTipoRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsTipoRolUsuarioDA ad = new clsTipoRolUsuarioDA();
return ad.ObtienepavTipoRolUsuario(pParametros);
}
#endregion 
#region TipoUsuario
public clsTipoUsuario ObtieneTipoUsuario(int IdTipoUsuario)
{
clsTipoUsuario oTipoUsuario = new clsTipoUsuario();
oTipoUsuario.IdTipoUsuario = IdTipoUsuario;
return oTipoUsuario.clsTipoUsuarioPorIdTipoUsuario();
}

public int AgregaTipoUsuario(clsTipoUsuario oTipoUsuario)
{return oTipoUsuario.AgregaTipoUsuario();}

public int ModificaTipoUsuario(clsTipoUsuario oTipoUsuario)
{return oTipoUsuario.ModificaTipoUsuario();}

public int EliminaTipoUsuario(int IdTipoUsuario)
{
clsTipoUsuario oTipoUsuario = new clsTipoUsuario();
oTipoUsuario.IdTipoUsuario = IdTipoUsuario;
return oTipoUsuario.EliminaTipoUsuario();}

//seleccion con parametros
public DataSet ObtienepavTipoUsuario1(string Campo, string Valor)
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
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.ObtienepavTipoUsuario(pParametros);
}
public DataSet ObtienepavTipoUsuario2(string Campo, string Valor,string Campo1, string Valor1)
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
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.ObtienepavTipoUsuario(pParametros);
}
public DataSet ObtienepavTipoUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.ObtienepavTipoUsuario(pParametros);
}
public DataSet ObtienepavTipoUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.ObtienepavTipoUsuario(pParametros);
}
public DataSet ObtienepavTipoUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsTipoUsuarioDA ad = new clsTipoUsuarioDA();
return ad.ObtienepavTipoUsuario(pParametros);
}
#endregion 
#region EstadoUsuario
public clsEstadoUsuario ObtieneEstadoUsuario(int IdEstadoUsuario)
{
clsEstadoUsuario oEstadoUsuario = new clsEstadoUsuario();
oEstadoUsuario.IdEstadoUsuario = IdEstadoUsuario;
return oEstadoUsuario.clsEstadoUsuarioPorIdEstadoUsuario();
}

public int AgregaEstadoUsuario(clsEstadoUsuario oEstadoUsuario)
{return oEstadoUsuario.AgregaEstadoUsuario();}

public int ModificaEstadoUsuario(clsEstadoUsuario oEstadoUsuario)
{return oEstadoUsuario.ModificaEstadoUsuario();}

public int EliminaEstadoUsuario(int IdEstadoUsuario)
{
clsEstadoUsuario oEstadoUsuario = new clsEstadoUsuario();
oEstadoUsuario.IdEstadoUsuario = IdEstadoUsuario;
return oEstadoUsuario.EliminaEstadoUsuario();}

//seleccion con parametros
public DataSet ObtienepavEstadoUsuario1(string Campo, string Valor)
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
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.ObtienepavEstadoUsuario(pParametros);
}
public DataSet ObtienepavEstadoUsuario2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.ObtienepavEstadoUsuario(pParametros);
}
public DataSet ObtienepavEstadoUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.ObtienepavEstadoUsuario(pParametros);
}
public DataSet ObtienepavEstadoUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.ObtienepavEstadoUsuario(pParametros);
}
public DataSet ObtienepavEstadoUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoUsuarioDA ad = new clsEstadoUsuarioDA();
return ad.ObtienepavEstadoUsuario(pParametros);
}
#endregion 
#region EstadoRolUsuario
public clsEstadoRolUsuario ObtieneEstadoRolUsuario(int IdEstadoRolUsuario)
{
clsEstadoRolUsuario oEstadoRolUsuario = new clsEstadoRolUsuario();
oEstadoRolUsuario.IdEstadoRolUsuario = IdEstadoRolUsuario;
return oEstadoRolUsuario.clsEstadoRolUsuarioPorIdEstadoRolUsuario();
}

public int AgregaEstadoRolUsuario(clsEstadoRolUsuario oEstadoRolUsuario)
{return oEstadoRolUsuario.AgregaEstadoRolUsuario();}

public int ModificaEstadoRolUsuario(clsEstadoRolUsuario oEstadoRolUsuario)
{return oEstadoRolUsuario.ModificaEstadoRolUsuario();}

public int EliminaEstadoRolUsuario(int IdEstadoRolUsuario)
{
clsEstadoRolUsuario oEstadoRolUsuario = new clsEstadoRolUsuario();
oEstadoRolUsuario.IdEstadoRolUsuario = IdEstadoRolUsuario;
return oEstadoRolUsuario.EliminaEstadoRolUsuario();}

//seleccion con parametros
public DataSet ObtienepavEstadoRolUsuario1(string Campo, string Valor)
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
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.ObtienepavEstadoRolUsuario(pParametros);
}
public DataSet ObtienepavEstadoRolUsuario2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.ObtienepavEstadoRolUsuario(pParametros);
}
public DataSet ObtienepavEstadoRolUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.ObtienepavEstadoRolUsuario(pParametros);
}
public DataSet ObtienepavEstadoRolUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.ObtienepavEstadoRolUsuario(pParametros);
}
public DataSet ObtienepavEstadoRolUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoRolUsuarioDA ad = new clsEstadoRolUsuarioDA();
return ad.ObtienepavEstadoRolUsuario(pParametros);
}
#endregion 
#region Permiso
public clsPermiso ObtienePermiso(int IdPermiso)
{
clsPermiso oPermiso = new clsPermiso();
oPermiso.IdPermiso = IdPermiso;
return oPermiso.clsPermisoPorIdPermiso();
}

public int AgregaPermiso(clsPermiso oPermiso)
{return oPermiso.AgregaPermiso();}

public int ModificaPermiso(clsPermiso oPermiso)
{return oPermiso.ModificaPermiso();}

public int EliminaPermiso(int IdPermiso)
{
clsPermiso oPermiso = new clsPermiso();
oPermiso.IdPermiso = IdPermiso;
return oPermiso.EliminaPermiso();}

//seleccion con parametros
public DataSet ObtienepavPermiso1(string Campo, string Valor)
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
clsPermisoDA ad = new clsPermisoDA();
return ad.ObtienepavPermiso(pParametros);
}
public DataSet ObtienepavPermiso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsPermisoDA ad = new clsPermisoDA();
return ad.ObtienepavPermiso(pParametros);
}
public DataSet ObtienepavPermiso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsPermisoDA ad = new clsPermisoDA();
return ad.ObtienepavPermiso(pParametros);
}
public DataSet ObtienepavPermiso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsPermisoDA ad = new clsPermisoDA();
return ad.ObtienepavPermiso(pParametros);
}
public DataSet ObtienepavPermiso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsPermisoDA ad = new clsPermisoDA();
return ad.ObtienepavPermiso(pParametros);
}
#endregion 
#region TipoPermiso
public clsTipoPermiso ObtieneTipoPermiso(int IdTipoPermiso)
{
clsTipoPermiso oTipoPermiso = new clsTipoPermiso();
oTipoPermiso.IdTipoPermiso = IdTipoPermiso;
return oTipoPermiso.clsTipoPermisoPorIdTipoPermiso();
}

public int AgregaTipoPermiso(clsTipoPermiso oTipoPermiso)
{return oTipoPermiso.AgregaTipoPermiso();}

public int ModificaTipoPermiso(clsTipoPermiso oTipoPermiso)
{return oTipoPermiso.ModificaTipoPermiso();}

public int EliminaTipoPermiso(int IdTipoPermiso)
{
clsTipoPermiso oTipoPermiso = new clsTipoPermiso();
oTipoPermiso.IdTipoPermiso = IdTipoPermiso;
return oTipoPermiso.EliminaTipoPermiso();}

//seleccion con parametros
public DataSet ObtienepavTipoPermiso1(string Campo, string Valor)
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
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.ObtienepavTipoPermiso(pParametros);
}
public DataSet ObtienepavTipoPermiso2(string Campo, string Valor,string Campo1, string Valor1)
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
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.ObtienepavTipoPermiso(pParametros);
}
public DataSet ObtienepavTipoPermiso3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.ObtienepavTipoPermiso(pParametros);
}
public DataSet ObtienepavTipoPermiso4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.ObtienepavTipoPermiso(pParametros);
}
public DataSet ObtienepavTipoPermiso5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsTipoPermisoDA ad = new clsTipoPermisoDA();
return ad.ObtienepavTipoPermiso(pParametros);
}
#endregion 
#region EstadoLlave
public clsEstadoLlave ObtieneEstadoLlave(int IdEstadoLlave)
{
clsEstadoLlave oEstadoLlave = new clsEstadoLlave();
oEstadoLlave.IdEstadoLlave = IdEstadoLlave;
return oEstadoLlave.clsEstadoLlavePorIdEstadoLlave();
}

public int AgregaEstadoLlave(clsEstadoLlave oEstadoLlave)
{return oEstadoLlave.AgregaEstadoLlave();}

public int ModificaEstadoLlave(clsEstadoLlave oEstadoLlave)
{return oEstadoLlave.ModificaEstadoLlave();}

public int EliminaEstadoLlave(int IdEstadoLlave)
{
clsEstadoLlave oEstadoLlave = new clsEstadoLlave();
oEstadoLlave.IdEstadoLlave = IdEstadoLlave;
return oEstadoLlave.EliminaEstadoLlave();}

//seleccion con parametros
public DataSet ObtienepavEstadoLlave1(string Campo, string Valor)
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
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.ObtienepavEstadoLlave(pParametros);
}
public DataSet ObtienepavEstadoLlave2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.ObtienepavEstadoLlave(pParametros);
}
public DataSet ObtienepavEstadoLlave3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.ObtienepavEstadoLlave(pParametros);
}
public DataSet ObtienepavEstadoLlave4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.ObtienepavEstadoLlave(pParametros);
}
public DataSet ObtienepavEstadoLlave5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.ObtienepavEstadoLlave(pParametros);
}
#endregion 
#region Sistema
public clsSistema ObtieneSistema(int IdSistema)
{
clsSistema oSistema = new clsSistema();
oSistema.IdSistema = IdSistema;
return oSistema.clsSistemaPorIdSistema();
}

public int AgregaSistema(clsSistema oSistema)
{return oSistema.AgregaSistema();}

public int ModificaSistema(clsSistema oSistema)
{return oSistema.ModificaSistema();}

public int EliminaSistema(int IdSistema)
{
clsSistema oSistema = new clsSistema();
oSistema.IdSistema = IdSistema;
return oSistema.EliminaSistema();}

//seleccion con parametros
public DataSet ObtienepavSistema1(string Campo, string Valor)
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
clsSistemaDA ad = new clsSistemaDA();
return ad.ObtienepavSistema(pParametros);
}
public DataSet ObtienepavSistema2(string Campo, string Valor,string Campo1, string Valor1)
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
clsSistemaDA ad = new clsSistemaDA();
return ad.ObtienepavSistema(pParametros);
}
public DataSet ObtienepavSistema3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsSistemaDA ad = new clsSistemaDA();
return ad.ObtienepavSistema(pParametros);
}
public DataSet ObtienepavSistema4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsSistemaDA ad = new clsSistemaDA();
return ad.ObtienepavSistema(pParametros);
}
public DataSet ObtienepavSistema5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsSistemaDA ad = new clsSistemaDA();
return ad.ObtienepavSistema(pParametros);
}
#endregion 
#region Reporte
public clsReporte ObtieneReporte(int IdReporte)
{
clsReporte oReporte = new clsReporte();
oReporte.IdReporte = IdReporte;
return oReporte.clsReportePorIdReporte();
}

public int AgregaReporte(clsReporte oReporte)
{return oReporte.AgregaReporte();}

public int ModificaReporte(clsReporte oReporte)
{return oReporte.ModificaReporte();}

public int EliminaReporte(int IdReporte)
{
clsReporte oReporte = new clsReporte();
oReporte.IdReporte = IdReporte;
return oReporte.EliminaReporte();}

//seleccion con parametros
public DataSet ObtienepavReporte1(string Campo, string Valor)
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
clsReporteDA ad = new clsReporteDA();
return ad.ObtienepavReporte(pParametros);
}
public DataSet ObtienepavReporte2(string Campo, string Valor,string Campo1, string Valor1)
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
clsReporteDA ad = new clsReporteDA();
return ad.ObtienepavReporte(pParametros);
}
public DataSet ObtienepavReporte3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsReporteDA ad = new clsReporteDA();
return ad.ObtienepavReporte(pParametros);
}
public DataSet ObtienepavReporte4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsReporteDA ad = new clsReporteDA();
return ad.ObtienepavReporte(pParametros);
}
public DataSet ObtienepavReporte5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsReporteDA ad = new clsReporteDA();
return ad.ObtienepavReporte(pParametros);
}
#endregion 
#region Equipo
public clsEquipo ObtieneEquipo(int IdEquipo)
{
clsEquipo oEquipo = new clsEquipo();
oEquipo.IdEquipo = IdEquipo;
return oEquipo.clsEquipoPorIdEquipo();
}

public int AgregaEquipo(clsEquipo oEquipo)
{return oEquipo.AgregaEquipo();}

public int ModificaEquipo(clsEquipo oEquipo)
{return oEquipo.ModificaEquipo();}

public int EliminaEquipo(int IdEquipo)
{
clsEquipo oEquipo = new clsEquipo();
oEquipo.IdEquipo = IdEquipo;
return oEquipo.EliminaEquipo();}

//seleccion con parametros
public DataSet ObtienepavEquipo1(string Campo, string Valor)
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
clsEquipoDA ad = new clsEquipoDA();
return ad.ObtienepavEquipo(pParametros);
}
public DataSet ObtienepavEquipo2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEquipoDA ad = new clsEquipoDA();
return ad.ObtienepavEquipo(pParametros);
}
public DataSet ObtienepavEquipo3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEquipoDA ad = new clsEquipoDA();
return ad.ObtienepavEquipo(pParametros);
}
public DataSet ObtienepavEquipo4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEquipoDA ad = new clsEquipoDA();
return ad.ObtienepavEquipo(pParametros);
}
public DataSet ObtienepavEquipo5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEquipoDA ad = new clsEquipoDA();
return ad.ObtienepavEquipo(pParametros);
}
#endregion 
#region EquipoDetalle
public clsEquipoDetalle ObtieneEquipoDetalle(int IdEquipoDetalle)
{
clsEquipoDetalle oEquipoDetalle = new clsEquipoDetalle();
oEquipoDetalle.IdEquipoDetalle = IdEquipoDetalle;
return oEquipoDetalle.clsEquipoDetallePorIdEquipoDetalle();
}

public int AgregaEquipoDetalle(clsEquipoDetalle oEquipoDetalle)
{return oEquipoDetalle.AgregaEquipoDetalle();}

public int ModificaEquipoDetalle(clsEquipoDetalle oEquipoDetalle)
{return oEquipoDetalle.ModificaEquipoDetalle();}

public int EliminaEquipoDetalle(int IdEquipoDetalle)
{
clsEquipoDetalle oEquipoDetalle = new clsEquipoDetalle();
oEquipoDetalle.IdEquipoDetalle = IdEquipoDetalle;
return oEquipoDetalle.EliminaEquipoDetalle();}

//seleccion con parametros
public DataSet ObtienepavEquipoDetalle1(string Campo, string Valor)
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
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.ObtienepavEquipoDetalle(pParametros);
}
public DataSet ObtienepavEquipoDetalle2(string Campo, string Valor,string Campo1, string Valor1)
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
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.ObtienepavEquipoDetalle(pParametros);
}
public DataSet ObtienepavEquipoDetalle3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.ObtienepavEquipoDetalle(pParametros);
}
public DataSet ObtienepavEquipoDetalle4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.ObtienepavEquipoDetalle(pParametros);
}
public DataSet ObtienepavEquipoDetalle5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.ObtienepavEquipoDetalle(pParametros);
}
#endregion 
#region Menu
public clsMenu ObtieneMenu(int IdMenu)
{
clsMenu oMenu = new clsMenu();
oMenu.IdMenu = IdMenu;
return oMenu.clsMenuPorIdMenu();
}

public int AgregaMenu(clsMenu oMenu)
{return oMenu.AgregaMenu();}

public int ModificaMenu(clsMenu oMenu)
{return oMenu.ModificaMenu();}

public int EliminaMenu(int IdMenu)
{
clsMenu oMenu = new clsMenu();
oMenu.IdMenu = IdMenu;
return oMenu.EliminaMenu();}

//seleccion con parametros
public DataSet ObtienepavMenu1(string Campo, string Valor)
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
clsMenuDA ad = new clsMenuDA();
return ad.ObtienepavMenu(pParametros);
}
public DataSet ObtienepavMenu2(string Campo, string Valor,string Campo1, string Valor1)
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
clsMenuDA ad = new clsMenuDA();
return ad.ObtienepavMenu(pParametros);
}
public DataSet ObtienepavMenu3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)
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
clsMenuDA ad = new clsMenuDA();
return ad.ObtienepavMenu(pParametros);
}
public DataSet ObtienepavMenu4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)
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
clsMenuDA ad = new clsMenuDA();
return ad.ObtienepavMenu(pParametros);
}
public DataSet ObtienepavMenu5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)
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
clsMenuDA ad = new clsMenuDA();
return ad.ObtienepavMenu(pParametros);
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
}
}
