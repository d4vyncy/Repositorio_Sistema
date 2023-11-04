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

public class clsSolicitud : clsSolicitudDA
{
public clsSolicitud()
{
this.IdSolicitud = 0;
this.NumeroSolicitud = 0;
this.FechaReal = DateTime.Now;
this.FechaSolicitud = DateTime.Now;
this.Observaciones = string.Empty;
this.Total = 0;
this.IdGrupoArticulo = 0;
this.IdUnidadSolicitante = 0;
this.IdGestion = 0;
this.IdUsuarioSolicitud = 0;
this.IdAlmacen = 0;
this.IdEstadoSolicitud = 0;
}

public clsSolicitud(int IdSolicitud)
{
}


public clsSolicitud clsSolicitudPorIdSolicitud()
{
using (IDataReader dr = ObtieneSolicitud(this))
{
if (dr.Read())
{
this.IdSolicitud = Convert.ToInt32(dr["IdSolicitud"]);
this.NumeroSolicitud = Convert.ToInt32(dr["NumeroSolicitud"]);
this.FechaReal = Convert.ToDateTime(dr["FechaReal"]);
this.FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"]);
this.Observaciones = Convert.ToString(dr["Observaciones"]);
this.Total = Convert.ToDecimal(dr["Total"]);
this.IdGrupoArticulo = Convert.ToInt32(dr["IdGrupoArticulo"]);
this.IdUnidadSolicitante = Convert.ToInt32(dr["IdUnidadSolicitante"]);
this.IdGestion = Convert.ToInt32(dr["IdGestion"]);
this.IdUsuarioSolicitud = Convert.ToInt32(dr["IdUsuarioSolicitud"]);
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.IdEstadoSolicitud = Convert.ToInt32(dr["IdEstadoSolicitud"]);
}
}
return this;
}

public int AgregaSolicitud()
{
clsSolicitudDA ad = new clsSolicitudDA();
return ad.AgregaSolicitud(this);
}

public int ModificaSolicitud()
{
clsSolicitudDA ad = new clsSolicitudDA();
return ad.ModificaSolicitud(this);
}

public int EliminaSolicitud()
{
clsSolicitudDA ad = new clsSolicitudDA();
return ad.EliminaSolicitud(this);
}

}
}
