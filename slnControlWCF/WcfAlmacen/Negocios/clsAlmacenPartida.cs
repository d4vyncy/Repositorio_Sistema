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

public class clsAlmacenPartida : clsAlmacenPartidaDA
{
public clsAlmacenPartida()
{
this.IdAlmacenPartida = 0;
this.NumeroPartida = 0;
this.IdAlmacenPartidaPadre = 0;
this.NombreAlmacenPartida = string.Empty;
this.Descripcion = string.Empty;
this.DetallePartida = string.Empty;
this.Estado = string.Empty;
}

public clsAlmacenPartida(int IdAlmacenPartida)
{
}


public clsAlmacenPartida clsAlmacenPartidaPorIdAlmacenPartida()
{
using (IDataReader dr = ObtieneAlmacenPartida(this))
{
if (dr.Read())
{
this.IdAlmacenPartida = Convert.ToInt32(dr["IdAlmacenPartida"]);
this.NumeroPartida = Convert.ToInt32(dr["NumeroPartida"]);
this.IdAlmacenPartidaPadre = Convert.ToInt32(dr["IdAlmacenPartidaPadre"]);
this.NombreAlmacenPartida = Convert.ToString(dr["NombreAlmacenPartida"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
this.DetallePartida = Convert.ToString(dr["DetallePartida"]);
this.Estado = Convert.ToString(dr["Estado"]);
}
}
return this;
}

public int AgregaAlmacenPartida()
{
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.AgregaAlmacenPartida(this);
}

public int ModificaAlmacenPartida()
{
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.ModificaAlmacenPartida(this);
}

public int EliminaAlmacenPartida()
{
clsAlmacenPartidaDA ad = new clsAlmacenPartidaDA();
return ad.EliminaAlmacenPartida(this);
}

}
}
