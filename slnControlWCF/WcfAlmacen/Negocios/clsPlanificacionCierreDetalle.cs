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

public class clsPlanificacionCierreDetalle : clsPlanificacionCierreDetalleDA
{
public clsPlanificacionCierreDetalle()
{
this.IdPlanificacionCierreDetalle = 0;
this.IdPlanificacionCierre = 0;
this.IdIngreso = 0;
this.IdIngresoDetalle = 0;
this.IdEgreso = 0;
this.IdEgresoDetalle = 0;
}

public clsPlanificacionCierreDetalle(int IdPlanificacionCierreDetalle)
{
}


public clsPlanificacionCierreDetalle clsPlanificacionCierreDetallePorIdPlanificacionCierreDetalle()
{
using (IDataReader dr = ObtienePlanificacionCierreDetalle(this))
{
if (dr.Read())
{
this.IdPlanificacionCierreDetalle = Convert.ToInt32(dr["IdPlanificacionCierreDetalle"]);
this.IdPlanificacionCierre = Convert.ToInt32(dr["IdPlanificacionCierre"]);
this.IdIngreso = Convert.ToInt32(dr["IdIngreso"]);
this.IdIngresoDetalle = Convert.ToInt32(dr["IdIngresoDetalle"]);
this.IdEgreso = Convert.ToInt32(dr["IdEgreso"]);
this.IdEgresoDetalle = Convert.ToInt32(dr["IdEgresoDetalle"]);
}
}
return this;
}

public int AgregaPlanificacionCierreDetalle()
{
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.AgregaPlanificacionCierreDetalle(this);
}

public int ModificaPlanificacionCierreDetalle()
{
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.ModificaPlanificacionCierreDetalle(this);
}

public int EliminaPlanificacionCierreDetalle()
{
clsPlanificacionCierreDetalleDA ad = new clsPlanificacionCierreDetalleDA();
return ad.EliminaPlanificacionCierreDetalle(this);
}

}
}
