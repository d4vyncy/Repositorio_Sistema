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

public class clsEstadoAsignado : clsEstadoAsignadoDA
{
public clsEstadoAsignado()
{
this.IdEstadoAsignado = 0;
this.NombreEstadoAsignado = string.Empty;
this.Descripcion = string.Empty;
}

public clsEstadoAsignado(int IdEstadoAsignado)
{
}


public clsEstadoAsignado clsEstadoAsignadoPorIdEstadoAsignado()
{
using (IDataReader dr = ObtieneEstadoAsignado(this))
{
if (dr.Read())
{
this.IdEstadoAsignado = Convert.ToInt32(dr["IdEstadoAsignado"]);
this.NombreEstadoAsignado = Convert.ToString(dr["NombreEstadoAsignado"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
}
}
return this;
}

public int AgregaEstadoAsignado()
{
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.AgregaEstadoAsignado(this);
}

public int ModificaEstadoAsignado()
{
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.ModificaEstadoAsignado(this);
}

public int EliminaEstadoAsignado()
{
clsEstadoAsignadoDA ad = new clsEstadoAsignadoDA();
return ad.EliminaEstadoAsignado(this);
}

}
}
