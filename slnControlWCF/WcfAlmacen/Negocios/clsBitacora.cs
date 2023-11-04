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

public class clsBitacora : clsBitacoraDA
{
public clsBitacora()
{
this.IdBitacora = 0;
this.Fecha = DateTime.Now;
this.Detalle = string.Empty;
this.IdUsuario = 0;
this.IdInsumo = 0;
this.Cantidad = 0;
}

public clsBitacora(int IdBitacora)
{
}


public clsBitacora clsBitacoraPorIdBitacora()
{
using (IDataReader dr = ObtieneBitacora(this))
{
if (dr.Read())
{
this.IdBitacora = Convert.ToInt32(dr["IdBitacora"]);
this.Fecha = Convert.ToDateTime(dr["Fecha"]);
this.Detalle = Convert.ToString(dr["Detalle"]);
this.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
this.IdInsumo = Convert.ToInt32(dr["IdInsumo"]);
this.Cantidad = Convert.ToInt32(dr["Cantidad"]);
}
}
return this;
}

public int AgregaBitacora()
{
clsBitacoraDA ad = new clsBitacoraDA();
return ad.AgregaBitacora(this);
}

public int ModificaBitacora()
{
clsBitacoraDA ad = new clsBitacoraDA();
return ad.ModificaBitacora(this);
}

public int EliminaBitacora()
{
clsBitacoraDA ad = new clsBitacoraDA();
return ad.EliminaBitacora(this);
}

}
}
