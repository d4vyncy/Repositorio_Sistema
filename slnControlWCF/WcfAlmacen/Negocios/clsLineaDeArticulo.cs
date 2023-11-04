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

public class clsLineaDeArticulo : clsLineaDeArticuloDA
{
public clsLineaDeArticulo()
{
this.IdLineaDeArticulo = 0;
this.NombreLineaDeArticulo = string.Empty;
}

public clsLineaDeArticulo(int IdLineaDeArticulo)
{
}


public clsLineaDeArticulo clsLineaDeArticuloPorIdLineaDeArticulo()
{
using (IDataReader dr = ObtieneLineaDeArticulo(this))
{
if (dr.Read())
{
this.IdLineaDeArticulo = Convert.ToInt32(dr["IdLineaDeArticulo"]);
this.NombreLineaDeArticulo = Convert.ToString(dr["NombreLineaDeArticulo"]);
}
}
return this;
}

public int AgregaLineaDeArticulo()
{
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.AgregaLineaDeArticulo(this);
}

public int ModificaLineaDeArticulo()
{
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.ModificaLineaDeArticulo(this);
}

public int EliminaLineaDeArticulo()
{
clsLineaDeArticuloDA ad = new clsLineaDeArticuloDA();
return ad.EliminaLineaDeArticulo(this);
}

}
}
