using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfAlmacen.Entidades;
using WcfAlmacen.Datos;

namespace WcfAlmacen.Negocios 
{

public class clsEstadoIngreso : clsEstadoIngresoDA
{
public clsEstadoIngreso()
{
this.IdEstadoIngreso = 0;
this.NombreEstadoIngreso = string.Empty;
this.Descripcion = string.Empty;
}

public clsEstadoIngreso(int IdEstadoIngreso)
{
}


public clsEstadoIngreso clsEstadoIngresoPorIdEstadoIngreso()
{
using (IDataReader dr = ObtieneEstadoIngreso(this))
{
if (dr.Read())
{
this.IdEstadoIngreso = Convert.ToInt32(dr["IdEstadoIngreso"]);
this.NombreEstadoIngreso = Convert.ToString(dr["NombreEstadoIngreso"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
}
}
return this;
}

public int AgregaEstadoIngreso()
{
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.AgregaEstadoIngreso(this);
}

public int ModificaEstadoIngreso()
{
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.ModificaEstadoIngreso(this);
}

public int EliminaEstadoIngreso()
{
clsEstadoIngresoDA ad = new clsEstadoIngresoDA();
return ad.EliminaEstadoIngreso(this);
}

}
}
