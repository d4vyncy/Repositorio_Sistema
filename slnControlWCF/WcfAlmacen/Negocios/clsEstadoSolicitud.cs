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

public class clsEstadoSolicitud : clsEstadoSolicitudDA
{
public clsEstadoSolicitud()
{
this.IdEstadoSolicitud = 0;
this.NombreEstadoSolicitud = string.Empty;
this.Descripcion = string.Empty;
}

public clsEstadoSolicitud(int IdEstadoSolicitud)
{
}


public clsEstadoSolicitud clsEstadoSolicitudPorIdEstadoSolicitud()
{
using (IDataReader dr = ObtieneEstadoSolicitud(this))
{
if (dr.Read())
{
this.IdEstadoSolicitud = Convert.ToInt32(dr["IdEstadoSolicitud"]);
this.NombreEstadoSolicitud = Convert.ToString(dr["NombreEstadoSolicitud"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
}
}
return this;
}

public int AgregaEstadoSolicitud()
{
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.AgregaEstadoSolicitud(this);
}

public int ModificaEstadoSolicitud()
{
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.ModificaEstadoSolicitud(this);
}

public int EliminaEstadoSolicitud()
{
clsEstadoSolicitudDA ad = new clsEstadoSolicitudDA();
return ad.EliminaEstadoSolicitud(this);
}

}
}
