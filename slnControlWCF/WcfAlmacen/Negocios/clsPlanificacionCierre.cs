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

public class clsPlanificacionCierre : clsPlanificacionCierreDA
{
public clsPlanificacionCierre()
{
this.IdPlanificacionCierre = 0;
this.FechaApertura = DateTime.Now;
this.FechaCierre = DateTime.Now;
this.IdTasaCambio = 0;
this.IdEstadoPlanificacionCierre = 0;
this.IdUsuarioCreacion = 0;
this.FechaCreacion = DateTime.Now;
this.IdAlmacen = 0;
}

public clsPlanificacionCierre(int IdPlanificacionCierre)
{
}


public clsPlanificacionCierre clsPlanificacionCierrePorIdPlanificacionCierre()
{
using (IDataReader dr = ObtienePlanificacionCierre(this))
{
if (dr.Read())
{
this.IdPlanificacionCierre = Convert.ToInt32(dr["IdPlanificacionCierre"]);
this.FechaApertura = Convert.ToDateTime(dr["FechaApertura"]);
this.FechaCierre = Convert.ToDateTime(dr["FechaCierre"]);
this.IdTasaCambio = Convert.ToInt32(dr["IdTasaCambio"]);
this.IdEstadoPlanificacionCierre = Convert.ToInt32(dr["IdEstadoPlanificacionCierre"]);
this.IdUsuarioCreacion = Convert.ToInt32(dr["IdUsuarioCreacion"]);
this.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
}
}
return this;
}

public int AgregaPlanificacionCierre()
{
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.AgregaPlanificacionCierre(this);
}

public int ModificaPlanificacionCierre()
{
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.ModificaPlanificacionCierre(this);
}

public int EliminaPlanificacionCierre()
{
clsPlanificacionCierreDA ad = new clsPlanificacionCierreDA();
return ad.EliminaPlanificacionCierre(this);
}

}
}
