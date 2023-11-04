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

public class clsReporte : clsReporteDA
{
public clsReporte()
{
this.IdReporte = 0;
this.NombreReporte = string.Empty;
this.NombreFormulario = string.Empty;
this.NumeroDeOrden = 0;
this.IdSistema = 0;
this.IdReportePadre = 0;
}

public clsReporte(int IdReporte)
{
}


public clsReporte clsReportePorIdReporte()
{
using (IDataReader dr = ObtieneReporte(this))
{
if (dr.Read())
{
this.IdReporte = Convert.ToInt32(dr["IdReporte"]);
this.NombreReporte = Convert.ToString(dr["NombreReporte"]);
this.NombreFormulario = Convert.ToString(dr["NombreFormulario"]);
this.NumeroDeOrden = Convert.ToInt32(dr["NumeroDeOrden"]);
this.IdSistema = Convert.ToInt32(dr["IdSistema"]);
this.IdReportePadre = Convert.ToInt32(dr["IdReportePadre"]);
}
}
return this;
}

public int AgregaReporte()
{
clsReporteDA ad = new clsReporteDA();
return ad.AgregaReporte(this);
}

public int ModificaReporte()
{
clsReporteDA ad = new clsReporteDA();
return ad.ModificaReporte(this);
}

public int EliminaReporte()
{
clsReporteDA ad = new clsReporteDA();
return ad.EliminaReporte(this);
}

}
}
