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

public class clsEstadoEgreso : clsEstadoEgresoDA
{
public clsEstadoEgreso()
{
this.IdEstadoEgreso = 0;
this.NombreEstadoEgreso = string.Empty;
this.Descripcion = string.Empty;
}

public clsEstadoEgreso(int IdEstadoEgreso)
{
}


public clsEstadoEgreso clsEstadoEgresoPorIdEstadoEgreso()
{
using (IDataReader dr = ObtieneEstadoEgreso(this))
{
if (dr.Read())
{
this.IdEstadoEgreso = Convert.ToInt32(dr["IdEstadoEgreso"]);
this.NombreEstadoEgreso = Convert.ToString(dr["NombreEstadoEgreso"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
}
}
return this;
}

public int AgregaEstadoEgreso()
{
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.AgregaEstadoEgreso(this);
}

public int ModificaEstadoEgreso()
{
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.ModificaEstadoEgreso(this);
}

public int EliminaEstadoEgreso()
{
clsEstadoEgresoDA ad = new clsEstadoEgresoDA();
return ad.EliminaEstadoEgreso(this);
}

}
}
