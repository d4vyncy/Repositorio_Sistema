using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfSeguridad.Entidades;
using WcfSeguridad.Datos;

namespace WcfSeguridad.Negocios 
{

public class clsEquipoDetalle : clsEquipoDetalleDA
{
public clsEquipoDetalle()
{
this.IdEquipoDetalle = 0;
this.IdEquipo = 0;
this.Descripcion = string.Empty;
this.FechaConsulta = DateTime.Now;
this.Respuesta = true;
}

public clsEquipoDetalle(int IdEquipoDetalle)
{
}


public clsEquipoDetalle clsEquipoDetallePorIdEquipoDetalle()
{
using (IDataReader dr = ObtieneEquipoDetalle(this))
{
if (dr.Read())
{
this.IdEquipoDetalle = Convert.ToInt32(dr["IdEquipoDetalle"]);
this.IdEquipo = Convert.ToInt32(dr["IdEquipo"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
this.FechaConsulta = Convert.ToDateTime(dr["FechaConsulta"]);
this.Respuesta = Convert.ToBoolean(dr["Respuesta"]);
}
}
return this;
}

public int AgregaEquipoDetalle()
{
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.AgregaEquipoDetalle(this);
}

public int ModificaEquipoDetalle()
{
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.ModificaEquipoDetalle(this);
}

public int EliminaEquipoDetalle()
{
clsEquipoDetalleDA ad = new clsEquipoDetalleDA();
return ad.EliminaEquipoDetalle(this);
}

}
}
