using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfAlmacen.Entidades 
{

public class clsPlanificacionCierreBE
{
public int IdPlanificacionCierre { get; set; }
public DateTime FechaApertura { get; set; }
public DateTime FechaCierre { get; set; }
public int IdTasaCambio { get; set; }
public int IdEstadoPlanificacionCierre { get; set; }
public int IdUsuarioCreacion { get; set; }
public DateTime FechaCreacion { get; set; }
public int IdAlmacen { get; set; }
}
}