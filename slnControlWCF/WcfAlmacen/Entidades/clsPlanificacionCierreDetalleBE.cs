using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsPlanificacionCierreDetalleBE
{
public int IdPlanificacionCierreDetalle { get; set; }
public int IdPlanificacionCierre { get; set; }
public int IdIngreso { get; set; }
public int IdIngresoDetalle { get; set; }
public int IdEgreso { get; set; }
public int IdEgresoDetalle { get; set; }
}
}