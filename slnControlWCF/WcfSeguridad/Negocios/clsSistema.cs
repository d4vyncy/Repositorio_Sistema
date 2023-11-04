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

public class clsSistema : clsSistemaDA
{
public clsSistema()
{
this.IdSistema = 0;
this.NombreSistema = string.Empty;
this.IpServer = string.Empty;
this.HostNameServer = string.Empty;
this.Url = string.Empty;
this.Detalle = string.Empty;
}

public clsSistema(int IdSistema)
{
}


public clsSistema clsSistemaPorIdSistema()
{
using (IDataReader dr = ObtieneSistema(this))
{
if (dr.Read())
{
this.IdSistema = Convert.ToInt32(dr["IdSistema"]);
this.NombreSistema = Convert.ToString(dr["NombreSistema"]);
this.IpServer = Convert.ToString(dr["IpServer"]);
this.HostNameServer = Convert.ToString(dr["HostNameServer"]);
this.Url = Convert.ToString(dr["Url"]);
this.Imagen = (byte[])dr["Imagen"];
this.Detalle = Convert.ToString(dr["Detalle"]);
}
}
return this;
}

public int AgregaSistema()
{
clsSistemaDA ad = new clsSistemaDA();
return ad.AgregaSistema(this);
}

public int ModificaSistema()
{
clsSistemaDA ad = new clsSistemaDA();
return ad.ModificaSistema(this);
}

public int EliminaSistema()
{
clsSistemaDA ad = new clsSistemaDA();
return ad.EliminaSistema(this);
}

}
}
